﻿namespace Login_inicio
{
    partial class frminicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.dgvlogin = new System.Windows.Forms.DataGridView();
            this.numeric_periodo = new System.Windows.Forms.NumericUpDown();
            this.Cbouser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelinicio = new System.Windows.Forms.Panel();
            this.lblminimizar = new System.Windows.Forms.PictureBox();
            this.lblcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Gray;
            this.txtuser.Location = new System.Drawing.Point(70, 113);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(424, 26);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.WordWrap = false;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Gray;
            this.txtpass.Location = new System.Drawing.Point(70, 277);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(442, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(142, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "INICIO DE SESION";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(29, 326);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(482, 40);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "&ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Transparent;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Crimson;
            this.lblerror.Location = new System.Drawing.Point(38, 373);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(36, 16);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "error";
            this.lblerror.Visible = false;
            // 
            // dgvlogin
            // 
            this.dgvlogin.AllowUserToAddRows = false;
            this.dgvlogin.AllowUserToDeleteRows = false;
            this.dgvlogin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvlogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvlogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlogin.ColumnHeadersHeight = 30;
            this.dgvlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlogin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlogin.EnableHeadersVisualStyles = false;
            this.dgvlogin.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvlogin.Location = new System.Drawing.Point(29, 409);
            this.dgvlogin.Name = "dgvlogin";
            this.dgvlogin.ReadOnly = true;
            this.dgvlogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvlogin.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvlogin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlogin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvlogin.Size = new System.Drawing.Size(482, 167);
            this.dgvlogin.TabIndex = 15;
            this.dgvlogin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlogin_CellClick);
            this.dgvlogin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlogin_CellDoubleClick);
            // 
            // numeric_periodo
            // 
            this.numeric_periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numeric_periodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric_periodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_periodo.ForeColor = System.Drawing.Color.White;
            this.numeric_periodo.Location = new System.Drawing.Point(220, 381);
            this.numeric_periodo.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numeric_periodo.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numeric_periodo.Name = "numeric_periodo";
            this.numeric_periodo.ReadOnly = true;
            this.numeric_periodo.Size = new System.Drawing.Size(101, 22);
            this.numeric_periodo.TabIndex = 16;
            this.numeric_periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_periodo.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numeric_periodo.ValueChanged += new System.EventHandler(this.numeric_periodo_ValueChanged);
            // 
            // Cbouser
            // 
            this.Cbouser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Cbouser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbouser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbouser.ForeColor = System.Drawing.Color.White;
            this.Cbouser.FormattingEnabled = true;
            this.Cbouser.ItemHeight = 18;
            this.Cbouser.Location = new System.Drawing.Point(30, 113);
            this.Cbouser.Name = "Cbouser";
            this.Cbouser.Size = new System.Drawing.Size(482, 26);
            this.Cbouser.TabIndex = 18;
            this.Cbouser.SelectedIndexChanged += new System.EventHandler(this.Cbouser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(27, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "________________________________________________________________________________";
            // 
            // txtroles
            // 
            this.txtroles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtroles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtroles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroles.ForeColor = System.Drawing.Color.Gray;
            this.txtroles.Location = new System.Drawing.Point(70, 195);
            this.txtroles.Multiline = true;
            this.txtroles.Name = "txtroles";
            this.txtroles.ReadOnly = true;
            this.txtroles.Size = new System.Drawing.Size(444, 26);
            this.txtroles.TabIndex = 2;
            this.txtroles.Text = "ROL";
            this.txtroles.Enter += new System.EventHandler(this.txtroles_Enter);
            this.txtroles.Leave += new System.EventHandler(this.txtroles_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(27, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "________________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(27, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________________________________________________________________";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.candado;
            this.pictureBox4.Location = new System.Drawing.Point(30, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.empleados1;
            this.pictureBox3.Location = new System.Drawing.Point(30, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.clientes;
            this.pictureBox2.Location = new System.Drawing.Point(30, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logolct2_png;
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelinicio
            // 
            this.panelinicio.Controls.Add(this.lblminimizar);
            this.panelinicio.Controls.Add(this.lblcerrar);
            this.panelinicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelinicio.Location = new System.Drawing.Point(0, 0);
            this.panelinicio.Name = "panelinicio";
            this.panelinicio.Size = new System.Drawing.Size(540, 35);
            this.panelinicio.TabIndex = 24;
            this.panelinicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelinicio_MouseDown);
            // 
            // lblminimizar
            // 
            this.lblminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblminimizar.Image = global::Presentacion.Properties.Resources.mi_18dp;
            this.lblminimizar.Location = new System.Drawing.Point(470, 0);
            this.lblminimizar.Name = "lblminimizar";
            this.lblminimizar.Size = new System.Drawing.Size(35, 35);
            this.lblminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblminimizar.TabIndex = 13;
            this.lblminimizar.TabStop = false;
            this.lblminimizar.Click += new System.EventHandler(this.lblminimizar_Click);
            this.lblminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblminimizar_MouseDown);
            this.lblminimizar.MouseLeave += new System.EventHandler(this.lblminimizar_MouseLeave);
            this.lblminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblminimizar_MouseMove);
            // 
            // lblcerrar
            // 
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblcerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.lblcerrar.Location = new System.Drawing.Point(505, 0);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(35, 35);
            this.lblcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcerrar.TabIndex = 12;
            this.lblcerrar.TabStop = false;
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            this.lblcerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseDown);
            this.lblcerrar.MouseLeave += new System.EventHandler(this.lblcerrar_MouseLeave);
            this.lblcerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseMove);
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(540, 588);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtroles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numeric_periodo);
            this.Controls.Add(this.dgvlogin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.Cbouser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelinicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frminicio";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frminicio_FormClosing);
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frminicio_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_periodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelinicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.DataGridView dgvlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numeric_periodo;
        private System.Windows.Forms.ComboBox Cbouser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtroles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelinicio;
        private System.Windows.Forms.PictureBox lblcerrar;
        private System.Windows.Forms.PictureBox lblminimizar;
    }
}

