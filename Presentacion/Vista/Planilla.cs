﻿using Negocio.Models;
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
    public partial class Planilla : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        public Planilla()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            String[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //string m=mes[0];
            cbxmes.Items.AddRange(mes);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (np)
            {
                //np.Id_planilla = txtdescCorta.Text.Trim().ToUpper();
                //np.Id_tipo_planilla = txtdescripcion.Text.Trim().ToUpper();
                np.Id_periodo = Convert.ToInt32(numyear.Text.ToString());
                np.Fecha_pago = Convert.ToDateTime(txtpago.Text.Trim());
                np.Dias_mes =Convert.ToInt32(txtdia.Text.Trim());
                np.Horas_mes = Convert.ToInt32(txthora.Text.Trim());
                np.Remu_basica = Convert.ToDecimal(txtremu.Text.Trim());
                np.Asig_familiar = Convert.ToDecimal(txttope.Text.Trim());
                np.Tope_horario_nocturno = Convert.ToInt32(txttope);


                bool valida = new ValidacionDatos(np).Validate();
                if (valida)
                {
                   
                    result = np.GuardarCambios();

                    Messages.M_info(result);
                }

            }
        }


    }
}