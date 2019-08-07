namespace Historieta
{
    partial class frmHistorieta
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
            this.SuspendLayout();
            // 
            // frmHistorieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(141)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistorieta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historieta";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(141)))), ((int)(((byte)(142)))));
            this.Load += new System.EventHandler(this.frmHistorieta_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHistorieta_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

