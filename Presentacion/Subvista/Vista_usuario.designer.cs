namespace Presentacion.Subvista
{
    partial class frmvista_usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictbuscar = new System.Windows.Forms.PictureBox();
            this.dgvvista_user = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 73;
            this.lineShape1.X2 = 412;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 42;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictbuscar);
            this.panel1.Controls.Add(this.dgvvista_user);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.lblcantidad);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 388);
            this.panel1.TabIndex = 9;
            // 
            // pictbuscar
            // 
            this.pictbuscar.Image = global::Presentacion.Properties.Resources.loupe_78956__1_;
            this.pictbuscar.Location = new System.Drawing.Point(34, 21);
            this.pictbuscar.Name = "pictbuscar";
            this.pictbuscar.Size = new System.Drawing.Size(35, 21);
            this.pictbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbuscar.TabIndex = 8;
            this.pictbuscar.TabStop = false;
            // 
            // dgvvista_user
            // 
            this.dgvvista_user.AllowUserToAddRows = false;
            this.dgvvista_user.AllowUserToDeleteRows = false;
            this.dgvvista_user.AllowUserToResizeColumns = false;
            this.dgvvista_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvvista_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvvista_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvvista_user.BackgroundColor = System.Drawing.Color.White;
            this.dgvvista_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvista_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvvista_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvista_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvvista_user.ColumnHeadersHeight = 35;
            this.dgvvista_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvista_user.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvvista_user.EnableHeadersVisualStyles = false;
            this.dgvvista_user.Location = new System.Drawing.Point(7, 70);
            this.dgvvista_user.MultiSelect = false;
            this.dgvvista_user.Name = "dgvvista_user";
            this.dgvvista_user.ReadOnly = true;
            this.dgvvista_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvista_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvvista_user.RowHeadersWidth = 25;
            this.dgvvista_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvvista_user.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvvista_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvista_user.Size = new System.Drawing.Size(757, 311);
            this.dgvvista_user.TabIndex = 1;
            this.dgvvista_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvista_user_CellDoubleClick);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncerrar.Location = new System.Drawing.Point(739, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "X";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblcantidad.Location = new System.Drawing.Point(40, 50);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(38, 17);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = "cant";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.White;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.Location = new System.Drawing.Point(75, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(334, 19);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.WordWrap = false;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(775, 386);
            this.shapeContainer2.TabIndex = 9;
            this.shapeContainer2.TabStop = false;
            // 
            // frmvista_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 388);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmvista_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VISTA USUARIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmvista_usuario_FormClosing);
            this.Load += new System.EventHandler(this.frmvista_usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictbuscar;
        private System.Windows.Forms.DataGridView dgvvista_user;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtbuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}