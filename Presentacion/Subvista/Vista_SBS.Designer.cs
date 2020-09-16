namespace Presentacion.Subvista
{
    partial class Frmvista_sbs
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
            this.webafp = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webafp
            // 
            this.webafp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webafp.Location = new System.Drawing.Point(0, 3);
            this.webafp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webafp.Name = "webafp";
            this.webafp.Size = new System.Drawing.Size(800, 444);
            this.webafp.TabIndex = 1;
            this.webafp.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Frmvista_sbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webafp);
            this.Name = "Frmvista_sbs";
            this.Text = "Vista_SBS";
            this.Load += new System.EventHandler(this.frmvista_sbs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webafp;
    }
}