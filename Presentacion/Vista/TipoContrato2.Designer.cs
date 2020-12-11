namespace Presentacion.Vista
{
    partial class TipoContrato2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoContrato = new System.Windows.Forms.TextBox();
            this.txttotaldias = new System.Windows.Forms.TextBox();
            this.dgvTcontrato = new System.Windows.Forms.DataGridView();
            this.dgvtxtidtcontrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxttcontrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTcontrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle91.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle91;
            this.dataGridViewImageColumn1.Description = "Modificar";
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle92.NullValue = null;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle92;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.delete18p;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 35);
            this.panel2.TabIndex = 102;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp;
            this.btncerrar.Location = new System.Drawing.Point(353, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 97;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Tipo de Contrato";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::Presentacion.Properties.Resources.baseline_save_white_24dp;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(245, 57);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(101, 24);
            this.btnguardar.TabIndex = 101;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Ingresar Contrato:";
            // 
            // txtTipoContrato
            // 
            this.txtTipoContrato.Location = new System.Drawing.Point(32, 61);
            this.txtTipoContrato.Name = "txtTipoContrato";
            this.txtTipoContrato.Size = new System.Drawing.Size(185, 20);
            this.txtTipoContrato.TabIndex = 99;
            this.txtTipoContrato.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipoContrato_Validating);
            // 
            // txttotaldias
            // 
            this.txttotaldias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotaldias.Enabled = false;
            this.txttotaldias.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldias.Location = new System.Drawing.Point(186, 284);
            this.txttotaldias.Multiline = true;
            this.txttotaldias.Name = "txttotaldias";
            this.txttotaldias.Size = new System.Drawing.Size(149, 24);
            this.txttotaldias.TabIndex = 98;
            // 
            // dgvTcontrato
            // 
            this.dgvTcontrato.AllowUserToAddRows = false;
            this.dgvTcontrato.AllowUserToDeleteRows = false;
            this.dgvTcontrato.AllowUserToOrderColumns = true;
            this.dgvTcontrato.AllowUserToResizeColumns = false;
            this.dgvTcontrato.AllowUserToResizeRows = false;
            dataGridViewCellStyle93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle93.ForeColor = System.Drawing.Color.Black;
            this.dgvTcontrato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle93;
            this.dgvTcontrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTcontrato.BackgroundColor = System.Drawing.Color.White;
            this.dgvTcontrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTcontrato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTcontrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle94.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle94.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle94.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle94.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle94.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTcontrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle94;
            this.dgvTcontrato.ColumnHeadersHeight = 34;
            this.dgvTcontrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTcontrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtidtcontrato,
            this.dgvtxttcontrato,
            this.modificar,
            this.eliminar});
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle98.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle98.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle98.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle98.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle98.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTcontrato.DefaultCellStyle = dataGridViewCellStyle98;
            this.dgvTcontrato.EnableHeadersVisualStyles = false;
            this.dgvTcontrato.Location = new System.Drawing.Point(32, 95);
            this.dgvTcontrato.Name = "dgvTcontrato";
            this.dgvTcontrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle99.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle99.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTcontrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle99;
            this.dgvTcontrato.RowHeadersVisible = false;
            this.dgvTcontrato.RowHeadersWidth = 42;
            dataGridViewCellStyle100.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTcontrato.RowsDefaultCellStyle = dataGridViewCellStyle100;
            this.dgvTcontrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTcontrato.Size = new System.Drawing.Size(318, 183);
            this.dgvTcontrato.TabIndex = 96;
            this.dgvTcontrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsubsidio_CellContentClick);
            // 
            // dgvtxtidtcontrato
            // 
            this.dgvtxtidtcontrato.DataPropertyName = "id_tcontrato";
            this.dgvtxtidtcontrato.HeaderText = "ID";
            this.dgvtxtidtcontrato.Name = "dgvtxtidtcontrato";
            this.dgvtxtidtcontrato.Width = 41;
            // 
            // dgvtxttcontrato
            // 
            this.dgvtxttcontrato.DataPropertyName = "tiem_contrato";
            dataGridViewCellStyle95.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvtxttcontrato.DefaultCellStyle = dataGridViewCellStyle95;
            this.dgvtxttcontrato.HeaderText = "Tipo Contrato";
            this.dgvtxttcontrato.Name = "dgvtxttcontrato";
            this.dgvtxttcontrato.Width = 200;
            // 
            // modificar
            // 
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle96.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle96.NullValue = null;
            this.modificar.DefaultCellStyle = dataGridViewCellStyle96;
            this.modificar.Description = "Modificar";
            this.modificar.HeaderText = "Editar";
            this.modificar.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modificar.Width = 48;
            // 
            // eliminar
            // 
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle97.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle97.NullValue = null;
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle97;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::Presentacion.Properties.Resources.delete18p;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Width = 65;
            // 
            // TipoContrato2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoContrato);
            this.Controls.Add(this.txttotaldias);
            this.Controls.Add(this.dgvTcontrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoContrato2";
            this.Text = "TipoContrato2";
            this.Load += new System.EventHandler(this.TipoContrato2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTcontrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoContrato;
        private System.Windows.Forms.TextBox txttotaldias;
        private System.Windows.Forms.DataGridView dgvTcontrato;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtidtcontrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxttcontrato;
        private System.Windows.Forms.DataGridViewImageColumn modificar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}