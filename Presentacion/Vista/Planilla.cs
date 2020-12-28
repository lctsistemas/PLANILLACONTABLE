using Comun.Cache;
using Negocio.Models;
using Presentacion.Helps;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    public partial class FrmPlanilla : Form
    {
        String result;
        private NPlanilla np = new NPlanilla();
        private Nafp naf;
        private static FrmPlanilla instance;

        public FrmPlanilla()
        {
            InitializeComponent();
            //UserCache.Periodo = "2020";
            //Initialize();
            
        }
        
        //METODO INSTANCIA.
        public static FrmPlanilla GetInstance()
        {
            if (instance == null)
                instance = new FrmPlanilla();

            return instance;
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtdia.Text) || String.IsNullOrWhiteSpace(txthora.Text) || String.IsNullOrWhiteSpace(txttope.Text) || String.IsNullOrWhiteSpace(cbxmes.Text))
            {
                ValidateChildren();
                return true;
            }
            else
                return false;
        }

        //LLENAR MES EN COMBOBOX
        private void LlenarMes()
        {
            using (naf = new Nafp())
            {
                cbxmes.DataSource = naf.Mostrar_mes();
                cbxmes.DisplayMember = "Mes";
                cbxmes.ValueMember = "Idmes";
            }
        }

        //LLENAR TIPO DE PLANILLA EN COMBOBOX
        private void LlenarTipoPlanilla()
        {
            using (NTipoPlanilla ntp= new NTipoPlanilla())
            {
                cbotipoplanilla.DataSource = ntp.Getall();
                cbotipoplanilla.DisplayMember = "Tipo_Planilla";
                cbotipoplanilla.ValueMember = "IdTipoPlanilla";
            }
        }

        private void Initialize()
        {                     
            DateTime datefin;
            datefin = dtpfin.Value;
           
            DateTime primerDia = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, 1); //obteniendo el ultimo primer del mes
            DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);//obteniendo el ultimo dia del mes
            Int32 ultimoDiaInt = ultimoDia.Day;

            dtpini.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, 1);
            dtpfin.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month+1, ultimoDiaInt);
            dtppago.Value = new DateTime(Convert.ToInt32(UserCache.Periodo), datefin.Month + 1, ultimoDiaInt);

            //cbxmes.SelectedItem = cbxmes.Items[datefin.Month];seleccionar el ultimo mes ingresado          
        }

        //MOSTRAR MES DE MAQUINA ACTUAL AL INICIAR PLANILLA
        private void Mes_actual()
        {
            int mact = DateTime.Now.Month;
            cbxmes.SelectedIndex = (mact - 1);
        }
        
                
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                return;
            }

            result = "";
            using (np)
            {

                FrmPlanillaEmpleados frmplaem = (FrmPlanillaEmpleados)Owner;
                int idmes= Convert.ToInt32(cbxmes.SelectedValue);

                if (frmplaem.Existe(idmes))
                {
                    Messages.M_error("La planilla de "+ cbxmes.Text+ " ya existe.");
                    return;
                }
                np.Idtipo_planilla = Convert.ToInt32(cbotipoplanilla.SelectedValue);
                np.Id_periodo = UserCache.Idperiodo;
                np.Id_empresam = UserCache.Codigo_empresa;
                np.Id_mes = idmes;               
                np.Fecha_inicial = Convert.ToDateTime(dtpini.Text.Trim());
                np.Fecha_final = Convert.ToDateTime(dtpfin.Text.Trim());
                np.Fecha_pago = Convert.ToDateTime(dtppago.Text.Trim());
                np.Dias_mes = Convert.ToInt32(txtdia.Text.Trim());
                np.Horas_mes = Convert.ToInt32(txthora.Text.Trim());
                np.Tope_horario_nocturno = Convert.ToDecimal(txttope.Text.Trim());               
                result = np.GuardarCambios();
                Messages.M_info(result);
                
            }
            this.Close();
        }

        private void Planilla_Load(object sender, EventArgs e)
        {
            
            if (UserCache.Periodo != null)
               lblyear.Text = UserCache.Periodo.ToString();
                        
            LlenarMes();
            LlenarTipoPlanilla();
            Mes_actual();
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

        private void cbxmes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbxmes, "Mes requerido!");
        }

        private void txtdia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txtdia, "Campo dia requerido!");
        }

        private void txthora_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txthora, "Codigo de hora requerido!");
        }

        private void txttope_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateError.Validate_text(txttope, "Tope horario nocturno requerido!");
        }

        private void FrmPlanilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
