namespace Presentacion.Vista
{
    partial class FrmTipoContrato2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTcontrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewImageColumn1.Description = "Modificar";
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.NullValue = null;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.delete18p;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.btnminimizar);
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
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.mi_18dp;
            this.btnminimizar.Location = new System.Drawing.Point(322, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 35);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnminimizar.TabIndex = 96;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseDown);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            this.btnminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseMove);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.btncerrar.Location = new System.Drawing.Point(357, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 97;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 95;
            this.label1.Text = "TIPO DE CONTRATO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
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
            this.txttotaldias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            this.dgvTcontrato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTcontrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTcontrato.BackgroundColor = System.Drawing.Color.White;
            this.dgvTcontrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTcontrato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTcontrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTcontrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTcontrato.ColumnHeadersHeight = 34;
            this.dgvTcontrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTcontrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtidtcontrato,
            this.dgvtxttcontrato,
            this.modificar,
            this.eliminar});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTcontrato.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvTcontrato.EnableHeadersVisualStyles = false;
            this.dgvTcontrato.Location = new System.Drawing.Point(32, 95);
            this.dgvTcontrato.Name = "dgvTcontrato";
            this.dgvTcontrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTcontrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvTcontrato.RowHeadersVisible = false;
            this.dgvTcontrato.RowHeadersWidth = 42;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTcontrato.RowsDefaultCellStyle = dataGridViewCellStyle30;
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
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvtxttcontrato.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvtxttcontrato.HeaderText = "Tipo Contrato";
            this.dgvtxttcontrato.Name = "dgvtxttcontrato";
            this.dgvtxttcontrato.Width = 200;
            // 
            // modificar
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.NullValue = null;
            this.modificar.DefaultCellStyle = dataGridViewCellStyle26;
            this.modificar.Description = "Modificar";
            this.modificar.HeaderText = "Editar";
            this.modificar.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modificar.Width = 48;
            // 
            // eliminar
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.NullValue = null;
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle27;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::Presentacion.Properties.Resources.delete18p;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Width = 65;
            // 
            // FrmTipoContrato2
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
            this.Name = "FrmTipoContrato2";
            this.Text = "TipoContrato2";
            this.Load += new System.EventHandler(this.TipoContrato2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtidtcontrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxttcontrato;
        private System.Windows.Forms.DataGridViewImageColumn modificar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}