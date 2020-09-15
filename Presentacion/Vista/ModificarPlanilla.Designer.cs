namespace Presentacion.Vista
{
    partial class frmModificarPlanilla
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
            this.label16 = new System.Windows.Forms.Label();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpago = new System.Windows.Forms.Label();
            this.cbxmes = new System.Windows.Forms.ComboBox();
            this.txtpago = new System.Windows.Forms.MaskedTextBox();
            this.lblper = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(68, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "MODIFICAR";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label16_MouseDown);
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
            this.paneltitulo.Size = new System.Drawing.Size(341, 50);
            this.paneltitulo.TabIndex = 91;
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
            this.btncerrar.Location = new System.Drawing.Point(303, 3);
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
            this.btnminimizar.Location = new System.Drawing.Point(221, 3);
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
            this.btnmaximizar.Location = new System.Drawing.Point(262, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 10;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Enabled = false;
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(262, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 11;
            this.btnrestaurar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Año :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mes : ";
            // 
            // lblpago
            // 
            this.lblpago.AutoSize = true;
            this.lblpago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpago.Location = new System.Drawing.Point(50, 165);
            this.lblpago.Name = "lblpago";
            this.lblpago.Size = new System.Drawing.Size(94, 16);
            this.lblpago.TabIndex = 94;
            this.lblpago.Text = "Fecha pago :";
            // 
            // cbxmes
            // 
            this.cbxmes.Enabled = false;
            this.cbxmes.FormattingEnabled = true;
            this.cbxmes.Location = new System.Drawing.Point(168, 120);
            this.cbxmes.Name = "cbxmes";
            this.cbxmes.Size = new System.Drawing.Size(97, 21);
            this.cbxmes.TabIndex = 95;
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(168, 164);
            this.txtpago.Mask = "00/00/0000";
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(97, 20);
            this.txtpago.TabIndex = 97;
            this.txtpago.ValidatingType = typeof(System.DateTime);
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Location = new System.Drawing.Point(165, 81);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(35, 13);
            this.lblper.TabIndex = 98;
            this.lblper.Text = "label3";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_24dp;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(53, 214);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(98, 34);
            this.btnguardar.TabIndex = 99;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.Image = global::Presentacion.Properties.Resources.baseline_cancel_white_24dp;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(192, 214);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(107, 34);
            this.btncancelar.TabIndex = 100;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmModificarPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 273);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblper);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.cbxmes);
            this.Controls.Add(this.lblpago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarPlanilla";
            this.Text = "ModificarPlanilla";
            this.Load += new System.EventHandler(this.frmModificarPlanilla_Load);
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

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblpago;
        public System.Windows.Forms.MaskedTextBox txtpago;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.ComboBox cbxmes;
        public System.Windows.Forms.Label lblper;
    }
}