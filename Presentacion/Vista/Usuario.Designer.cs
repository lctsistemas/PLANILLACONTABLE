namespace Presentacion.Vista
{
    partial class frmusuario
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
            this.tabuser = new System.Windows.Forms.TabControl();
            this.tablista = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabgestion = new System.Windows.Forms.TabPage();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrol = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtacceso = new System.Windows.Forms.TextBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.txtnom_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabuser.SuspendLayout();
            this.tablista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.tabgestion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabuser
            // 
            this.tabuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabuser.Controls.Add(this.tablista);
            this.tabuser.Controls.Add(this.tabgestion);
            this.tabuser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabuser.ItemSize = new System.Drawing.Size(98, 26);
            this.tabuser.Location = new System.Drawing.Point(1, 35);
            this.tabuser.Name = "tabuser";
            this.tabuser.Padding = new System.Drawing.Point(8, 6);
            this.tabuser.SelectedIndex = 0;
            this.tabuser.Size = new System.Drawing.Size(888, 482);
            this.tabuser.TabIndex = 5;
            // 
            // tablista
            // 
            this.tablista.BackColor = System.Drawing.Color.White;
            this.tablista.Controls.Add(this.label6);
            this.tablista.Controls.Add(this.txtbuscar);
            this.tablista.Controls.Add(this.label19);
            this.tablista.Controls.Add(this.btnremover);
            this.tablista.Controls.Add(this.dgvusuario);
            this.tablista.Controls.Add(this.lbltotal);
            this.tablista.Location = new System.Drawing.Point(4, 30);
            this.tablista.Name = "tablista";
            this.tablista.Padding = new System.Windows.Forms.Padding(3);
            this.tablista.Size = new System.Drawing.Size(880, 448);
            this.tablista.TabIndex = 0;
            this.tablista.Text = "LISTA USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Buscar Usuario";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(10, 40);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(271, 17);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(281, 17);
            this.label19.TabIndex = 86;
            this.label19.Text = "_______________________________________";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.SteelBlue;
            this.btnremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp1;
            this.btnremover.Location = new System.Drawing.Point(442, 23);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(70, 43);
            this.btnremover.TabIndex = 1;
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // dgvusuario
            // 
            this.dgvusuario.AllowUserToAddRows = false;
            this.dgvusuario.AllowUserToDeleteRows = false;
            this.dgvusuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvusuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvusuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvusuario.ColumnHeadersHeight = 35;
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvusuario.Location = new System.Drawing.Point(3, 77);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.ReadOnly = true;
            this.dgvusuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvusuario.RowHeadersWidth = 30;
            this.dgvusuario.Size = new System.Drawing.Size(768, 216);
            this.dgvusuario.TabIndex = 4;
            this.dgvusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellDoubleClick);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbltotal.Location = new System.Drawing.Point(315, 39);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(39, 16);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total";
            // 
            // tabgestion
            // 
            this.tabgestion.BackColor = System.Drawing.SystemColors.Window;
            this.tabgestion.Controls.Add(this.panel1);
            this.tabgestion.Location = new System.Drawing.Point(4, 30);
            this.tabgestion.Name = "tabgestion";
            this.tabgestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabgestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabgestion.Size = new System.Drawing.Size(880, 448);
            this.tabgestion.TabIndex = 1;
            this.tabgestion.Text = "GESTION USUARIO";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp1;
            this.btnnuevo.Location = new System.Drawing.Point(9, 1);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(38, 32);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp2;
            this.btnguardar.Location = new System.Drawing.Point(65, 1);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(41, 32);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnrol);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtacceso);
            this.panel1.Controls.Add(this.cborol);
            this.panel1.Controls.Add(this.txtnom_usuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(19, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 189);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            // 
            // btnrol
            // 
            this.btnrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrol.ForeColor = System.Drawing.Color.White;
            this.btnrol.Location = new System.Drawing.Point(419, 138);
            this.btnrol.Name = "btnrol";
            this.btnrol.Size = new System.Drawing.Size(53, 24);
            this.btnrol.TabIndex = 9;
            this.btnrol.Text = "&ROL";
            this.btnrol.UseVisualStyleBackColor = false;
            this.btnrol.Click += new System.EventHandler(this.btnrol_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(69, 17);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(102, 22);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtacceso
            // 
            this.txtacceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacceso.Location = new System.Drawing.Point(6, 75);
            this.txtacceso.Name = "txtacceso";
            this.txtacceso.Size = new System.Drawing.Size(165, 22);
            this.txtacceso.TabIndex = 1;
            this.txtacceso.Validating += new System.ComponentModel.CancelEventHandler(this.txtacceso_Validating);
            // 
            // cborol
            // 
            this.cborol.DropDownHeight = 116;
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborol.FormattingEnabled = true;
            this.cborol.IntegralHeight = false;
            this.cborol.Location = new System.Drawing.Point(229, 138);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(177, 24);
            this.cborol.TabIndex = 4;
            this.cborol.SelectedIndexChanged += new System.EventHandler(this.cborol_SelectedIndexChanged);
            // 
            // txtnom_usuario
            // 
            this.txtnom_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_usuario.Location = new System.Drawing.Point(229, 74);
            this.txtnom_usuario.Name = "txtnom_usuario";
            this.txtnom_usuario.Size = new System.Drawing.Size(221, 22);
            this.txtnom_usuario.TabIndex = 2;
            this.txtnom_usuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtnom_usuario_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ROL";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(6, 140);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(165, 22);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CODIGO DE ACCESO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE DE USUARIO";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp;
            this.btncerrar.Location = new System.Drawing.Point(841, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseHover += new System.EventHandler(this.btncerrar_MouseHover);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(371, 16);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 7;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp;
            this.pictureBox2.Location = new System.Drawing.Point(407, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 520);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.tabuser);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmusuario";
            this.Text = "Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmusuario_FormClosing);
            this.Load += new System.EventHandler(this.frmusuario_Load);
            this.tabuser.ResumeLayout(false);
            this.tablista.ResumeLayout(false);
            this.tablista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.tabgestion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabuser;
        private System.Windows.Forms.TabPage tablista;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TabPage tabgestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrol;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtacceso;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.TextBox txtnom_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
    }
}