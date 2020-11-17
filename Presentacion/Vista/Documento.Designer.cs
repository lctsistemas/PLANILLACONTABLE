namespace Presentacion.Vista
{
    partial class frmdocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvdocumento = new System.Windows.Forms.DataGridView();
            this.paneldocumento = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcoddoc = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocumento)).BeginInit();
            this.paneldocumento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbuscar.Location = new System.Drawing.Point(37, 281);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(359, 23);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // dgvdocumento
            // 
            this.dgvdocumento.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvdocumento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdocumento.BackgroundColor = System.Drawing.Color.White;
            this.dgvdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdocumento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvdocumento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvdocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdocumento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdocumento.Location = new System.Drawing.Point(8, 310);
            this.dgvdocumento.Name = "dgvdocumento";
            this.dgvdocumento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvdocumento.RowHeadersWidth = 25;
            this.dgvdocumento.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvdocumento.Size = new System.Drawing.Size(388, 200);
            this.dgvdocumento.TabIndex = 0;
            this.dgvdocumento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdocumento_CellDoubleClick);
            // 
            // paneldocumento
            // 
            this.paneldocumento.BackColor = System.Drawing.Color.White;
            this.paneldocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldocumento.Controls.Add(this.groupBox1);
            this.paneldocumento.Controls.Add(this.pictureBox1);
            this.paneldocumento.Controls.Add(this.barraTitulo);
            this.paneldocumento.Controls.Add(this.dgvdocumento);
            this.paneldocumento.Controls.Add(this.txtbuscar);
            this.paneldocumento.Controls.Add(this.lbltotal);
            this.paneldocumento.Controls.Add(this.btnnuevo);
            this.paneldocumento.Controls.Add(this.btneliminar);
            this.paneldocumento.Controls.Add(this.btnguardar);
            this.paneldocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldocumento.Location = new System.Drawing.Point(0, 0);
            this.paneldocumento.Name = "paneldocumento";
            this.paneldocumento.Size = new System.Drawing.Size(409, 539);
            this.paneldocumento.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtcoddoc);
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 196);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Codigo Documento";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(118, 123);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescripcion.Size = new System.Drawing.Size(189, 53);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtcoddoc
            // 
            this.txtcoddoc.Location = new System.Drawing.Point(118, 40);
            this.txtcoddoc.Name = "txtcoddoc";
            this.txtcoddoc.Size = new System.Drawing.Size(105, 23);
            this.txtcoddoc.TabIndex = 7;
            this.txtcoddoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcoddoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtcoddoc_Validating);
            this.txtcoddoc.Validated += new System.EventHandler(this.txtcoddoc_Validated);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(118, 83);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(189, 22);
            this.txtdocumento.TabIndex = 4;
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            this.txtdocumento.Validating += new System.ComponentModel.CancelEventHandler(this.txtdocumento_Validating);
            this.txtdocumento.Validated += new System.EventHandler(this.txtdocumento_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.loupe_78956__1_;
            this.pictureBox1.Location = new System.Drawing.Point(8, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.barraTitulo.Controls.Add(this.btnmaximizar);
            this.barraTitulo.Controls.Add(this.btnminimizar);
            this.barraTitulo.Controls.Add(this.btncerrar);
            this.barraTitulo.Controls.Add(this.label4);
            this.barraTitulo.Controls.Add(this.btnrestaurar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(407, 40);
            this.barraTitulo.TabIndex = 8;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = global::Presentacion.Properties.Resources.baseline_check_box_outline_blank_white_36dp;
            this.btnmaximizar.Location = new System.Drawing.Point(337, 6);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(33, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 2;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Presentacion.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(303, 7);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(33, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_36dp1;
            this.btncerrar.Location = new System.Drawing.Point(371, 7);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Padding = new System.Windows.Forms.Padding(3);
            this.btncerrar.Size = new System.Drawing.Size(33, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 2;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseDown);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            this.btncerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncerrar_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIPO DE DOCUMENTO";
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = global::Presentacion.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(337, 7);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(33, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltotal.Location = new System.Drawing.Point(237, 513);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(39, 17);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.baseline_add_white_24dp;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(108, 46);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(99, 27);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_24dp;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(213, 46);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(99, 27);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.btnguardar.Location = new System.Drawing.Point(5, 46);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(99, 27);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmdocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 539);
            this.Controls.Add(this.paneldocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmdocumento";
            this.Text = "TIPO DE DOCUMENTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdocumento_FormClosing);
            this.Load += new System.EventHandler(this.frmdocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocumento)).EndInit();
            this.paneldocumento.ResumeLayout(false);
            this.paneldocumento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvdocumento;
        private System.Windows.Forms.Panel paneldocumento;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.TextBox txtcoddoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}