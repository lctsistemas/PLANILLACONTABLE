using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmrol : Form
    {
        Nrol nr = new Nrol();
        string result = "";
        private static frmrol instance;
        public frmrol()
        {
            InitializeComponent();
            ShowRol();
            Tabla();
        }
        //METODO PARA INSTANCIAR EL FORMULARIO
        public static frmrol GetInstance()
        {
            if (instance == null)
                instance = new frmrol();

            return instance;
        }
        //METODO SHOW IN DATAGRIVIEW
        private void ShowRol()
        {
            using (nr)
            {
                dgvrol.DataSource = nr.Getall();
                this.Text = "Gestion Rol  | Count " + dgvrol.RowCount.ToString();
            }
        }
        //MODIFICAR DATAGRIDVIEW
        private void Tabla()
        {
            dgvrol.Columns[0].HeaderText = "CODIGO";
            dgvrol.Columns[0].Width = 50;
            dgvrol.Columns[0].Visible = false;

            dgvrol.Columns[1].HeaderText = "NOMBRE ROL";
            dgvrol.Columns[1].Width = 195;
        }
        private void Limpiar()
        {
            txtrol.Text = String.Empty;
            using (nr) { nr.state = EntityState.Guardar; }
            txtrol.Focus();
        }

        //...........
        private void frmrol_FormClosing(object sender, FormClosingEventArgs e)
        { instance = null; }
        //GUARDAR
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtrol.Text)) {

                ValidateChildren();
                return;

            }
                

            using (nr)
            {
                nr.nombre_rol = txtrol.Text.Trim().ToUpper();
                result = nr.SaveChanges();
                ShowRol();
                Messages.M_info(result);
                Limpiar();
            }
        }
        //LOAD
        private void frmrol_Load(object sender, EventArgs e)
        { }
        //PARA EDITAR
        private void dgvrol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvrol.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                using (nr)
                {
                    nr.state = EntityState.Modificar;
                    nr.idrol = Convert.ToInt32(dgvrol.CurrentRow.Cells[0].Value);//idrol
                    txtrol.Text = dgvrol.CurrentRow.Cells[1].Value.ToString();//nombre rol
                    
                }
            }
        }
        //NUEVO
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvrol.Rows.GetFirstRow(DataGridViewElementStates.Selected) != -1)
            {
                DialogResult rsu = Messages.M_question("¿Desea eliminar rol?");
                if (rsu == DialogResult.Yes)
                {
                    using (nr)
                    {
                        nr.state = EntityState.Remover;
                        nr.idrol = Convert.ToInt32(dgvrol.CurrentRow.Cells[0].Value);
                        result = nr.SaveChanges();
                        ShowRol();
                        if (result.Contains("ESTA EN USO"))
                        {
                            Messages.M_error(result);
                        }
                        else
                        {
                            Messages.M_info(result);
                        }
                        Limpiar();

                    }
                }
            }
        }

        private void txtrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtrol_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtrol, "Rol requerido!");
        }
    }
}
