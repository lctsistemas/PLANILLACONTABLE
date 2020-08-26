using Comun.Cache;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion.Vista
{

    public partial class frmempleado : Form
    {
        String result;
        NEmpleado nEmpleado = new NEmpleado();
        List<object> list;
        private Int32 codigoemp;
        public frmempleado()
        {
            InitializeComponent();
            Mostrar_cargo();
            MostrarDocumento();
            MostrarAFP();            
            mostrarEmp("","");

        }
        //GENERAR CODIGO
        private void GenerateCodigo()
        {
            codigoemp = 0;
            using (nEmpleado)
            {
                codigoemp = nEmpleado.GetCodigo();
                txtcodigo.Text = "EMP 0" + codigoemp;
            }
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

        //HABILITAR CAMPO AFP
        private void Habilitar_afp(bool v)
        {
            cmbafp.Visible = v;
            lblafp.Visible = v;
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
            if (cmbtipdoc.SelectedItem.ToString() == "Pasaporte")
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
            cbxpen.Enabled = v;
            cbxgene.Enabled = v;
            cmbtipdoc.Enabled = v;
            txtdire.Enabled = v;
            txttele.Enabled = v;
            dtfecha.Enabled = v;
            txtnac.Enabled = v;
            cmbafp.Enabled = v;
            cmbcar.Enabled = v;
            btnguardar.Enabled = v;
        }

        private void Mostrar_cargo()
        {
            using (nEmpleado)
            {
                cmbcar.DataSource = nEmpleado.Mostrar_car_empleado();
                cmbcar.DisplayMember = "nombre_cargo";
                cmbcar.ValueMember = "id_cargo";
            }
        }

        private void MostrarDocumento()
        {
            using (nEmpleado)
            {
                cmbtipdoc.DataSource = nEmpleado.Mostrar_TipoDocumento();
                cmbtipdoc.DisplayMember = "nombre";
                cmbtipdoc.ValueMember = "id_documento";
            }
        }

        private void MostrarAFP()
        {
            using (nEmpleado)
            {
                cmbafp.DataSource = nEmpleado.Mostrar_AFP();
                cmbafp.DisplayMember = "nombre_afp";
                cmbafp.ValueMember = "id_afp";
            }

        }
        

        private void mostrarEmp(String numdoc,String nombre)
        {
            using (nEmpleado)
            {
                //nEmpleado.Nom_emp = datos;
                list = new List<object>();
                nEmpleado.Id_emp_maestra = UserCache.Codigo_empresa;
                nEmpleado.Num_doc = numdoc;
                nEmpleado.Nom_emp = nombre;
                nEmpleado.ListaEmpleado(list, nEmpleado);
                dgvempleado.DataSource = list;
                lblcantidad_registro.Text = "TOTAL REGISTRO:  " + dgvempleado.Rows.Count;
            }
        }


        private void limpiar()
        {
            txtNombre.Text = String.Empty;
            txtApeMat.Text = String.Empty;
            txtApePat.Text = String.Empty;
            txttele.Text = String.Empty;
            cbxpen.Text = "";
            cbxpen.SelectedValue = 0;
            cbxgene.Text = "";
            cbxgene.SelectedValue = 0;
            cmbtipdoc.Text = "";
            cmbtipdoc.SelectedValue = 0;
            cmbcar.Text = "";
            cmbcar.SelectedValue = 0;
           
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
                string.IsNullOrEmpty(cmbtipdoc.Text) || string.IsNullOrEmpty(cmbcar.Text) ||
                string.IsNullOrEmpty(txtnac.Text) || string.IsNullOrEmpty(txtdire.Text) ||
                string.IsNullOrEmpty(txtnumdoc.Text) ||
                string.IsNullOrEmpty(cbxpen.Text) || string.IsNullOrEmpty(cbxgene.Text))
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
                using (nEmpleado)
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
                    cbxpen.Text = r.Cells[13].Value.ToString();
                    if (cbxpen.Text == "A.F.P")
                    {
                        cmbafp.SelectedValue = r.Cells[12].Value.ToString();
                        cmbafp.Text = r.Cells[14].Value.ToString();
                    }

                    cmbtipdoc.SelectedValue = r.Cells[15].Value.ToString();
                    cmbtipdoc.Text = (r.Cells[16].Value.ToString());

                    cmbcar.SelectedValue = r.Cells[17].Value.ToString();
                    cmbcar.Text = r.Cells[18].Value.ToString();
                  
                    tabEmpleado.SelectedIndex = 1;
                    Habilitar(true);
                    Habilitar_doc(true);
                    ValidateError.validate.Clear();


                }
            }

        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            cbxpen.Items.Add("O.N.P");
            cbxpen.Items.Add("A.F.P");


            cbxgene.Items.Add("Masculino");
            cbxgene.Items.Add("Femenino");

            cmbestado.Items.Add("Activo");
            cmbestado.Items.Add("Cesado");

            cmbcar.Text = "";
            cmbcar.SelectedValue = 0;
            //iniciar el radiobutom en dni
            rddni.Checked = true;
            
            //Tabla();
            Habilitar_afp(false);
            Habilitar(false);
            txtcodigo.Enabled = false;
            txtnumdoc.Enabled = false;
            
            lblem.Text = UserCache.Codigo_empresa.ToString();
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
                    nEmpleado.Id_empleado = codigoemp;

                nEmpleado.Nom_emp = txtNombre.Text.Trim();
                nEmpleado.Ape_pat = txtApePat.Text.Trim();
                nEmpleado.Ape_mat = txtApeMat.Text.Trim();                
                nEmpleado.Fec_nac = Convert.ToDateTime(dtfecha.Value);

                nEmpleado.Tip_pension = cbxpen.SelectedItem.ToString();
                nEmpleado.Tipo_genero = cbxgene.SelectedItem.ToString();
                nEmpleado.Nacionalidad = txtnac.Text.Trim();                
                nEmpleado.Direccion = txtdire.Text.Trim();
                nEmpleado.Telefono = txttele.Text.Trim();
                nEmpleado.Num_doc = txtnumdoc.Text;

                nEmpleado.Estado = cmbestado.SelectedItem.ToString();
                nEmpleado.Id_afp = Convert.ToInt32(cmbafp.SelectedValue);
                nEmpleado.Id_doc = Convert.ToInt32(cmbtipdoc.SelectedValue);
                nEmpleado.Id_cargo = Convert.ToInt32(cmbcar.SelectedValue);
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
            mostrarEmp("","");        
            GenerateCodigo();
        }

        private void btnmensaje_Click_1(object sender, EventArgs e)
        {
            Messages.M_info("" + txtNombre.Text.ToString());
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            /*if (rdnombre.Checked==true)
            {
                mostrarEmp("",txtBuscar.Text.Trim());
            }
            else if (rddni.Checked==true)
            {
                mostrarEmp(txtBuscar.Text.Trim(),"");
            }
            else           
                mostrarEmp("","");*/

            //dgvempleado.DataSource = nEmpleado.Search(txtBuscar.Text.Trim());
            

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (nEmpleado) { nEmpleado.state = EntityState.Guardar; }
            GenerateCodigo();

            Habilitar(true);
            limpiar();
        }

        private void cbxpen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxpen.SelectedItem.ToString() == "A.F.P")
            {
                Habilitar_afp(true);
            }

            else
            {
                Habilitar_afp(false);
            }
        }

        private void cmbtipdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipdoc.Text == "")
            {
                Habilitar_doc(false);
            }
            else
            {
                Habilitar_doc(true);
                txtnumdoc.Focus();
            }

            if (cmbtipdoc.SelectedIndex == 0)
            {
                txtnumdoc.MaxLength = 8;

                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Focus();
                }
            }
            else if (cmbtipdoc.SelectedIndex == 1)
            {
                txtnumdoc.MaxLength = 11;
                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Text = "";
                    txtnumdoc.Focus();
                }
            }
            else if (cmbtipdoc.SelectedIndex == 2)
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
            ValidateError.Validate_combo(cmbtipdoc, "Campo requerido");
        }

        private void cbxpen_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbxpen, "Campo requerido");
        }

        private void cmbcar_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cmbcar, "Campo requerido");
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
                        mostrarEmp("","");
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
                if (dgvempleado.Columns[e.ColumnIndex].Name == "CONTRATO")
                {
                    using (frmcontrato formcontrato = new frmcontrato())
                    {
                        DataGridViewRow dgr = dgvempleado.CurrentRow;
                        formcontrato.txtid_empleado.Text = dgr.Cells[1].Value.ToString();
                        string last_name = dgr.Cells[2].Value.ToString() + " " + dgr.Cells[3].Value.ToString() + " " + dgr.Cells[4].Value.ToString();
                        formcontrato.txtnombre.Text = last_name;
                        formcontrato.txtdocumento.Text = dgr.Cells[10].Value.ToString();
                        formcontrato.lbldocumento.Text = dgr.Cells[16].Value.ToString();
                        formcontrato.txtcargo.Text = dgr.Cells[18].Value.ToString();
                        formcontrato.txtpen.Text = dgr.Cells[13].Value.ToString();
                        formcontrato.txtafp.Text = dgr.Cells[14].Value.ToString();
                        formcontrato.ShowDialog();
                    }                    
                }
            }
        }

        private void chkcontrato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcontrato.Checked == true)
                dgvempleado.Columns[0].Visible = true;
            else
                dgvempleado.Columns[0].Visible = false;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rdnombre_Click(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void rddni_Click(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }
    }
}
