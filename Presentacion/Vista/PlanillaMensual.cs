﻿using Presentacion.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmPlanillaMensual : Form
    {
        
        public FrmPlanillaMensual()
        {
            InitializeComponent();
        }


        //TABLA
        private void TablaPlanilla() {
            dgvplanilla1.Columns["ape_nom"].Frozen = true;
            dgvplanilla2.Columns["valor1"].Frozen = true;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvplanilla1.Rows.Add();
            //dgvplanilla1.BeginEdit(true);
        }

        private void dgvplanilla1_Scroll(object sender, ScrollEventArgs e)
        {
            dgvplanilla2.HorizontalScrollingOffset = dgvplanilla1.HorizontalScrollingOffset;
        }

        private void FrmPlanillaMensual_Load(object sender, EventArgs e)
        {
            TablaPlanilla();
            
        }

        //envento cuando una fila esta validando.
        private void dgvplanilla1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvplanilla1.CurrentRow != null)
            {
                if (dgvplanilla1.CurrentRow.Index < dgvplanilla1.Rows.Count -1 )
                {
                    if (dgvplanilla1.CurrentRow.Cells[6].Value != null)
                    {
                        if (dgvplanilla1.CurrentRow.Cells[6].Value.ToString() == "")
                        {
                            MessageBox.Show("El campo no puede estar vacío");
                            e.Cancel = true;
                            return;
                        }
                    }

                }
            }
        }

        private void dgvplanilla1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //decimal sueldo = 0, asig_fami = 0, Hdiurna25 = 0;
            //decimal subtotal = 0;

            //if (dgvplanilla1.Columns[e.ColumnIndex].Name=="sueldo")
            //{
            //    sueldo = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells["sueldo"].Value.ToString());
            //    asig_fami = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells["a_familiar"].Value.ToString());
            //    Hdiurna25 = decimal.Parse(dgvplanilla1.Rows[e.RowIndex].Cells[10].Value.ToString());
            //    subtotal = (sueldo + asig_fami + Hdiurna25);
            //    dgvplanilla1.Rows[e.RowIndex].Cells[35].Value = subtotal.ToString("#.##");//total remu.
            //}
            DataGridViewRow dar = dgvplanilla1.CurrentRow;

            switch (e.ColumnIndex)
             {
                case 7: //sueldo
                case 8: //asig fami      
                case 28: //monto subsidio
                case 30: //monto nega de subsi.
                case 32: //monto positi de subsi.
                case 33: //total horas extr.
                case 34: //reintegro
                case 35: // vacaciones
                case 36: // vaca trunca.
                case 37: // grati trunca.
                case 38: // boni trunca.
                case 39: // cts trunca.
                    try
                    {
                        double suel = 0, asigfami = 0, monto_sub = 0, montonegasub = 0, montoposisub = 0, totalHorasEx = 0;
                        double reintegr = 0, vacacion = 0, vaca_trun = 0, grati_tru = 0, boni_tru = 0, cts_tru = 0;
                        double subtotal1 = 0.00, subtotal2 = 0.00, totalsub = 0.00;                        

                        if (dar.Cells["sueldo"].Value == null)
                            suel = 0.00;
                        else
                            suel = Convert.ToDouble(dar.Cells["sueldo"].Value);


                        if (dar.Cells["a_familiar"].Value == null)
                            asigfami = 0.00;
                        else
                            asigfami = Convert.ToDouble(dar.Cells["a_familiar"].Value);


                        if (dar.Cells["montosub"].Value == null)
                            monto_sub = 0.00;
                        else
                            monto_sub = Convert.ToDouble(dar.Cells["montosub"].Value);


                        if (dar.Cells["montonega"].Value == null)
                            montonegasub = 0.00;
                        else
                            montonegasub = Convert.ToDouble(dar.Cells["montonega"].Value);


                        if (dar.Cells["montoposi"].Value == null)
                            montoposisub = 0.00;
                        else
                            montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                        if (dar.Cells["montoposi"].Value == null)
                            montoposisub = 0.00;
                        else
                            montoposisub = Convert.ToDouble(dar.Cells["montoposi"].Value);


                        if (dar.Cells["thoras"].Value == null)
                            totalHorasEx = 0.00;
                        else
                            totalHorasEx = Convert.ToDouble(dar.Cells["thoras"].Value);


                        if (dar.Cells["reintegro"].Value == null)
                            reintegr = 0.00;
                        else
                            reintegr = Convert.ToDouble(dar.Cells["reintegro"].Value);


                        if (dar.Cells["vacaciones"].Value == null)
                            vacacion = 0.00;
                        else
                            vacacion = Convert.ToDouble(dar.Cells["vacaciones"].Value);


                        if (dar.Cells["tvaca"].Value == null)
                            vaca_trun = 0.00;
                        else
                            vaca_trun = Convert.ToDouble(dar.Cells["tvaca"].Value);


                        if (dar.Cells["tgrati"].Value == null)
                            grati_tru = 0.00;
                        else
                            grati_tru = Convert.ToDouble(dar.Cells["tgrati"].Value);


                        if (dar.Cells["tboni"].Value == null)
                            boni_tru = 0.00;
                        else
                            boni_tru = Convert.ToDouble(dar.Cells["tboni"].Value);


                        if (dar.Cells["tcts"].Value == null)
                            cts_tru = 0.00;
                        else
                            cts_tru = Convert.ToDouble(dar.Cells["tcts"].Value);

                        subtotal1 = (suel + asigfami + monto_sub + montoposisub + totalHorasEx);
                        subtotal2 = (reintegr + vacacion + vaca_trun + grati_tru + boni_tru + cts_tru);
                        totalsub = (subtotal1 + subtotal2 ) - montonegasub;

                        dar.Cells["totaremu"].Value = totalsub;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default:
                    //dar.Cells["totaremu"].Value = 0.00;
                    break;
            }


            //TOTAL HORAS EXTRAS.
            switch (e.ColumnIndex)
            {
                case 11:
                case 14:
                case 17:
                case 20:
                case 23:
                case 25:                    
                    double montoD25 = 0, montoD35 = 0, montoN25 = 0, montoN35 = 0, feriado = 0, boniNoct = 0;
                    double totalHorasExt = 0;

                    //diurna de 25%
                    if (dar.Cells["montod25"].Value == null)
                        montoD25 = 0.00;
                    else
                        montoD25 = Convert.ToDouble(dar.Cells["montod25"].Value);

                    //diurna de 35%
                    if (dar.Cells["montod35"].Value == null)
                        montoD35 = 0.00;
                    else
                        montoD35 = Convert.ToDouble(dar.Cells["montod35"].Value);

                    //nocturno de 25%
                    if (dar.Cells["monton25"].Value == null)
                        montoN25 = 0.00;
                    else
                        montoN25 = Convert.ToDouble(dar.Cells["monton25"].Value);

                    //nocturno de 35%
                    if (dar.Cells["monton35"].Value == null)
                        montoN35 = 0.00;
                    else
                        montoN35 = Convert.ToDouble(dar.Cells["monton35"].Value);

                    //feriado
                    if (dar.Cells["montoferiado"].Value == null)
                        feriado = 0.00;
                    else
                        feriado = Convert.ToDouble(dar.Cells["montoferiado"].Value);

                    //bonificacion nocturna
                    if (dar.Cells["montoboninocturno"].Value == null)
                        boniNoct = 0.00;
                    else
                        boniNoct = Convert.ToDouble(dar.Cells["montoboninocturno"].Value);

                    //total horas extras.
                    totalHorasExt = (montoD25 + montoD35 + montoN25 + montoN35 + feriado + boniNoct);
                    dar.Cells["thoras"].Value = totalHorasExt.ToString();

                    break;
                default:
                    break;
            }


        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelplanilla_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
