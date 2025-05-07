namespace CookMe.Views.VistasProducto
{
    partial class Carrito
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 479);
            this.panel1.TabIndex = 0;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = global::CookMe.Properties.Resources.atras;
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 25);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 16;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb1.Location = new System.Drawing.Point(126, 26);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(225, 41);
            this.lb1.TabIndex = 27;
            this.lb1.Text = "Carrito Actual";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 528);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(881, 575);
            this.MinimumSize = new System.Drawing.Size(881, 575);
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.Label lb1;
    }
}