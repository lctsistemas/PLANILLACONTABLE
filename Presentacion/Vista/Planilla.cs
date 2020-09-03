using Comun.Cache;
using Negocio.Models;
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
        private Int32 codigo;
        public Planilla()
        {
            InitializeComponent();
            Initialize();
        }

        private void GenerarCodigo()
        {
            codigo = 0;
            using (np)
            {
                codigo = np.GetCodigo();
            }
        }

        private void Initialize() {
            String[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //string m=mes[0];
            cbxmes.Items.AddRange(mes);

            txtremu.Text = "930.00";
            txtasig.Text = "93.00";
            txttope.Text = "1200";


        }

        private static Planilla instance;

        public static Planilla GetInstance()
        {
            if (instance == null)
                instance = new Planilla();

            return instance;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            result = "";
            using (np)
            {
                np.Id_planilla = codigo;
                //np.Id_planilla = txtdescCorta.Text.Trim().ToUpper();
                //np.Id_tipo_planilla = txtdescripcion.Text.Trim().ToUpper();
                np.Id_periodo = Convert.ToInt32(UserCache.Periodo);
                np.Fecha_inicial = Convert.ToDateTime(dtpini.Text.Trim());
                np.Fecha_final = Convert.ToDateTime(dtpfin.Text.Trim());
                np.Fecha_pago = Convert.ToDateTime(dtppago.Text.Trim());
                np.Dias_mes =Convert.ToInt32(txtdia.Text.Trim());
                np.Horas_mes = Convert.ToInt32(txthora.Text.Trim());
                np.Remu_basica = Convert.ToDecimal(txtremu.Text.Trim());
                np.Asig_familiar = Convert.ToDecimal(txtasig.Text.Trim());
                np.Tope_horario_nocturno = Convert.ToInt32(txttope.Text.ToString());


                bool valida = new ValidacionDatos(np).Validate();
                if (valida)
                {
                   
                    result = np.GuardarCambios();

                    Messages.M_info(result);
                }

                GenerarCodigo();

            }
        }

        private void Planilla_Load(object sender, EventArgs e)
        {
            if (UserCache.Periodo != null)
            {
                numyear.Value = Convert.ToInt32(UserCache.Periodo);

            }
            GenerarCodigo();
        }
        

        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            DateTime datefin;
            datefin = dtpfin.Value;
            txtdia.Text = datefin.Day.ToString();
            Int32 horas_mes = datefin.Day * 8;
           
            
            txthora.Text= Convert.ToString(horas_mes);

            
        }

        
    }
}
