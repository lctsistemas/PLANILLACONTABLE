﻿namespace Presentacion.Vista
{
    partial class frmcontrato
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
            this.panelcontrato = new System.Windows.Forms.Panel();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid_empleado = new System.Windows.Forms.TextBox();
            this.lblcts = new System.Windows.Forms.Label();
            this.txtcts = new System.Windows.Forms.TextBox();
            this.cmbmoneda = new System.Windows.Forms.ComboBox();
            this.lbltipomoneda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbanco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnum_cuenta = new System.Windows.Forms.TextBox();
            this.lblasig = new System.Windows.Forms.Label();
            this.lblremu = new System.Windows.Forms.Label();
            this.txtremune = new System.Windows.Forms.TextBox();
            this.txtasig = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbtipcont = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfin = new System.Windows.Forms.DateTimePicker();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.lblfechaini = new System.Windows.Forms.Label();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcussp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lbldocumento = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtafp = new System.Windows.Forms.TextBox();
            this.panelcontrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontrato
            // 
            this.panelcontrato.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcontrato.Controls.Add(this.btnmaximizar);
            this.panelcontrato.Controls.Add(this.btnrestaurar);
            this.panelcontrato.Controls.Add(this.btnminimizar);
            this.panelcontrato.Controls.Add(this.btncerrar);
            this.panelcontrato.Controls.Add(this.pictureBox1);
            this.panelcontrato.Controls.Add(this.label1);
            this.panelcontrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcontrato.Location = new System.Drawing.Point(0, 0);
            this.panelcontrato.Name = "panelcontrato";
            this.panelcontrato.Size = new System.Drawing.Size(676, 50);
            this.panelcontrato.TabIndex = 0;
            this.panelcontrato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcontrato_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.maxi;
            this.btnmaximizar.Location = new System.Drawing.Point(600, 6);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 9;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Visible = false;
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(600, 6);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 10;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(563, 6);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 11;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Visible = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp;
            this.btncerrar.Location = new System.Drawing.Point(637, 6);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 12;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_lct_2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTRATO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.txtid_empleado);
            this.panel2.Controls.Add(this.lblcts);
            this.panel2.Controls.Add(this.txtcts);
            this.panel2.Controls.Add(this.cmbmoneda);
            this.panel2.Controls.Add(this.lbltipomoneda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbbanco);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnum_cuenta);
            this.panel2.Location = new System.Drawing.Point(1, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 138);
            this.panel2.TabIndex = 17;
            // 
            // txtid_empleado
            // 
            this.txtid_empleado.Location = new System.Drawing.Point(473, 96);
            this.txtid_empleado.Name = "txtid_empleado";
            this.txtid_empleado.Size = new System.Drawing.Size(29, 20);
            this.txtid_empleado.TabIndex = 31;
            // 
            // lblcts
            // 
            this.lblcts.AutoSize = true;
            this.lblcts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcts.ForeColor = System.Drawing.Color.White;
            this.lblcts.Location = new System.Drawing.Point(28, 75);
            this.lblcts.Name = "lblcts";
            this.lblcts.Size = new System.Drawing.Size(31, 16);
            this.lblcts.TabIndex = 25;
            this.lblcts.Text = "CTS";
            // 
            // txtcts
            // 
            this.txtcts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcts.Location = new System.Drawing.Point(31, 94);
            this.txtcts.Name = "txtcts";
            this.txtcts.Size = new System.Drawing.Size(318, 22);
            this.txtcts.TabIndex = 24;
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Items.AddRange(new object[] {
            "SOLES ",
            "DOLARES"});
            this.cmbmoneda.Location = new System.Drawing.Point(381, 32);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(121, 25);
            this.cmbmoneda.TabIndex = 23;
            // 
            // lbltipomoneda
            // 
            this.lbltipomoneda.AutoSize = true;
            this.lbltipomoneda.BackColor = System.Drawing.Color.Transparent;
            this.lbltipomoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltipomoneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipomoneda.ForeColor = System.Drawing.Color.White;
            this.lbltipomoneda.Location = new System.Drawing.Point(378, 12);
            this.lbltipomoneda.Name = "lbltipomoneda";
            this.lbltipomoneda.Size = new System.Drawing.Size(102, 16);
            this.lbltipomoneda.TabIndex = 22;
            this.lbltipomoneda.Text = "TIPO_MONEDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "BANCO";
            // 
            // cmbbanco
            // 
            this.cmbbanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbanco.FormattingEnabled = true;
            this.cmbbanco.Location = new System.Drawing.Point(31, 31);
            this.cmbbanco.Name = "cmbbanco";
            this.cmbbanco.Size = new System.Drawing.Size(140, 25);
            this.cmbbanco.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(189, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "NUMERO DE CUENTA";
            // 
            // txtnum_cuenta
            // 
            this.txtnum_cuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_cuenta.Location = new System.Drawing.Point(190, 30);
            this.txtnum_cuenta.Name = "txtnum_cuenta";
            this.txtnum_cuenta.Size = new System.Drawing.Size(163, 22);
            this.txtnum_cuenta.TabIndex = 17;
            // 
            // lblasig
            // 
            this.lblasig.AutoSize = true;
            this.lblasig.BackColor = System.Drawing.Color.Transparent;
            this.lblasig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblasig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasig.ForeColor = System.Drawing.Color.White;
            this.lblasig.Location = new System.Drawing.Point(28, 87);
            this.lblasig.Name = "lblasig";
            this.lblasig.Size = new System.Drawing.Size(159, 16);
            this.lblasig.TabIndex = 11;
            this.lblasig.Text = "ASIGNACION FAMILIAR";
            // 
            // lblremu
            // 
            this.lblremu.AutoSize = true;
            this.lblremu.BackColor = System.Drawing.Color.Transparent;
            this.lblremu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblremu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremu.ForeColor = System.Drawing.Color.White;
            this.lblremu.Location = new System.Drawing.Point(229, 87);
            this.lblremu.Name = "lblremu";
            this.lblremu.Size = new System.Drawing.Size(166, 16);
            this.lblremu.TabIndex = 10;
            this.lblremu.Text = "REMUNERACION BASICA";
            // 
            // txtremune
            // 
            this.txtremune.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremune.Location = new System.Drawing.Point(232, 106);
            this.txtremune.Name = "txtremune";
            this.txtremune.Size = new System.Drawing.Size(163, 22);
            this.txtremune.TabIndex = 12;
            // 
            // txtasig
            // 
            this.txtasig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasig.Location = new System.Drawing.Point(31, 106);
            this.txtasig.Name = "txtasig";
            this.txtasig.Size = new System.Drawing.Size(156, 22);
            this.txtasig.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.cmbtipcont);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtfin);
            this.panel3.Controls.Add(this.lblfechafin);
            this.panel3.Controls.Add(this.lblfechaini);
            this.panel3.Controls.Add(this.dtinicio);
            this.panel3.Controls.Add(this.lblremu);
            this.panel3.Controls.Add(this.txtremune);
            this.panel3.Controls.Add(this.lblasig);
            this.panel3.Controls.Add(this.txtasig);
            this.panel3.Location = new System.Drawing.Point(1, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 166);
            this.panel3.TabIndex = 18;
            // 
            // cmbtipcont
            // 
            this.cmbtipcont.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipcont.FormattingEnabled = true;
            this.cmbtipcont.Location = new System.Drawing.Point(31, 38);
            this.cmbtipcont.Name = "cmbtipcont";
            this.cmbtipcont.Size = new System.Drawing.Size(163, 25);
            this.cmbtipcont.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "TIPO DE CONTRATO";
            // 
            // dtfin
            // 
            this.dtfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfin.Location = new System.Drawing.Point(427, 37);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(152, 20);
            this.dtfin.TabIndex = 19;
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.BackColor = System.Drawing.Color.Transparent;
            this.lblfechafin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfechafin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechafin.ForeColor = System.Drawing.Color.White;
            this.lblfechafin.Location = new System.Drawing.Point(424, 19);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(74, 16);
            this.lblfechafin.TabIndex = 18;
            this.lblfechafin.Text = "FECHA FIN";
            // 
            // lblfechaini
            // 
            this.lblfechaini.AutoSize = true;
            this.lblfechaini.BackColor = System.Drawing.Color.Transparent;
            this.lblfechaini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfechaini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaini.ForeColor = System.Drawing.Color.White;
            this.lblfechaini.Location = new System.Drawing.Point(229, 18);
            this.lblfechaini.Name = "lblfechaini";
            this.lblfechaini.Size = new System.Drawing.Size(97, 16);
            this.lblfechaini.TabIndex = 17;
            this.lblfechaini.Text = "FECHA INICIO";
            // 
            // dtinicio
            // 
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(232, 38);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(156, 20);
            this.dtinicio.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.txtafp);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtcussp);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtpen);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtcargo);
            this.panel4.Controls.Add(this.lblcargo);
            this.panel4.Controls.Add(this.txtdocumento);
            this.panel4.Controls.Add(this.lbldocumento);
            this.panel4.Controls.Add(this.txtnombre);
            this.panel4.Controls.Add(this.lblnombre);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 141);
            this.panel4.TabIndex = 19;
            // 
            // txtcussp
            // 
            this.txtcussp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcussp.Location = new System.Drawing.Point(305, 106);
            this.txtcussp.Name = "txtcussp";
            this.txtcussp.Size = new System.Drawing.Size(160, 22);
            this.txtcussp.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(307, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "N° CUSSP";
            // 
            // txtpen
            // 
            this.txtpen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpen.Location = new System.Drawing.Point(15, 106);
            this.txtpen.Name = "txtpen";
            this.txtpen.Size = new System.Drawing.Size(83, 22);
            this.txtpen.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "PENSION";
            // 
            // txtcargo
            // 
            this.txtcargo.Enabled = false;
            this.txtcargo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.Location = new System.Drawing.Point(487, 55);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(139, 22);
            this.txtcargo.TabIndex = 26;
            this.txtcargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.Black;
            this.lblcargo.Location = new System.Drawing.Point(493, 36);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(58, 16);
            this.lblcargo.TabIndex = 25;
            this.lblcargo.Text = "CARGO";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Enabled = false;
            this.txtdocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(305, 55);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(160, 22);
            this.txtdocumento.TabIndex = 24;
            // 
            // lbldocumento
            // 
            this.lbldocumento.AutoSize = true;
            this.lbldocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldocumento.ForeColor = System.Drawing.Color.Black;
            this.lbldocumento.Location = new System.Drawing.Point(307, 36);
            this.lbldocumento.Name = "lbldocumento";
            this.lbldocumento.Size = new System.Drawing.Size(92, 16);
            this.lbldocumento.TabIndex = 23;
            this.lbldocumento.Text = "DOCUMENTO";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(15, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(257, 22);
            this.txtnombre.TabIndex = 22;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(16, 36);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(138, 16);
            this.lblnombre.TabIndex = 21;
            this.lblnombre.Text = "NOMBRE COMPLETO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(239, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "DATOS PERSONALES";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp;
            this.btnnuevo.Location = new System.Drawing.Point(406, 514);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(61, 46);
            this.btnnuevo.TabIndex = 66;
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp1;
            this.btnguardar.Location = new System.Drawing.Point(194, 514);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(61, 46);
            this.btnguardar.TabIndex = 65;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(142, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "TIPO A.F.P";
            // 
            // txtafp
            // 
            this.txtafp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtafp.Location = new System.Drawing.Point(115, 106);
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(157, 22);
            this.txtafp.TabIndex = 30;
            // 
            // frmcontrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 572);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelcontrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcontrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contrato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcontrato_FormClosing);
            this.Load += new System.EventHandler(this.frmcontrato_Load);
            this.panelcontrato.ResumeLayout(false);
            this.panelcontrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblasig;
        private System.Windows.Forms.Label lblremu;
        private System.Windows.Forms.TextBox txtremune;
        private System.Windows.Forms.TextBox txtasig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnum_cuenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtfin;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.Label lblfechaini;
        private System.Windows.Forms.ComboBox cmbtipcont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbanco;
        private System.Windows.Forms.ComboBox cmbmoneda;
        private System.Windows.Forms.Label lbltipomoneda;
        private System.Windows.Forms.Label lblcts;
        private System.Windows.Forms.TextBox txtcts;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtpen;
        public System.Windows.Forms.TextBox txtcargo;
        public System.Windows.Forms.TextBox txtdocumento;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtid_empleado;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtafp;
        public System.Windows.Forms.Label lbldocumento;
        public System.Windows.Forms.TextBox txtcussp;
    }
}