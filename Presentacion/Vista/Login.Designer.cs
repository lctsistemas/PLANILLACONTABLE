namespace Presentacion.Vista
{
    partial class frmloin
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
            this.panellogin = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnempresa = new System.Windows.Forms.Button();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnusuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.SteelBlue;
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogin.Location = new System.Drawing.Point(0, 0);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(714, 50);
            this.panellogin.TabIndex = 0;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(73, 104);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(175, 97);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa";
            // 
            // btnempresa
            // 
            this.btnempresa.Location = new System.Drawing.Point(294, 170);
            this.btnempresa.Name = "btnempresa";
            this.btnempresa.Size = new System.Drawing.Size(33, 23);
            this.btnempresa.TabIndex = 4;
            this.btnempresa.UseVisualStyleBackColor = true;
            this.btnempresa.Click += new System.EventHandler(this.btnempresa_Click);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(175, 173);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(100, 20);
            this.txtempresa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(294, 94);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(33, 23);
            this.btnusuario.TabIndex = 4;
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // frmloin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 401);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnempresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.panellogin);
            this.Name = "frmloin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnempresa;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnusuario;
    }
}