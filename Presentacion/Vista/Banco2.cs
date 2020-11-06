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
    public partial class Banco2 : Form
    {
        NBanco nb;
        public Banco2()
        {
            InitializeComponent();
            //Fillcombo();
            Fill_Banco();
        }
/*
        private void Fillcombo()
        {
            using (nb = new NBanco())
            {
                cboBanco.DataSource = nb.Getall();
                cboBanco.DisplayMember = "Nom_banco";
                cboBanco.ValueMember = "IdBanco";
            }
        }*/

        private void Fill_Banco()
        {
            using (nb = new NBanco())
            {
                //ndsub.Id_mes = 1;
                //ndsub.Id_periodo = 2;
                //ndsub.Id_empleado = 1;
                //ndsub.ValTipSubsidio = tipo_subsi;
                dgvsubsidio.DataSource = nb.Getall();
            }
        }
    }
}
