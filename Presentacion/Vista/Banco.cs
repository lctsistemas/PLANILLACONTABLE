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

            using (nbanco)
            {
                codigoban = nbanco.GetCodigo();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            result = "";
            using (nbanco)
            {
                if (nbanco.state == EntityState.Guardar)
                    nbanco.IdBanco = codigoban;
                    nbanco.Nom_banco = txtBanco.Text.Trim();

                
                result = nbanco.GuardarCambios();
                
                if (nbanco.state == EntityState.Guardar)
                    nbanco.Nom_banco = txtBanco.Text.Trim();


                result = nbanco.GuardarCambios();

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
