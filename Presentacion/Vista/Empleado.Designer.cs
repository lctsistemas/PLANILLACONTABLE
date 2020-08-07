using Negocio.ValueObjects;
using Presentacion.Helps;
using System;
using System.Windows.Forms;

namespace Presentacion.Vista
{
    partial class Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.CONTRATO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.lblem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxpen = new System.Windows.Forms.ComboBox();
            this.lblempresa = new System.Windows.Forms.Label();
            this.lblafp = new System.Windows.Forms.Label();
            this.cmbcar = new System.Windows.Forms.ComboBox();
            this.cmbafp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtipdoc = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxgene = new System.Windows.Forms.ComboBox();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.listaEmpleados = new System.Windows.Forms.TabPage();
            this.rddni = new System.Windows.Forms.RadioButton();
            this.rdnombre = new System.Windows.Forms.RadioButton();
            this.chkcontrato = new System.Windows.Forms.CheckBox();
            this.lblcantidad_registro = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabEmpleado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.listaEmpleados.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleado
            // 
            this.dgvempleado.AllowUserToAddRows = false;
            this.dgvempleado.AllowUserToDeleteRows = false;
            this.dgvempleado.AllowUserToOrderColumns = true;
            this.dgvempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvempleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvempleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONTRATO});
            this.dgvempleado.EnableHeadersVisualStyles = false;
            this.dgvempleado.Location = new System.Drawing.Point(3, 77);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.ReadOnly = true;
            this.dgvempleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvempleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvempleado.RowHeadersWidth = 30;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvempleado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvempleado.Size = new System.Drawing.Size(731, 293);
            this.dgvempleado.TabIndex = 18;
            this.dgvempleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellClick);
            this.dgvempleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellDoubleClick);
            // 
            // CONTRATO
            // 
            this.CONTRATO.HeaderText = "CONTRATO";
            this.CONTRATO.Name = "CONTRATO";
            this.CONTRATO.ReadOnly = true;
            this.CONTRATO.Text = "Registrar";
            this.CONTRATO.UseColumnTextForButtonValue = true;
            this.CONTRATO.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnguardar);
            this.tabPage2.Location = new System.Drawing.Point(33, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 419);
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
            this.groupBox2.Controls.Add(this.cmbtipdoc);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxgene);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 344);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbestado);
            this.groupBox3.Controls.Add(this.lblem);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxpen);
            this.groupBox3.Controls.Add(this.lblempresa);
            this.groupBox3.Controls.Add(this.lblafp);
            this.groupBox3.Controls.Add(this.cmbcar);
            this.groupBox3.Controls.Add(this.cmbafp);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(395, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 344);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(24, 160);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(112, 24);
            this.cmbestado.TabIndex = 76;
            // 
            // lblem
            // 
            this.lblem.AutoSize = true;
            this.lblem.Location = new System.Drawing.Point(27, 236);
            this.lblem.Name = "lblem";
            this.lblem.Size = new System.Drawing.Size(52, 16);
            this.lblem.TabIndex = 75;
            this.lblem.Text = "label13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tipo pension";
            // 
            // cbxpen
            // 
            this.cbxpen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxpen.FormattingEnabled = true;
            this.cbxpen.Location = new System.Drawing.Point(25, 41);
            this.cbxpen.Name = "cbxpen";
            this.cbxpen.Size = new System.Drawing.Size(118, 24);
            this.cbxpen.TabIndex = 60;
            this.cbxpen.SelectedIndexChanged += new System.EventHandler(this.cbxpen_SelectedIndexChanged);
            this.cbxpen.Validating += new System.ComponentModel.CancelEventHandler(this.cbxpen_Validating);
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblempresa.Location = new System.Drawing.Point(22, 203);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(55, 13);
            this.lblempresa.TabIndex = 73;
            this.lblempresa.Text = "Empresa";
            // 
            // lblafp
            // 
            this.lblafp.AutoSize = true;
            this.lblafp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafp.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblafp.Location = new System.Drawing.Point(165, 25);
            this.lblafp.Name = "lblafp";
            this.lblafp.Size = new System.Drawing.Size(30, 13);
            this.lblafp.TabIndex = 67;
            this.lblafp.Text = "AFP";
            // 
            // cmbcar
            // 
            this.cmbcar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcar.FormattingEnabled = true;
            this.cmbcar.Location = new System.Drawing.Point(18, 103);
            this.cmbcar.Name = "cmbcar";
            this.cmbcar.Size = new System.Drawing.Size(118, 24);
            this.cmbcar.TabIndex = 62;
            this.cmbcar.Validating += new System.ComponentModel.CancelEventHandler(this.cmbcar_Validating);
            // 
            // cmbafp
            // 
            this.cmbafp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbafp.FormattingEnabled = true;
            this.cmbafp.Items.AddRange(new object[] {
            "Profuturo",
            "Habitat"});
            this.cmbafp.Location = new System.Drawing.Point(166, 41);
            this.cmbafp.Name = "cmbafp";
            this.cmbafp.Size = new System.Drawing.Size(112, 24);
            this.cmbafp.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(21, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Cargo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(22, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Estado";
            // 
            // dtfecha
            // 
            this.dtfecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(156, 219);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(121, 22);
            this.dtfecha.TabIndex = 57;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(11, 45);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(105, 22);
            this.txtcodigo.TabIndex = 66;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(9, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre ";
            // 
            // cmbtipdoc
            // 
            this.cmbtipdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipdoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipdoc.FormattingEnabled = true;
            this.cmbtipdoc.Location = new System.Drawing.Point(158, 45);
            this.cmbtipdoc.Name = "cmbtipdoc";
            this.cmbtipdoc.Size = new System.Drawing.Size(121, 24);
            this.cmbtipdoc.TabIndex = 52;
            this.cmbtipdoc.SelectedIndexChanged += new System.EventHandler(this.cmbtipdoc_SelectedIndexChanged);
            this.cmbtipdoc.Validating += new System.ComponentModel.CancelEventHandler(this.cmbtipdoc_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(11, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 22);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(9, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellido paterno";
            // 
            // cbxgene
            // 
            this.cbxgene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgene.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgene.FormattingEnabled = true;
            this.cbxgene.Location = new System.Drawing.Point(12, 282);
            this.cbxgene.Name = "cbxgene";
            this.cbxgene.Size = new System.Drawing.Size(104, 24);
            this.cbxgene.TabIndex = 49;
            this.cbxgene.Validating += new System.ComponentModel.CancelEventHandler(this.cbxgene_Validating);
            // 
            // txtApePat
            // 
            this.txtApePat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.Location = new System.Drawing.Point(12, 162);
            this.txtApePat.Multiline = true;
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(104, 20);
            this.txtApePat.TabIndex = 43;
            this.txtApePat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePat_KeyPress);
            this.txtApePat.Validating += new System.ComponentModel.CancelEventHandler(this.txtApePat_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(9, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(296, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 58;
            this.label10.Text = "N° documento";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMat.Location = new System.Drawing.Point(12, 219);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(105, 22);
            this.txtApeMat.TabIndex = 45;
            this.txtApeMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeMat_KeyPress);
            this.txtApeMat.Validating += new System.ComponentModel.CancelEventHandler(this.txtApeMat_Validating);
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumdoc.Location = new System.Drawing.Point(284, 45);
            this.txtnumdoc.MaxLength = 8;
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(105, 22);
            this.txtnumdoc.TabIndex = 53;
            this.txtnumdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumdoc_KeyPress);
            this.txtnumdoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtnumdoc_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(155, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 69;
            this.label14.Text = "Tipo de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(153, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(155, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nacionalidad";
            // 
            // txtnac
            // 
            this.txtnac.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnac.Location = new System.Drawing.Point(156, 283);
            this.txtnac.Name = "txtnac";
            this.txtnac.Size = new System.Drawing.Size(121, 22);
            this.txtnac.TabIndex = 59;
            this.txtnac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnac_KeyPress);
            this.txtnac.Validating += new System.ComponentModel.CancelEventHandler(this.txtnac_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(153, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Direccion";
            // 
            // txtdire
            // 
            this.txtdire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdire.Location = new System.Drawing.Point(156, 103);
            this.txtdire.Multiline = true;
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(233, 20);
            this.txtdire.TabIndex = 54;
            this.txtdire.Validating += new System.ComponentModel.CancelEventHandler(this.txtdire_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(159, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Telefono";
            // 
            // txttele
            // 
            this.txttele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttele.Location = new System.Drawing.Point(156, 161);
            this.txttele.MaxLength = 9;
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(121, 22);
            this.txttele.TabIndex = 56;
            this.txttele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttele_KeyPress);
            this.txttele.Validating += new System.ComponentModel.CancelEventHandler(this.txttele_Validating);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp;
            this.btnNuevo.Location = new System.Drawing.Point(408, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(61, 46);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnguardar.Location = new System.Drawing.Point(247, 362);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(61, 46);
            this.btnguardar.TabIndex = 62;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // listaEmpleados
            // 
            this.listaEmpleados.Controls.Add(this.rddni);
            this.listaEmpleados.Controls.Add(this.rdnombre);
            this.listaEmpleados.Controls.Add(this.chkcontrato);
            this.listaEmpleados.Controls.Add(this.lblcantidad_registro);
            this.listaEmpleados.Controls.Add(this.label17);
            this.listaEmpleados.Controls.Add(this.txtBuscar);
            this.listaEmpleados.Controls.Add(this.btneliminar);
            this.listaEmpleados.Controls.Add(this.dgvempleado);
            this.listaEmpleados.Controls.Add(this.label19);
            this.listaEmpleados.Location = new System.Drawing.Point(33, 4);
            this.listaEmpleados.Name = "listaEmpleados";
            this.listaEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.listaEmpleados.Size = new System.Drawing.Size(735, 419);
            this.listaEmpleados.TabIndex = 0;
            this.listaEmpleados.Text = "Lista Empleados";
            this.listaEmpleados.UseVisualStyleBackColor = true;
            // 
            // rddni
            // 
            this.rddni.AutoSize = true;
            this.rddni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddni.Location = new System.Drawing.Point(562, 43);
            this.rddni.Name = "rddni";
            this.rddni.Size = new System.Drawing.Size(47, 21);
            this.rddni.TabIndex = 86;
            this.rddni.TabStop = true;
            this.rddni.Text = "DNI";
            this.rddni.UseVisualStyleBackColor = true;
            // 
            // rdnombre
            // 
            this.rdnombre.AutoSize = true;
            this.rdnombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnombre.Location = new System.Drawing.Point(461, 43);
            this.rdnombre.Name = "rdnombre";
            this.rdnombre.Size = new System.Drawing.Size(76, 21);
            this.rdnombre.TabIndex = 86;
            this.rdnombre.TabStop = true;
            this.rdnombre.Text = "NOMBRE";
            this.rdnombre.UseVisualStyleBackColor = true;
            // 
            // chkcontrato
            // 
            this.chkcontrato.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkcontrato.AutoSize = true;
            this.chkcontrato.FlatAppearance.BorderSize = 0;
            this.chkcontrato.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcontrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkcontrato.Location = new System.Drawing.Point(15, 382);
            this.chkcontrato.Name = "chkcontrato";
            this.chkcontrato.Size = new System.Drawing.Size(68, 26);
            this.chkcontrato.TabIndex = 83;
            this.chkcontrato.Text = "Contrato";
            this.chkcontrato.UseVisualStyleBackColor = true;
            this.chkcontrato.CheckedChanged += new System.EventHandler(this.chkcontrato_CheckedChanged);
            // 
            // lblcantidad_registro
            // 
            this.lblcantidad_registro.AutoSize = true;
            this.lblcantidad_registro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad_registro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcantidad_registro.Location = new System.Drawing.Point(559, 387);
            this.lblcantidad_registro.Name = "lblcantidad_registro";
            this.lblcantidad_registro.Size = new System.Drawing.Size(33, 16);
            this.lblcantidad_registro.TabIndex = 82;
            this.lblcantidad_registro.Text = "total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(16, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 16);
            this.label17.TabIndex = 81;
            this.label17.Text = "BUSCAR";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(20, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(355, 16);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp;
            this.btneliminar.Location = new System.Drawing.Point(674, 20);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(61, 48);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(373, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "_____________________________________________________________\r\n";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(288, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "COLABORADORES";
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabEmpleado.Controls.Add(this.listaEmpleados);
            this.tabEmpleado.Controls.Add(this.tabPage2);
            this.tabEmpleado.Controls.Add(this.tabPage1);
            this.tabEmpleado.ItemSize = new System.Drawing.Size(89, 29);
            this.tabEmpleado.Location = new System.Drawing.Point(1, 48);
            this.tabEmpleado.Multiline = true;
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(772, 427);
            this.tabEmpleado.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(33, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 419);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registrar Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.paneltitulo.Size = new System.Drawing.Size(773, 50);
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
            this.btncerrar.Location = new System.Drawing.Point(734, 3);
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
            this.btnminimizar.Location = new System.Drawing.Point(662, 3);
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
            this.btnmaximizar.Location = new System.Drawing.Point(698, 3);
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
            this.btnrestaurar.Location = new System.Drawing.Point(698, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 11;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 475);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.tabEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Empleado";
            this.Text = "EMPLEADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Empleado_FormClosing);
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.listaEmpleados.ResumeLayout(false);
            this.listaEmpleados.PerformLayout();
            this.tabEmpleado.ResumeLayout(false);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        

        

        #endregion
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxgene;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage listaEmpleados;
        private System.Windows.Forms.TabControl tabEmpleado;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbtipdoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private Label label17;
        private TextBox txtBuscar;
        private Label label16;
        private TabPage tabPage1;
        private Label lblcantidad_registro;
        private CheckBox chkcontrato;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox btnmaximizar;
        private Label label19;
        private Panel paneltitulo;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox cbxpen;
        private Label lblempresa;
        private Label lblafp;
        private ComboBox cmbcar;
        private ComboBox cmbafp;
        private Label label15;
        private Label label12;
        private PictureBox btnrestaurar;
        private PictureBox pictureBox1;
        private RadioButton rddni;
        private RadioButton rdnombre;
        private DataGridViewButtonColumn CONTRATO;
        private Label lblem;
        private ComboBox cmbestado;
    }
}