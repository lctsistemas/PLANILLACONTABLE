
namespace Presentacion.Vista
{
    partial class Privilegios
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkcomis = new System.Windows.Forms.CheckBox();
            this.checkregpens = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkplan = new System.Windows.Forms.CheckBox();
            this.checkempl = new System.Windows.Forms.CheckBox();
            this.checkempresa = new System.Windows.Forms.CheckBox();
            this.checksucursal = new System.Windows.Forms.CheckBox();
            this.checkusuario = new System.Windows.Forms.CheckBox();
            this.CONFIGURACION = new System.Windows.Forms.GroupBox();
            this.checkroles = new System.Windows.Forms.CheckBox();
            this.checktpla = new System.Windows.Forms.CheckBox();
            this.checktipocont = new System.Windows.Forms.CheckBox();
            this.checkregsalud = new System.Windows.Forms.CheckBox();
            this.checksubnosub = new System.Windows.Forms.CheckBox();
            this.checkcargo = new System.Windows.Forms.CheckBox();
            this.checktipodoc = new System.Windows.Forms.CheckBox();
            this.checkbanco = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxrol = new System.Windows.Forms.ComboBox();
            this.panelpriv = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.lblpriv = new System.Windows.Forms.Label();
            this.txtid_privilegios = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Registrar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CONFIGURACION.SuspendLayout();
            this.panelpriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_24dp;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(38, 49);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(99, 27);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Controls.Add(this.groupBox2);
            this.Registrar.Controls.Add(this.groupBox1);
            this.Registrar.Controls.Add(this.CONFIGURACION);
            this.Registrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Registrar.Location = new System.Drawing.Point(21, 94);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(541, 342);
            this.Registrar.TabIndex = 3;
            this.Registrar.TabStop = false;
            this.Registrar.Text = "ACCESOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkcomis);
            this.groupBox2.Controls.Add(this.checkregpens);
            this.groupBox2.Location = new System.Drawing.Point(15, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 132);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MANTENIMIENTO";
            // 
            // checkcomis
            // 
            this.checkcomis.AutoSize = true;
            this.checkcomis.Location = new System.Drawing.Point(9, 64);
            this.checkcomis.Name = "checkcomis";
            this.checkcomis.Size = new System.Drawing.Size(101, 21);
            this.checkcomis.TabIndex = 11;
            this.checkcomis.Text = "Comisiones";
            this.checkcomis.UseVisualStyleBackColor = true;
            // 
            // checkregpens
            // 
            this.checkregpens.AutoSize = true;
            this.checkregpens.Location = new System.Drawing.Point(9, 27);
            this.checkregpens.Name = "checkregpens";
            this.checkregpens.Size = new System.Drawing.Size(134, 21);
            this.checkregpens.TabIndex = 10;
            this.checkregpens.Text = "Reg. Pensionario";
            this.checkregpens.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkplan);
            this.groupBox1.Controls.Add(this.checkempl);
            this.groupBox1.Controls.Add(this.checkempresa);
            this.groupBox1.Controls.Add(this.checksucursal);
            this.groupBox1.Controls.Add(this.checkusuario);
            this.groupBox1.Location = new System.Drawing.Point(302, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 164);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO";
            // 
            // checkplan
            // 
            this.checkplan.AutoSize = true;
            this.checkplan.Location = new System.Drawing.Point(126, 20);
            this.checkplan.Name = "checkplan";
            this.checkplan.Size = new System.Drawing.Size(73, 21);
            this.checkplan.TabIndex = 16;
            this.checkplan.Text = "Planilla";
            this.checkplan.UseVisualStyleBackColor = true;
            // 
            // checkempl
            // 
            this.checkempl.AutoSize = true;
            this.checkempl.Location = new System.Drawing.Point(10, 20);
            this.checkempl.Name = "checkempl";
            this.checkempl.Size = new System.Drawing.Size(94, 21);
            this.checkempl.TabIndex = 12;
            this.checkempl.Text = "Empleado";
            this.checkempl.UseVisualStyleBackColor = true;
            // 
            // checkempresa
            // 
            this.checkempresa.AutoSize = true;
            this.checkempresa.Location = new System.Drawing.Point(10, 60);
            this.checkempresa.Name = "checkempresa";
            this.checkempresa.Size = new System.Drawing.Size(82, 21);
            this.checkempresa.TabIndex = 13;
            this.checkempresa.Text = "Empresa";
            this.checkempresa.UseVisualStyleBackColor = true;
            // 
            // checksucursal
            // 
            this.checksucursal.AutoSize = true;
            this.checksucursal.Location = new System.Drawing.Point(10, 95);
            this.checksucursal.Name = "checksucursal";
            this.checksucursal.Size = new System.Drawing.Size(78, 21);
            this.checksucursal.TabIndex = 14;
            this.checksucursal.Text = "Sucursal";
            this.checksucursal.UseVisualStyleBackColor = true;
            // 
            // checkusuario
            // 
            this.checkusuario.AutoSize = true;
            this.checkusuario.Location = new System.Drawing.Point(10, 133);
            this.checkusuario.Name = "checkusuario";
            this.checkusuario.Size = new System.Drawing.Size(73, 21);
            this.checkusuario.TabIndex = 15;
            this.checkusuario.Text = "Usuario";
            this.checkusuario.UseVisualStyleBackColor = true;
            // 
            // CONFIGURACION
            // 
            this.CONFIGURACION.Controls.Add(this.checkroles);
            this.CONFIGURACION.Controls.Add(this.checktpla);
            this.CONFIGURACION.Controls.Add(this.checktipocont);
            this.CONFIGURACION.Controls.Add(this.checkregsalud);
            this.CONFIGURACION.Controls.Add(this.checksubnosub);
            this.CONFIGURACION.Controls.Add(this.checkcargo);
            this.CONFIGURACION.Controls.Add(this.checktipodoc);
            this.CONFIGURACION.Controls.Add(this.checkbanco);
            this.CONFIGURACION.Location = new System.Drawing.Point(15, 22);
            this.CONFIGURACION.Name = "CONFIGURACION";
            this.CONFIGURACION.Size = new System.Drawing.Size(272, 164);
            this.CONFIGURACION.TabIndex = 18;
            this.CONFIGURACION.TabStop = false;
            this.CONFIGURACION.Text = "CONFIGURACION";
            // 
            // checkroles
            // 
            this.checkroles.AutoSize = true;
            this.checkroles.Location = new System.Drawing.Point(162, 133);
            this.checkroles.Name = "checkroles";
            this.checkroles.Size = new System.Drawing.Size(60, 21);
            this.checkroles.TabIndex = 9;
            this.checkroles.Text = "Roles";
            this.checkroles.UseVisualStyleBackColor = true;
            // 
            // checktpla
            // 
            this.checktpla.AutoSize = true;
            this.checktpla.Location = new System.Drawing.Point(7, 20);
            this.checktpla.Name = "checktpla";
            this.checktpla.Size = new System.Drawing.Size(103, 21);
            this.checktpla.TabIndex = 2;
            this.checktpla.Text = "Tipo Planilla";
            this.checktpla.UseVisualStyleBackColor = true;
            // 
            // checktipocont
            // 
            this.checktipocont.AutoSize = true;
            this.checktipocont.Location = new System.Drawing.Point(7, 60);
            this.checktipocont.Name = "checktipocont";
            this.checktipocont.Size = new System.Drawing.Size(114, 21);
            this.checktipocont.TabIndex = 3;
            this.checktipocont.Text = "Tipo contrato";
            this.checktipocont.UseVisualStyleBackColor = true;
            // 
            // checkregsalud
            // 
            this.checkregsalud.AutoSize = true;
            this.checkregsalud.Location = new System.Drawing.Point(7, 95);
            this.checkregsalud.Name = "checkregsalud";
            this.checkregsalud.Size = new System.Drawing.Size(123, 21);
            this.checkregsalud.TabIndex = 4;
            this.checkregsalud.Text = "Regimen Salud";
            this.checkregsalud.UseVisualStyleBackColor = true;
            // 
            // checksubnosub
            // 
            this.checksubnosub.AutoSize = true;
            this.checksubnosub.Location = new System.Drawing.Point(7, 133);
            this.checksubnosub.Name = "checksubnosub";
            this.checksubnosub.Size = new System.Drawing.Size(116, 21);
            this.checksubnosub.TabIndex = 5;
            this.checksubnosub.Text = "Subs./No Subs";
            this.checksubnosub.UseVisualStyleBackColor = true;
            // 
            // checkcargo
            // 
            this.checkcargo.AutoSize = true;
            this.checkcargo.Location = new System.Drawing.Point(162, 20);
            this.checkcargo.Name = "checkcargo";
            this.checkcargo.Size = new System.Drawing.Size(69, 21);
            this.checkcargo.TabIndex = 6;
            this.checkcargo.Text = "Cargo";
            this.checkcargo.UseVisualStyleBackColor = true;
            // 
            // checktipodoc
            // 
            this.checktipodoc.AutoSize = true;
            this.checktipodoc.Location = new System.Drawing.Point(162, 60);
            this.checktipodoc.Name = "checktipodoc";
            this.checktipodoc.Size = new System.Drawing.Size(84, 21);
            this.checktipodoc.TabIndex = 7;
            this.checktipodoc.Text = "Tipo Doc";
            this.checktipodoc.UseVisualStyleBackColor = true;
            // 
            // checkbanco
            // 
            this.checkbanco.AutoSize = true;
            this.checkbanco.Location = new System.Drawing.Point(162, 95);
            this.checkbanco.Name = "checkbanco";
            this.checkbanco.Size = new System.Drawing.Size(68, 21);
            this.checkbanco.TabIndex = 8;
            this.checkbanco.Text = "Banco";
            this.checkbanco.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROL";
            // 
            // cbxrol
            // 
            this.cbxrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxrol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrol.FormattingEnabled = true;
            this.cbxrol.IntegralHeight = false;
            this.cbxrol.Location = new System.Drawing.Point(250, 50);
            this.cbxrol.Name = "cbxrol";
            this.cbxrol.Size = new System.Drawing.Size(186, 25);
            this.cbxrol.TabIndex = 0;
            this.cbxrol.SelectedIndexChanged += new System.EventHandler(this.cbxrol_SelectedIndexChanged);
            // 
            // panelpriv
            // 
            this.panelpriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.panelpriv.Controls.Add(this.btnminimizar);
            this.panelpriv.Controls.Add(this.btncerrar);
            this.panelpriv.Controls.Add(this.lblpriv);
            this.panelpriv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelpriv.Location = new System.Drawing.Point(0, 0);
            this.panelpriv.Name = "panelpriv";
            this.panelpriv.Size = new System.Drawing.Size(583, 35);
            this.panelpriv.TabIndex = 4;
            this.panelpriv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelpriv_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.mi_18dp;
            this.btnminimizar.Location = new System.Drawing.Point(513, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 35);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnminimizar.TabIndex = 3;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseDown);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            // 
            // btncerrar
            // 
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.btncerrar.Location = new System.Drawing.Point(548, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 2;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // lblpriv
            // 
            this.lblpriv.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblpriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblpriv.ForeColor = System.Drawing.Color.White;
            this.lblpriv.Location = new System.Drawing.Point(0, 0);
            this.lblpriv.Name = "lblpriv";
            this.lblpriv.Size = new System.Drawing.Size(125, 35);
            this.lblpriv.TabIndex = 0;
            this.lblpriv.Text = "PRIVILEGIOS";
            this.lblpriv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblpriv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblpriv_MouseDown);
            // 
            // txtid_privilegios
            // 
            this.txtid_privilegios.Enabled = false;
            this.txtid_privilegios.Location = new System.Drawing.Point(459, 54);
            this.txtid_privilegios.Name = "txtid_privilegios";
            this.txtid_privilegios.Size = new System.Drawing.Size(56, 20);
            this.txtid_privilegios.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtid_privilegios);
            this.panel2.Controls.Add(this.Registrar);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 456);
            this.panel2.TabIndex = 6;
            // 
            // Privilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 456);
            this.Controls.Add(this.panelpriv);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Privilegios";
            this.Text = "Privilegios";
            this.Load += new System.EventHandler(this.Privilegios_Load);
            this.Registrar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CONFIGURACION.ResumeLayout(false);
            this.CONFIGURACION.PerformLayout();
            this.panelpriv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox Registrar;
        private System.Windows.Forms.Panel panelpriv;
        private System.Windows.Forms.Label lblpriv;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.ComboBox cbxrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkusuario;
        private System.Windows.Forms.CheckBox checksucursal;
        private System.Windows.Forms.CheckBox checkempresa;
        private System.Windows.Forms.CheckBox checkempl;
        private System.Windows.Forms.CheckBox checkcomis;
        private System.Windows.Forms.CheckBox checkregpens;
        private System.Windows.Forms.CheckBox checkroles;
        private System.Windows.Forms.CheckBox checkbanco;
        private System.Windows.Forms.CheckBox checktipodoc;
        private System.Windows.Forms.CheckBox checkcargo;
        private System.Windows.Forms.CheckBox checksubnosub;
        private System.Windows.Forms.CheckBox checkregsalud;
        private System.Windows.Forms.CheckBox checktipocont;
        private System.Windows.Forms.CheckBox checktpla;
        private System.Windows.Forms.CheckBox checkplan;
        private System.Windows.Forms.GroupBox CONFIGURACION;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.TextBox txtid_privilegios;
        private System.Windows.Forms.Panel panel2;
    }
}