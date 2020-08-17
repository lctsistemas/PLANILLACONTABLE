using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class frmcontrato : Form
    {
        NContrato ncontrato = new NContrato();
        Ntipocontrato ntcontrato;
        String result;
        public frmcontrato()
        {
            InitializeComponent();
            Mostrar_banco();
            Mostrar_tcontrato();
        }
        
        private void Mostrar_banco()
        {
            using (ncontrato)
            {
                cmbbanco.DataSource = ncontrato.MostrarBanco();
                cmbbanco.DisplayMember = "nombre_banco";
                cmbbanco.ValueMember = "id_banco";
            }
        }

        private void Mostrar_tcontrato()
        {
            using ( ntcontrato=new Ntipocontrato())
            {
                cmbtipcont.DataSource = ntcontrato.MostrarTcontrato();
                cmbtipcont.DisplayMember = "tiem_contrato";
                cmbtipcont.ValueMember = "id_tcontrato";
            }                
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (ncontrato)
            {
                ncontrato.id_contrato = ncontrato.Getcodigo();
                ncontrato.id_empleado = Convert.ToInt32(txtid_empleado.Text.Trim());
                ncontrato.id_banco = Convert.ToInt32(cmbbanco.SelectedValue);
                ncontrato.id_tcontrato = Convert.ToInt32(cmbtipcont.SelectedValue);
                ncontrato.fecha_inicio = Convert.ToDateTime(dtinicio.Value);
                ncontrato.fecha_fin = Convert.ToDateTime(dtfin.Value);
                ncontrato.num_cuenta = txtnum_cuenta.Text.Trim();
                ncontrato.remu_basica = Convert.ToDecimal(txtremune.Text.Trim());
                ncontrato.asig_fami= Convert.ToDecimal(txtasig.Text.Trim());
                ncontrato.descuento= Convert.ToDecimal(txtdescuento.Text.Trim());
                ncontrato.tipo_moneda = cmbmoneda.SelectedItem.ToString();
                ncontrato.cts = txtcts.Text.Trim();
                ncontrato.cussp = txtcussp.Text.Trim();
                result = ncontrato.SaveChanges();
                Messages.M_info(result);
            }
        }

        private void frmcontrato_Load(object sender, EventArgs e)
        {
            cmbbanco.Text = "Seleccione...";
            cmbmoneda.SelectedIndex = 0;
            txtpen.Enabled = false;
        }

        private void frmcontrato_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void panelcontrato_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.SteelBlue;
        }

        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(205, 97, 85);
        }

        
    }

}
