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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblcodigo_empledo = new System.Windows.Forms.Label();
            this.lblnombre_empleado = new System.Windows.Forms.Label();
            this.cbosubsidio = new System.Windows.Forms.ComboBox();
            this.dgvsubsidio = new System.Windows.Forms.DataGridView();
            this.tsupension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canti_dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.id_dsubsidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_subsidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvacaciones = new System.Windows.Forms.Label();
            this.lbltotalSi = new System.Windows.Forms.Label();
            this.lbltotalSp = new System.Windows.Forms.Label();
            this.txttotaldias = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigo_empledo
            // 
            this.lblcodigo_empledo.AutoSize = true;
            this.lblcodigo_empledo.Location = new System.Drawing.Point(7, 3);
            this.lblcodigo_empledo.Name = "lblcodigo_empledo";
            this.lblcodigo_empledo.Size = new System.Drawing.Size(63, 13);
            this.lblcodigo_empledo.TabIndex = 0;
            this.lblcodigo_empledo.Text = "Codigo - dni";
            // 
            // lblnombre_empleado
            // 
            this.lblnombre_empleado.AutoSize = true;
            this.lblnombre_empleado.Location = new System.Drawing.Point(76, 3);
            this.lblnombre_empleado.Name = "lblnombre_empleado";
            this.lblnombre_empleado.Size = new System.Drawing.Size(56, 13);
            this.lblnombre_empleado.TabIndex = 1;
            this.lblnombre_empleado.Text = "-  Nombre ";
            // 
            // cbosubsidio
            // 
            this.cbosubsidio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosubsidio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosubsidio.FormattingEnabled = true;
            this.cbosubsidio.Items.AddRange(new object[] {
            "Elemento1",
            "Elemento2",
            "Elemento3",
            "LICENCIA Y OTROS MOTIVOS CON GOCE DE HABER"});
            this.cbosubsidio.Location = new System.Drawing.Point(4, 25);
            this.cbosubsidio.Name = "cbosubsidio";
            this.cbosubsidio.Size = new System.Drawing.Size(300, 24);
            this.cbosubsidio.TabIndex = 2;
            this.cbosubsidio.SelectedIndexChanged += new System.EventHandler(this.cbosubsidio_SelectedIndexChanged);
            // 
            // dgvsubsidio
            // 
            this.dgvsubsidio.AllowUserToAddRows = false;
            this.dgvsubsidio.AllowUserToResizeColumns = false;
            this.dgvsubsidio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvsubsidio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsubsidio.BackgroundColor = System.Drawing.Color.White;
            this.dgvsubsidio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsubsidio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvsubsidio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsubsidio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsubsidio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubsidio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsupension,
            this.canti_dias,
            this.modificar,
            this.eliminar,
            this.id_dsubsidio,
            this.cod_subsidio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsubsidio.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsubsidio.EnableHeadersVisualStyles = false;
            this.dgvsubsidio.Location = new System.Drawing.Point(4, 45);
            this.dgvsubsidio.Name = "dgvsubsidio";
            this.dgvsubsidio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvsubsidio.RowHeadersVisible = false;
            this.dgvsubsidio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvsubsidio.Size = new System.Drawing.Size(462, 150);
            this.dgvsubsidio.TabIndex = 3;
            this.dgvsubsidio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsubsidio_CellClick);
            this.dgvsubsidio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsubsidio_CellContentClick);
            this.dgvsubsidio.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvsubsidio_EditingControlShowing);
            // 
            // tsupension
            // 
            this.tsupension.DataPropertyName = "Descrip_corta";
            this.tsupension.HeaderText = "Tipo de suspensión";
            this.tsupension.Name = "tsupension";
            this.tsupension.Width = 300;
            // 
            // canti_dias
            // 
            this.canti_dias.DataPropertyName = "Dias";
            this.canti_dias.HeaderText = "Cantidad de dias";
            this.canti_dias.Name = "canti_dias";
            this.canti_dias.Width = 60;
            // 
            // modificar
            // 
            this.modificar.Description = "Modificar";
            this.modificar.HeaderText = "Editar";
            this.modificar.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modificar.Width = 50;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::Presentacion.Properties.Resources.delete18p;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Width = 50;
            // 
            // id_dsubsidio
            // 
            this.id_dsubsidio.DataPropertyName = "Id_det_subsidios";
            this.id_dsubsidio.HeaderText = "ID";
            this.id_dsubsidio.Name = "id_dsubsidio";
            this.id_dsubsidio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_dsubsidio.Width = 50;
            // 
            // cod_subsidio
            // 
            this.cod_subsidio.DataPropertyName = "Codigo_subsidio";
            this.cod_subsidio.HeaderText = "CODSU";
            this.cod_subsidio.Name = "cod_subsidio";
            this.cod_subsidio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cod_subsidio.Width = 50;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(305, 26);
            this.txtdias.MaxLength = 2;
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(60, 20);
            this.txtdias.TabIndex = 4;
            this.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdias_KeyPress);
            this.txtdias.Validating += new System.ComponentModel.CancelEventHandler(this.txtdias_Validating);
            // 
            // btngrabar
            // 
            this.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabar.Location = new System.Drawing.Point(365, 25);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(50, 22);
            this.btngrabar.TabIndex = 5;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblvacaciones);
            this.panel1.Controls.Add(this.lbltotalSi);
            this.panel1.Controls.Add(this.lbltotalSp);
            this.panel1.Controls.Add(this.txtdias);
            this.panel1.Controls.Add(this.txttotaldias);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.lblcodigo_empledo);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.lblnombre_empleado);
            this.panel1.Controls.Add(this.btngrabar);
            this.panel1.Controls.Add(this.dgvsubsidio);
            this.panel1.Controls.Add(this.cbosubsidio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 243);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblvacaciones
            // 
            this.lblvacaciones.AutoSize = true;
            this.lblvacaciones.Location = new System.Drawing.Point(126, 218);
            this.lblvacaciones.Name = "lblvacaciones";
            this.lblvacaciones.Size = new System.Drawing.Size(31, 13);
            this.lblvacaciones.TabIndex = 10;
            this.lblvacaciones.Text = "vaca";
            this.lblvacaciones.Visible = false;
            // 
            // lbltotalSi
            // 
            this.lbltotalSi.AutoSize = true;
            this.lbltotalSi.Location = new System.Drawing.Point(177, 218);
            this.lbltotalSi.Name = "lbltotalSi";
            this.lbltotalSi.Size = new System.Drawing.Size(10, 13);
            this.lbltotalSi.TabIndex = 9;
            this.lbltotalSi.Text = ".";
            this.lbltotalSi.Visible = false;
            // 
            // lbltotalSp
            // 
            this.lbltotalSp.AutoSize = true;
            this.lbltotalSp.Location = new System.Drawing.Point(177, 200);
            this.lbltotalSp.Name = "lbltotalSp";
            this.lbltotalSp.Size = new System.Drawing.Size(10, 13);
            this.lbltotalSp.TabIndex = 9;
            this.lbltotalSp.Text = ".";
            this.lbltotalSp.Visible = false;
            // 
            // txttotaldias
            // 
            this.txttotaldias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotaldias.Enabled = false;
            this.txttotaldias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldias.Location = new System.Drawing.Point(304, 210);
            this.txttotaldias.Multiline = true;
            this.txttotaldias.Name = "txttotaldias";
            this.txttotaldias.Size = new System.Drawing.Size(60, 20);
            this.txttotaldias.TabIndex = 8;
            this.txttotaldias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Modificar";
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.delete2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDiasSubsidiados2_FormClosing);
            this.Load += new System.EventHandler(this.FrmDiasSubsidiados2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbosubsidio;
        private System.Windows.Forms.DataGridView dgvsubsidio;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotaldias;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsupension;
        private System.Windows.Forms.DataGridViewTextBoxColumn canti_dias;
        private System.Windows.Forms.DataGridViewImageColumn modificar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dsubsidio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_subsidio;
        private System.Windows.Forms.Label lbltotalSi;
        private System.Windows.Forms.Label lbltotalSp;
        private System.Windows.Forms.Label lblvacaciones;
        public System.Windows.Forms.Label lblcodigo_empledo;
        public System.Windows.Forms.Label lblnombre_empleado;
    }
}