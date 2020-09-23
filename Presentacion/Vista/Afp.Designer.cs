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
            this.linkcomisiones = new System.Windows.Forms.LinkLabel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbomes = new System.Windows.Forms.ComboBox();
            this.lblperiodo = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.id_regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // linkcomisiones
            // 
            this.linkcomisiones.AutoSize = true;
            this.linkcomisiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkcomisiones.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkcomisiones.Location = new System.Drawing.Point(670, 82);
            this.linkcomisiones.Name = "linkcomisiones";
            this.linkcomisiones.Size = new System.Drawing.Size(197, 17);
            this.linkcomisiones.TabIndex = 92;
            this.linkcomisiones.TabStop = true;
            this.linkcomisiones.Text = "Página Web Comisiones - SBS";
            this.linkcomisiones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcomisiones_LinkClicked);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = global::Presentacion.Properties.Resources.baseline_save_white_24dp;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(502, 71);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(162, 33);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "&Guardar Cambios";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbomes
            // 
            this.cbomes.BackColor = System.Drawing.Color.White;
            this.cbomes.DropDownWidth = 130;
            this.cbomes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbomes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbomes.FormattingEnabled = true;
            this.cbomes.IntegralHeight = false;
            this.cbomes.ItemHeight = 17;
            this.cbomes.Location = new System.Drawing.Point(198, 79);
            this.cbomes.Name = "cbomes";
            this.cbomes.Size = new System.Drawing.Size(130, 25);
            this.cbomes.TabIndex = 3;
            // 
            // lblperiodo
            // 
            this.lblperiodo.AutoSize = true;
            this.lblperiodo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblperiodo.Location = new System.Drawing.Point(16, 106);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(55, 17);
            this.lblperiodo.TabIndex = 2;
            this.lblperiodo.Text = "periodo";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblmes.Location = new System.Drawing.Point(16, 80);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(103, 17);
            this.lblmes.TabIndex = 2;
            this.lblmes.Text = "Mes devengue: ";
            // 
            // dgvcomision
            // 
            this.dgvcomision.AllowUserToAddRows = false;
            this.dgvcomision.AllowUserToDeleteRows = false;
            this.dgvcomision.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvcomision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcomision.BackgroundColor = System.Drawing.Color.White;
            this.dgvcomision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcomision.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcomision.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvcomision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcomision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcomision.ColumnHeadersHeight = 70;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcomision.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcomision.EnableHeadersVisualStyles = false;
            this.dgvcomision.Location = new System.Drawing.Point(19, 159);
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.RowHeadersVisible = false;
            this.dgvcomision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvcomision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvcomision.Size = new System.Drawing.Size(879, 302);
            this.dgvcomision.TabIndex = 0;            
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Controls.Add(this.label16);
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(931, 50);
            this.paneltitulo.TabIndex = 92;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp2;
            this.btncerrar.Location = new System.Drawing.Point(891, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(24, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(476, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Comisiones y Primas de Seguro del SPP";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(853, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(355, 71);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(129, 33);
            this.btnbuscar.TabIndex = 93;
            this.btnbuscar.Text = "&Buscar Datos";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            // Frmafp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 488);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvcomision);
            this.Controls.Add(this.linkcomisiones);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbomes);
            this.Controls.Add(this.lblperiodo);
            this.Controls.Add(this.lblmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmafp";
            this.Text = "Afp";
            this.Load += new System.EventHandler(this.Frmafp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
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
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tope;
    }
}