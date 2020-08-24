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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabuser = new System.Windows.Forms.TabControl();
            this.tablista = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabgestion = new System.Windows.Forms.TabPage();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtacceso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.txtnom_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.tabuser.SuspendLayout();
            this.tablista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.tabgestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
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
            this.tabuser.ItemSize = new System.Drawing.Size(98, 25);
            this.tabuser.Location = new System.Drawing.Point(1, 38);
            this.tabuser.Multiline = true;
            this.tabuser.Name = "tabuser";
            this.tabuser.Padding = new System.Drawing.Point(8, 6);
            this.tabuser.SelectedIndex = 0;
            this.tabuser.Size = new System.Drawing.Size(888, 513);
            this.tabuser.TabIndex = 5;
            // 
            // tablista
            // 
            this.tablista.BackColor = System.Drawing.Color.White;
            this.tablista.Controls.Add(this.label6);
            this.tablista.Controls.Add(this.txtbuscar);
            this.tablista.Controls.Add(this.label19);
            this.tablista.Controls.Add(this.dgvusuario);
            this.tablista.Controls.Add(this.lbltotal);
            this.tablista.Location = new System.Drawing.Point(4, 29);
            this.tablista.Name = "tablista";
            this.tablista.Padding = new System.Windows.Forms.Padding(3);
            this.tablista.Size = new System.Drawing.Size(880, 480);
            this.tablista.TabIndex = 0;
            this.tablista.Text = "LISTA USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Buscar Usuario";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(10, 40);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(271, 19);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(7, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(281, 17);
            this.label19.TabIndex = 86;
            this.label19.Text = "_______________________________________";
            // 
            // dgvusuario
            // 
            this.dgvusuario.AllowUserToAddRows = false;
            this.dgvusuario.AllowUserToDeleteRows = false;
            this.dgvusuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvusuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvusuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvusuario.ColumnHeadersHeight = 35;
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvusuario.EnableHeadersVisualStyles = false;
            this.dgvusuario.Location = new System.Drawing.Point(5, 94);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.ReadOnly = true;
            this.dgvusuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvusuario.RowHeadersWidth = 30;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvusuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvusuario.Size = new System.Drawing.Size(768, 357);
            this.dgvusuario.TabIndex = 4;
            this.dgvusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellDoubleClick);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.DimGray;
            this.lbltotal.Location = new System.Drawing.Point(8, 74);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(39, 17);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total";
            // 
            // tabgestion
            // 
            this.tabgestion.BackColor = System.Drawing.SystemColors.Window;
            this.tabgestion.Controls.Add(this.lblerror);
            this.tabgestion.Controls.Add(this.btnrol);
            this.tabgestion.Controls.Add(this.label1);
            this.tabgestion.Controls.Add(this.txtcodigo);
            this.tabgestion.Controls.Add(this.txtacceso);
            this.tabgestion.Controls.Add(this.label2);
            this.tabgestion.Controls.Add(this.cborol);
            this.tabgestion.Controls.Add(this.txtnom_usuario);
            this.tabgestion.Controls.Add(this.label3);
            this.tabgestion.Controls.Add(this.txtpassword);
            this.tabgestion.Controls.Add(this.label4);
            this.tabgestion.Controls.Add(this.label5);
            this.tabgestion.Location = new System.Drawing.Point(4, 29);
            this.tabgestion.Name = "tabgestion";
            this.tabgestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabgestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabgestion.Size = new System.Drawing.Size(880, 480);
            this.tabgestion.TabIndex = 1;
            this.tabgestion.Text = "GESTION USUARIO";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Crimson;
            this.lblerror.Location = new System.Drawing.Point(30, 324);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(36, 17);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "Error";
            this.lblerror.Visible = false;
            // 
            // btnrol
            // 
            this.btnrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrol.FlatAppearance.BorderSize = 0;
            this.btnrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrol.ForeColor = System.Drawing.Color.DimGray;
            this.btnrol.Location = new System.Drawing.Point(450, 239);
            this.btnrol.Name = "btnrol";
            this.btnrol.Size = new System.Drawing.Size(53, 24);
            this.btnrol.TabIndex = 9;
            this.btnrol.Text = "&ROL";
            this.btnrol.UseVisualStyleBackColor = false;
            this.btnrol.Click += new System.EventHandler(this.btnrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(194, 46);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(102, 22);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtacceso
            // 
            this.txtacceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacceso.Location = new System.Drawing.Point(194, 92);
            this.txtacceso.Name = "txtacceso";
            this.txtacceso.Size = new System.Drawing.Size(170, 22);
            this.txtacceso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "CODIGO DE ACCESO:";
            // 
            // cborol
            // 
            this.cborol.DropDownHeight = 116;
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborol.FormattingEnabled = true;
            this.cborol.IntegralHeight = false;
            this.cborol.Location = new System.Drawing.Point(194, 239);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(221, 24);
            this.cborol.TabIndex = 4;
            // 
            // txtnom_usuario
            // 
            this.txtnom_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_usuario.Location = new System.Drawing.Point(194, 139);
            this.txtnom_usuario.Name = "txtnom_usuario";
            this.txtnom_usuario.Size = new System.Drawing.Size(221, 22);
            this.txtnom_usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE DE USUARIO:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(194, 188);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(221, 22);
            this.txtpassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(30, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(30, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ROL:";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.SteelBlue;
            this.btnremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremover.FlatAppearance.BorderSize = 0;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp1;
            this.btnremover.Location = new System.Drawing.Point(121, 3);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(35, 30);
            this.btnremover.TabIndex = 1;
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
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
            this.btnnuevo.Location = new System.Drawing.Point(9, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(35, 30);
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
            this.btnguardar.Location = new System.Drawing.Point(65, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(35, 30);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp;
            this.btncerrar.Location = new System.Drawing.Point(849, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(888, 551);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.tabuser);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnremover);
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
            this.tabgestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
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
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblerror;
    }
}