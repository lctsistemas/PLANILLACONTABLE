using Comun.Cache;
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
    public partial class frmSubsiyNoSubsi : Form
    {
        String result;
        private NDiasSubsidiados nds = new NDiasSubsidiados();
       
        public frmSubsiyNoSubsi()
        {
            InitializeComponent();
           /* DataGridViewHeaderCell s = new DataGridViewHeaderCell();
            s.Style.SelectionBackColor = Color.Black;*/
            Mostrar_cargo();
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

        

        private static frmSubsiyNoSubsi instance;
        
        public static frmSubsiyNoSubsi GetInstance()
        {
            if (instance == null)
                instance = new frmSubsiyNoSubsi();
            return instance;
        }

        private void DiasSubsidiados_Load(object sender, EventArgs e)
        {
            CalculoDiasSubsidiado();
            limpiar();
        }

      

        public void CalculoDiasSubsidiado()
        {
            PlanillaMensual plamens = new PlanillaMensual();
            double basico = Double.Parse(plamens.txtHaberBasico.Text.ToString());
            double importeDiario = Math.Round(basico / 30, 4);

            txtimporte.Text = importeDiario.ToString();
            txtdias.Text = Convert.ToString(0);
            
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
            txtcodsub.Focus();
        }

        private void limpiar()
        {
            txtcodsub.Text = String.Empty;
            txtdescrip.Text = String.Empty;            
            using (nds) { nds.state = EntityState.Guardar; }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (nds)
            {              
                nds.Id_subsidios = Convert.ToInt32(txtidsubsidio.Text.Trim());
                nds.Id_empleado = UserCache.IdUser;
                nds.Id_mes = Convert.ToInt32(txtmes.Text.Trim());
                nds.Id_periodo = UserCache.Idperiodo;
                nds.Dias = Convert.ToInt32(txtdias.Text.Trim());

                bool valida = new ValidacionDatos(nds).Validate();
                if (valida)
                {
                    result = nds.GuardarCambios();
                    Messages.M_info(result);
                }              

            }
        }
      
    }
}
