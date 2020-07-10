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

        private NBanco nb=new NBanco();
        public Banco()
        {
            InitializeComponent();
        }

        public void generarCodigo()
        {
            codigoban = 0;
            using (nb)
            {
               // codigoban = nb.
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            result = "";
            using (nb)
            {
                if (nb.state == EntityState.Guardar)
                    nb.IdBanco =
                    nb.Nom_banco = txtBanco.Text.Trim();


                result = nb.GuardarCambios();

                Messages.M_info(result);
                if (nb.state == EntityState.Guardar)
                {
                    GenerarCodigo();
                    limpiar();
                }

            }
        }

        private void limpiar()
        {
            txtBanco.Text = String.Empty;
            txtBanco.Focus();
        }
    }
}
