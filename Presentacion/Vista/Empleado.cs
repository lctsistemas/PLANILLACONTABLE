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
        NEmpleado nEmpleado;                

        public frmempleado()
        {
            InitializeComponent();
            Mostrar_documento();
            Mostrar_cargo();
            Mostrar_regimenpensionario();

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
            dgvempleado.Columns[0].HeaderText = "CONTRATO";
            dgvempleado.Columns[0].Width = 100;
            dgvempleado.Columns[0].Visible = false;

            dgvempleado.Columns[1].HeaderText = "CODIGO";//codigo empleado
            dgvempleado.Columns[1].Width = 50;
            dgvempleado.Columns[1].Visible = false;

            dgvempleado.Columns[2].HeaderText = "NOMBRE";
            dgvempleado.Columns[2].Width = 100;

            dgvempleado.Columns[3].HeaderText = "APELLIDO PATERNO";
            dgvempleado.Columns[3].Width = 100;

            dgvempleado.Columns[4].HeaderText = "APELLIDO MATERNO";
            dgvempleado.Columns[4].Width = 100;

            dgvempleado.Columns[5].HeaderText = "FECHA NACIMIENTO";
            dgvempleado.Columns[5].Width = 100;

            dgvempleado.Columns[6].HeaderText = "NACIONALIDAD";
            dgvempleado.Columns[6].Width = 100;

            dgvempleado.Columns[7].HeaderText = "GENERO";
            dgvempleado.Columns[7].Width = 80;

            dgvempleado.Columns[8].HeaderText = "DIRECCION";
            dgvempleado.Columns[8].Width = 250;

            dgvempleado.Columns[9].HeaderText = "TELEFONO";
            dgvempleado.Columns[9].Width = 80;

            dgvempleado.Columns[10].HeaderText = "N° DOCUMENTO";
            dgvempleado.Columns[10].Width = 100;

            dgvempleado.Columns[11].HeaderText = "ESTADO";
            dgvempleado.Columns[11].Width = 80;

            dgvempleado.Columns[12].HeaderText = "ID AFP";
            dgvempleado.Columns[12].Width = 100;
            dgvempleado.Columns[12].Visible = false;

            dgvempleado.Columns[13].HeaderText = "TIPO PENSION";
            dgvempleado.Columns[13].Width = 80;

            dgvempleado.Columns[14].HeaderText = "TIPO AFP";
            dgvempleado.Columns[14].Width = 100;

            dgvempleado.Columns[15].HeaderText = "ID DOCUMENTO";
            dgvempleado.Columns[15].Width = 100;
            dgvempleado.Columns[15].Visible = false;

            dgvempleado.Columns[16].HeaderText = "DOCUMENTO";
            dgvempleado.Columns[16].Width = 90;

            dgvempleado.Columns[17].HeaderText = "ID CARGO";
            dgvempleado.Columns[17].Width = 70;
            dgvempleado.Columns[17].Visible = false;

            dgvempleado.Columns[18].HeaderText = "CARGO";
            dgvempleado.Columns[18].Width = 150;

            dgvempleado.Columns[19].HeaderText = "ID EMPRESA";
            dgvempleado.Columns[19].Width = 70;
            dgvempleado.Columns[19].Visible = false;

            dgvempleado.Columns[20].HeaderText = UserCache.Empresa_Sucursal;
            dgvempleado.Columns[20].Width = 250;
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
            cmbafp.Enabled = v;
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
                cmbafp.DataSource = nre.Getall();
                cmbafp.DisplayMember = "Descripcion";
                cmbafp.ValueMember = "Codigo_Regimen";
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
           
            cmbafp.Text = "";
            cmbafp.SelectedValue = 0;
            txtnac.Text = String.Empty;
            txtdire.Text = String.Empty;
            txtnumdoc.Text = String.Empty;

            txtNombre.Focus();
        }

        //VALIDAR CAMPOS

        private bool Validar_campos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApePat.Text) ||
                string.IsNullOrEmpty(txtApeMat.Text) || string.IsNullOrEmpty(txttele.Text) ||
                string.IsNullOrEmpty(cbotipo_documento.Text) || string.IsNullOrEmpty(cbocar.Text) ||
                string.IsNullOrEmpty(txtnac.Text) || string.IsNullOrEmpty(txtdire.Text) ||
                string.IsNullOrEmpty(txtnumdoc.Text) ||string.IsNullOrEmpty(cbxgene.Text))
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
                using (nEmpleado = new NEmpleado())
                {
                    nEmpleado.state = EntityState.Modificar;
                    nEmpleado.Id_empleado = Convert.ToInt32(r.Cells[1].Value);

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
                                                            
                    cmbafp.SelectedValue = r.Cells[12].Value.ToString();
                    cmbafp.Text = r.Cells[14].Value.ToString();                    

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
            //lblem.Text = UserCache.Codigo_empresa.ToString();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (Validar_campos())
            {
                Messages.M_warning("Ingrese todos los campos por favor");                
                return;
            }

            if (btnValidar_telefono() == false)
            {
                Messages.M_warning("El Teléfono debe tener 9 dígitos");
                return;
            }

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
            using (nEmpleado)
            {
                if (nEmpleado.state == EntityState.Guardar)
                    //nEmpleado.Id_empleado = ;

                nEmpleado.Nom_emp = txtNombre.Text.Trim();
                nEmpleado.Ape_pat = txtApePat.Text.Trim();
                nEmpleado.Ape_mat = txtApeMat.Text.Trim();                
                nEmpleado.Fec_nac = Convert.ToDateTime(dtfecha.Value);
          
                nEmpleado.Tipo_genero = cbxgene.SelectedItem.ToString();
                nEmpleado.Nacionalidad = txtnac.Text.Trim();                
                nEmpleado.Direccion = txtdire.Text.Trim();
                nEmpleado.Telefono = txttele.Text.Trim();
                nEmpleado.Num_doc = txtnumdoc.Text;

                nEmpleado.Estado = cmbestado.SelectedItem.ToString();
                nEmpleado.Id_afp = Convert.ToInt32(cmbafp.SelectedValue);
                nEmpleado.Id_doc = Convert.ToInt32(cbotipo_documento.SelectedValue);
                nEmpleado.Id_cargo = Convert.ToInt32(cbocar.SelectedValue);
                nEmpleado.Id_emp_maestra = UserCache.Codigo_empresa; 

                result = nEmpleado.GuardarCambios();

                if(result.Contains("YA SE ENCUENTRA REGISTRADO"))
                {
                    Messages.M_warning(result);                   
                }
                else
                {
                    Messages.M_info(result);
                    limpiar();

                }

            }
           
        }        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (nEmpleado) { nEmpleado.state = EntityState.Guardar; }
      

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

        private void cbxpen_Validating(object sender, CancelEventArgs e)
        {
           //ValidateError.Validate_combo(cbxpen, "Campo requerido");
        }

        private void cmbcar_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbocar, "Campo requerido");
        }
        
        private void btneliminar_Click(object sender, EventArgs e)
        {
            result = "";
            if (dgvempleado.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult re = Messages.M_question("¿Deseas eliminar al empleado?");
                if (re == DialogResult.Yes)
                {
                    using (nEmpleado)
                    {
                        nEmpleado.state = EntityState.Remover;
                        nEmpleado.Id_empleado = Convert.ToInt32(dgvempleado.CurrentRow.Cells[1].Value);
                        result = nEmpleado.GuardarCambios();
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
    }
}
