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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvempresa = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.dgvempresa);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 344);
            this.panel2.TabIndex = 11;
            // 
            // dgvempresa
            // 
            this.dgvempresa.AllowUserToAddRows = false;
            this.dgvempresa.AllowUserToDeleteRows = false;
            this.dgvempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempresa.Location = new System.Drawing.Point(2, 101);
            this.dgvempresa.Name = "dgvempresa";
            this.dgvempresa.ReadOnly = true;
            this.dgvempresa.Size = new System.Drawing.Size(245, 170);
            this.dgvempresa.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(287, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "______________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(287, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "______________________________________________________________________";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.DimGray;
            this.txtuser.Location = new System.Drawing.Point(290, 85);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(424, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(290, 175);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(424, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(449, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "LOGIN";
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
            this.btnlogin.Location = new System.Drawing.Point(319, 262);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(361, 40);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "&ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.DimGray;
            this.linkpass.Location = new System.Drawing.Point(410, 314);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(182, 17);
            this.linkpass.TabIndex = 4;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Ha olvidado contraseña?";
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblcerrar.Location = new System.Drawing.Point(749, 5);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(26, 25);
            this.lblcerrar.TabIndex = 7;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.AutoSize = true;
            this.btnminimizar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.Color.DimGray;
            this.btnminimizar.Location = new System.Drawing.Point(708, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(33, 25);
            this.btnminimizar.TabIndex = 7;
            this.btnminimizar.Text = "▬";
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Transparent;
            this.lblerror.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Firebrick;
            this.lblerror.Location = new System.Drawing.Point(287, 214);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(36, 17);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "error";
            this.lblerror.Visible = false;
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 344);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frminicio";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frminicio_FormClosing);
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frminicio_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label btnminimizar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.DataGridView dgvempresa;
    }
}

