﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Presentacion.Helps;
using Negocio.Models;
using Comun.Cache;
using Negocio.ValueObjects;

namespace Presentacion.Vista
{
    public partial class FrmDiasSubsidiados2 : Form
    {
        NSubsidios nsub;
        NDiasSubsidiados ndsub;
        int subtotal_si = 0;
        string mensaje;
        
        private static FrmDiasSubsidiados2 _intancia;
        public FrmDiasSubsidiados2()
        {
            InitializeComponent();
            Fillcombo(PlanillaCache.Subsidiado);            
            
        }

        //METODO LLAMAR THIS FORMULARIO
        public static FrmDiasSubsidiados2 Getinstance()
        {
            if (_intancia == null)
                _intancia = new FrmDiasSubsidiados2();
            return _intancia;
        }

        //METODO CARGAR COMBOBOX SUBSIDIOS
        private void Fillcombo(string tipo_subsidio)
        {
            using (nsub =new NSubsidios())
            {
                nsub.Tipo_subsidio = tipo_subsidio;
                cbosubsidio.DataSource = nsub.ShowSubsidio();
                cbosubsidio.DisplayMember = "Cod_subsidios";
                cbosubsidio.ValueMember = "Id_subsidios";
            }
        }

        //CARGAR DATAGRI 
        private void Fill_detSubsidio(string tipo_subsi)
        {
            using (ndsub= new NDiasSubsidiados())
            {
                ndsub.Id_mes = PlanillaCache.p_idmes;
                ndsub.Id_periodo = UserCache.Idperiodo;
                ndsub.Id_empleado = PlanillaCache.p_idempleado;
                ndsub.ValTipSubsidio = tipo_subsi;
                dgvsubsidio.DataSource = ndsub.GetData();
            }
        }

        //SUMAR SUMA CELDA DATAGRIDVIEW | IMPORTANTE ANALIZAR Y SIMPLIFICAR CODIGO
        private void SumarDias()
        {
            subtotal_si = 0;
            int total_sp = 0, total_si = 0, total = 0, vaca = 0;
            foreach (DataGridViewRow item in dgvsubsidio.Rows)
            {
                int canti= Convert.ToInt32(item.Cells["canti_dias"].Value);
                string tsusp = item.Cells["tsupension"].Value.ToString();
                if (tsusp.Contains("S.P."))
                    total_sp += canti;
                else if (tsusp.Contains("S.I.") && !tsusp.Contains("23 - S.I."))
                    total_si += canti;
                else if (tsusp.Contains("23 - S.I."))
                    vaca = canti;
            }

            subtotal_si = (total_si + vaca);            
            lbltotalSp.Text = total_sp.ToString();
            lbltotalSi.Text = total_si.ToString();
            lblvacaciones.Text = vaca.ToString();
            total = (total_sp + subtotal_si);
            txttotaldias.Text = total.ToString();
        }

        //DISEÑO TABLA
        private void Tabla()
        {
            dgvsubsidio.Columns["canti_dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvsubsidio.Columns["id_dsubsidio"].Visible = false;
            dgvsubsidio.Columns["cod_subsidio"].Visible = false;
            dgvsubsidio.Columns["tsupension"].ReadOnly = true;
        }

        //ENVIAR DIAS SUBSIDIOS
        private void SentDayinDatagri(dynamic negativo, dynamic positivo, bool val)
        {
            FrmPlanillaMensual2 frpla2 = (FrmPlanillaMensual2)Owner;
            if (val)
                frpla2.Dgvplanilla1.CurrentRow.Cells[negativo].Value = lbltotalSp.Text;

            frpla2.Dgvplanilla1.CurrentRow.Cells[positivo].Value = subtotal_si;           
            frpla2.xdia_subposi = Convert.ToInt32(lbltotalSi.Text);
            frpla2.Dgvplanilla1.CurrentRow.Cells["dgvdia_vaca"].Value = Convert.ToInt32(lblvacaciones.Text);
        }

        //ENVIAR DIAS POR TIPO DE SUBSIDIO
        private void SentTypeDaySubsidio()
        {
            if (PlanillaCache.Subsidiado.Equals("NO SUBSIDIADOS"))
                SentDayinDatagri("ndiasnega", "ndiasposi", true);
            else if (PlanillaCache.Subsidiado.Equals("SUBSIDIADOS"))
                SentDayinDatagri("", "ndias", false);
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloNumeros(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbosubsidio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdias.Focus();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            /*string cbo;
            cbo = cbosubsidio.Text;
            if (cbo.Contains("S.P."))
                Messages.M_warning("SUPENSION PERFECTA");
            else if (cbo.Contains("S.I."))
                Messages.M_warning("SUSPENSION IMPERFECTA");*/           
            
            if (String.IsNullOrWhiteSpace(txtdias.Text))
                return;
            
            mensaje = "";
             using (ndsub =new NDiasSubsidiados())
             {
                ndsub.Id_subsidios = Convert.ToInt32(cbosubsidio.SelectedValue);
                ndsub.Id_empleado = PlanillaCache.p_idempleado;
                ndsub.Id_mes = PlanillaCache.p_idmes;
                ndsub.Id_periodo = UserCache.Idperiodo;
                ndsub.Dias = Convert.ToInt32(txtdias.Text.Trim());
                mensaje = ndsub.GuardarCambios();
             }
                                  
            txtdias.Text = string.Empty;
            txtdias.Focus();                        
            Fill_detSubsidio(PlanillaCache.Subsidiado);
            SumarDias();
            SentTypeDaySubsidio();           
        }

        private void FrmDiasSubsidiados2_Load(object sender, EventArgs e)
        {
            dgvsubsidio.AutoGenerateColumns = false;
            Fill_detSubsidio(PlanillaCache.Subsidiado);
            SumarDias();
            Tabla();
        }

        private void dgvsubsidio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {               
                if (dgvsubsidio.Rows[e.RowIndex].Cells["modificar"].Selected)
                {
                    mensaje = "";
                    using (ndsub = new NDiasSubsidiados())
                    {
                        ndsub.state = EntityState.Modificar;
                        ndsub.Dias = Convert.ToInt32(dgvsubsidio.Rows[e.RowIndex].Cells["canti_dias"].Value);
                        ndsub.Id_det_subsidios = Convert.ToInt32(dgvsubsidio.Rows[e.RowIndex].Cells["id_dsubsidio"].Value);
                        mensaje = ndsub.GuardarCambios();
                        if (!mensaje.Equals(""))
                        {
                            Fill_detSubsidio(PlanillaCache.Subsidiado);
                            SumarDias();
                            SentTypeDaySubsidio();
                        }
                        Messages.M_info(mensaje);
                        ndsub.state = EntityState.Guardar;
                    }
                }
                else if (dgvsubsidio.Rows[e.RowIndex].Cells["eliminar"].Selected)
                {
                    mensaje = "";
                    using (ndsub = new NDiasSubsidiados())
                    {
                        string cod_subsi = dgvsubsidio.CurrentRow.Cells["cod_subsidio"].Value.ToString();
                        DialogResult result = Messages.M_question("¿Está seguro de eliminar el tipo " + cod_subsi +"?");
                        if (result==DialogResult.Yes)
                        {
                            ndsub.state = EntityState.Remover;
                            ndsub.Id_det_subsidios = Convert.ToInt32(dgvsubsidio.Rows[e.RowIndex].Cells["id_dsubsidio"].Value);
                            mensaje = ndsub.GuardarCambios();
                            if (!mensaje.Equals(""))
                            {
                                Fill_detSubsidio(PlanillaCache.Subsidiado);
                                SumarDias();
                                SentTypeDaySubsidio();
                            }
                            Messages.M_info(mensaje);
                            ndsub.state = EntityState.Guardar;
                        }                        
                    }
                }
            }
        }

        private void dgvsubsidio_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewCellStyle style = e.CellStyle;
            style.Font = new Font(style.Font.FontFamily, 10, FontStyle.Bold);
            style.BackColor = Color.Beige;
        }
        
        private void dgvsubsidio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvsubsidio.Rows[e.RowIndex].Cells["canti_dias"].Selected)
                {
                    dgvsubsidio.BeginEdit(true);                    
                }
            }
        }

        private void FrmDiasSubsidiados2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _intancia = null;
        }

        private void txtdias_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdias, "Ingrese el numero dias");
        }

        private void btnsalir_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.BackColor = Color.White;
            btnsalir.ForeColor = Color.Black;
        }

        private void btnsalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnsalir.BackColor = Color.Crimson;
            btnsalir.ForeColor = Color.White;
        }
    }
}
