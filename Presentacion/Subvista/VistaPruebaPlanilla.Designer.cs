
namespace Presentacion.Subvista
{
    partial class FrmVistaPruebaPlanilla
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
            this.dgvlistprueba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistprueba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistprueba
            // 
            this.dgvlistprueba.AllowUserToAddRows = false;
            this.dgvlistprueba.AllowUserToDeleteRows = false;
            this.dgvlistprueba.BackgroundColor = System.Drawing.Color.White;
            this.dgvlistprueba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvlistprueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistprueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvlistprueba.GridColor = System.Drawing.Color.Silver;
            this.dgvlistprueba.Location = new System.Drawing.Point(0, 0);
            this.dgvlistprueba.Name = "dgvlistprueba";
            this.dgvlistprueba.ReadOnly = true;
            this.dgvlistprueba.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvlistprueba.RowHeadersWidth = 25;
            this.dgvlistprueba.Size = new System.Drawing.Size(1141, 434);
            this.dgvlistprueba.TabIndex = 0;
            // 
            // FrmVistaPruebaPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 434);
            this.Controls.Add(this.dgvlistprueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVistaPruebaPlanilla";
            this.Load += new System.EventHandler(this.FrmVistaPruebaPlanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistprueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistprueba;
    }
}