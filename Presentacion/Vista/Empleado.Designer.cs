using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    partial class frmempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblcantidad_registro = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtasig = new System.Windows.Forms.TextBox();
            this.lblasig = new System.Windows.Forms.Label();
            this.cboregimensalud = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtremune = new System.Windows.Forms.TextBox();
            this.cbotipocontra = new System.Windows.Forms.ComboBox();
            this.lblremu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboperiodicidad = new System.Windows.Forms.ComboBox();
            this.txtnum_cuenta = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbotipopago = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbobanco = new System.Windows.Forms.ComboBox();
            this.lblcts = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtcts = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbotipo_moneda = new System.Windows.Forms.ComboBox();
            this.lbltipomoneda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfecha_fin = new System.Windows.Forms.MaskedTextBox();
            this.linkpagina = new System.Windows.Forms.LinkLabel();
            this.txtcussp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.lblfechaini = new System.Windows.Forms.Label();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lblafp = new System.Windows.Forms.Label();
            this.cbocargo = new System.Windows.Forms.ComboBox();
            this.cbore_pensionario = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotipo_documento = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbogenero = new System.Windows.Forms.ComboBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdire = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttele = new System.Windows.Forms.TextBox();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvempleado
            // 
            this.dgvempleado.AllowUserToAddRows = false;
            this.dgvempleado.AllowUserToDeleteRows = false;
            this.dgvempleado.AllowUserToOrderColumns = true;
            this.dgvempleado.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvempleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvempleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvempleado.ColumnHeadersHeight = 40;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvempleado.EnableHeadersVisualStyles = false;
            this.dgvempleado.Location = new System.Drawing.Point(4, 89);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.ReadOnly = true;
            this.dgvempleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvempleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvempleado.RowHeadersWidth = 22;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvempleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvempleado.Size = new System.Drawing.Size(233, 449);
            this.dgvempleado.TabIndex = 18;
            this.dgvempleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp;
            this.btnNuevo.Location = new System.Drawing.Point(302, 55);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 27);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp1;
            this.btnguardar.Location = new System.Drawing.Point(242, 55);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(52, 27);
            this.btnguardar.TabIndex = 62;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblcantidad_registro
            // 
            this.lblcantidad_registro.AutoSize = true;
            this.lblcantidad_registro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad_registro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcantidad_registro.Location = new System.Drawing.Point(436, 60);
            this.lblcantidad_registro.Name = "lblcantidad_registro";
            this.lblcantidad_registro.Size = new System.Drawing.Size(37, 17);
            this.lblcantidad_registro.TabIndex = 82;
            this.lblcantidad_registro.Text = "total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(4, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 81;
            this.label17.Text = "Buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(60, 66);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(133, 16);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp;
            this.btneliminar.Location = new System.Drawing.Point(355, 55);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(52, 27);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.ForeColor = System.Drawing.Color.DimGray;
            this.lblbuscar.Location = new System.Drawing.Point(56, 72);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(139, 13);
            this.lblbuscar.TabIndex = 85;
            this.lblbuscar.Text = "______________________\r\n";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(407, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "COLABORADORES";
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.paneltitulo.Controls.Add(this.pictureBox1);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Controls.Add(this.label16);
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Controls.Add(this.btnmaximizar);
            this.paneltitulo.Controls.Add(this.btnrestaurar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1011, 50);
            this.paneltitulo.TabIndex = 81;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_lct_2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp2;
            this.btncerrar.Location = new System.Drawing.Point(972, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(900, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Enabled = false;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp1;
            this.btnmaximizar.Location = new System.Drawing.Point(936, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 10;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(788, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 11;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 408);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registrar Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtasig);
            this.groupBox5.Controls.Add(this.lblasig);
            this.groupBox5.Controls.Add(this.cboregimensalud);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtremune);
            this.groupBox5.Controls.Add(this.cbotipocontra);
            this.groupBox5.Controls.Add(this.lblremu);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(12, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(738, 107);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            // 
            // txtasig
            // 
            this.txtasig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasig.Location = new System.Drawing.Point(554, 52);
            this.txtasig.Name = "txtasig";
            this.txtasig.Size = new System.Drawing.Size(128, 22);
            this.txtasig.TabIndex = 27;
            // 
            // lblasig
            // 
            this.lblasig.AutoSize = true;
            this.lblasig.BackColor = System.Drawing.Color.Transparent;
            this.lblasig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblasig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasig.ForeColor = System.Drawing.Color.DimGray;
            this.lblasig.Location = new System.Drawing.Point(551, 29);
            this.lblasig.Name = "lblasig";
            this.lblasig.Size = new System.Drawing.Size(131, 17);
            this.lblasig.TabIndex = 24;
            this.lblasig.Text = "Asignación familiar";
            // 
            // cboregimensalud
            // 
            this.cboregimensalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboregimensalud.DropDownWidth = 138;
            this.cboregimensalud.FormattingEnabled = true;
            this.cboregimensalud.Location = new System.Drawing.Point(201, 49);
            this.cboregimensalud.Name = "cboregimensalud";
            this.cboregimensalud.Size = new System.Drawing.Size(148, 25);
            this.cboregimensalud.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(198, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Régimen de salud";
            // 
            // txtremune
            // 
            this.txtremune.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremune.Location = new System.Drawing.Point(385, 52);
            this.txtremune.Name = "txtremune";
            this.txtremune.Size = new System.Drawing.Size(140, 22);
            this.txtremune.TabIndex = 25;
            // 
            // cbotipocontra
            // 
            this.cbotipocontra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipocontra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipocontra.FormattingEnabled = true;
            this.cbotipocontra.Location = new System.Drawing.Point(13, 49);
            this.cbotipocontra.Name = "cbotipocontra";
            this.cbotipocontra.Size = new System.Drawing.Size(140, 25);
            this.cbotipocontra.TabIndex = 33;
            // 
            // lblremu
            // 
            this.lblremu.BackColor = System.Drawing.Color.Transparent;
            this.lblremu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblremu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremu.ForeColor = System.Drawing.Color.DimGray;
            this.lblremu.Location = new System.Drawing.Point(382, 15);
            this.lblremu.Name = "lblremu";
            this.lblremu.Size = new System.Drawing.Size(114, 34);
            this.lblremu.TabIndex = 22;
            this.lblremu.Text = "Remuneración básica inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo de contrato";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboperiodicidad);
            this.groupBox4.Controls.Add(this.txtnum_cuenta);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cbotipopago);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.cbobanco);
            this.groupBox4.Controls.Add(this.lblcts);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtcts);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cbotipo_moneda);
            this.groupBox4.Controls.Add(this.lbltipomoneda);
            this.groupBox4.Location = new System.Drawing.Point(12, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 144);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // cboperiodicidad
            // 
            this.cboperiodicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodicidad.FormattingEnabled = true;
            this.cboperiodicidad.Location = new System.Drawing.Point(554, 39);
            this.cboperiodicidad.Name = "cboperiodicidad";
            this.cboperiodicidad.Size = new System.Drawing.Size(144, 25);
            this.cboperiodicidad.TabIndex = 48;
            // 
            // txtnum_cuenta
            // 
            this.txtnum_cuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_cuenta.Location = new System.Drawing.Point(185, 43);
            this.txtnum_cuenta.Name = "txtnum_cuenta";
            this.txtnum_cuenta.Size = new System.Drawing.Size(170, 22);
            this.txtnum_cuenta.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(551, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(161, 17);
            this.label22.TabIndex = 46;
            this.label22.Text = "Periodicidad de ingreso";
            // 
            // cbotipopago
            // 
            this.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipopago.DropDownWidth = 150;
            this.cbotipopago.FormattingEnabled = true;
            this.cbotipopago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbotipopago.Location = new System.Drawing.Point(12, 40);
            this.cbotipopago.Name = "cbotipopago";
            this.cbotipopago.Size = new System.Drawing.Size(141, 25);
            this.cbotipopago.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(182, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 17);
            this.label20.TabIndex = 37;
            this.label20.Text = "Número de cuenta";
            // 
            // cbobanco
            // 
            this.cbobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobanco.FormattingEnabled = true;
            this.cbobanco.Location = new System.Drawing.Point(385, 39);
            this.cbobanco.Name = "cbobanco";
            this.cbobanco.Size = new System.Drawing.Size(140, 25);
            this.cbobanco.TabIndex = 38;
            // 
            // lblcts
            // 
            this.lblcts.AutoSize = true;
            this.lblcts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcts.ForeColor = System.Drawing.Color.DimGray;
            this.lblcts.Location = new System.Drawing.Point(182, 83);
            this.lblcts.Name = "lblcts";
            this.lblcts.Size = new System.Drawing.Size(79, 17);
            this.lblcts.TabIndex = 43;
            this.lblcts.Text = "Cuenta cts";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(10, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Tipo de pago";
            // 
            // txtcts
            // 
            this.txtcts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcts.Location = new System.Drawing.Point(185, 105);
            this.txtcts.Name = "txtcts";
            this.txtcts.Size = new System.Drawing.Size(318, 22);
            this.txtcts.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(382, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Banco";
            // 
            // cbotipo_moneda
            // 
            this.cbotipo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo_moneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo_moneda.FormattingEnabled = true;
            this.cbotipo_moneda.Items.AddRange(new object[] {
            "SOLES ",
            "DOLARES"});
            this.cbotipo_moneda.Location = new System.Drawing.Point(12, 103);
            this.cbotipo_moneda.Name = "cbotipo_moneda";
            this.cbotipo_moneda.Size = new System.Drawing.Size(121, 25);
            this.cbotipo_moneda.TabIndex = 41;
            // 
            // lbltipomoneda
            // 
            this.lbltipomoneda.AutoSize = true;
            this.lbltipomoneda.BackColor = System.Drawing.Color.Transparent;
            this.lbltipomoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltipomoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipomoneda.ForeColor = System.Drawing.Color.DimGray;
            this.lbltipomoneda.Location = new System.Drawing.Point(10, 83);
            this.lbltipomoneda.Name = "lbltipomoneda";
            this.lbltipomoneda.Size = new System.Drawing.Size(115, 17);
            this.lbltipomoneda.TabIndex = 40;
            this.lbltipomoneda.Text = "Tipo de moneda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfecha_fin);
            this.groupBox1.Controls.Add(this.linkpagina);
            this.groupBox1.Controls.Add(this.txtcussp);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.lblfechaini);
            this.groupBox1.Controls.Add(this.lblfechafin);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 88);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // txtfecha_fin
            // 
            this.txtfecha_fin.Location = new System.Drawing.Point(204, 44);
            this.txtfecha_fin.Mask = "00/00/0000";
            this.txtfecha_fin.Name = "txtfecha_fin";
            this.txtfecha_fin.Size = new System.Drawing.Size(128, 23);
            this.txtfecha_fin.TabIndex = 46;
            // 
            // linkpagina
            // 
            this.linkpagina.AutoSize = true;
            this.linkpagina.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkpagina.Location = new System.Drawing.Point(596, 51);
            this.linkpagina.Name = "linkpagina";
            this.linkpagina.Size = new System.Drawing.Size(89, 17);
            this.linkpagina.TabIndex = 34;
            this.linkpagina.TabStop = true;
            this.linkpagina.Text = "Consulta SBS";
            this.linkpagina.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpagina_LinkClicked);
            // 
            // txtcussp
            // 
            this.txtcussp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcussp.Location = new System.Drawing.Point(386, 46);
            this.txtcussp.Name = "txtcussp";
            this.txtcussp.Size = new System.Drawing.Size(197, 22);
            this.txtcussp.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(383, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "N° CUSSP";
            // 
            // dtinicio
            // 
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(16, 44);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(120, 23);
            this.dtinicio.TabIndex = 28;
            // 
            // lblfechaini
            // 
            this.lblfechaini.AutoSize = true;
            this.lblfechaini.BackColor = System.Drawing.Color.Transparent;
            this.lblfechaini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfechaini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaini.ForeColor = System.Drawing.Color.DimGray;
            this.lblfechaini.Location = new System.Drawing.Point(13, 24);
            this.lblfechaini.Name = "lblfechaini";
            this.lblfechaini.Size = new System.Drawing.Size(106, 17);
            this.lblfechaini.TabIndex = 29;
            this.lblfechaini.Text = "Fecha de inicio";
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.BackColor = System.Drawing.Color.Transparent;
            this.lblfechafin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfechafin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechafin.ForeColor = System.Drawing.Color.DimGray;
            this.lblfechafin.Location = new System.Drawing.Point(201, 26);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(66, 17);
            this.lblfechafin.TabIndex = 30;
            this.lblfechafin.Text = "Fecha fin";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtfecha);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbotipo_documento);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbogenero);
            this.groupBox2.Controls.Add(this.txtApePat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtApeMat);
            this.groupBox2.Controls.Add(this.txtnumdoc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnac);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdire);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txttele);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 375);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.cboestado);
            this.groupBox3.Controls.Add(this.lblafp);
            this.groupBox3.Controls.Add(this.cbocargo);
            this.groupBox3.Controls.Add(this.cbore_pensionario);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(483, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 374);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(18, 170);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(133, 25);
            this.cboestado.TabIndex = 76;
            // 
            // lblafp
            // 
            this.lblafp.AutoSize = true;
            this.lblafp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafp.ForeColor = System.Drawing.Color.DimGray;
            this.lblafp.Location = new System.Drawing.Point(13, 32);
            this.lblafp.Name = "lblafp";
            this.lblafp.Size = new System.Drawing.Size(143, 17);
            this.lblafp.TabIndex = 67;
            this.lblafp.Text = "Regimen Pensionario";
            // 
            // cbocargo
            // 
            this.cbocargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocargo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocargo.FormattingEnabled = true;
            this.cbocargo.Location = new System.Drawing.Point(16, 109);
            this.cbocargo.Name = "cbocargo";
            this.cbocargo.Size = new System.Drawing.Size(173, 25);
            this.cbocargo.TabIndex = 62;
            // 
            // cbore_pensionario
            // 
            this.cbore_pensionario.DropDownHeight = 111;
            this.cbore_pensionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbore_pensionario.DropDownWidth = 168;
            this.cbore_pensionario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbore_pensionario.FormattingEnabled = true;
            this.cbore_pensionario.IntegralHeight = false;
            this.cbore_pensionario.Location = new System.Drawing.Point(16, 53);
            this.cbore_pensionario.Name = "cbore_pensionario";
            this.cbore_pensionario.Size = new System.Drawing.Size(173, 25);
            this.cbore_pensionario.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(15, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 71;
            this.label15.Text = "Cargo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(15, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Estado";
            // 
            // dtfecha
            // 
            this.dtfecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(190, 234);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 22);
            this.dtfecha.TabIndex = 57;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(13, 54);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(131, 22);
            this.txtcodigo.TabIndex = 66;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre ";
            // 
            // cbotipo_documento
            // 
            this.cbotipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo_documento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo_documento.FormattingEnabled = true;
            this.cbotipo_documento.Location = new System.Drawing.Point(190, 54);
            this.cbotipo_documento.Name = "cbotipo_documento";
            this.cbotipo_documento.Size = new System.Drawing.Size(123, 25);
            this.cbotipo_documento.TabIndex = 52;
            this.cbotipo_documento.SelectedIndexChanged += new System.EventHandler(this.cmbtipdoc_SelectedIndexChanged);
            this.cbotipo_documento.Validating += new System.ComponentModel.CancelEventHandler(this.cmbtipdoc_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(11, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 22);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(10, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido paterno";
            // 
            // cbogenero
            // 
            this.cbogenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogenero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogenero.FormattingEnabled = true;
            this.cbogenero.Location = new System.Drawing.Point(12, 294);
            this.cbogenero.Name = "cbogenero";
            this.cbogenero.Size = new System.Drawing.Size(130, 25);
            this.cbogenero.TabIndex = 49;
            this.cbogenero.Validating += new System.ComponentModel.CancelEventHandler(this.cbxgene_Validating);
            // 
            // txtApePat
            // 
            this.txtApePat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.Location = new System.Drawing.Point(13, 174);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(129, 22);
            this.txtApePat.TabIndex = 43;
            this.txtApePat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePat_KeyPress);
            this.txtApePat.Validating += new System.ComponentModel.CancelEventHandler(this.txtApePat_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(340, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "N° documento";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMat.Location = new System.Drawing.Point(12, 234);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(130, 22);
            this.txtApeMat.TabIndex = 45;
            this.txtApeMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeMat_KeyPress);
            this.txtApeMat.Validating += new System.ComponentModel.CancelEventHandler(this.txtApeMat_Validating);
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumdoc.Location = new System.Drawing.Point(343, 57);
            this.txtnumdoc.MaxLength = 8;
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(123, 22);
            this.txtnumdoc.TabIndex = 53;
            this.txtnumdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumdoc_KeyPress);
            this.txtnumdoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtnumdoc_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(187, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 69;
            this.label14.Text = "Tipo de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(189, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(191, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nacionalidad";
            // 
            // txtnac
            // 
            this.txtnac.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnac.Location = new System.Drawing.Point(190, 294);
            this.txtnac.Name = "txtnac";
            this.txtnac.Size = new System.Drawing.Size(121, 22);
            this.txtnac.TabIndex = 59;
            this.txtnac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnac_KeyPress);
            this.txtnac.Validating += new System.ComponentModel.CancelEventHandler(this.txtnac_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(189, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Dirección";
            // 
            // txtdire
            // 
            this.txtdire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdire.Location = new System.Drawing.Point(190, 115);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(274, 22);
            this.txtdire.TabIndex = 54;
            this.txtdire.Validating += new System.ComponentModel.CancelEventHandler(this.txtdire_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(191, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Telefono";
            // 
            // txttele
            // 
            this.txttele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttele.Location = new System.Drawing.Point(190, 174);
            this.txttele.MaxLength = 9;
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(123, 22);
            this.txttele.TabIndex = 56;
            this.txttele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttele_KeyPress);
            this.txttele.Validating += new System.ComponentModel.CancelEventHandler(this.txttele_Validating);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabPage2);
            this.tabEmpleado.Controls.Add(this.tabPage1);
            this.tabEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpleado.ItemSize = new System.Drawing.Size(89, 33);
            this.tabEmpleado.Location = new System.Drawing.Point(238, 89);
            this.tabEmpleado.Multiline = true;
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.Padding = new System.Drawing.Point(20, 3);
            this.tabEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(768, 449);
            this.tabEmpleado.TabIndex = 40;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(195, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 16);
            this.linkLabel1.TabIndex = 77;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nuevo";
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.lblcantidad_registro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tabEmpleado);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmempleado";
            this.Text = "EMPLEADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Empleado_FormClosing);
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        #endregion
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnNuevo;
        private Label label17;
        private TextBox txtbuscar;
        private Label label16;
        private Label lblcantidad_registro;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox btnmaximizar;
        private Label lblbuscar;
        private Panel paneltitulo;
        private PictureBox btnrestaurar;
        private PictureBox pictureBox1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cboestado;
        private Label lblafp;
        private ComboBox cbocargo;
        private ComboBox cbore_pensionario;
        private Label label15;
        private Label label12;
        private DateTimePicker dtfecha;
        private TextBox txtcodigo;
        private Label label9;
        private Label label1;
        private ComboBox cbotipo_documento;
        private TextBox txtNombre;
        private Label label11;
        private Label label2;
        private ComboBox cbogenero;
        private TextBox txtApePat;
        private Label label3;
        private Label label10;
        private TextBox txtApeMat;
        private TextBox txtnumdoc;
        private Label label14;
        private Label label5;
        private Label label4;
        private TextBox txtnac;
        private Label label8;
        private TextBox txtdire;
        private Label label7;
        private TextBox txttele;
        private TabControl tabEmpleado;
        private ComboBox cbotipocontra;
        private Label label6;
        private Label lblfechafin;
        private Label lblfechaini;
        private DateTimePicker dtinicio;
        private Label lblremu;
        private TextBox txtremune;
        private Label label13;
        private Label lblasig;
        private TextBox txtasig;
        private GroupBox groupBox1;
        public TextBox txtcussp;
        private Label label18;
        private Label lblcts;
        private TextBox txtcts;
        private ComboBox cbotipo_moneda;
        private Label lbltipomoneda;
        private Label label19;
        private ComboBox cbobanco;
        private Label label20;
        private TextBox txtnum_cuenta;
        private LinkLabel linkpagina;
        private ComboBox cbotipopago;
        private Label label22;
        private Label label21;
        private ComboBox cboregimensalud;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private ComboBox cboperiodicidad;
        private MaskedTextBox txtfecha_fin;
        private LinkLabel linkLabel1;
    }
}