
namespace Presentacion.Subvista
{
    partial class FrmVista_rol
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
            this.panel_rol = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Label();
            this.dgvrol = new System.Windows.Forms.DataGridView();
            this.panel_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_rol
            // 
            this.panel_rol.BackColor = System.Drawing.Color.White;
            this.panel_rol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_rol.Controls.Add(this.dgvrol);
            this.panel_rol.Controls.Add(this.btncerrar);
            this.panel_rol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rol.Location = new System.Drawing.Point(0, 0);
            this.panel_rol.Name = "panel_rol";
            this.panel_rol.Size = new System.Drawing.Size(354, 253);
            this.panel_rol.TabIndex = 0;
            this.panel_rol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_rol_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncerrar.Location = new System.Drawing.Point(316, 0);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.TabIndex = 12;
            this.btncerrar.Text = "X";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // dgvrol
            // 
            this.dgvrol.AllowUserToAddRows = false;
            this.dgvrol.AllowUserToDeleteRows = false;
            this.dgvrol.AllowUserToResizeColumns = false;
            this.dgvrol.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvrol.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrol.BackgroundColor = System.Drawing.Color.White;
            this.dgvrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrol.ColumnHeadersHeight = 30;
            this.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrol.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrol.EnableHeadersVisualStyles = false;
            this.dgvrol.Location = new System.Drawing.Point(3, 52);
            this.dgvrol.MultiSelect = false;
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.ReadOnly = true;
            this.dgvrol.RowHeadersVisible = false;
            this.dgvrol.RowHeadersWidth = 28;
            this.dgvrol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvrol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrol.Size = new System.Drawing.Size(345, 195);
            this.dgvrol.TabIndex = 13;
            // 
            // FrmVista_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 253);
            this.Controls.Add(this.panel_rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVista_rol";
            this.Text = "Vista_rol";
            this.Load += new System.EventHandler(this.FrmVista_rol_Load);
            this.panel_rol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_rol;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.DataGridView dgvrol;
    }
}