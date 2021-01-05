namespace Presentacion.Vista
{
    partial class Frmafp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkcomisiones = new System.Windows.Forms.LinkLabel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbomes = new System.Windows.Forms.ComboBox();
            this.lblperiodo = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.id_regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvonp = new System.Windows.Forms.DataGridView();
            this.idregi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onpcomision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkonp = new System.Windows.Forms.CheckBox();
            this.txtidmes = new System.Windows.Forms.TextBox();
            this.chkcopy_pega = new System.Windows.Forms.CheckBox();
            this.Panelsbs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvonp)).BeginInit();
            this.Panelsbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkcomisiones
            // 
            this.linkcomisiones.AutoSize = true;
            this.linkcomisiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkcomisiones.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkcomisiones.Location = new System.Drawing.Point(673, 59);
            this.linkcomisiones.Name = "linkcomisiones";
            this.linkcomisiones.Size = new System.Drawing.Size(197, 17);
            this.linkcomisiones.TabIndex = 92;
            this.linkcomisiones.TabStop = true;
            this.linkcomisiones.Text = "Página Web Comisiones - SBS";
            this.linkcomisiones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcomisiones_LinkClicked);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Enabled = false;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(528, 51);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 27);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "&Actualizar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbomes
            // 
            this.cbomes.BackColor = System.Drawing.Color.White;
            this.cbomes.DropDownHeight = 210;
            this.cbomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomes.DropDownWidth = 130;
            this.cbomes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbomes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbomes.FormattingEnabled = true;
            this.cbomes.IntegralHeight = false;
            this.cbomes.ItemHeight = 17;
            this.cbomes.Location = new System.Drawing.Point(146, 51);
            this.cbomes.Name = "cbomes";
            this.cbomes.Size = new System.Drawing.Size(130, 25);
            this.cbomes.TabIndex = 3;
            this.cbomes.SelectedIndexChanged += new System.EventHandler(this.cbomes_SelectedIndexChanged);
            // 
            // lblperiodo
            // 
            this.lblperiodo.AutoSize = true;
            this.lblperiodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblperiodo.Location = new System.Drawing.Point(16, 80);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(59, 17);
            this.lblperiodo.TabIndex = 2;
            this.lblperiodo.Text = "periodo";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblmes.Location = new System.Drawing.Point(16, 54);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(110, 17);
            this.lblmes.TabIndex = 2;
            this.lblmes.Text = "Mes devengue: ";
            // 
            // dgvcomision
            // 
            this.dgvcomision.AllowUserToAddRows = false;
            this.dgvcomision.AllowUserToDeleteRows = false;
            this.dgvcomision.AllowUserToResizeColumns = false;
            this.dgvcomision.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvcomision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcomision.BackgroundColor = System.Drawing.Color.White;
            this.dgvcomision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcomision.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcomision.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvcomision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcomision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcomision.ColumnHeadersHeight = 70;
            this.dgvcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvcomision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_regimen,
            this.afp,
            this.id_comision,
            this.comision,
            this.saldo,
            this.seguro,
            this.aporte,
            this.tope});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcomision.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcomision.EnableHeadersVisualStyles = false;
            this.dgvcomision.Location = new System.Drawing.Point(19, 112);
            this.dgvcomision.MultiSelect = false;
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.RowHeadersVisible = false;
            this.dgvcomision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvcomision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvcomision.Size = new System.Drawing.Size(879, 302);
            this.dgvcomision.TabIndex = 0;
            this.dgvcomision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomision_CellClick);
            this.dgvcomision.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomision_CellValueChanged);
            this.dgvcomision.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvcomision_EditingControlShowing);
            // 
            // id_regimen
            // 
            this.id_regimen.DataPropertyName = "Codigo_regimen";
            this.id_regimen.HeaderText = "CODIGO REGIMEN";
            this.id_regimen.Name = "id_regimen";
            // 
            // afp
            // 
            this.afp.DataPropertyName = "descripcion";
            this.afp.HeaderText = "AFP";
            this.afp.Name = "afp";
            // 
            // id_comision
            // 
            this.id_comision.DataPropertyName = "Id_comision";
            this.id_comision.HeaderText = "ID COMISION";
            this.id_comision.Name = "id_comision";
            // 
            // comision
            // 
            this.comision.DataPropertyName = "Comision";
            this.comision.HeaderText = "COMISION MIXTA Y SOBRE FLUJO";
            this.comision.Name = "comision";
            this.comision.Width = 143;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "Saldo";
            this.saldo.HeaderText = "COMISION ANUAL SOBRE SALDO";
            this.saldo.Name = "saldo";
            this.saldo.Width = 143;
            // 
            // seguro
            // 
            this.seguro.DataPropertyName = "Seguro";
            this.seguro.HeaderText = "PRIMA DE SEGUROS";
            this.seguro.Name = "seguro";
            this.seguro.Width = 144;
            // 
            // aporte
            // 
            this.aporte.DataPropertyName = "Aporte";
            this.aporte.HeaderText = "APORTE OBLIGATORIO AL FONDO DE PENSIONES";
            this.aporte.Name = "aporte";
            this.aporte.Width = 143;
            // 
            // tope
            // 
            this.tope.DataPropertyName = "Tope";
            this.tope.HeaderText = "REMUNERACION MAXIMA ASEGURABLE";
            this.tope.Name = "tope";
            this.tope.Width = 143;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Controls.Add(this.label16);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(905, 35);
            this.paneltitulo.TabIndex = 92;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.mi_18dp;
            this.btnminimizar.Location = new System.Drawing.Point(835, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 35);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnminimizar.TabIndex = 16;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseDown);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            this.btnminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseMove);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.btncerrar.Location = new System.Drawing.Point(870, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 17;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(344, 35);
            this.label16.TabIndex = 0;
            this.label16.Text = "Comisiones y Primas de Seguro del SPP";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_24dp;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(414, 51);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(99, 27);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvonp
            // 
            this.dgvonp.AllowUserToAddRows = false;
            this.dgvonp.AllowUserToResizeColumns = false;
            this.dgvonp.AllowUserToResizeRows = false;
            this.dgvonp.BackgroundColor = System.Drawing.Color.White;
            this.dgvonp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvonp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvonp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvonp.ColumnHeadersHeight = 27;
            this.dgvonp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvonp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idregi,
            this.idcomi,
            this.donp,
            this.onpcomision});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvonp.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvonp.EnableHeadersVisualStyles = false;
            this.dgvonp.Location = new System.Drawing.Point(31, 445);
            this.dgvonp.Name = "dgvonp";
            this.dgvonp.RowHeadersVisible = false;
            this.dgvonp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvonp.Size = new System.Drawing.Size(498, 53);
            this.dgvonp.TabIndex = 94;
            // 
            // idregi
            // 
            this.idregi.DataPropertyName = "Codigo_regimen";
            this.idregi.HeaderText = "ID REGI";
            this.idregi.Name = "idregi";
            this.idregi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idregi.Width = 50;
            // 
            // idcomi
            // 
            this.idcomi.DataPropertyName = "Id_comision";
            this.idcomi.HeaderText = "ID COMI";
            this.idcomi.Name = "idcomi";
            this.idcomi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idcomi.Width = 50;
            // 
            // donp
            // 
            this.donp.DataPropertyName = "descripcion";
            this.donp.HeaderText = "ONP - DECRETO LEY 19990";
            this.donp.Name = "donp";
            this.donp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.donp.Width = 200;
            // 
            // onpcomision
            // 
            this.onpcomision.DataPropertyName = "Comision";
            this.onpcomision.HeaderText = "VALOR";
            this.onpcomision.Name = "onpcomision";
            this.onpcomision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.onpcomision.Width = 130;
            // 
            // chkonp
            // 
            this.chkonp.AutoSize = true;
            this.chkonp.Checked = true;
            this.chkonp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkonp.Location = new System.Drawing.Point(19, 423);
            this.chkonp.Name = "chkonp";
            this.chkonp.Size = new System.Drawing.Size(104, 17);
            this.chkonp.TabIndex = 95;
            this.chkonp.Text = "Actualizar O.N.P";
            this.chkonp.UseVisualStyleBackColor = true;
            this.chkonp.CheckedChanged += new System.EventHandler(this.chkonp_CheckedChanged);
            // 
            // txtidmes
            // 
            this.txtidmes.Location = new System.Drawing.Point(535, 445);
            this.txtidmes.Name = "txtidmes";
            this.txtidmes.Size = new System.Drawing.Size(75, 20);
            this.txtidmes.TabIndex = 97;
            this.txtidmes.Visible = false;
            // 
            // chkcopy_pega
            // 
            this.chkcopy_pega.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkcopy_pega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chkcopy_pega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkcopy_pega.FlatAppearance.BorderSize = 0;
            this.chkcopy_pega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkcopy_pega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcopy_pega.ForeColor = System.Drawing.Color.White;
            this.chkcopy_pega.Location = new System.Drawing.Point(299, 51);
            this.chkcopy_pega.Name = "chkcopy_pega";
            this.chkcopy_pega.Size = new System.Drawing.Size(99, 27);
            this.chkcopy_pega.TabIndex = 98;
            this.chkcopy_pega.Text = "COPIAR";
            this.chkcopy_pega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkcopy_pega.UseVisualStyleBackColor = false;
            this.chkcopy_pega.CheckedChanged += new System.EventHandler(this.chkcopy_pega_CheckedChanged);
            // 
            // Panelsbs
            // 
            this.Panelsbs.BackColor = System.Drawing.Color.White;
            this.Panelsbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panelsbs.Controls.Add(this.paneltitulo);
            this.Panelsbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelsbs.Location = new System.Drawing.Point(0, 0);
            this.Panelsbs.Name = "Panelsbs";
            this.Panelsbs.Size = new System.Drawing.Size(907, 515);
            this.Panelsbs.TabIndex = 99;
            // 
            // Frmafp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 515);
            this.Controls.Add(this.chkcopy_pega);
            this.Controls.Add(this.txtidmes);
            this.Controls.Add(this.chkonp);
            this.Controls.Add(this.dgvonp);
            this.Controls.Add(this.dgvcomision);
            this.Controls.Add(this.linkcomisiones);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbomes);
            this.Controls.Add(this.lblperiodo);
            this.Controls.Add(this.lblmes);
            this.Controls.Add(this.Panelsbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmafp";
            this.Text = "Afp";
            this.Load += new System.EventHandler(this.Frmafp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvonp)).EndInit();
            this.Panelsbs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvcomision;
        private System.Windows.Forms.ComboBox cbomes;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.LinkLabel linkcomisiones;
        private System.Windows.Forms.Label lblperiodo;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tope;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvonp;
        private System.Windows.Forms.CheckBox chkonp;
        private System.Windows.Forms.TextBox txtidmes;
        private System.Windows.Forms.CheckBox chkcopy_pega;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donp;
        private System.Windows.Forms.DataGridViewTextBoxColumn onpcomision;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel Panelsbs;
    }
}