namespace CookMe.Views.VistaUsuario
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.tbDireccionRegis = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.tbApellidosregis = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.tbNombreRegis = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.btSeleccion = new CustomButton();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.btRegistrar = new CustomButton();
            this.btVaciarCampos1 = new CustomButton();
            this.chbProfesor = new System.Windows.Forms.CheckBox();
            this.lbProfesor = new System.Windows.Forms.Label();
            this.lbErrorEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDireccionRegis
            // 
            this.tbDireccionRegis.BorderColor = System.Drawing.Color.Blue;
            this.tbDireccionRegis.BorderRadius = 15;
            this.tbDireccionRegis.Location = new System.Drawing.Point(164, 555);
            this.tbDireccionRegis.Multiline = true;
            this.tbDireccionRegis.Name = "tbDireccionRegis";
            this.tbDireccionRegis.Padding = new System.Windows.Forms.Padding(10);
            this.tbDireccionRegis.PasswordChar = '\0';
            this.tbDireccionRegis.Size = new System.Drawing.Size(199, 42);
            this.tbDireccionRegis.TabIndex = 41;
            // 
            // tbApellidosregis
            // 
            this.tbApellidosregis.BorderColor = System.Drawing.Color.Blue;
            this.tbApellidosregis.BorderRadius = 15;
            this.tbApellidosregis.Location = new System.Drawing.Point(164, 475);
            this.tbApellidosregis.Multiline = true;
            this.tbApellidosregis.Name = "tbApellidosregis";
            this.tbApellidosregis.Padding = new System.Windows.Forms.Padding(10);
            this.tbApellidosregis.PasswordChar = '\0';
            this.tbApellidosregis.Size = new System.Drawing.Size(199, 42);
            this.tbApellidosregis.TabIndex = 40;
            // 
            // tbNombreRegis
            // 
            this.tbNombreRegis.BorderColor = System.Drawing.Color.Blue;
            this.tbNombreRegis.BorderRadius = 15;
            this.tbNombreRegis.Location = new System.Drawing.Point(164, 394);
            this.tbNombreRegis.Multiline = true;
            this.tbNombreRegis.Name = "tbNombreRegis";
            this.tbNombreRegis.Padding = new System.Windows.Forms.Padding(10);
            this.tbNombreRegis.PasswordChar = '\0';
            this.tbNombreRegis.Size = new System.Drawing.Size(199, 41);
            this.tbNombreRegis.TabIndex = 39;
            // 
            // btSeleccion
            // 
            this.btSeleccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeleccion.ForeColor = System.Drawing.Color.Black;
            this.btSeleccion.Location = new System.Drawing.Point(137, 308);
            this.btSeleccion.Name = "btSeleccion";
            this.btSeleccion.Size = new System.Drawing.Size(161, 37);
            this.btSeleccion.TabIndex = 37;
            this.btSeleccion.Text = "Seleccionar Imagen";
            this.btSeleccion.UseVisualStyleBackColor = false;
            this.btSeleccion.Click += new System.EventHandler(this.btSeleccion_Click);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDireccion.Location = new System.Drawing.Point(34, 567);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(98, 21);
            this.lbDireccion.TabIndex = 36;
            this.lbDireccion.Text = "DIRECCIÓN";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbApellidos.Location = new System.Drawing.Point(34, 486);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(95, 21);
            this.lbApellidos.TabIndex = 35;
            this.lbApellidos.Text = "APELLIDOS";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbNombre.Location = new System.Drawing.Point(43, 403);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 21);
            this.lbNombre.TabIndex = 34;
            this.lbNombre.Text = "NOMBRE";
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.Location = new System.Drawing.Point(100, 33);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(241, 256);
            this.pbFotoPerfil.TabIndex = 32;
            this.pbFotoPerfil.TabStop = false;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("botonImagen1.ButtonImage")));
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 23);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 31;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btRegistrar.Location = new System.Drawing.Point(250, 703);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(132, 40);
            this.btRegistrar.TabIndex = 46;
            this.btRegistrar.Text = "Guardar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btVaciarCampos1
            // 
            this.btVaciarCampos1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btVaciarCampos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVaciarCampos1.ForeColor = System.Drawing.Color.Black;
            this.btVaciarCampos1.Location = new System.Drawing.Point(63, 703);
            this.btVaciarCampos1.Name = "btVaciarCampos1";
            this.btVaciarCampos1.Size = new System.Drawing.Size(135, 40);
            this.btVaciarCampos1.TabIndex = 45;
            this.btVaciarCampos1.Text = "Borrar Todo";
            this.btVaciarCampos1.UseVisualStyleBackColor = false;
            this.btVaciarCampos1.Click += new System.EventHandler(this.btVaciarCampos1_Click);
            // 
            // chbProfesor
            // 
            this.chbProfesor.AutoSize = true;
            this.chbProfesor.Location = new System.Drawing.Point(253, 627);
            this.chbProfesor.Name = "chbProfesor";
            this.chbProfesor.Size = new System.Drawing.Size(18, 17);
            this.chbProfesor.TabIndex = 43;
            this.chbProfesor.UseVisualStyleBackColor = true;
            // 
            // lbProfesor
            // 
            this.lbProfesor.AutoSize = true;
            this.lbProfesor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfesor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbProfesor.Location = new System.Drawing.Point(37, 622);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.Size = new System.Drawing.Size(151, 21);
            this.lbProfesor.TabIndex = 42;
            this.lbProfesor.Text = "¿ERES PROFESOR?";
            // 
            // lbErrorEditar
            // 
            this.lbErrorEditar.AutoSize = true;
            this.lbErrorEditar.Location = new System.Drawing.Point(124, 664);
            this.lbErrorEditar.Name = "lbErrorEditar";
            this.lbErrorEditar.Size = new System.Drawing.Size(0, 16);
            this.lbErrorEditar.TabIndex = 47;
            // 
            // EditarUsuario
            // 
            this.AcceptButton = this.btRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 767);
            this.Controls.Add(this.lbErrorEditar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btVaciarCampos1);
            this.Controls.Add(this.chbProfesor);
            this.Controls.Add(this.lbProfesor);
            this.Controls.Add(this.tbDireccionRegis);
            this.Controls.Add(this.tbApellidosregis);
            this.Controls.Add(this.tbNombreRegis);
            this.Controls.Add(this.btSeleccion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pbFotoPerfil);
            this.Controls.Add(this.botonImagen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.TextBoxRedondeado tbDireccionRegis;
        private ControlesPersonalizados.TextBoxRedondeado tbApellidosregis;
        private ControlesPersonalizados.TextBoxRedondeado tbNombreRegis;
        private CustomButton btSeleccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox pbFotoPerfil;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private CustomButton btRegistrar;
        private CustomButton btVaciarCampos1;
        private System.Windows.Forms.CheckBox chbProfesor;
        private System.Windows.Forms.Label lbProfesor;
        private System.Windows.Forms.Label lbErrorEditar;
    }
}