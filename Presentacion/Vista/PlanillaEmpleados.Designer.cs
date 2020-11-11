namespace Presentacion.Vista
{
    partial class FrmPlanillaEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvplanilla = new System.Windows.Forms.DataGridView();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnnuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnmodificar = new System.Windows.Forms.ToolStripButton();
            this.tbtneliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtcalculo = new System.Windows.Forms.ToolStripButton();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).BeginInit();
            this.paneltitulo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvplanilla
            // 
            this.dgvplanilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvplanilla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvplanilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvplanilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvplanilla.ColumnHeadersHeight = 30;
            this.dgvplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvplanilla.EnableHeadersVisualStyles = false;
            this.dgvplanilla.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvplanilla.Location = new System.Drawing.Point(8, 77);
            this.dgvplanilla.Name = "dgvplanilla";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvplanilla.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvplanilla.Size = new System.Drawing.Size(799, 378);
            this.dgvplanilla.TabIndex = 89;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Controls.Add(this.label16);
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Controls.Add(this.btnmaximizar);
            this.paneltitulo.Controls.Add(this.btnrestaurar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(818, 40);
            this.paneltitulo.TabIndex = 90;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(7, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "PLANILLA";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnnuevo,
            this.toolStripSeparator1,
            this.tbtnmodificar,
            this.toolStripSeparator2,
            this.tbtneliminar,
            this.toolStripSeparator3,
            this.tbtcalculo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 95;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnnuevo
            // 
            this.tbtnnuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnnuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnnuevo.Image = global::Presentacion.Properties.Resources.agregar;
            this.tbtnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnnuevo.Name = "tbtnnuevo";
            this.tbtnnuevo.Size = new System.Drawing.Size(66, 22);
            this.tbtnnuevo.Text = "&Nuevo";
            this.tbtnnuevo.Click += new System.EventHandler(this.tbtnnuevo_Click);
            // 
            // tbtnmodificar
            // 
            this.tbtnmodificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnmodificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnmodificar.Image = global::Presentacion.Properties.Resources.DocumentEdit_40924;
            this.tbtnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnmodificar.Name = "tbtnmodificar";
            this.tbtnmodificar.Size = new System.Drawing.Size(84, 22);
            this.tbtnmodificar.Text = "&Modificar";
            this.tbtnmodificar.Click += new System.EventHandler(this.tbtnmodificar_Click);
            // 
            // tbtneliminar
            // 
            this.tbtneliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtneliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtneliminar.Image = global::Presentacion.Properties.Resources.borrar;
            this.tbtneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtneliminar.Name = "tbtneliminar";
            this.tbtneliminar.Size = new System.Drawing.Size(74, 22);
            this.tbtneliminar.Text = "&Eliminar";
            this.tbtneliminar.ToolTipText = "Eliminar";
            this.tbtneliminar.Click += new System.EventHandler(this.tbtneliminar_Click);
            // 
            // tbtcalculo
            // 
            this.tbtcalculo.Image = global::Presentacion.Properties.Resources.planilla;
            this.tbtcalculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtcalculo.Name = "tbtcalculo";
            this.tbtcalculo.Size = new System.Drawing.Size(87, 22);
            this.tbtcalculo.Text = "Ir al cálculo";
            this.tbtcalculo.Click += new System.EventHandler(this.tbtcalculo_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp2;
            this.btncerrar.Location = new System.Drawing.Point(778, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Enabled = false;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(707, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp1;
            this.btnmaximizar.Location = new System.Drawing.Point(743, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 10;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(743, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 11;
            this.btnrestaurar.TabStop = false;
            // 
            // FrmPlanillaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.dgvplanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanillaEmpleados";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnrestaurar;
        public System.Windows.Forms.DataGridView dgvplanilla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnnuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnmodificar;
        private System.Windows.Forms.ToolStripButton tbtneliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtcalculo;
    }
}