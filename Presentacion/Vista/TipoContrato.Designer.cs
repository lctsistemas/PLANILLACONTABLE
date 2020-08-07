namespace Presentacion.Vista
{
    partial class TipoContrato
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
            this.tabtipo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvtipocontrato = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabtipo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipocontrato)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabtipo
            // 
            this.tabtipo.Controls.Add(this.tabPage1);
            this.tabtipo.Controls.Add(this.tabPage2);
            this.tabtipo.Location = new System.Drawing.Point(-4, 54);
            this.tabtipo.Name = "tabtipo";
            this.tabtipo.SelectedIndex = 0;
            this.tabtipo.Size = new System.Drawing.Size(400, 257);
            this.tabtipo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Controls.Add(this.txttipo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion tipo contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnNuevo.Location = new System.Drawing.Point(232, 120);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(61, 46);
            this.btnNuevo.TabIndex = 68;
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
            this.btnguardar.Location = new System.Drawing.Point(71, 120);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(61, 46);
            this.btnguardar.TabIndex = 67;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(207, 51);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 1;
            this.txttipo.Validating += new System.ComponentModel.CancelEventHandler(this.txttipo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIPO DE CONTRATO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvtipocontrato);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista Tipo contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvtipocontrato
            // 
            this.dgvtipocontrato.AllowUserToAddRows = false;
            this.dgvtipocontrato.AllowUserToDeleteRows = false;
            this.dgvtipocontrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipocontrato.Location = new System.Drawing.Point(6, 35);
            this.dgvtipocontrato.Name = "dgvtipocontrato";
            this.dgvtipocontrato.ReadOnly = true;
            this.dgvtipocontrato.Size = new System.Drawing.Size(381, 196);
            this.dgvtipocontrato.TabIndex = 0;
            this.dgvtipocontrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtipocontrato_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.btnmaximizar);
            this.panel1.Controls.Add(this.btnrestaurar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 50);
            this.panel1.TabIndex = 1;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp2;
            this.btncerrar.Location = new System.Drawing.Point(355, 14);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 14;
            this.btncerrar.TabStop = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(283, 14);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 15;
            this.btnminimizar.TabStop = false;
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Enabled = false;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp1;
            this.btnmaximizar.Location = new System.Drawing.Point(319, 14);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 16;
            this.btnmaximizar.TabStop = false;
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Enabled = false;
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(320, 14);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 17;
            this.btnrestaurar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_lct_2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE CONTRATO";
            // 
            // TipoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabtipo);
            this.Name = "TipoContrato";
            this.Text = "TipoContrato";
            this.Load += new System.EventHandler(this.TipoContrato_Load);
            this.tabtipo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipocontrato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabtipo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtipocontrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnguardar;
    }
}