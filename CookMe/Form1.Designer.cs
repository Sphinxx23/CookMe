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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btIS = new System.Windows.Forms.Button();
            this.btRG = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btIS
            // 
            this.btIS.Location = new System.Drawing.Point(102, 299);
            this.btIS.Name = "btIS";
            this.btIS.Size = new System.Drawing.Size(174, 33);
            this.btIS.TabIndex = 0;
            this.btIS.Text = "Iniciar Sesión";
            this.btIS.UseVisualStyleBackColor = true;
            this.btIS.Click += new System.EventHandler(this.btIS_Click);
            // 
            // btRG
            // 
            this.btRG.Location = new System.Drawing.Point(102, 355);
            this.btRG.Name = "btRG";
            this.btRG.Size = new System.Drawing.Size(174, 34);
            this.btRG.TabIndex = 1;
            this.btRG.Text = "Registrarse";
            this.btRG.UseVisualStyleBackColor = true;
            this.btRG.Click += new System.EventHandler(this.btRG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 286);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRG);
            this.Controls.Add(this.btIS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIS;
        private System.Windows.Forms.Button btRG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

