﻿namespace Presentacion.Subvista
{
    partial class frmvista_usuario
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvvista_user = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbuscar.Location = new System.Drawing.Point(22, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(387, 15);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.WordWrap = false;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvvista_user
            // 
            this.dgvvista_user.AllowUserToAddRows = false;
            this.dgvvista_user.AllowUserToDeleteRows = false;
            this.dgvvista_user.AllowUserToOrderColumns = true;
            this.dgvvista_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvista_user.Location = new System.Drawing.Point(1, 53);
            this.dgvvista_user.Name = "dgvvista_user";
            this.dgvvista_user.ReadOnly = true;
            this.dgvvista_user.RowHeadersWidth = 30;
            this.dgvvista_user.Size = new System.Drawing.Size(648, 307);
            this.dgvvista_user.TabIndex = 1;
            this.dgvvista_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvista_user_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTA DE USUARIOS";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(482, 21);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(10, 13);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = ".";
            // 
            // frmvista_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 360);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvvista_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmvista_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VISTA USUARIO";
            this.Load += new System.EventHandler(this.frmvista_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvvista_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcantidad;
    }
}