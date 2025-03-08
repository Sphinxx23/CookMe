namespace CookMe.Views.Landing
{
    partial class LandingUsuario
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
            this.lbBienvenidaUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBienvenidaUsuario
            // 
            this.lbBienvenidaUsuario.AutoSize = true;
            this.lbBienvenidaUsuario.Location = new System.Drawing.Point(141, 49);
            this.lbBienvenidaUsuario.Name = "lbBienvenidaUsuario";
            this.lbBienvenidaUsuario.Size = new System.Drawing.Size(0, 16);
            this.lbBienvenidaUsuario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LandingUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBienvenidaUsuario);
            this.Name = "LandingUsuario";
            this.Text = "LandingUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenidaUsuario;
        private System.Windows.Forms.Button button1;
    }
}