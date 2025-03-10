namespace CookMe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btIS = new CustomButton();
            this.btRG = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 227);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btIS
            // 
            this.btIS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btIS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIS.ForeColor = System.Drawing.Color.Black;
            this.btIS.Location = new System.Drawing.Point(93, 303);
            this.btIS.Name = "btIS";
            this.btIS.Size = new System.Drawing.Size(194, 39);
            this.btIS.TabIndex = 3;
            this.btIS.Text = "Iniciar Sesión";
            this.btIS.UseVisualStyleBackColor = false;
            this.btIS.Click += new System.EventHandler(this.btIS_Click_1);
            // 
            // btRG
            // 
            this.btRG.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btRG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRG.ForeColor = System.Drawing.Color.Black;
            this.btRG.Location = new System.Drawing.Point(93, 365);
            this.btRG.Name = "btRG";
            this.btRG.Size = new System.Drawing.Size(194, 40);
            this.btRG.TabIndex = 4;
            this.btRG.Text = "Registrarse";
            this.btRG.UseVisualStyleBackColor = false;
            this.btRG.Click += new System.EventHandler(this.btRG_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 451);
            this.Controls.Add(this.btRG);
            this.Controls.Add(this.btIS);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(413, 498);
            this.MinimumSize = new System.Drawing.Size(413, 498);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton btIS;
        private CustomButton btRG;
    }
}

