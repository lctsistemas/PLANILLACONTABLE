using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
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
    public partial class frmDiasSubsidiados : Form
    {
        String result;
        private NSubsidios ns = new NSubsidios();
        private Int32 codigo;
        public frmDiasSubsidiados()
        {
            InitializeComponent();
            DataGridViewHeaderCell s = new DataGridViewHeaderCell();
            s.Style.SelectionBackColor = Color.Black;
            Mostrar_cargo();
        }

        private void GenerarCodigo()
        {
            codigo = 0;
            using (ns)
            {
                //codigo = ns.GetCodigo();
            }
        }

        private void Mostrar_cargo()
        {

            //DataGridViewComboBoxColumn oDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            //oDataGridViewComboBoxColumn.DataSource = oLista;
            //oDataGridViewComboBoxColumn.Name = "Fecha del Taller " + pr_InicioProgramacion.AddDays(j).ToShortDateString();
            //oDataGridViewComboBoxColumn.DisplayMember = "pr_NombreCompletoEmpleado";
            //oDataGridViewComboBoxColumn.ValueMember = "pr_CodigoEmpleado";
            //oDataGridViewComboBoxColumn.DataPropertyName = "pr_CodigoEmpleado";

           
            //    using (NSubsidios nca = new NSubsidios())
            //    {
            //    cbosubsidio.DataSource = nca.Getall();
            //    cbosubsidio.DisplayMember = "descripcion_subsidio";
            //    cbosubsidio.ValueMember = "id_subsidios";
            //    cbosubsidio.DataPropertyName = "id_subsidios";
            //}
   
        }

        

        private static frmDiasSubsidiados instance;
        public static frmDiasSubsidiados GetInstance()
        {
            if (instance == null)
                instance = new frmDiasSubsidiados();
            return instance;
        }

        private void DiasSubsidiados_Load(object sender, EventArgs e)
        {
            ShowNoSubsidiados();
            
        }

        private void ShowNoSubsidiados()
        {
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmListaNoSubsidiados fr = new frmListaNoSubsidiados();
            this.AddOwnedForm(fr);

            fr.StartPosition = FormStartPosition.CenterParent;
            fr.ShowDialog();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtcodsub.Text = String.Empty;
            txtdescrip.Text = String.Empty;
            
            using (ns) { ns.state = EntityState.Guardar; }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (ns)
            {
                ns.Id_subsidios = codigo;

                ns.Cod_subsidios = Convert.ToInt32(txtcodsub.Text.Trim());
                ns.Descripcion_subsidio = Convert.ToString(txtdescrip.Text.Trim());

                bool valida = new ValidacionDatos(ns).Validate();
                if (valida)
                {

                    //result = ns.GuardarCambios();

                    Messages.M_info(result);
                }

                GenerarCodigo();

            }
        }
    }
}
