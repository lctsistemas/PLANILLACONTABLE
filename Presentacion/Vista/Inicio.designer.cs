namespace Login_inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.lblminimizar = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.dgvlogin = new System.Windows.Forms.DataGridView();
            this.numeric_periodo = new System.Windows.Forms.NumericUpDown();
            this.Cbouser = new System.Windows.Forms.ComboBox();
            this.cboroles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_periodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Gray;
            this.txtuser.Location = new System.Drawing.Point(67, 113);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(424, 25);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.WordWrap = false;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Gray;
            this.txtpass.Location = new System.Drawing.Point(67, 276);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(442, 25);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(109, 9);
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
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(67, 536);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(400, 40);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "&ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblcerrar
            // 
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblcerrar.Location = new System.Drawing.Point(503, 9);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(28, 26);
            this.lblcerrar.TabIndex = 7;
            this.lblcerrar.Text = "X";
            this.lblcerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            this.lblcerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseDown);
            this.lblcerrar.MouseLeave += new System.EventHandler(this.lblcerrar_MouseLeave);
            this.lblcerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseMove);
            // 
            // lblminimizar
            // 
            this.lblminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblminimizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminimizar.ForeColor = System.Drawing.Color.DimGray;
            this.lblminimizar.Location = new System.Drawing.Point(472, 9);
            this.lblminimizar.Name = "lblminimizar";
            this.lblminimizar.Size = new System.Drawing.Size(28, 26);
            this.lblminimizar.TabIndex = 7;
            this.lblminimizar.Text = "▬";
            this.lblminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.lblminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblminimizar_MouseDown);
            this.lblminimizar.MouseLeave += new System.EventHandler(this.lblminimizar_MouseLeave);
            this.lblminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblminimizar_MouseMove);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Transparent;
            this.lblerror.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Crimson;
            this.lblerror.Location = new System.Drawing.Point(112, 499);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(36, 17);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "error";
            this.lblerror.Visible = false;
            // 
            // dgvlogin
            // 
            this.dgvlogin.AllowUserToAddRows = false;
            this.dgvlogin.AllowUserToDeleteRows = false;
            this.dgvlogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvlogin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvlogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlogin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlogin.ColumnHeadersHeight = 30;
            this.dgvlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvlogin.EnableHeadersVisualStyles = false;
            this.dgvlogin.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvlogin.Location = new System.Drawing.Point(27, 320);
            this.dgvlogin.Name = "dgvlogin";
            this.dgvlogin.ReadOnly = true;
            this.dgvlogin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvlogin.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvlogin.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvlogin.Size = new System.Drawing.Size(482, 171);
            this.dgvlogin.TabIndex = 15;
            this.dgvlogin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlogin_CellClick);
            // 
            // numeric_periodo
            // 
            this.numeric_periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numeric_periodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric_periodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_periodo.ForeColor = System.Drawing.Color.White;
            this.numeric_periodo.Location = new System.Drawing.Point(216, 499);
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
            this.Cbouser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbouser.ForeColor = System.Drawing.Color.White;
            this.Cbouser.FormattingEnabled = true;
            this.Cbouser.ItemHeight = 17;
            this.Cbouser.Items.AddRange(new object[] {
            "ELEMENTO 1",
            "ELEMENTO 2",
            "ELEMENTO 3",
            "ELEMENTO 4"});
            this.Cbouser.Location = new System.Drawing.Point(27, 113);
            this.Cbouser.Name = "Cbouser";
            this.Cbouser.Size = new System.Drawing.Size(482, 25);
            this.Cbouser.TabIndex = 18;
            this.Cbouser.SelectedIndexChanged += new System.EventHandler(this.Cbouser_SelectedIndexChanged);
            // 
            // cboroles
            // 
            this.cboroles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboroles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboroles.ForeColor = System.Drawing.Color.White;
            this.cboroles.FormattingEnabled = true;
            this.cboroles.Items.AddRange(new object[] {
            "ELEMENTO 1",
            "ELEMENTO 2",
            "ELEMENTO 3",
            "ELEMENTO 4"});
            this.cboroles.Location = new System.Drawing.Point(27, 195);
            this.cboroles.Name = "cboroles";
            this.cboroles.Size = new System.Drawing.Size(482, 25);
            this.cboroles.TabIndex = 18;
            this.cboroles.SelectedIndexChanged += new System.EventHandler(this.cboroles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 131);
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
            this.txtroles.Location = new System.Drawing.Point(67, 195);
            this.txtroles.Multiline = true;
            this.txtroles.Name = "txtroles";
            this.txtroles.Size = new System.Drawing.Size(424, 25);
            this.txtroles.TabIndex = 21;
            this.txtroles.Text = "ROL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(24, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "________________________________________________________________________________";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.candado;
            this.pictureBox4.Location = new System.Drawing.Point(27, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.empleados1;
            this.pictureBox3.Location = new System.Drawing.Point(27, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.clientes;
            this.pictureBox2.Location = new System.Drawing.Point(27, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_lct_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________________________________________________________________";
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(540, 588);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtroles);
            this.Controls.Add(this.cboroles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numeric_periodo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvlogin);
            this.Controls.Add(this.lblminimizar);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.Cbouser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label lblminimizar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.DataGridView dgvlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numeric_periodo;
        private System.Windows.Forms.ComboBox Cbouser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboroles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtroles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
    }
}

