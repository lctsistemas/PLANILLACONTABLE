using Comun.Cache;
using Comun.Comunicacion;
using Negocio.Models;
using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using System.Drawing;

namespace Presentacion.Vista
{

    public partial class frmempleado : Form
    {
        String result;
        NEmpleadoContrato emple_contra = new NEmpleadoContrato();

        public frmempleado()
        {
            InitializeComponent();       
            
            Mostrar_documento();
            Mostrar_cargo();
            Mostrar_regimenpensionario();
            Mostar_banco();
            Mostar_tcontrato();
            MostrarRegimenSalud();
            InitEmpty_combobox();

        }


        //METODO DE INICIALIZACION PARA CONTRATO
        private void Initialize()
        {
            String[] tpago = { "EFECTIVO", "DEPOSITO EN CUENTA", "OTROS" };
            cbotipopago.Items.AddRange(tpago);          

            String[] periodicidad = { "MENSUAL", "QUINCENAL", "SEMANAL", "DIARIO", "OTROS" };
            cboperiodicidad.Items.AddRange(periodicidad);

            String[] genero = { "MASCULINO", "FEMENINO" };
            cbogenero.Items.AddRange(genero);

            String[] estado = { "ACTIVO", "CESADO" };
            cboestado.Items.AddRange(estado);

            String[] jornada = { "FULL-TIME", "PART-TIME" };
            Cbojornada_laboral.Items.AddRange(jornada);
        }

        private void Tabla()
        {
            dgvempleado.Columns[0].HeaderText = "ID EMPLEADO";
            dgvempleado.Columns[0].Visible = false;

            dgvempleado.Columns[1].Visible = false;
            dgvempleado.Columns[2].HeaderText = "APELLIDOS Y NOMBRES"; // este nombre esta validando en eliminar, si cambiar este nombre tambien cambia en Eliminar
            dgvempleado.Columns[2].Width = 320;

            dgvempleado.Columns[3].Visible = false;
            dgvempleado.Columns[4].Visible = false;
            dgvempleado.Columns[5].Visible = false;
            dgvempleado.Columns[6].Visible = false;
            dgvempleado.Columns[7].Visible = false;
            dgvempleado.Columns[8].Visible = false;
            dgvempleado.Columns[9].Visible = false;
            dgvempleado.Columns[10].Visible = false;
            dgvempleado.Columns[11].Visible = false;
            dgvempleado.Columns[12].Visible = false;
            dgvempleado.Columns[13].Visible = false;
            dgvempleado.Columns[14].Visible = false;
            dgvempleado.Columns[15].Visible = false;
            dgvempleado.Columns[16].HeaderText = "ID EMPRESA MAESTRA";
            dgvempleado.Columns[16].Visible = false;

            dgvempleado.Columns[17].HeaderText = "EMPRESA";
            dgvempleado.Columns[17].Visible = false;

            dgvempleado.Columns[18].Visible = false;
            dgvempleado.Columns[19].Visible = false;
            dgvempleado.Columns[20].Visible = false;
            dgvempleado.Columns[21].Visible = false;
            dgvempleado.Columns[22].Visible = false;
            dgvempleado.Columns[23].Visible = false;
            dgvempleado.Columns[24].Visible = false;
            dgvempleado.Columns[25].Visible = false;
            dgvempleado.Columns[26].Visible = false;
            dgvempleado.Columns[27].Visible = false;
            dgvempleado.Columns[28].Visible = false;
            dgvempleado.Columns[29].Visible = false;
            dgvempleado.Columns[30].Visible = false;
            dgvempleado.Columns[31].Visible = false;
            dgvempleado.Columns[32].Visible = false;
            dgvempleado.Columns[33].Visible = false;
            dgvempleado.Columns[34].Visible = false;
        }

        private void Habilitar_doc(bool v)
        {
            txtnumdoc.Enabled = v;
        }

        //HABILITAR BOTONES ELIMINAR Y GURARDAR
        private void HabilitarBoton(bool v)
        {
            btneliminar.Enabled = v;
            btnguardar.Enabled = v;
        }
        private bool btnValidar_telefono()
        {
            if (txttele.Text.Trim().Length != 9)
            {
                return false;
            }

            return true;

        }

        private bool Validar_DNI()
        {
            if (txtnumdoc.Text.Trim().Length != 8)
            {
                return false;
            }

            return true;
        }

        private bool ValidarPasa()
        {
            if (cbotipo_documento.SelectedItem.ToString() == "Pasaporte")
            {
                if (txtnumdoc.Text.Trim().Length != 9)
                {
                    return false;
                }
            }
            return true;
        }      

        private void Mostrar_cargo()
        {
            using (Ncargo nca = new Ncargo())
            {
                cbocargo.DataSource = nca.Getall();
                cbocargo.DisplayMember = "nombre_cargo";
                cbocargo.ValueMember = "idcargo";
            }
        }

        private void MostrarRegimenSalud()
        {
            using (NRegimenSalud nrs = new NRegimenSalud())
            {
                cboregimensalud.DataSource = nrs.Getall();
                cboregimensalud.DisplayMember = "Descripcion";
                cboregimensalud.ValueMember = "id_regimen_salud";
            }
        }

        private void Mostrar_regimenpensionario()
        {
            using (NRegimen nre = new NRegimen())
            {
                cbore_pensionario.DataSource = nre.Getall();
                cbore_pensionario.DisplayMember = "Descripcion";
                cbore_pensionario.ValueMember = "Codigo_Regimen";
            }
        }

        private void Mostrar_documento()
        {
            using (Ndocumento ndo = new Ndocumento())
            {
                cbotipo_documento.DataSource = ndo.Getall();
                cbotipo_documento.DisplayMember = "nombre_documento";
                cbotipo_documento.ValueMember = "iddocumento";
            }
        }
        private void mostrarEmpleado()
        {
            using (emple_contra)
            {
                emple_contra.Id_emp_maestra = UserCache.Codigo_empresa;
                dgvempleado.DataSource = emple_contra.listar_empleado();
                lblcantidad_registro.Text = "Total registro:  " + dgvempleado.RowCount;
            }
        }


        //MOSTRAR PARA CONTRATO
        private void Mostar_banco()
        {
            using (NBanco nb = new NBanco())
            {
                cbobanco.DataSource = nb.Getall();
                cbobanco.DisplayMember = "Nom_banco";
                cbobanco.ValueMember = "IdBanco";
            }
        }

        private void Mostar_tcontrato()
        {
            using (Ntipocontrato ntc = new Ntipocontrato())
            {
                cbotipocontra.DataSource = ntc.MostrarTcontrato();
                cbotipocontra.DisplayMember = "tiem_contrato";
                cbotipocontra.ValueMember = "id_tcontrato";
            }
        }


        //LIMPIAR CONTROLES
        private void limpiar()
        {
            using (emple_contra) { emple_contra.state = EntityState.Guardar; }
            txtNombre.Text = String.Empty;
            txtApeMat.Text = String.Empty;
            txtApePat.Text = String.Empty;
            txttele.Text = String.Empty;
            cbogenero.Text = null;                                              
            Cbojornada_laboral.Text = null;
            cboestado.Text = null;                        
            cbotipopago.Text = null;           
            cboperiodicidad.Text = null;
            cbotipo_moneda.Text = null;
            txtnac.Text = String.Empty;
            txtdire.Text = String.Empty;
            txtnumdoc.Text = String.Empty;
            txtfecha_fin.Text = null;
            txtcussp.Text = string.Empty;
            txtnum_cuenta.Text = string.Empty;
            txtcts.Text = string.Empty;
            dtfecha.Value = DateTime.Today;
            dtinicio.Value = DateTime.Today;
            InitEmpty_combobox();
        }


        //COMBOBOX INICIAR VACIOS
        private void InitEmpty_combobox()
        {
            cbotipo_documento.Text = null;
            cbotipo_documento.SelectedValue = 0;
            cbocargo.Text = null;
            cbocargo.SelectedValue = 0;
            cbore_pensionario.Text = null;
            cbore_pensionario.SelectedValue = 0;
            cboregimensalud.Text = null;
            cboregimensalud.SelectedValue = 0;
            cbobanco.Text = null;
            cbobanco.SelectedValue = 0;
            cbotipocontra.Text = null;
            cbotipocontra.SelectedValue = 0;
        }

        //VALIDAR CAMPOS
        private bool Validar_campos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApePat.Text) ||
                string.IsNullOrEmpty(txtApeMat.Text) ||
                string.IsNullOrEmpty(cbotipo_documento.Text) || string.IsNullOrEmpty(cbocargo.Text) ||
                string.IsNullOrEmpty(txtnac.Text) || string.IsNullOrEmpty(txtnumdoc.Text) ||
                string.IsNullOrEmpty(cbogenero.Text) || string.IsNullOrEmpty(txtremune.Text) || string.IsNullOrEmpty(cbotipopago.Text)
                || string.IsNullOrEmpty(cbotipopago.Text) || string.IsNullOrEmpty(cboperiodicidad.Text) || string.IsNullOrEmpty(cbobanco.Text)                
                || string.IsNullOrEmpty(cbotipo_moneda.Text) || string.IsNullOrEmpty(txtasig.Text) || (!cbore_pensionario.Text.Contains("O.N.P") && string.IsNullOrWhiteSpace(txtcussp.Text))
                || (cbotipopago.Text.Contains("DEPOSITO EN CUENTA") && string.IsNullOrWhiteSpace(txtnum_cuenta.Text)))
            {
                ValidateChildren();
                return true;
            }
            else
            {
                return false;
            }

        }



        private void Empleado_Load(object sender, EventArgs e)
        {
            Initialize();
            mostrarEmpleado();
            Tabla();
            HabilitarBoton(false);
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar_campos())
                return;
            

            //if (btnValidar_telefono() == false)
            //{
            //    Messages.M_warning("El Teléfono debe tener 9 dígitos");
            //    return;
            //}

            if (Validar_DNI() == false)
            {
                Messages.M_warning("El DNI debe tener 8 dígitos");
                return;
            }

            if (ValidarPasa() == false)
            {
                Messages.M_warning("El Pasaporte debe tener 9 dígitos");
                return;
            }


            result = "";
            using (emple_contra)
            {
                if (emple_contra.Existe(txtnumdoc.Text.Trim()) && emple_contra.state ==EntityState.Guardar)
                {
                    Messages.M_error("Código ya existe.");
                    txtnumdoc.Focus();
                    txtnumdoc.SelectAll();
                    return;
                }

                //EMPLEADO                
                emple_contra.Codigo = txtcodigo.Text.Trim();
                emple_contra.Nom_emp = txtNombre.Text.Trim();
                emple_contra.Ape_pat = txtApePat.Text.Trim();
                emple_contra.Ape_mat = txtApeMat.Text.Trim();
                emple_contra.Fec_nac = Convert.ToDateTime(dtfecha.Value);
                emple_contra.Nacionalidad = txtnac.Text.Trim();
                emple_contra.Tipo_genero = cbogenero.SelectedItem.ToString();
                emple_contra.Direccion = txtdire.Text.Trim();
                emple_contra.Telefono = txttele.Text.Trim();
                emple_contra.Num_doc = txtnumdoc.Text;
                emple_contra.Estado = cboestado.SelectedItem.ToString();
                emple_contra.Codigo_regimen = Convert.ToInt32(cbore_pensionario.SelectedValue);
                emple_contra.Id_doc = Convert.ToInt32(cbotipo_documento.SelectedValue);
                emple_contra.Id_cargo = Convert.ToInt32(cbocargo.SelectedValue);
                emple_contra.Jornada_laboral = Cbojornada_laboral.SelectedItem.ToString();
                emple_contra.Id_emp_maestra = UserCache.Codigo_empresa;

                //CONTRATO               
                emple_contra.cid_banco = int.Parse(cbobanco.SelectedValue.ToString());
                emple_contra.cid_tcontrato = int.Parse(cbotipocontra.SelectedValue.ToString());
                emple_contra.cfecha_inicio = DateTime.Parse(dtinicio.Value.ToString());

                if (txtfecha_fin.Text == "  /  /")
                    emple_contra.cfecha_fin = new DateTime(1900, 01, 01);
                else
                    emple_contra.cfecha_fin = DateTime.Parse(txtfecha_fin.Text);

                emple_contra.cnum_cuenta = txtnum_cuenta.Text.Trim();
                emple_contra.cremu_basica = decimal.Parse(txtremune.Text.Trim());
                emple_contra.casig_fami = decimal.Parse(txtasig.Text.Trim());
                emple_contra.cid_salud = Convert.ToInt32(cboregimensalud.SelectedValue);
                emple_contra.ctipo_pago = cbotipopago.SelectedItem.ToString();
                emple_contra.ctipo_moneda = cbotipo_moneda.SelectedItem.ToString();
                emple_contra.cperiodicidad = cboperiodicidad.SelectedItem.ToString();
                emple_contra.ccts = txtcts.Text.Trim();
                emple_contra.ccussp = txtcussp.Text.Trim();

                result = emple_contra.GuardarCambios();
                if (result.Contains("ya se encuentra registrado"))
                    Messages.M_warning(result);
                else
                {
                    mostrarEmpleado();
                    Messages.M_info(result);
                    limpiar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            ValidateError.validate.Clear();
            btnguardar.Enabled = true;
            limpiar();
        }

        private void cmbtipdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo_documento.Text == "")
            {
                Habilitar_doc(false);
            }
            else
            {
                Habilitar_doc(true);
                //txtnumdoc.Focus();
            }

            if (cbotipo_documento.SelectedIndex == 0)
            {
                txtnumdoc.MaxLength = 8;

                if (txtnumdoc.Text != "")
                {
                   // txtnumdoc.Focus();
                }
            }
            else if (cbotipo_documento.SelectedIndex == 1)
            {
                txtnumdoc.MaxLength = 11;
                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Text = "";
                    //txtnumdoc.Focus();
                }
            }
            else if (cbotipo_documento.SelectedIndex == 2)
            {
                txtnumdoc.MaxLength = 9;
                if (txtnumdoc.Text != "")
                {
                    txtnumdoc.Text = "";
                    //txtnumdoc.Focus();
                }
            }
        }

        #region EVENTO KEYPRESS
        private void txttele_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           Keypress.SoloLetras(e);         
        }

        private void txtApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtnac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloLetras(e);
        }

        private void txtnumdoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keypress.SoloNumeros(e);
        }
        #endregion

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvempleado.CurrentRow.Cells[2].Selected)
                {
                    result = "";
                    DialogResult re = Messages.M_question("¿Deseas Anular al colaborador?");
                    if (re == DialogResult.Yes)
                    {
                        using (emple_contra)
                        {
                            emple_contra.state = EntityState.Remover;
                            emple_contra.Id_empleado = Convert.ToInt32(dgvempleado.CurrentRow.Cells[0].Value);
                            result = emple_contra.GuardarCambios();
                            if (result.Contains("No puedes Anular"))
                                Messages.M_error(result);
                            else
                            {
                                Messages.M_info(result);
                                HabilitarBoton(false);
                                mostrarEmpleado();
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HabilitarBoton(false);
                MessageBox.Show(ex.Message);   
            }
          
        }        

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMove.ReleaseCapture();
            WindowsMove.SendMessage(this.Handle, 0x112, 0xf012, 0);
            if(this.WindowState == FormWindowState.Normal)
            {
                btnmaximizar.Visible = true;
                btnrestaurar.Visible = false;
            }            
        }
     
        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ValidateError.validate.Clear();
                HabilitarBoton(true);
                using (emple_contra)
                {
                    emple_contra.state = EntityState.Modificar;
                    emple_contra.Id_empleado = Convert.ToInt32(dgvempleado.CurrentRow.Cells[0].Value);
                    DataRow dr = emple_contra.ListaEmple_total(emple_contra).Rows[0];

                     txtcodigo.Text = dr["codigo"].ToString();
                     txtNombre.Text = dr["nombre_empleado"].ToString();
                     txtApePat.Text = dr["ape_paterno"].ToString();
                     txtApeMat.Text = dr["ape_materno"].ToString();
                     dtfecha.Value = Convert.ToDateTime(dr["fecha_nacimiento"]);
                     txtnac.Text = dr["nacionalidad"].ToString();
                     cbogenero.Text = dr["tipo_genero"].ToString();
                     txtdire.Text = dr["direccion"].ToString();
                     txttele.Text = dr["telefono"].ToString();
                     txtnumdoc.Text = dr["numero_documento"].ToString();
                     cboestado.Text = dr["estado"].ToString();
                     cbore_pensionario.SelectedValue = dr["codigo_regimen"].ToString();
                     cbore_pensionario.Text = dr["descripcion"].ToString();
                     cbotipo_documento.SelectedValue = dr["id_documento"].ToString();
                     cbotipo_documento.Text = dr["nombre"].ToString();
                     cbocargo.SelectedValue = dr["id_cargo"].ToString();
                     cbocargo.Text = dr["nombre_cargo"].ToString();
                     Cbojornada_laboral.Text = dr["jornada_laboral"].ToString();
                     cbobanco.SelectedValue = dr["id_banco"].ToString();
                     cbobanco.Text = dr["nombre_banco"].ToString();
                     cbotipocontra.SelectedValue = dr["id_tipocontrato"].ToString();
                     cbotipocontra.Text = dr["tiempo_contrato"].ToString();
                     dtinicio.Value = Convert.ToDateTime(dr["fecha_inicio"]);
                    //txtfecha_fin.Text= dr["fecha_fin"].ToString() == "1900/01/01" ? null : dr["fecha_fin"].ToString();

                    txtfecha_fin.Text = Convert.ToDateTime(dr["fecha_fin"]).ToString("dd/MM/yyyy") == "01/01/1900" ? null : Convert.ToDateTime(dr["fecha_fin"]).ToString("dd/MM/yyyy");
                     txtnum_cuenta.Text = dr["numero_cuenta"].ToString();
                     txtremune.Text = Convert.ToDecimal(dr["remuneracion_basica"]).ToString("N2");
                     txtasig.Text = Convert.ToDecimal(dr["asignacion_familiar"]).ToString("N2");
                     cboregimensalud.SelectedValue = dr["id_rsalud"].ToString();
                     cboregimensalud.Text = dr["descripcion_rsalud"].ToString();
                     cbotipopago.Text = dr["tipo_pago"].ToString();
                     cboperiodicidad.Text = dr["periodicidad"].ToString();
                     cbotipo_moneda.Text = dr["tipo_moneda"].ToString();
                     txtcts.Text = dr["cuenta_cts"].ToString();
                     txtcussp.Text = dr["cussp"].ToString();

                    //txtfecha_fin.Text = Convert.ToDateTime(dr["fecha_fin"]).ToString("dd/MM/yyyy");// == "1900/01/01" ? null : dr["fecha_fin"].ToString();
                    //MessageBox.Show("es: "+Convert.ToDateTime (dr["fecha_fin"]).ToString("dd/MM/yyyy"));
                }
            }
        }


        private void linkpagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start(@"https://reportedeudas.sbs.gob.pe/ReporteSituacionPrevisional/Afil_Consulta.aspx");
            Process.Start(@"https://www2.sbs.gob.pe/afiliados/paginas/Consulta.aspx");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            using (emple_contra)
            {
                dgvempleado.DataSource = emple_contra.Search(txtbuscar.Text.Trim());
                lblcantidad_registro.Text = "Registro:  " + dgvempleado.RowCount;
            }
        }

        private void txtnumdoc_TextChanged(object sender, EventArgs e)
        {
            txtcodigo.Text = txtnumdoc.Text.Trim();
        }

        private void linkconsulta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dapi da = new Dapi()
            {
                dni = txtnumdoc.Text.Trim()
            };

            using (Request re = new Request())
            {
                re.Solicitar(da);
                if (RecuperarData.mensaje.Contains("found data"))
                {
                    txtNombre.Text = RecuperarData.nombres;
                    txtApePat.Text = RecuperarData.paterno;
                    txtApeMat.Text = RecuperarData.materno;
                }
                else
                    Messages.M_error(RecuperarData.mensaje);
            }

        }

        private void linkcargo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contextmenu.Show(cbocargo,0,0);
            totxtcargo.Focus();
        }

        private void totxtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(totxtcargo.Text))
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    using (Ncargo nca = new Ncargo())
                    {
                        nca.state = EntityState.Guardar;
                        nca.nombre_cargo = totxtcargo.Text.Trim();
                        nca.descripcion = "";
                        nca.SaveChanges();
                        
                    }
                    totxtcargo.Text = "";
                    contextmenu.Close();
                    Mostrar_cargo();

                }
            }
        }


        #region VALIDACION ERROR PROVIDER
        private void txtApePat_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtApePat, "Campo requerido");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtNombre, "Campo requerido");
        }

        private void txtApeMat_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtApeMat, "Campo requerido");
        }

        private void txtnumdoc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnumdoc, "Campo requerido");
        }

        private void txtnac_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtnac, "Campo requerido");
        }

        private void cbxgene_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbogenero, "Campo requerido");
        }

        private void cmbtipdoc_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbotipo_documento, "Campo requerido");
        }

        private void cbobanco_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbobanco, "Campo banco requerido");
        }

        private void cbotipopago_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbotipopago, "Campo tipo de pago requerido");
        }

        private void cbotipo_moneda_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbotipo_moneda, "Campo tipo de moneda requerido");
        }

        private void cboperiodicidad_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cboperiodicidad, "Campo periodicidad requerido");
        }

        private void txtremune_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtremune, "Campo remuneracion requerido");
        }

        private void cbore_pensionario_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbore_pensionario, "Campo regimen requerido");
        }

        private void cbocargo_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbocargo, "Campo cargo requerido");
        }

        private void cboestado_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cboestado, "Campo estado requerido");
        }

        private void cbotipocontra_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_combo(cbotipocontra, "Campo tipo contrato requerido");
        }

        private void txtasig_Validating(object sender, CancelEventArgs e)
        {
            ValidateError.Validate_text(txtasig, "Campo asignacion familiar requerido");
        }
        private void txtcussp_Validating(object sender, CancelEventArgs e)
        {
            if (!cbore_pensionario.Text.Contains("O.N.P") && cbore_pensionario.Text != string.Empty)
            {
                ValidateError.Validate_text(txtcussp, "Requerido");
            }
            else
                ValidateError.Validate_text(txtcussp, null);
          
        }

        private void txtnum_cuenta_Validating(object sender, CancelEventArgs e)
        {
            if (cbotipopago.Text.Contains("DEPOSITO EN CUENTA") && cbotipopago.Text != string.Empty)
            {
                ValidateError.Validate_text(txtnum_cuenta, "Requerido");
            }
            else
                ValidateError.Validate_text(txtnum_cuenta, null);
        }

        private void cbore_pensionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbore_pensionario.Text.Contains("O.N.P"))
                ValidateError.validate.SetError(txtcussp, null);
        }

        private void cbotipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbotipopago.Text.Contains("DEPOSITO EN CUENTA"))
                ValidateError.validate.SetError(txtnum_cuenta,null);
        }
        #endregion

        //cerrar
        private void btncerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(241,112,122);
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            btncerrar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btncerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btncerrar.BackColor = Color.Crimson;
        }
        //maximizar
        private void btnmaximizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(165, 171, 179);
        }
        private void btnmaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnmaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnmaximizar.BackColor = Color.FromArgb(138, 140, 140);
        }
        //restaurar
        private void btnrestaurar_MouseDown(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnrestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnrestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnrestaurar.BackColor = Color.FromArgb(138, 140, 140);
        }
        //minimizar
        private void btnminimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(165,171,179);
        }

        private void btnminimizar_MouseLeave(object sender, EventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(116,118,118);
        }

        private void btnminimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnminimizar.BackColor = Color.FromArgb(138,140,140) ;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //..
        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

       
    }
}
