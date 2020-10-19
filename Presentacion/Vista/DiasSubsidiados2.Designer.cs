namespace Presentacion.Vista
{
    partial class FrmDiasSubsidiados2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbosubsidio = new System.Windows.Forms.ComboBox();
            this.dgvsubsidio = new System.Windows.Forms.DataGridView();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Label();
            this.tsupension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canti_dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttdias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo - dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-  Nombre ";
            // 
            // cbosubsidio
            // 
            this.cbosubsidio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosubsidio.FormattingEnabled = true;
            this.cbosubsidio.Items.AddRange(new object[] {
            "Elemento1",
            "Elemento2",
            "Elemento3"});
            this.cbosubsidio.Location = new System.Drawing.Point(4, 25);
            this.cbosubsidio.Name = "cbosubsidio";
            this.cbosubsidio.Size = new System.Drawing.Size(300, 21);
            this.cbosubsidio.TabIndex = 2;
            // 
            // dgvsubsidio
            // 
            this.dgvsubsidio.AllowUserToResizeColumns = false;
            this.dgvsubsidio.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvsubsidio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvsubsidio.BackgroundColor = System.Drawing.Color.White;
            this.dgvsubsidio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsubsidio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvsubsidio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvsubsidio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubsidio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsupension,
            this.canti_dias,
            this.modificar,
            this.eliminar});
            this.dgvsubsidio.Location = new System.Drawing.Point(4, 45);
            this.dgvsubsidio.Name = "dgvsubsidio";
            this.dgvsubsidio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvsubsidio.RowHeadersVisible = false;
            this.dgvsubsidio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvsubsidio.Size = new System.Drawing.Size(464, 150);
            this.dgvsubsidio.TabIndex = 3;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(304, 26);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(60, 20);
            this.txtdias.TabIndex = 4;
            this.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btngrabar
            // 
            this.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabar.Location = new System.Drawing.Point(364, 25);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(50, 22);
            this.btngrabar.TabIndex = 5;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.AutoSize = true;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(443, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(16, 16);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "X";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // tsupension
            // 
            this.tsupension.HeaderText = "Tipo de suspensión";
            this.tsupension.Name = "tsupension";
            this.tsupension.Width = 300;
            // 
            // canti_dias
            // 
            this.canti_dias.HeaderText = "Cantidad de dias";
            this.canti_dias.Name = "canti_dias";
            this.canti_dias.Width = 60;
            // 
            // modificar
            // 
            this.modificar.HeaderText = "Editar";
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modificar.Width = 50;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtdias);
            this.panel1.Controls.Add(this.txttdias);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btngrabar);
            this.panel1.Controls.Add(this.dgvsubsidio);
            this.panel1.Controls.Add(this.cbosubsidio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 243);
            this.panel1.TabIndex = 7;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(228, 213);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(42, 13);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "TOTAL";
            // 
            // txttdias
            // 
            this.txttdias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttdias.Enabled = false;
            this.txttdias.Location = new System.Drawing.Point(304, 210);
            this.txttdias.Name = "txttdias";
            this.txttdias.Size = new System.Drawing.Size(60, 20);
            this.txttdias.TabIndex = 8;
            this.txttdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDiasSubsidiados2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 243);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiasSubsidiados2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiasSubsidiados2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbosubsidio;
        private System.Windows.Forms.DataGridView dgvsubsidio;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsupension;
        private System.Windows.Forms.DataGridViewTextBoxColumn canti_dias;
        private System.Windows.Forms.DataGridViewImageColumn modificar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.Label btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttdias;
        private System.Windows.Forms.Label lbltotal;
    }
}