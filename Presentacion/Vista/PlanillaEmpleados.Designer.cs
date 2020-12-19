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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.toolmenu = new System.Windows.Forms.ToolStrip();
            this.tbtnnuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnmodificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtneliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtcalculo = new System.Windows.Forms.ToolStripButton();
            this.dgvplanilla = new System.Windows.Forms.DataGridView();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.paneltitulo.SuspendLayout();
            this.toolmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.paneltitulo.Controls.Add(this.btnminimizar);
            this.paneltitulo.Controls.Add(this.btnmaximizar);
            this.paneltitulo.Controls.Add(this.btnrestaurar);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Controls.Add(this.label16);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(984, 35);
            this.paneltitulo.TabIndex = 90;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 35);
            this.label16.TabIndex = 0;
            this.label16.Text = "PLANILLA";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolmenu
            // 
            this.toolmenu.BackColor = System.Drawing.Color.White;
            this.toolmenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnnuevo,
            this.toolStripSeparator1,
            this.tbtnmodificar,
            this.toolStripSeparator2,
            this.tbtneliminar,
            this.toolStripSeparator3,
            this.tbtcalculo});
            this.toolmenu.Location = new System.Drawing.Point(0, 35);
            this.toolmenu.Name = "toolmenu";
            this.toolmenu.Padding = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.toolmenu.Size = new System.Drawing.Size(984, 26);
            this.toolmenu.TabIndex = 95;
            this.toolmenu.Text = "toolStrip1";
            // 
            // tbtnnuevo
            // 
            this.tbtnnuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnnuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnnuevo.Image = global::Presentacion.Properties.Resources.agregar;
            this.tbtnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnnuevo.Name = "tbtnnuevo";
            this.tbtnnuevo.Size = new System.Drawing.Size(66, 21);
            this.tbtnnuevo.Text = "&Nuevo";
            this.tbtnnuevo.Click += new System.EventHandler(this.tbtnnuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // tbtnmodificar
            // 
            this.tbtnmodificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnmodificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnmodificar.Image = global::Presentacion.Properties.Resources.DocumentEdit_40924;
            this.tbtnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnmodificar.Name = "tbtnmodificar";
            this.tbtnmodificar.Size = new System.Drawing.Size(84, 21);
            this.tbtnmodificar.Text = "&Modificar";
            this.tbtnmodificar.Click += new System.EventHandler(this.tbtnmodificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // tbtneliminar
            // 
            this.tbtneliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtneliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtneliminar.Image = global::Presentacion.Properties.Resources.borrar;
            this.tbtneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtneliminar.Name = "tbtneliminar";
            this.tbtneliminar.Size = new System.Drawing.Size(74, 21);
            this.tbtneliminar.Text = "&Eliminar";
            this.tbtneliminar.ToolTipText = "Eliminar";
            this.tbtneliminar.Click += new System.EventHandler(this.tbtneliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // tbtcalculo
            // 
            this.tbtcalculo.Image = global::Presentacion.Properties.Resources.planilla;
            this.tbtcalculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtcalculo.Name = "tbtcalculo";
            this.tbtcalculo.Size = new System.Drawing.Size(87, 21);
            this.tbtcalculo.Text = "Ir al cálculo";
            this.tbtcalculo.Click += new System.EventHandler(this.tbtcalculo_Click);
            // 
            // dgvplanilla
            // 
            this.dgvplanilla.AllowUserToAddRows = false;
            this.dgvplanilla.AllowUserToResizeColumns = false;
            this.dgvplanilla.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvplanilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvplanilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvplanilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvplanilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvplanilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvplanilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplanilla.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvplanilla.EnableHeadersVisualStyles = false;
            this.dgvplanilla.Location = new System.Drawing.Point(10, 102);
            this.dgvplanilla.MultiSelect = false;
            this.dgvplanilla.Name = "dgvplanilla";
            this.dgvplanilla.ReadOnly = true;
            this.dgvplanilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvplanilla.RowHeadersVisible = false;
            this.dgvplanilla.RowHeadersWidth = 25;
            this.dgvplanilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvplanilla.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvplanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvplanilla.Size = new System.Drawing.Size(962, 435);
            this.dgvplanilla.TabIndex = 96;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.mi_18dp;
            this.btnminimizar.Location = new System.Drawing.Point(844, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(35, 35);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnminimizar.TabIndex = 16;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            this.btnminimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseDown);
            this.btnminimizar.MouseLeave += new System.EventHandler(this.btnminimizar_MouseLeave);
            this.btnminimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnminimizar_MouseMove);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.maxi_18dp;
            this.btnmaximizar.Location = new System.Drawing.Point(879, 0);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnmaximizar.TabIndex = 17;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Visible = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            this.btnmaximizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnmaximizar_MouseDown);
            this.btnmaximizar.MouseLeave += new System.EventHandler(this.btnmaximizar_MouseLeave);
            this.btnmaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmaximizar_MouseMove);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.restore_18dp;
            this.btnrestaurar.Location = new System.Drawing.Point(914, 0);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnrestaurar.TabIndex = 18;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            this.btnrestaurar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnrestaurar_MouseDown);
            this.btnrestaurar.MouseLeave += new System.EventHandler(this.btnrestaurar_MouseLeave);
            this.btnrestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnrestaurar_MouseMove);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.btncerrar.Location = new System.Drawing.Point(949, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 19;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // FrmPlanillaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 598);
            this.Controls.Add(this.dgvplanilla);
            this.Controls.Add(this.toolmenu);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanillaEmpleados";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.paneltitulo.ResumeLayout(false);
            this.toolmenu.ResumeLayout(false);
            this.toolmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripButton tbtnnuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnmodificar;
        private System.Windows.Forms.ToolStripButton tbtneliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtcalculo;
        private System.Windows.Forms.DataGridView dgvplanilla;
        public System.Windows.Forms.ToolStrip toolmenu;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        protected internal System.Windows.Forms.PictureBox btncerrar;
    }
}