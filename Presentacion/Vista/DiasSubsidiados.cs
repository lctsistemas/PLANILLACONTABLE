using Negocio.Models;
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
    public partial class DiasSubsidiados : Form
    {
        public DiasSubsidiados()
        {
            InitializeComponent();
            DataGridViewHeaderCell s = new DataGridViewHeaderCell();
            s.Style.SelectionBackColor = Color.Black;
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

           
                using (Ncargo nca = new Ncargo())
                {
                cbosubsidio.DataSource = nca.Getall();
                cbosubsidio.DisplayMember = "nombre_cargo";
                cbosubsidio.ValueMember = "idcargo";
                }
   
        }

        private static DiasSubsidiados instance;
        public static DiasSubsidiados GetInstance()
        {
            if (instance == null)
                instance = new DiasSubsidiados();
            return instance;
        }

        

    }
}
