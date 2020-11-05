namespace Presentacion.Vista
{
    partial class Banco2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotalSi = new System.Windows.Forms.Label();
            this.lbltotalSp = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.txttotaldias = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.dgvsubsidio = new System.Windows.Forms.DataGridView();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cod_subsidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dsubsidio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.canti_dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsupension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbltotalSi);
            this.panel1.Controls.Add(this.lbltotalSp);
            this.panel1.Controls.Add(this.txtdias);
            this.panel1.Controls.Add(this.txttotaldias);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btngrabar);
            this.panel1.Controls.Add(this.dgvsubsidio);
            this.panel1.Controls.Add(this.cboBanco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 237);
            this.panel1.TabIndex = 8;
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
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(305, 26);
            this.txtdias.MaxLength = 2;
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(60, 20);
            this.txtdias.TabIndex = 4;
            this.txtdias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo - dni";
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
            // btngrabar
            // 
            this.btngrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrabar.Location = new System.Drawing.Point(365, 25);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(50, 22);
            this.btngrabar.TabIndex = 5;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // dgvsubsidio
            // 
            this.dgvsubsidio.AllowUserToAddRows = false;
            this.dgvsubsidio.AllowUserToResizeColumns = false;
            this.dgvsubsidio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsubsidio.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvsubsidio.EnableHeadersVisualStyles = false;
            this.dgvsubsidio.Location = new System.Drawing.Point(2, 47);
            this.dgvsubsidio.Name = "dgvsubsidio";
            this.dgvsubsidio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvsubsidio.RowHeadersVisible = false;
            this.dgvsubsidio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvsubsidio.Size = new System.Drawing.Size(463, 150);
            this.dgvsubsidio.TabIndex = 3;
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Items.AddRange(new object[] {
            "Elemento1",
            "Elemento2",
            "Elemento3",
            "LICENCIA Y OTROS MOTIVOS CON GOCE DE HABER"});
            this.cboBanco.Location = new System.Drawing.Point(2, 25);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(297, 24);
            this.cboBanco.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Modificar";
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.delete18p;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // cod_subsidio
            // 
            this.cod_subsidio.DataPropertyName = "Codigo_subsidio";
            this.cod_subsidio.HeaderText = "CODSU";
            this.cod_subsidio.Name = "cod_subsidio";
            this.cod_subsidio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cod_subsidio.Width = 50;
            // 
            // id_dsubsidio
            // 
            this.id_dsubsidio.DataPropertyName = "Id_det_subsidios";
            this.id_dsubsidio.HeaderText = "ID";
            this.id_dsubsidio.Name = "id_dsubsidio";
            this.id_dsubsidio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_dsubsidio.Width = 50;
            // 
            // eliminar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle6;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::Presentacion.Properties.Resources.delete18p;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Width = 50;
            // 
            // modificar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.modificar.DefaultCellStyle = dataGridViewCellStyle5;
            this.modificar.Description = "Modificar";
            this.modificar.HeaderText = "Editar";
            this.modificar.Image = global::Presentacion.Properties.Resources.baseline_edit_black_18dp;
            this.modificar.Name = "modificar";
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modificar.Width = 50;
            // 
            // canti_dias
            // 
            this.canti_dias.DataPropertyName = "Dias";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canti_dias.DefaultCellStyle = dataGridViewCellStyle4;
            this.canti_dias.HeaderText = "Cantidad de dias";
            this.canti_dias.Name = "canti_dias";
            this.canti_dias.Width = 60;
            // 
            // tsupension
            // 
            this.tsupension.DataPropertyName = "Descrip_corta";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsupension.DefaultCellStyle = dataGridViewCellStyle3;
            this.tsupension.HeaderText = "Tipo de suspensión";
            this.tsupension.Name = "tsupension";
            this.tsupension.Width = 300;
            // 
            // Banco2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 237);
            this.Controls.Add(this.panel1);
            this.Name = "Banco2";
            this.Text = "Banco2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubsidio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotalSi;
        private System.Windows.Forms.Label lbltotalSp;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.TextBox txttotaldias;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.DataGridView dgvsubsidio;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsupension;
        private System.Windows.Forms.DataGridViewTextBoxColumn canti_dias;
        private System.Windows.Forms.DataGridViewImageColumn modificar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dsubsidio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_subsidio;
    }
}