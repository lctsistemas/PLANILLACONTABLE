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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelvista_user = new System.Windows.Forms.Panel();
            this.pictbuscar = new System.Windows.Forms.PictureBox();
            this.dgvvista_user = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panelvista_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 73;
            this.lineShape1.X2 = 412;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 42;
            // 
            // panelvista_user
            // 
            this.panelvista_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelvista_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelvista_user.Controls.Add(this.pictbuscar);
            this.panelvista_user.Controls.Add(this.dgvvista_user);
            this.panelvista_user.Controls.Add(this.btncerrar);
            this.panelvista_user.Controls.Add(this.lblcantidad);
            this.panelvista_user.Controls.Add(this.txtbuscar);
            this.panelvista_user.Controls.Add(this.shapeContainer2);
            this.panelvista_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvista_user.Location = new System.Drawing.Point(0, 0);
            this.panelvista_user.Name = "panelvista_user";
            this.panelvista_user.Size = new System.Drawing.Size(777, 388);
            this.panelvista_user.TabIndex = 9;
            this.panelvista_user.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelvista_user_MouseDown);
            // 
            // pictbuscar
            // 
            this.pictbuscar.Image = global::Presentacion.Properties.Resources.loupe_78956__1_;
            this.pictbuscar.Location = new System.Drawing.Point(34, 21);
            this.pictbuscar.Name = "pictbuscar";
            this.pictbuscar.Size = new System.Drawing.Size(35, 21);
            this.pictbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbuscar.TabIndex = 8;
            this.pictbuscar.TabStop = false;
            // 
            // dgvvista_user
            // 
            this.dgvvista_user.AllowUserToAddRows = false;
            this.dgvvista_user.AllowUserToDeleteRows = false;
            this.dgvvista_user.AllowUserToResizeColumns = false;
            this.dgvvista_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvvista_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvista_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvvista_user.BackgroundColor = System.Drawing.Color.White;
            this.dgvvista_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvista_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvista_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvvista_user.ColumnHeadersHeight = 35;
            this.dgvvista_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvista_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvvista_user.EnableHeadersVisualStyles = false;
            this.dgvvista_user.Location = new System.Drawing.Point(7, 70);
            this.dgvvista_user.MultiSelect = false;
            this.dgvvista_user.Name = "dgvvista_user";
            this.dgvvista_user.ReadOnly = true;
            this.dgvvista_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvista_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvvista_user.RowHeadersVisible = false;
            this.dgvvista_user.RowHeadersWidth = 25;
            this.dgvvista_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvvista_user.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvvista_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvista_user.Size = new System.Drawing.Size(757, 311);
            this.dgvvista_user.TabIndex = 1;
            this.dgvvista_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvista_user_CellDoubleClick);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncerrar.Location = new System.Drawing.Point(739, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "X";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblcantidad.Location = new System.Drawing.Point(40, 50);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(38, 17);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = "cant";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.White;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.Location = new System.Drawing.Point(75, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(334, 19);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.WordWrap = false;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(775, 386);
            this.shapeContainer2.TabIndex = 9;
            this.shapeContainer2.TabStop = false;
            // 
            // frmvista_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 388);
            this.Controls.Add(this.panelvista_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmvista_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VISTA USUARIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmvista_usuario_FormClosing);
            this.Load += new System.EventHandler(this.frmvista_usuario_Load);
            this.panelvista_user.ResumeLayout(false);
            this.panelvista_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelvista_user;
        private System.Windows.Forms.PictureBox pictbuscar;
        private System.Windows.Forms.DataGridView dgvvista_user;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtbuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}