namespace CookMe.Views.Login
{
    partial class Login
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
            this.lbInfoEmail = new System.Windows.Forms.Label();
            this.lbInfoContrasena = new System.Windows.Forms.Label();
            this.lbErrorCredenciales = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.tbContrasenaLogin = new System.Windows.Forms.TextBox();
            this.botonImagen2 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.btBorrarCamposLogin1 = new CustomButton();
            this.btAccederLogin1 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfoEmail
            // 
            this.lbInfoEmail.AutoSize = true;
            this.lbInfoEmail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbInfoEmail.Location = new System.Drawing.Point(69, 268);
            this.lbInfoEmail.Name = "lbInfoEmail";
            this.lbInfoEmail.Size = new System.Drawing.Size(59, 21);
            this.lbInfoEmail.TabIndex = 4;
            this.lbInfoEmail.Text = "EMAIL";
            // 
            // lbInfoContrasena
            // 
            this.lbInfoContrasena.AutoSize = true;
            this.lbInfoContrasena.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoContrasena.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbInfoContrasena.Location = new System.Drawing.Point(49, 321);
            this.lbInfoContrasena.Name = "lbInfoContrasena";
            this.lbInfoContrasena.Size = new System.Drawing.Size(116, 21);
            this.lbInfoContrasena.TabIndex = 5;
            this.lbInfoContrasena.Text = "CONTRASEÑA";
            // 
            // lbErrorCredenciales
            // 
            this.lbErrorCredenciales.AutoSize = true;
            this.lbErrorCredenciales.Location = new System.Drawing.Point(128, 364);
            this.lbErrorCredenciales.Name = "lbErrorCredenciales";
            this.lbErrorCredenciales.Size = new System.Drawing.Size(0, 16);
            this.lbErrorCredenciales.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 222);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Location = new System.Drawing.Point(184, 267);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(193, 22);
            this.tbEmailLogin.TabIndex = 13;
            // 
            // tbContrasenaLogin
            // 
            this.tbContrasenaLogin.Location = new System.Drawing.Point(184, 319);
            this.tbContrasenaLogin.Name = "tbContrasenaLogin";
            this.tbContrasenaLogin.PasswordChar = '*';
            this.tbContrasenaLogin.Size = new System.Drawing.Size(193, 22);
            this.tbContrasenaLogin.TabIndex = 14;
            // 
            // botonImagen2
            // 
            this.botonImagen2.ButtonImage = global::CookMe.Properties.Resources.ojo1;
            this.botonImagen2.CornerRadius = 20;
            this.botonImagen2.Location = new System.Drawing.Point(402, 319);
            this.botonImagen2.Name = "botonImagen2";
            this.botonImagen2.Size = new System.Drawing.Size(77, 23);
            this.botonImagen2.TabIndex = 10;
            this.botonImagen2.Text = "botonImagen2";
            this.botonImagen2.UseVisualStyleBackColor = true;
            this.botonImagen2.Click += new System.EventHandler(this.botonImagen2_Click);
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = global::CookMe.Properties.Resources.atras;
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 22);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 8;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // btBorrarCamposLogin1
            // 
            this.btBorrarCamposLogin1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btBorrarCamposLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrarCamposLogin1.ForeColor = System.Drawing.Color.Black;
            this.btBorrarCamposLogin1.Location = new System.Drawing.Point(120, 394);
            this.btBorrarCamposLogin1.Name = "btBorrarCamposLogin1";
            this.btBorrarCamposLogin1.Size = new System.Drawing.Size(120, 40);
            this.btBorrarCamposLogin1.TabIndex = 15;
            this.btBorrarCamposLogin1.Text = "Borrar";
            this.btBorrarCamposLogin1.UseVisualStyleBackColor = false;
            this.btBorrarCamposLogin1.Click += new System.EventHandler(this.btBorrarCamposLogin1_Click);
            // 
            // btAccederLogin1
            // 
            this.btAccederLogin1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btAccederLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAccederLogin1.ForeColor = System.Drawing.Color.Black;
            this.btAccederLogin1.Location = new System.Drawing.Point(298, 394);
            this.btAccederLogin1.Name = "btAccederLogin1";
            this.btAccederLogin1.Size = new System.Drawing.Size(120, 40);
            this.btAccederLogin1.TabIndex = 16;
            this.btAccederLogin1.Text = "Acceder";
            this.btAccederLogin1.UseVisualStyleBackColor = false;
            this.btAccederLogin1.Click += new System.EventHandler(this.btAccederLogin1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 456);
            this.Controls.Add(this.btAccederLogin1);
            this.Controls.Add(this.btBorrarCamposLogin1);
            this.Controls.Add(this.tbContrasenaLogin);
            this.Controls.Add(this.tbEmailLogin);
            this.Controls.Add(this.botonImagen2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.lbErrorCredenciales);
            this.Controls.Add(this.lbInfoContrasena);
            this.Controls.Add(this.lbInfoEmail);
            this.MaximumSize = new System.Drawing.Size(532, 503);
            this.MinimumSize = new System.Drawing.Size(532, 503);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfoEmail;
        private System.Windows.Forms.Label lbInfoContrasena;
        private System.Windows.Forms.Label lbErrorCredenciales;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesPersonalizados.BotonImagen botonImagen2;
        private System.Windows.Forms.TextBox tbEmailLogin;
        private System.Windows.Forms.TextBox tbContrasenaLogin;
        private CustomButton btBorrarCamposLogin1;
        private CustomButton btAccederLogin1;
    }
}