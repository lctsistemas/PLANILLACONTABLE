using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion.Vista
{

    public partial class frmempleado : Form
    {
        String result;
        NEmpleado emple_contra =new  NEmpleado();

        public frmempleado()
        {
            InitializeComponent();
            Mostrar_documento();
            Mostrar_cargo();
            Mostrar_regimenpensionario();
            Mostar_banco();
            Mostar_tcontrato();

        }        
       

        //METODO DE INICIALIZACION PARA CONTRATO
        private void Initialize()
        {
            String[] tpago = {"EFECTIVO","DEPOSITO EN CUENTA","OTROS" };
            cbotipopago.Items.AddRange(tpago);

            cboregimensalud.Items.Add("ESSALUD REGULAR");

            String[] periodicidad = {"MENSUAL","QUINCENAL","SEMANAL","DIARIO","OTROS"};
            cboperiodicidad.Items.AddRange(periodicidad);

            String[] genero = { "MASCULINO","FEMENINO"};
            cbxgene.Items.AddRange(genero);

            String[] estado = { "ACTIVO", "CESADO" };
            cmbestado.Items.AddRange(estado);
        }

        private void Tabla()
        {
            dgvempleado.Columns[0].HeaderText = "ID EMPLEADO";         
            dgvempleado.Columns[0].Visible = false;               
            dgvempleado.Columns[1].Visible = false;
            dgvempleado.Columns[2].HeaderText = "APELLIDOS Y NOMBRES";
            dgvempleado.Columns[2].Width = 211;
            dgvempleado.Columns[3].Visible = false;
            dgvempleado.Columns[4].Visible = false;
            dgvempleado.Columns[5].Visible = false;
            dgvempleado.Columns[6].Visible = false;
            dgvempleado.Columns[7].Visible = false;
            dgvempleado.Columns[8].Visible = false;
            dgvempleado.Columns[9].Visible = false;
            dgvempleado.Columns[10].Visible = false;
            dgvempleado.Columns[11].Visible = false;
            dgvempleado.Columns[12].Visible = false;
            dgvempleado.Columns[13].Visible = false;
            dgvempleado.Columns[14].Visible = false;
            dgvempleado.Columns[15].Visible = false;
            dgvempleado.Columns[16].HeaderText = "ID EMPRESA MAESTRA";
            dgvempleado.Columns[16].Visible = false;
            dgvempleado.Columns[17].HeaderText = "EMPRESA";
            dgvempleado.Columns[17].Visible = false;
            dgvempleado.Columns[18].Visible = false;
            dgvempleado.Columns[19].Visible = false;
            dgvempleado.Columns[20].Visible = false;
            dgvempleado.Columns[21].Visible = false;
            dgvempleado.Columns[22].Visible = false;
            dgvempleado.Columns[23].Visible = false;
            dgvempleado.Columns[24].Visible = false;
            dgvempleado.Columns[25].Visible = false;
            dgvempleado.Columns[26].Visible = false;
            dgvempleado.Columns[27].Visible = false;
            dgvempleado.Columns[28].Visible = false;
            dgvempleado.Columns[29].Visible = false;
            dgvempleado.Columns[30].Visible = false;         
            dgvempleado.Columns[31].Visible = false;         
            dgvempleado.Columns[32].Visible = false;         
            dgvempleado.Columns[33].Visible = false;         
        }              

        private void Habilitar_doc(bool v)
        {
            txtnumdoc.Enabled = v;
        }

        private bool btnValidar_telefono()
        {
            if (txttele.Text.Trim().Length != 9)
            {
                return false;
            }

            return true;

        }

        private bool Validar_DNI()
        {
            if (txtnumdoc.Text.Trim().Length != 8)
            {
                return false;
            }

            return true;
        }

        private bool ValidarPasa()
        {
            if (cbotipo_documento.SelectedItem.ToString() == "Pasaporte")
            {
                if (txtnumdoc.Text.Trim().Length != 9)
                {
                    return false;
                }
            }
            return true;
        }

        private void Habilitar(bool v)
        {
            txtNombre.Enabled = v;
            txtApePat.Enabled = v;
            txtApeMat.Enabled = v;           
            cbxgene.Enabled = v;
            cbotipo_documento.Enabled = v;
            txtdire.Enabled = v;
            txttele.Enabled = v;
            dtfecha.Enabled = v;
            txtnac.Enabled = v;
            cbore_pensionario.Enabled = v;
            cbocar.Enabled = v;
            btnguardar.Enabled = v;
        }

        private void Mostrar_cargo()
        {
            using (Ncargo nca = new Ncargo())
            {
                cbocar.DataSource = nca.Getall();
                cbocar.DisplayMember = "nombre_cargo";
                cbocar.ValueMember = "idcargo";
            }
        }

        private void Mostrar_regimenpensionario()
        {
            using (NRegimen nre= new NRegimen())
            {
                cbore_pensionario.DataSource = nre.Getall();
                cbore_pensionario.DisplayMember = "Descripcion";
                cbore_pensionario.ValueMember = "Codigo_Regimen";
            }
        }

        private void Mostrar_documento()
        {
            using (Ndocumento ndo=new Ndocumento())
            {
                cbotipo_documento.DataSource = ndo.Getall();
                cbotipo_documento.DisplayMember = "nombre_documento";
                cbotipo_documento.ValueMember = "iddocumento";
            }
        }
        private void mostrarEmp()
        {
            using (emple_contra=new NEmpleado())
            {
                emple_contra.Id_emp_maestra = UserCache.Codigo_empresa;
                dgvempleado.DataSource = emple_contra.listar_empleado();
                lblcantidad_registro.Text ="Registro:  "+ dgvempleado.RowCount;
            }
        }

        //MOSTRAR PARA CONTRATO
        private void Mostar_banco()
        {
            using (NBanco nb=new NBanco())
            {
                cbobanco.DataSource = nb.Getall();
                cbobanco.DisplayMember = "Nom_banco";
                cbobanco.ValueMember = "IdBanco";
            }
        }

        private void Mostar_tcontrato()
        {
            using (Ntipocontrato ntc=new Ntipocontrato())
            {
                cbotipocontra.DataSource = ntc.MostrarTcontrato();
                cbotipocontra.DisplayMember = "tiem_contrato";
                cbotipocontra.ValueMember = "id_tcontrato";
            }
        }
        private void limpiar()
        {
            txtNombre.Text = String.Empty;
            txtApeMat.Text = String.Empty;
            txtApePat.Text = String.Empty;
            txttele.Text = String.Empty;            
            cbxgene.Text = "";
            cbxgene.SelectedValue = 0;
            cbotipo_documento.Text = "";
            cbotipo_documento.SelectedValue = 0;
            cbocar.Text = "";
            cbocar.SelectedValue = 0;
           
            cbore_pensionario.Text = "";
            cbore_pensionario.SelectedValue = 0;
            txtnac.Text = String.Empty;
            txtdire.Text = String.Empty;
            txtnumdoc.Text = String.Empty;

            txtNombre.Focus();
        }

        //VALIDAR CAMPOS

        private bool Validar_campos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApePat.Text) ||
                string.IsNullOrEmpty(txtApeMat.Text) || 
                string.IsNullOrEmpty(cbotipo_documento.Text) || string.IsNullOrEmpty(cbocar.Text) ||
                string.IsNullOrEmpty(txtnac.Text) || string.IsNullOrEmpty(txtnumdoc.Text) ||
                string.IsNullOrEmpty(cbxgene.Text))
            {
                ValidateChildren();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvempleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvempleado.CurrentRow;

            if (dgvempleado.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (emple_contra = new NEmpleado())
                {
                    emple_contra.state = EntityState.Modificar;
                    emple_contra.Id_empleado = Convert.ToInt32(r.Cells[1].Value);

                    txtcodigo.Text = "EMP 0" + r.Cells[1].Value.ToString();
                    txtNombre.Text = r.Cells[2].Value.ToString();
                    txtApePat.Text = r.Cells[3].Value.ToString();
                    txtApeMat.Text = r.Cells[4].Value.ToString();

                    dtfecha.Value = Convert.ToDateTime(r.Cells[5].Value.ToString());
                    txtnac.Text = r.Cells[6].Value.ToString();
                    cbxgene.Text = r.Cells[7].Value.ToString();
                    txtdire.Text = r.Cells[8].Value.ToString();
                    txttele.Text = r.Cells[9].Value.ToString();

                    txtnumdoc.Text = r.Cells[10].Value.ToString();
                    cmbestado.Text = r.Cells[11].Value.ToString();
                                                            
                    cbore_pensionario.SelectedValue = r.Cells[12].Value.ToString();
                    cbore_pensionario.Text = r.Cells[14].Value.ToString();                    

                    cbotipo_documento.SelectedValue = r.Cells[15].Value.ToString();
                    cbotipo_documento.Text = (r.Cells[16].Value.ToString());

                    cbocar.SelectedValue = r.Cells[17].Value.ToString();
                    cbocar.Text = r.Cells[18].Value.ToString();
                  
                    tabEmpleado.SelectedIndex = 1;
                    Habilitar(true);
                    Habilitar_doc(true);
                    ValidateError.validate.Clear();
                }
            }
        }
        private void Empleado_Load(object sender, EventArgs e)
        {                       
            Initialize();
            UserCache.Codigo_empresa = 2;
            mostrarEmp();
            Tabla();
            //lblem.Text = UserCache.Codigo_empresa.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar_campos())
            {
                Messages.M_warning("Ingrese todos los campos por favor");                
                return;
            }

            //if (btnValidar_telefono() == false)
            //{
            //    Messages.M_warning("El Teléfono debe tener 9 dígitos");
            //    return;
            //}

            if (Validar_DNI() == false)
            {
                Messages.M_warning("El DNI debe tener 8 dígitos");
                return;
            }

            if (ValidarPasa() == false)
            {
                Messages.M_warning("El Pasaporte debe tener 9 dígitos");
                return;
            }


            result = "";
            using (emple_contra)
            {
                if (emple_contra.state == EntityState.Guardar)
                    emple_contra.Id_empleado = emple_contra.GetCodigo_empleado();
                //EMPLEADO
                emple_contra.Codigo = txtcodigo.Text.Trim();
                emple_contra.Nom_emp = txtNombre.Text.Trim();
                emple_contra.Ape_pat = txtApePat.Text.Trim();
                emple_contra.Ape_mat = txtApeMat.Text.Trim();                
                emple_contra.Fec_nac = Convert.ToDateTime(dtfecha.Value);
                emple_contra.Nacionalidad = txtnac.Text.Trim();
                emple_contra.Tipo_genero = cbxgene.SelectedItem.ToString();                            
                emple_contra.Direccion = txtdire.Text.Trim();
                emple_contra.Telefono = txttele.Text.Trim();
                emple_contra.Num_doc = txtnumdoc.Text;
                emple_contra.Estado = cmbestado.SelectedItem.ToString();
                emple_contra.Codigo_regimen = Convert.ToInt32(cbore_pensionario.SelectedValue);
                emple_contra.Id_doc = Convert.ToInt32(cbotipo_documento.SelectedValue);
                emple_contra.Id_cargo = Convert.ToInt32(cbocar.SelectedValue);
                emple_contra.Id_emp_maestra = int.Parse(txtidempresa.Text); //UserCache.Codigo_empresa; 

                //CONTRATO
                if(emple_contra.state==EntityState.Guardar)
                    emple_contra.cid_contrato = emple_contra.Getcodigo_contrato();

                emple_contra.cid_banco = int.Parse(cbobanco.SelectedValue.ToString());
                emple_contra.cid_tcontrato = int.Parse(cbotipocontra.SelectedValue.ToString());
                emple_contra.cfecha_inicio = DateTime.Parse(dtinicio.Value.ToString());

                if (txtfecha_fin.Text == "  /  /")                                 
                    emple_contra.cfecha_fin = new DateTime(1900, 01, 01);                                   
                else
                    emple_contra.cfecha_fin = DateTime.Parse(txtfecha_fin.Text);

                emple_contra.cnum_cuenta = txtnum_cuenta.Text.Trim();
                emple_contra.cremu_basica =decimal.Parse(txtremune.Text);
                emple_contra.casig_fami = decimal.Parse(txtasig.Text);
                emple_contra.cregimen_salud = cboregimensalud.SelectedItem.ToString();
                emple_contra.ctipo_pago = cbotipopago.SelectedItem.ToString();
                emple_contra.ctipo_moneda = cbotipo_moneda.SelectedItem.ToString();
                emple_contra.cperiodicidad = cboperiodicidad.SelectedItem.ToString();
                emple_contra.ccts = txtcts.Text.Trim();
                emple_contra.ccussp = txtcussp.Text.Trim();

                result = emple_contra.GuardarCambios();

                if(result.Contains("ya se encuentra registrado"))
                {
                    Messages.M_warning(result);           
                }
                else
                {
                    mostrarEmp();
                    Messages.M_info(result);
                    limpiar();
                }
            }           
        }               

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (emple_contra) { emple_contra.state = EntityState.Guardar; }      
            Habilitar(true);
            limpiar();
        }       

        private void cmbtipdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo_documento.Text == "")
            {
                Habilitar_doc(false);
            }
            else
            {
                Habilitar_doc(true);
                txtnumdoc.Focus();
            }

            if (cbotipo_documento.SelectedIndex == 0)
            {
                txtnumdoc.MaxLength = 8;

                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Focus();
                }
            }
            else if (cbotipo_documento.SelectedIndex == 1)
            {
                txtnumdoc.MaxLength = 11;
                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Text = "";
                    txtnumdoc.Focus();
                }
            }
            else if (cbotipo_documento.SelectedIndex == 2)
            {
                txtnumdoc.MaxLength = 9;
                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Text = "";
                    txtnumdoc.Focus();
                }
            }
        }

        private void txttele_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtnac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtnumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloNumeros(e);
        }

        private void txtApePat_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtApePat, "Campo requerido");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtNombre, "Campo requerido");
        }

        private void txtApeMat_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtApeMat, "Campo requerido");
        }

        private void txtnumdoc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnumdoc, "Campo requerido");
        }

        private void txtdire_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdire, "Campo requerido");
        }

        private void txttele_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txttele, "Campo requerido");
        }

        private void txtnac_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnac, "Campo requerido");
        }

        private void cbxgene_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbxgene, "Campo requerido");
        }

        private void cmbtipdoc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbotipo_documento, "Campo requerido");
        }      
        
        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvempleado.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult re = Messages.M_question("¿Deseas eliminar al empleado?");
                if (re == DialogResult.Yes)
                {
                    using (emple_contra)
                    {
                        emple_contra.state = EntityState.Remover;
                        emple_contra.Id_empleado = Convert.ToInt32(dgvempleado.CurrentRow.Cells[1].Value);
                        result = emple_contra.GuardarCambios();
                        Messages.M_info(result);                 
                        btnguardar.Enabled = false;
                    }
                }
            }
            else
            {
                Messages.M_warning("Seleccione un Fila");
            }
        }

        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnminimizar.Visible = true;
            btnmaximizar.Visible = false;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvempleado.Rows.GetFirstRow(DataGridViewElementStates.Selected) == -1)
            {
                
            }
        }
      
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkpagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start(@"https://reportedeudas.sbs.gob.pe/ReporteSituacionPrevisional/Afil_Consulta.aspx");
            Process.Start(@"https://www2.sbs.gob.pe/afiliados/paginas/Consulta.aspx");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            using (emple_contra)
            {
                dgvempleado.DataSource = emple_contra.Search(txtbuscar.Text.Trim());
                lblcantidad_registro.Text = "Registro:  " + dgvempleado.RowCount;
            }  
        }
    }
}
