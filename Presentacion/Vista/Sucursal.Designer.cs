﻿namespace Presentacion.Vista
{
    partial class frmsucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsucursal));
            this.tapsucursal = new System.Windows.Forms.TabControl();
            this.tablista_empresa = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvsucursal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.tabgestion_empresa = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnempresa = new System.Windows.Forms.Button();
            this.txtregimen = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtidempresa = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtrazon_social = new System.Windows.Forms.TextBox();
            this.txtcodigo_sucursal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelsucursal = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tapsucursal.SuspendLayout();
            this.tablista_empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsucursal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabgestion_empresa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelsucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tapsucursal
            // 
            this.tapsucursal.Controls.Add(this.tablista_empresa);
            this.tapsucursal.Controls.Add(this.tabgestion_empresa);
            this.tapsucursal.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tapsucursal, "tapsucursal");
            this.tapsucursal.Multiline = true;
            this.tapsucursal.Name = "tapsucursal";
            this.tapsucursal.SelectedIndex = 0;
            // 
            // tablista_empresa
            // 
            this.tablista_empresa.BackColor = System.Drawing.SystemColors.Window;
            this.tablista_empresa.Controls.Add(this.btneliminar);
            this.tablista_empresa.Controls.Add(this.lbltotal);
            this.tablista_empresa.Controls.Add(this.dgvsucursal);
            this.tablista_empresa.Controls.Add(this.groupBox1);
            this.tablista_empresa.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.tablista_empresa, "tablista_empresa");
            this.tablista_empresa.Name = "tablista_empresa";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btneliminar, "btneliminar");
            this.btneliminar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp1;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lbltotal
            // 
            resources.ApplyResources(this.lbltotal, "lbltotal");
            this.lbltotal.Name = "lbltotal";
            // 
            // dgvsucursal
            // 
            this.dgvsucursal.AllowUserToAddRows = false;
            this.dgvsucursal.AllowUserToDeleteRows = false;
            this.dgvsucursal.AllowUserToOrderColumns = true;
            this.dgvsucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvsucursal, "dgvsucursal");
            this.dgvsucursal.Name = "dgvsucursal";
            this.dgvsucursal.ReadOnly = true;
            this.dgvsucursal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsucursal_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbuscar);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtbuscar, "txtbuscar");
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // tabgestion_empresa
            // 
            this.tabgestion_empresa.BackColor = System.Drawing.SystemColors.Window;
            this.tabgestion_empresa.Controls.Add(this.groupBox2);
            this.tabgestion_empresa.Controls.Add(this.btnempresa);
            this.tabgestion_empresa.Controls.Add(this.txtregimen);
            this.tabgestion_empresa.Controls.Add(this.txtusuario);
            this.tabgestion_empresa.Controls.Add(this.txtidempresa);
            this.tabgestion_empresa.Controls.Add(this.txtruc);
            this.tabgestion_empresa.Controls.Add(this.txtdomicilio);
            this.tabgestion_empresa.Controls.Add(this.txtdireccion);
            this.tabgestion_empresa.Controls.Add(this.txtlocalidad);
            this.tabgestion_empresa.Controls.Add(this.txtrazon_social);
            this.tabgestion_empresa.Controls.Add(this.txtcodigo_sucursal);
            this.tabgestion_empresa.Controls.Add(this.label8);
            this.tabgestion_empresa.Controls.Add(this.label1);
            this.tabgestion_empresa.Controls.Add(this.label2);
            this.tabgestion_empresa.Controls.Add(this.label7);
            this.tabgestion_empresa.Controls.Add(this.label3);
            this.tabgestion_empresa.Controls.Add(this.label6);
            this.tabgestion_empresa.Controls.Add(this.label4);
            this.tabgestion_empresa.Controls.Add(this.label5);
            resources.ApplyResources(this.tabgestion_empresa, "tabgestion_empresa");
            this.tabgestion_empresa.Name = "tabgestion_empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.btnguardar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnnuevo, "btnnuevo");
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp1;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnguardar, "btnguardar");
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp2;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnempresa
            // 
            this.btnempresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempresa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnempresa.FlatAppearance.BorderSize = 0;
            this.btnempresa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnempresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnempresa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnempresa, "btnempresa");
            this.btnempresa.Name = "btnempresa";
            this.btnempresa.UseVisualStyleBackColor = true;
            this.btnempresa.Click += new System.EventHandler(this.btnempresa_Click_1);
            // 
            // txtregimen
            // 
            resources.ApplyResources(this.txtregimen, "txtregimen");
            this.txtregimen.Name = "txtregimen";
            // 
            // txtusuario
            // 
            resources.ApplyResources(this.txtusuario, "txtusuario");
            this.txtusuario.Name = "txtusuario";
            // 
            // txtidempresa
            // 
            resources.ApplyResources(this.txtidempresa, "txtidempresa");
            this.txtidempresa.Name = "txtidempresa";
            // 
            // txtruc
            // 
            resources.ApplyResources(this.txtruc, "txtruc");
            this.txtruc.Name = "txtruc";
            // 
            // txtdomicilio
            // 
            resources.ApplyResources(this.txtdomicilio, "txtdomicilio");
            this.txtdomicilio.Name = "txtdomicilio";
            // 
            // txtdireccion
            // 
            resources.ApplyResources(this.txtdireccion, "txtdireccion");
            this.txtdireccion.Name = "txtdireccion";
            // 
            // txtlocalidad
            // 
            resources.ApplyResources(this.txtlocalidad, "txtlocalidad");
            this.txtlocalidad.Name = "txtlocalidad";
            // 
            // txtrazon_social
            // 
            resources.ApplyResources(this.txtrazon_social, "txtrazon_social");
            this.txtrazon_social.Name = "txtrazon_social";
            // 
            // txtcodigo_sucursal
            // 
            resources.ApplyResources(this.txtcodigo_sucursal, "txtcodigo_sucursal");
            this.txtcodigo_sucursal.Name = "txtcodigo_sucursal";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Name = "label2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Name = "label5";
            // 
            // panelsucursal
            // 
            this.panelsucursal.BackColor = System.Drawing.Color.SteelBlue;
            this.panelsucursal.Controls.Add(this.pictureBox1);
            this.panelsucursal.Controls.Add(this.label10);
            this.panelsucursal.Controls.Add(this.btnminimizar);
            this.panelsucursal.Controls.Add(this.btnmaximizar);
            this.panelsucursal.Controls.Add(this.btncerrar);
            this.panelsucursal.Controls.Add(this.btnrestaurar);
            resources.ApplyResources(this.panelsucursal, "panelsucursal");
            this.panelsucursal.Name = "panelsucursal";
            this.panelsucursal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelsucursal_MouseDown);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // btnminimizar
            // 
            resources.ApplyResources(this.btnminimizar, "btnminimizar");
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            this.btnminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseMove);
            // 
            // btnmaximizar
            // 
            resources.ApplyResources(this.btnmaximizar, "btnmaximizar");
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp;
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            this.btnmaximizar.MouseLeave += new System.EventHandler(this.btnmaximizar_MouseLeave);
            this.btnmaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmaximizar_MouseMove);
            // 
            // btncerrar
            // 
            resources.ApplyResources(this.btncerrar, "btncerrar");
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // btnrestaurar
            // 
            resources.ApplyResources(this.btnrestaurar, "btnrestaurar");
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            this.btnrestaurar.MouseLeave += new System.EventHandler(this.btnrestaurar_MouseLeave);
            this.btnrestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnrestaurar_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_lct_2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmsucursal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelsucursal);
            this.Controls.Add(this.tapsucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsucursal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsucursal_FormClosing);
            this.Load += new System.EventHandler(this.frmsucursal_Load);
            this.tapsucursal.ResumeLayout(false);
            this.tablista_empresa.ResumeLayout(false);
            this.tablista_empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsucursal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabgestion_empresa.ResumeLayout(false);
            this.tabgestion_empresa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelsucursal.ResumeLayout(false);
            this.panelsucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tapsucursal;
        private System.Windows.Forms.TabPage tablista_empresa;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgvsucursal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TabPage tabgestion_empresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnempresa;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtruc;
        public System.Windows.Forms.TextBox txtdomicilio;
        public System.Windows.Forms.TextBox txtrazon_social;
        public System.Windows.Forms.TextBox txtregimen;
        public System.Windows.Forms.TextBox txtidempresa;
        public System.Windows.Forms.TextBox txtcodigo_sucursal;
        private System.Windows.Forms.Panel panelsucursal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}