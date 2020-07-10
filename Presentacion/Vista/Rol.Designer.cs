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
            this.tabrol = new System.Windows.Forms.TabControl();
            this.tablista = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.tabgestion = new System.Windows.Forms.TabPage();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            this.tabrol.SuspendLayout();
            this.tablista.SuspendLayout();
            this.tabgestion.SuspendLayout();
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
            this.dgvrol.Location = new System.Drawing.Point(0, 48);
            this.dgvrol.MultiSelect = false;
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.ReadOnly = true;
            this.dgvrol.RowHeadersWidth = 28;
            this.dgvrol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvrol.Size = new System.Drawing.Size(221, 191);
            this.dgvrol.TabIndex = 0;
            this.dgvrol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrol_CellDoubleClick);
            // 
            // tabrol
            // 
            this.tabrol.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabrol.Controls.Add(this.tablista);
            this.tabrol.Controls.Add(this.tabgestion);
            this.tabrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabrol.ItemSize = new System.Drawing.Size(67, 25);
            this.tabrol.Location = new System.Drawing.Point(0, 0);
            this.tabrol.Name = "tabrol";
            this.tabrol.Padding = new System.Drawing.Point(20, 5);
            this.tabrol.SelectedIndex = 0;
            this.tabrol.Size = new System.Drawing.Size(229, 272);
            this.tabrol.TabIndex = 3;
            // 
            // tablista
            // 
            this.tablista.BackColor = System.Drawing.SystemColors.Control;
            this.tablista.Controls.Add(this.btneliminar);
            this.tablista.Controls.Add(this.dgvrol);
            this.tablista.Location = new System.Drawing.Point(4, 29);
            this.tablista.Name = "tablista";
            this.tablista.Size = new System.Drawing.Size(221, 239);
            this.tablista.TabIndex = 0;
            this.tablista.Text = "LISTA ROL";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Presentacion.Properties.Resources.baseline_delete_white_18dp1;
            this.btneliminar.Location = new System.Drawing.Point(164, 6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(44, 35);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // tabgestion
            // 
            this.tabgestion.BackColor = System.Drawing.SystemColors.Control;
            this.tabgestion.Controls.Add(this.label1);
            this.tabgestion.Controls.Add(this.txtrol);
            this.tabgestion.Controls.Add(this.btnsave);
            this.tabgestion.Controls.Add(this.btnnuevo);
            this.tabgestion.Controls.Add(this.label2);
            this.tabgestion.Location = new System.Drawing.Point(4, 29);
            this.tabgestion.Name = "tabgestion";
            this.tabgestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabgestion.Size = new System.Drawing.Size(221, 239);
            this.tabgestion.TabIndex = 1;
            this.tabgestion.Text = "GESTION ROL";
            // 
            // txtrol
            // 
            this.txtrol.BackColor = System.Drawing.SystemColors.Control;
            this.txtrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrol.Location = new System.Drawing.Point(11, 43);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(202, 16);
            this.txtrol.TabIndex = 4;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::Presentacion.Properties.Resources.baseline_save_white_18dp2;
            this.btnsave.Location = new System.Drawing.Point(10, 115);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 43);
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
            this.btnnuevo.Location = new System.Drawing.Point(137, 115);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 43);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registrar Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "__________________________________";
            // 
            // frmrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(229, 272);
            this.Controls.Add(this.tabrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmrol_FormClosing);
            this.Load += new System.EventHandler(this.frmrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            this.tabrol.ResumeLayout(false);
            this.tablista.ResumeLayout(false);
            this.tabgestion.ResumeLayout(false);
            this.tabgestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrol;
        private System.Windows.Forms.TabControl tabrol;
        private System.Windows.Forms.TabPage tablista;
        private System.Windows.Forms.TabPage tabgestion;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}