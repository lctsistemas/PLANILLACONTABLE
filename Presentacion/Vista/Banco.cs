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
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Banco : Form
    {
        String result;
        private Int32 codigoban;

        private NBanco nbanco=new NBanco();
        public Banco()
        {
            InitializeComponent();
        }

        public void generarCodigo()
        {
            codigoban = 0;
<<<<<<< HEAD
            using (nbanco)
            {
                codigoban = nbanco.GetCodigo();
=======
            using (nb)
            {
               // codigoban = nb.
>>>>>>> f04750b705c61975c9d91c1f6d8c7ed4e2334d05
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            result = "";
            using (nbanco)
            {
<<<<<<< HEAD
                if (nbanco.state == EntityState.Guardar)
                    nbanco.IdBanco = codigoban;
                    nbanco.Nom_banco = txtBanco.Text.Trim();

                
                result = nbanco.GuardarCambios();
                
=======
                if (nb.state == EntityState.Guardar)
                    nb.IdBanco =
                    nb.Nom_banco = txtBanco.Text.Trim();


                result = nb.GuardarCambios();

>>>>>>> f04750b705c61975c9d91c1f6d8c7ed4e2334d05
                Messages.M_info(result);
                if (nbanco.state == EntityState.Guardar)
                {
                    generarCodigo();
                    limpiar();
                }

            }
        }

        private void limpiar()
        {
            txtBanco.Text = String.Empty;
            txtBanco.Focus();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
