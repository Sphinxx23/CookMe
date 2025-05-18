namespace CookMe.Views.VistaEliminacion
{
    partial class Eliminacion
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
            this.tbContrasenaLogin = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.btEliminarSi = new CustomButton();
            this.lbErrorCredenciales = new System.Windows.Forms.Label();
            this.lbInfoContrasena = new System.Windows.Forms.Label();
            this.botonImagen2 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbContrasenaLogin
            // 
            this.tbContrasenaLogin.BorderColor = System.Drawing.Color.Blue;
            this.tbContrasenaLogin.BorderRadius = 15;
            this.tbContrasenaLogin.Location = new System.Drawing.Point(148, 273);
            this.tbContrasenaLogin.Multiline = true;
            this.tbContrasenaLogin.Name = "tbContrasenaLogin";
            this.tbContrasenaLogin.Padding = new System.Windows.Forms.Padding(10);
            this.tbContrasenaLogin.PasswordChar = '*';
            this.tbContrasenaLogin.Size = new System.Drawing.Size(205, 43);
            this.tbContrasenaLogin.TabIndex = 34;
            // 
            // btEliminarSi
            // 
            this.btEliminarSi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btEliminarSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminarSi.ForeColor = System.Drawing.Color.Black;
            this.btEliminarSi.Location = new System.Drawing.Point(184, 365);
            this.btEliminarSi.Name = "btEliminarSi";
            this.btEliminarSi.Size = new System.Drawing.Size(120, 40);
            this.btEliminarSi.TabIndex = 32;
            this.btEliminarSi.Text = "Eliminar Cuenta";
            this.btEliminarSi.UseVisualStyleBackColor = false;
            this.btEliminarSi.Click += new System.EventHandler(this.btEliminarSi_Click);
            // 
            // lbErrorCredenciales
            // 
            this.lbErrorCredenciales.AutoSize = true;
            this.lbErrorCredenciales.Location = new System.Drawing.Point(159, 333);
            this.lbErrorCredenciales.Name = "lbErrorCredenciales";
            this.lbErrorCredenciales.Size = new System.Drawing.Size(0, 16);
            this.lbErrorCredenciales.TabIndex = 27;
            // 
            // lbInfoContrasena
            // 
            this.lbInfoContrasena.AutoSize = true;
            this.lbInfoContrasena.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoContrasena.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbInfoContrasena.Location = new System.Drawing.Point(13, 282);
            this.lbInfoContrasena.Name = "lbInfoContrasena";
            this.lbInfoContrasena.Size = new System.Drawing.Size(116, 21);
            this.lbInfoContrasena.TabIndex = 26;
            this.lbInfoContrasena.Text = "CONTRASEÑA";
            // 
            // botonImagen2
            // 
            this.botonImagen2.ButtonImage = global::CookMe.Properties.Resources.ojo1;
            this.botonImagen2.CornerRadius = 20;
            this.botonImagen2.Location = new System.Drawing.Point(359, 273);
            this.botonImagen2.Name = "botonImagen2";
            this.botonImagen2.Size = new System.Drawing.Size(77, 30);
            this.botonImagen2.TabIndex = 30;
            this.botonImagen2.Text = "botonImagen2";
            this.botonImagen2.UseVisualStyleBackColor = true;
            this.botonImagen2.Click += new System.EventHandler(this.botonImagen2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(120, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 222);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = global::CookMe.Properties.Resources.atras;
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 37);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 28;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // Eliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 395);
            this.Controls.Add(this.tbContrasenaLogin);
            this.Controls.Add(this.btEliminarSi);
            this.Controls.Add(this.botonImagen2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.lbErrorCredenciales);
            this.Controls.Add(this.lbInfoContrasena);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(468, 442);
            this.Name = "Eliminacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.TextBoxRedondeado tbContrasenaLogin;
        private CustomButton btEliminarSi;
        private ControlesPersonalizados.BotonImagen botonImagen2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.Label lbErrorCredenciales;
        private System.Windows.Forms.Label lbInfoContrasena;
    }
}