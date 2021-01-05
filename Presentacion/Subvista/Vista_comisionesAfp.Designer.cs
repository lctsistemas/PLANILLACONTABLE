
namespace Presentacion.Subvista
{
    partial class FrmVista_comisionesAfp
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
            this.PanelLista = new System.Windows.Forms.Panel();
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.id_regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncerrar = new System.Windows.Forms.Label();
            this.PanelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLista
            // 
            this.PanelLista.BackColor = System.Drawing.Color.White;
            this.PanelLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLista.Controls.Add(this.btncerrar);
            this.PanelLista.Controls.Add(this.dgvcomision);
            this.PanelLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLista.Location = new System.Drawing.Point(0, 0);
            this.PanelLista.Name = "PanelLista";
            this.PanelLista.Size = new System.Drawing.Size(781, 281);
            this.PanelLista.TabIndex = 1;
            this.PanelLista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLista_MouseDown);
            // 
            // dgvcomision
            // 
            this.dgvcomision.AllowUserToAddRows = false;
            this.dgvcomision.AllowUserToDeleteRows = false;
            this.dgvcomision.AllowUserToResizeColumns = false;
            this.dgvcomision.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvcomision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcomision.BackgroundColor = System.Drawing.Color.White;
            this.dgvcomision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcomision.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvcomision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcomision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcomision.ColumnHeadersHeight = 70;
            this.dgvcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvcomision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_regimen,
            this.afp,
            this.id_comision,
            this.comision,
            this.saldo,
            this.seguro,
            this.aporte,
            this.tope});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcomision.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcomision.EnableHeadersVisualStyles = false;
            this.dgvcomision.GridColor = System.Drawing.Color.Lavender;
            this.dgvcomision.Location = new System.Drawing.Point(2, 31);
            this.dgvcomision.MultiSelect = false;
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.ReadOnly = true;
            this.dgvcomision.RowHeadersVisible = false;
            this.dgvcomision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvcomision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvcomision.Size = new System.Drawing.Size(784, 247);
            this.dgvcomision.TabIndex = 1;
            this.dgvcomision.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvcomision_CellFormatting);
            // 
            // id_regimen
            // 
            this.id_regimen.DataPropertyName = "Codigo_regimen";
            this.id_regimen.HeaderText = "CODIGO REGIMEN";
            this.id_regimen.Name = "id_regimen";
            this.id_regimen.ReadOnly = true;
            // 
            // afp
            // 
            this.afp.DataPropertyName = "descripcion";
            this.afp.HeaderText = "AFP";
            this.afp.Name = "afp";
            this.afp.ReadOnly = true;
            // 
            // id_comision
            // 
            this.id_comision.DataPropertyName = "Id_comision";
            this.id_comision.HeaderText = "ID COMISION";
            this.id_comision.Name = "id_comision";
            this.id_comision.ReadOnly = true;
            // 
            // comision
            // 
            this.comision.DataPropertyName = "Comision";
            this.comision.HeaderText = "COMISION MIXTA Y SOBRE FLUJO";
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            this.comision.Width = 143;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "Saldo";
            this.saldo.HeaderText = "COMISION ANUAL SOBRE SALDO";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 143;
            // 
            // seguro
            // 
            this.seguro.DataPropertyName = "Seguro";
            this.seguro.HeaderText = "PRIMA DE SEGUROS";
            this.seguro.Name = "seguro";
            this.seguro.ReadOnly = true;
            this.seguro.Width = 144;
            // 
            // aporte
            // 
            this.aporte.DataPropertyName = "Aporte";
            this.aporte.HeaderText = "APORTE OBLIGATORIO AL FONDO DE PENSIONES";
            this.aporte.Name = "aporte";
            this.aporte.ReadOnly = true;
            this.aporte.Width = 143;
            // 
            // tope
            // 
            this.tope.DataPropertyName = "Tope";
            this.tope.HeaderText = "REMUNERACION MAXIMA ASEGURABLE";
            this.tope.Name = "tope";
            this.tope.ReadOnly = true;
            this.tope.Width = 143;
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncerrar.Location = new System.Drawing.Point(747, 0);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(33, 30);
            this.btncerrar.TabIndex = 12;
            this.btncerrar.Text = "X";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // FrmVista_comisionesAfp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 281);
            this.Controls.Add(this.PanelLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVista_comisionesAfp";
            this.Text = "Vista Comisiones AFP";
            this.Load += new System.EventHandler(this.FrmVista_comisionesAfp_Load);
            this.PanelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelLista;
        private System.Windows.Forms.DataGridView dgvcomision;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tope;
        private System.Windows.Forms.Label btncerrar;
    }
}