namespace Presentacion.Vista
{
    partial class frmrol
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
            this.dgvrol = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrol
            // 
            this.dgvrol.AllowUserToAddRows = false;
            this.dgvrol.AllowUserToDeleteRows = false;
            this.dgvrol.AllowUserToOrderColumns = true;
            this.dgvrol.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrol.Location = new System.Drawing.Point(281, 118);
            this.dgvrol.MultiSelect = false;
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.ReadOnly = true;
            this.dgvrol.RowHeadersWidth = 28;
            this.dgvrol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvrol.Size = new System.Drawing.Size(162, 132);
            this.dgvrol.TabIndex = 0;
            this.dgvrol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrol_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp1;
            this.btneliminar.Location = new System.Drawing.Point(199, 41);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(44, 35);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registrar Rol";
            // 
            // txtrol
            // 
            this.txtrol.BackColor = System.Drawing.SystemColors.Control;
            this.txtrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrol.Location = new System.Drawing.Point(12, 99);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(202, 16);
            this.txtrol.TabIndex = 4;
            this.txtrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrol_KeyPress);
            this.txtrol.Validating += new System.ComponentModel.CancelEventHandler(this.txtrol_Validating);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp2;
            this.btnsave.Location = new System.Drawing.Point(249, 41);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(44, 35);
            this.btnsave.TabIndex = 3;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Presentacion.Properties.Resources.outline_add_white_18dp1;
            this.btnnuevo.Location = new System.Drawing.Point(218, 86);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(42, 43);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "__________________________________";
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.SlateGray;
            this.panelheader.Controls.Add(this.btncerrar);
            this.panelheader.Controls.Add(this.label3);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(471, 35);
            this.panelheader.TabIndex = 4;
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.baseline_close_white_18dp;
            this.btncerrar.Location = new System.Drawing.Point(436, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Padding = new System.Windows.Forms.Padding(3);
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btncerrar.TabIndex = 3;
            this.btncerrar.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "ROL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvrol);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmrol_FormClosing);
            this.Load += new System.EventHandler(this.frmrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrol;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label3;
    }
}