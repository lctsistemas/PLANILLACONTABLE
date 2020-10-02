using Comun.Cache;
using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class Planilla : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        private Nafp naf;
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

        private void LlenarMes()
        {
            using (naf = new Nafp())
            {
                cbxmes.DataSource = naf.Mostrar_mes();
                cbxmes.DisplayMember = "Mes";
                cbxmes.ValueMember = "Idmes";
            }
        }

        private void Initialize()
        {
            String[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //string m=mes[0];
            cbxmes.Items.AddRange(mes);

            PlanillaEmpleados planilla = new PlanillaEmpleados();


            DateTime datefin;
            datefin = dtpfin.Value;
           

            DateTime primerDia = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, 1); //obteniendo el ultimo primer del mes

            DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);//obteniendo el ultimo dia del mes

            Int32 ultimoDiaInt = ultimoDia.Day;


            dtpini.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, 1);
            dtpfin.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, ultimoDiaInt);
            dtppago.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month + 1, ultimoDiaInt);

            cbxmes.SelectedItem = mes.ElementAt(datefin.Month);
            

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
                np.Id_periodo = UserCache.Idperiodo;
                np.Id_empresa = UserCache.Codigo_empresa;
                np.Mes = cbxmes.SelectedItem.ToString();
                // = cbxmes.SelectedItem.ToString(); 
                np.Fecha_inicial = Convert.ToDateTime(dtpini.Text.Trim());
                np.Fecha_final = Convert.ToDateTime(dtpfin.Text.Trim());
                np.Fecha_pago = Convert.ToDateTime(dtppago.Text.Trim());
                np.Dias_mes = Convert.ToInt32(txtdia.Text.Trim());
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
                lblyear.Text = UserCache.Periodo.ToString();

            }
            GenerarCodigo();
            LlenarMes();
        }


        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            DateTime datefin;
            datefin = dtpfin.Value;
            txtdia.Text = datefin.Day.ToString();
            Int32 horas_mes = datefin.Day * 8;
            txthora.Text = Convert.ToString(horas_mes);
        }

        private void cbxmes_TextChanged(object sender, EventArgs e)
        {
            DateTime datefin;
            datefin = dtpfin.Value;

            Int32 mes;
            mes = Convert.ToInt32(cbxmes.SelectedIndex);

            DateTime primerDia = new DateTime(Convert.ToInt32(UserCache.Periodo), mes+1, 1); //obteniendo el ultimo primer del mes

            DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);//obteniendo el ultimo dia del mes

            Int32 ultimoDiaInt = ultimoDia.Day;

            dtpini.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), mes + 1, 1);
            dtpfin.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), mes+1, ultimoDiaInt);
            dtppago.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), mes + 1, ultimoDiaInt);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
