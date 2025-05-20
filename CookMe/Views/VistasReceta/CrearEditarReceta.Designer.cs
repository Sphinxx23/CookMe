namespace CookMe.Views.VistasReceta
{
    partial class CrearEditarReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEditarReceta));
            this.pbFotoTematica = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbIngredientes = new System.Windows.Forms.Label();
            this.lbPasos = new System.Windows.Forms.Label();
            this.btBorrarR = new System.Windows.Forms.Button();
            this.btGuardarR = new CustomButton();
            this.tbIngredientes = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.tbDescripcion = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.tbPasos = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.botonImagen2 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.tbTitulo = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoTematica)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoTematica
            // 
            this.pbFotoTematica.Location = new System.Drawing.Point(81, 54);
            this.pbFotoTematica.Name = "pbFotoTematica";
            this.pbFotoTematica.Size = new System.Drawing.Size(218, 186);
            this.pbFotoTematica.TabIndex = 0;
            this.pbFotoTematica.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTitulo.Location = new System.Drawing.Point(355, 44);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(79, 24);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "TÍTULO";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDescripcion.Location = new System.Drawing.Point(316, 98);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(191, 24);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "BREVE DESCRIPCIÓN";
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.AutoSize = true;
            this.lbIngredientes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngredientes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbIngredientes.Location = new System.Drawing.Point(83, 291);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(148, 24);
            this.lbIngredientes.TabIndex = 6;
            this.lbIngredientes.Text = "INGREDIENTES";
            // 
            // lbPasos
            // 
            this.lbPasos.AutoSize = true;
            this.lbPasos.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPasos.Location = new System.Drawing.Point(330, 194);
            this.lbPasos.Name = "lbPasos";
            this.lbPasos.Size = new System.Drawing.Size(159, 24);
            this.lbPasos.TabIndex = 7;
            this.lbPasos.Text = "PASOS A SEGUIR";
            // 
            // btBorrarR
            // 
            this.btBorrarR.BackColor = System.Drawing.Color.LightCoral;
            this.btBorrarR.Location = new System.Drawing.Point(894, 480);
            this.btBorrarR.Name = "btBorrarR";
            this.btBorrarR.Size = new System.Drawing.Size(121, 40);
            this.btBorrarR.TabIndex = 13;
            this.btBorrarR.Text = "Borrar Todo";
            this.btBorrarR.UseVisualStyleBackColor = false;
            this.btBorrarR.Click += new System.EventHandler(this.btBorrarR_Click);
            // 
            // btGuardarR
            // 
            this.btGuardarR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btGuardarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarR.ForeColor = System.Drawing.Color.Black;
            this.btGuardarR.Location = new System.Drawing.Point(1058, 480);
            this.btGuardarR.Name = "btGuardarR";
            this.btGuardarR.Size = new System.Drawing.Size(120, 40);
            this.btGuardarR.TabIndex = 12;
            this.btGuardarR.Text = "Guardar";
            this.btGuardarR.UseVisualStyleBackColor = false;
            this.btGuardarR.Click += new System.EventHandler(this.btGuardarR_Click);
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.AutoScroll = true;
            this.tbIngredientes.BorderColor = System.Drawing.Color.Blue;
            this.tbIngredientes.BorderRadius = 15;
            this.tbIngredientes.Location = new System.Drawing.Point(30, 320);
            this.tbIngredientes.Multiline = true;
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Padding = new System.Windows.Forms.Padding(10);
            this.tbIngredientes.PasswordChar = '\0';
            this.tbIngredientes.Size = new System.Drawing.Size(269, 200);
            this.tbIngredientes.TabIndex = 11;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderColor = System.Drawing.Color.Blue;
            this.tbDescripcion.BorderRadius = 15;
            this.tbDescripcion.Location = new System.Drawing.Point(526, 98);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Padding = new System.Windows.Forms.Padding(10);
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.Size = new System.Drawing.Size(652, 74);
            this.tbDescripcion.TabIndex = 9;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = global::CookMe.Properties.Resources.imagen;
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(156, 246);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(75, 23);
            this.botonImagen1.TabIndex = 1;
            this.botonImagen1.Text = "btAgregarImagen";
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // tbPasos
            // 
            this.tbPasos.BorderColor = System.Drawing.Color.Blue;
            this.tbPasos.BorderRadius = 15;
            this.tbPasos.Location = new System.Drawing.Point(348, 227);
            this.tbPasos.Multiline = true;
            this.tbPasos.Name = "tbPasos";
            this.tbPasos.Padding = new System.Windows.Forms.Padding(10);
            this.tbPasos.PasswordChar = '\0';
            this.tbPasos.Size = new System.Drawing.Size(830, 239);
            this.tbPasos.TabIndex = 14;
            // 
            // botonImagen2
            // 
            this.botonImagen2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("botonImagen2.ButtonImage")));
            this.botonImagen2.CornerRadius = 20;
            this.botonImagen2.Location = new System.Drawing.Point(14, 26);
            this.botonImagen2.Name = "botonImagen2";
            this.botonImagen2.Size = new System.Drawing.Size(61, 42);
            this.botonImagen2.TabIndex = 29;
            this.botonImagen2.UseVisualStyleBackColor = true;
            this.botonImagen2.Click += new System.EventHandler(this.botonImagen2_Click);
            // 
            // tbTitulo
            // 
            this.tbTitulo.BorderColor = System.Drawing.Color.Blue;
            this.tbTitulo.BorderRadius = 15;
            this.tbTitulo.Location = new System.Drawing.Point(526, 35);
            this.tbTitulo.Multiline = true;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Padding = new System.Windows.Forms.Padding(10);
            this.tbTitulo.PasswordChar = '\0';
            this.tbTitulo.Size = new System.Drawing.Size(652, 49);
            this.tbTitulo.TabIndex = 30;
            // 
            // CrearEditarReceta
            // 
            this.AcceptButton = this.btGuardarR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 519);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.botonImagen2);
            this.Controls.Add(this.tbPasos);
            this.Controls.Add(this.btBorrarR);
            this.Controls.Add(this.btGuardarR);
            this.Controls.Add(this.tbIngredientes);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lbPasos);
            this.Controls.Add(this.lbIngredientes);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.pbFotoTematica);
            this.MaximumSize = new System.Drawing.Size(1273, 566);
            this.MinimumSize = new System.Drawing.Size(1273, 566);
            this.Name = "CrearEditarReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearEditarReceta";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoTematica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotoTematica;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbIngredientes;
        private System.Windows.Forms.Label lbPasos;
        private ControlesPersonalizados.TextBoxRedondeado tbDescripcion;
        private ControlesPersonalizados.TextBoxRedondeado tbIngredientes;
        private CustomButton btGuardarR;
        private System.Windows.Forms.Button btBorrarR;
        private ControlesPersonalizados.TextBoxRedondeado tbPasos;
        private ControlesPersonalizados.BotonImagen botonImagen2;
        private ControlesPersonalizados.TextBoxRedondeado tbTitulo;
    }
}