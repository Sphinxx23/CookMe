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
            this.btAccederLogin = new System.Windows.Forms.Button();
            this.btBorrarCamposLogin = new System.Windows.Forms.Button();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.tbContrasenaLogin = new System.Windows.Forms.TextBox();
            this.lbInfoEmail = new System.Windows.Forms.Label();
            this.lbInfoContrasena = new System.Windows.Forms.Label();
            this.lbErrorCredenciales = new System.Windows.Forms.Label();
            this.botonImagen2 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAccederLogin
            // 
            this.btAccederLogin.Location = new System.Drawing.Point(312, 382);
            this.btAccederLogin.Name = "btAccederLogin";
            this.btAccederLogin.Size = new System.Drawing.Size(75, 23);
            this.btAccederLogin.TabIndex = 0;
            this.btAccederLogin.Text = "Acceder";
            this.btAccederLogin.UseVisualStyleBackColor = true;
            this.btAccederLogin.Click += new System.EventHandler(this.btAccederLogin_Click);
            // 
            // btBorrarCamposLogin
            // 
            this.btBorrarCamposLogin.Location = new System.Drawing.Point(160, 382);
            this.btBorrarCamposLogin.Name = "btBorrarCamposLogin";
            this.btBorrarCamposLogin.Size = new System.Drawing.Size(75, 23);
            this.btBorrarCamposLogin.TabIndex = 1;
            this.btBorrarCamposLogin.Text = "Borrar";
            this.btBorrarCamposLogin.UseVisualStyleBackColor = true;
            this.btBorrarCamposLogin.Click += new System.EventHandler(this.btBorrarCamposLogin_Click);
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Location = new System.Drawing.Point(183, 257);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(220, 22);
            this.tbEmailLogin.TabIndex = 2;
            // 
            // tbContrasenaLogin
            // 
            this.tbContrasenaLogin.Location = new System.Drawing.Point(183, 314);
            this.tbContrasenaLogin.Name = "tbContrasenaLogin";
            this.tbContrasenaLogin.PasswordChar = '*';
            this.tbContrasenaLogin.Size = new System.Drawing.Size(220, 22);
            this.tbContrasenaLogin.TabIndex = 3;
            // 
            // lbInfoEmail
            // 
            this.lbInfoEmail.AutoSize = true;
            this.lbInfoEmail.Location = new System.Drawing.Point(62, 257);
            this.lbInfoEmail.Name = "lbInfoEmail";
            this.lbInfoEmail.Size = new System.Drawing.Size(46, 16);
            this.lbInfoEmail.TabIndex = 4;
            this.lbInfoEmail.Text = "EMAIL";
            // 
            // lbInfoContrasena
            // 
            this.lbInfoContrasena.AutoSize = true;
            this.lbInfoContrasena.Location = new System.Drawing.Point(50, 314);
            this.lbInfoContrasena.Name = "lbInfoContrasena";
            this.lbInfoContrasena.Size = new System.Drawing.Size(101, 16);
            this.lbInfoContrasena.TabIndex = 5;
            this.lbInfoContrasena.Text = "CONTRASEÑA";
            // 
            // lbErrorCredenciales
            // 
            this.lbErrorCredenciales.AutoSize = true;
            this.lbErrorCredenciales.Location = new System.Drawing.Point(180, 363);
            this.lbErrorCredenciales.Name = "lbErrorCredenciales";
            this.lbErrorCredenciales.Size = new System.Drawing.Size(0, 16);
            this.lbErrorCredenciales.TabIndex = 6;
            // 
            // botonImagen2
            // 
            this.botonImagen2.ButtonImage = global::CookMe.Properties.Resources.ojo1;
            this.botonImagen2.CornerRadius = 20;
            this.botonImagen2.Location = new System.Drawing.Point(427, 314);
            this.botonImagen2.Name = "botonImagen2";
            this.botonImagen2.Size = new System.Drawing.Size(75, 23);
            this.botonImagen2.TabIndex = 10;
            this.botonImagen2.Text = "botonImagen2";
            this.botonImagen2.UseVisualStyleBackColor = true;
            this.botonImagen2.Click += new System.EventHandler(this.botonImagen2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CookMe.Properties.Resources.CookMe;
            this.pictureBox1.Location = new System.Drawing.Point(92, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 244);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = global::CookMe.Properties.Resources.atras;
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 41);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 8;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 456);
            this.Controls.Add(this.botonImagen2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.lbErrorCredenciales);
            this.Controls.Add(this.lbInfoContrasena);
            this.Controls.Add(this.lbInfoEmail);
            this.Controls.Add(this.tbContrasenaLogin);
            this.Controls.Add(this.tbEmailLogin);
            this.Controls.Add(this.btBorrarCamposLogin);
            this.Controls.Add(this.btAccederLogin);
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

        private System.Windows.Forms.Button btAccederLogin;
        private System.Windows.Forms.Button btBorrarCamposLogin;
        private System.Windows.Forms.TextBox tbEmailLogin;
        private System.Windows.Forms.TextBox tbContrasenaLogin;
        private System.Windows.Forms.Label lbInfoEmail;
        private System.Windows.Forms.Label lbInfoContrasena;
        private System.Windows.Forms.Label lbErrorCredenciales;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesPersonalizados.BotonImagen botonImagen2;
    }
}