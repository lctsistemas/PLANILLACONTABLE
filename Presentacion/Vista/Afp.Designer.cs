namespace Presentacion.Vista
{
    partial class frmafp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbomes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.cbomes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvcomision);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 440);
            this.panel1.TabIndex = 0;
            // 
            // cbomes
            // 
            this.cbomes.FormattingEnabled = true;
            this.cbomes.Location = new System.Drawing.Point(117, 84);
            this.cbomes.Name = "cbomes";
            this.cbomes.Size = new System.Drawing.Size(125, 21);
            this.cbomes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes devengue: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regimen Pensionario - [comisiones]";
            // 
            // dgvcomision
            // 
            this.dgvcomision.AllowUserToDeleteRows = false;
            this.dgvcomision.AllowUserToOrderColumns = true;
            this.dgvcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomision.Location = new System.Drawing.Point(12, 122);
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.RowHeadersVisible = false;
            this.dgvcomision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcomision.Size = new System.Drawing.Size(731, 255);
            this.dgvcomision.TabIndex = 0;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(317, 84);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 23);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "&Actualizar";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // frmafp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 440);
            this.Controls.Add(this.panel1);
            this.Name = "frmafp";
            this.Text = "Afp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvcomision;
        private System.Windows.Forms.ComboBox cbomes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
    }
}