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
            this.linkcomisiones = new System.Windows.Forms.LinkLabel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbomes = new System.Windows.Forms.ComboBox();
            this.lblperiodo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.txtcodigo_regimen = new System.Windows.Forms.TextBox();
            this.txtidperiodo = new System.Windows.Forms.TextBox();
            this.txtidmes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // linkcomisiones
            // 
            this.linkcomisiones.AutoSize = true;
            this.linkcomisiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkcomisiones.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkcomisiones.Location = new System.Drawing.Point(557, 75);
            this.linkcomisiones.Name = "linkcomisiones";
            this.linkcomisiones.Size = new System.Drawing.Size(113, 17);
            this.linkcomisiones.TabIndex = 92;
            this.linkcomisiones.TabStop = true;
            this.linkcomisiones.Text = "Comisiones - SBS";
            this.linkcomisiones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcomisiones_LinkClicked);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(391, 72);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(148, 23);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "&Guardar Cambios";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbomes
            // 
            this.cbomes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomes.FormattingEnabled = true;
            this.cbomes.Location = new System.Drawing.Point(133, 75);
            this.cbomes.Name = "cbomes";
            this.cbomes.Size = new System.Drawing.Size(130, 25);
            this.cbomes.TabIndex = 3;
            // 
            // lblperiodo
            // 
            this.lblperiodo.AutoSize = true;
            this.lblperiodo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiodo.Location = new System.Drawing.Point(282, 78);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(55, 17);
            this.lblperiodo.TabIndex = 2;
            this.lblperiodo.Text = "periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes devengue: ";
            // 
            // dgvcomision
            // 
            this.dgvcomision.AllowUserToAddRows = false;
            this.dgvcomision.AllowUserToDeleteRows = false;
            this.dgvcomision.AllowUserToOrderColumns = true;
            this.dgvcomision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comision,
            this.saldo,
            this.seguro,
            this.aporte,
            this.tope});
            this.dgvcomision.Location = new System.Drawing.Point(12, 116);
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvcomision.Size = new System.Drawing.Size(716, 213);
            this.dgvcomision.TabIndex = 0;
            this.dgvcomision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvcomision_KeyDown);
            // 
            // comision
            // 
            this.comision.HeaderText = "COMISION";
            this.comision.Name = "comision";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "SALDO";
            this.saldo.Name = "saldo";
            // 
            // seguro
            // 
            this.seguro.HeaderText = "SEGURO";
            this.seguro.Name = "seguro";
            // 
            // aporte
            // 
            this.aporte.HeaderText = "APORTE";
            this.aporte.Name = "aporte";
            // 
            // tope
            // 
            this.tope.HeaderText = "TOPE";
            this.tope.Name = "tope";
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
            this.paneltitulo.Size = new System.Drawing.Size(755, 50);
            this.paneltitulo.TabIndex = 92;
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
            this.btncerrar.Location = new System.Drawing.Point(715, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(90, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "COMISIONES AFP\'S";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(644, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Enabled = false;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp1;
            this.btnmaximizar.Location = new System.Drawing.Point(680, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 10;
            this.btnmaximizar.TabStop = false;
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(680, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 11;
            this.btnrestaurar.TabStop = false;
            // 
            // txtcodigo_regimen
            // 
            this.txtcodigo_regimen.Location = new System.Drawing.Point(115, 349);
            this.txtcodigo_regimen.Name = "txtcodigo_regimen";
            this.txtcodigo_regimen.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo_regimen.TabIndex = 93;
            // 
            // txtidperiodo
            // 
            this.txtidperiodo.Location = new System.Drawing.Point(254, 349);
            this.txtidperiodo.Name = "txtidperiodo";
            this.txtidperiodo.Size = new System.Drawing.Size(100, 20);
            this.txtidperiodo.TabIndex = 93;
            // 
            // txtidmes
            // 
            this.txtidmes.Location = new System.Drawing.Point(391, 349);
            this.txtidmes.Name = "txtidmes";
            this.txtidmes.Size = new System.Drawing.Size(100, 20);
            this.txtidmes.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "codigo regimen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "id periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "id mes";
            // 
            // Frmafp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidmes);
            this.Controls.Add(this.txtidperiodo);
            this.Controls.Add(this.txtcodigo_regimen);
            this.Controls.Add(this.dgvcomision);
            this.Controls.Add(this.linkcomisiones);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbomes);
            this.Controls.Add(this.lblperiodo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmafp";
            this.Text = "Afp";
            this.Load += new System.EventHandler(this.Frmafp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvcomision;
        private System.Windows.Forms.ComboBox cbomes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.LinkLabel linkcomisiones;
        private System.Windows.Forms.Label lblperiodo;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tope;
        private System.Windows.Forms.TextBox txtcodigo_regimen;
        private System.Windows.Forms.TextBox txtidperiodo;
        private System.Windows.Forms.TextBox txtidmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}