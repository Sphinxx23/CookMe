namespace CookMe.Views.Landing
{
    partial class LandingAdmin
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
            this.lbBienvenidaAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBienvenidaAdmin
            // 
            this.lbBienvenidaAdmin.AutoSize = true;
            this.lbBienvenidaAdmin.Location = new System.Drawing.Point(270, 70);
            this.lbBienvenidaAdmin.Name = "lbBienvenidaAdmin";
            this.lbBienvenidaAdmin.Size = new System.Drawing.Size(0, 16);
            this.lbBienvenidaAdmin.TabIndex = 0;
            // 
            // LandingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBienvenidaAdmin);
            this.Name = "LandingAdmin";
            this.Text = "LandingAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenidaAdmin;
    }
}