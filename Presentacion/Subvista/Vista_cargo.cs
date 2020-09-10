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

namespace Presentacion.Subvista
{
    public partial class Vista_cargo : Form
    {
        private Ncargo nc = new Ncargo();
        string result = "";

        public Vista_cargo()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            nc.state = EntityState.Guardar;
            ValidateError.validate.Clear();
            Habilitar(true);
            limpiar();
        }

        private static Vista_cargo instance;
        public static Vista_cargo GetInstance()
        {
            if (instance == null)
                instance = new Vista_cargo();

            return instance;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (nc)
            {
                nc.nombre_cargo = txtnom_cargo.Text.Trim().ToUpper();
                nc.descripcion = txtdescrip.Text.Trim().ToUpper();

                bool valida = new ValidacionDatos(nc).Validate();
                if (valida)
                {
                    result = nc.SaveChanges();
                    Messages.M_info(result);
                }
                limpiar();
            }
        }


        private void Vista_cargo_Load(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void Habilitar(bool v)
        {
            txtnom_cargo.Enabled = v;
            txtdescrip.Enabled = v;
            btnguardar.Enabled = v;
        }


        private void limpiar()
        {
            txtnom_cargo.Text = String.Empty;
            txtdescrip.Text = String.Empty;
            txtnom_cargo.Focus();
        }
    }
}
