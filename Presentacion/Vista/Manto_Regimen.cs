using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;

namespace Presentacion.Vista
{
    public partial class Manto_Regimen : Form
    {
        String result;
        Int32 codigo;
        private NRegimen nr=new NRegimen();
        public Manto_Regimen()
        {
            InitializeComponent();
        }

        private void Manto_Regimen_Load(object sender, EventArgs e)
        {
            cbxregimen.Items.Add("S.N.P");
            cbxregimen.Items.Add("S.P.P");
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            codigo = 0;
            using (nr)
            {
                codigo = nr.Getcodigo();
                txtcodigo.Text = "USER 0" + codigo;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            using (nr) { nr.state = EntityState.Guardar; }
            GenerarCodigo();
            Habilitar(true);
            limpiar();
        }

        private void limpiar()
        {
            txtdescripcion.Text = String.Empty;
            txtdescCorta.Text = String.Empty;
            cbxregimen.Text = "";
            cbxregimen.SelectedValue = 0;
            txtcodigo.Focus();
        }

        private void Habilitar(bool v)
        {
            btnguardar.Enabled = v;
            txtdescripcion.Enabled = v;
            txtdescCorta.Enabled = v;
            cbxregimen.Enabled = v;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (nr)
            {
                if (nr.state == EntityState.Guardar)
                {
                    nr.Codigo_Regimen = codigo;
                    nr.Descripcion = txtdescripcion.Text.Trim().ToUpper();
                    nr.Descripcion_corta = txtdescCorta.Text.Trim().ToUpper();
                    nr.Tipo_regimen = Convert.ToInt32(cbxregimen.SelectedValue);

                    bool valida = new ValidacionDatos(nr).Validate();
                    if (valida)
                    {
                        result = nr.GuardarCambios();
                        Messages.M_info(result);
                        if (nr.state == EntityState.Guardar)
                        {
                            limpiar();
                        }
                    }
                }
            }
        }
    }
}
