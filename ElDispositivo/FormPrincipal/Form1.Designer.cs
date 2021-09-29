
namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAppNoInstaladas = new System.Windows.Forms.RichTextBox();
            this.rtbAppInstaladas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAppNoInstaladas
            // 
            this.rtbAppNoInstaladas.Location = new System.Drawing.Point(383, 44);
            this.rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            this.rtbAppNoInstaladas.Size = new System.Drawing.Size(294, 518);
            this.rtbAppNoInstaladas.TabIndex = 0;
            this.rtbAppNoInstaladas.Text = "";
            // 
            // rtbAppInstaladas
            // 
            this.rtbAppInstaladas.Location = new System.Drawing.Point(46, 44);
            this.rtbAppInstaladas.Name = "rtbAppInstaladas";
            this.rtbAppInstaladas.Size = new System.Drawing.Size(294, 518);
            this.rtbAppInstaladas.TabIndex = 1;
            this.rtbAppInstaladas.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(726, 623);
            this.Controls.Add(this.rtbAppInstaladas);
            this.Controls.Add(this.rtbAppNoInstaladas);
            this.Name = "Form1";
            this.Text = "Primer parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAppNoInstaladas;
        private System.Windows.Forms.RichTextBox rtbAppInstaladas;
    }
}

