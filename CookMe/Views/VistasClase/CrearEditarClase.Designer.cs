namespace CookMe.Views.VistasClase
{
    partial class CrearEditarClase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEditarClase));
            this.btBorrarTodo = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbPlazas = new System.Windows.Forms.Label();
            this.lbProfesor = new System.Windows.Forms.Label();
            this.numPlaza = new System.Windows.Forms.NumericUpDown();
            this.pbImagenTematica = new System.Windows.Forms.PictureBox();
            this.cboxProfesor = new System.Windows.Forms.ComboBox();
            this.tbFecha = new System.Windows.Forms.MaskedTextBox();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.btSeleccionTematica = new CustomButton();
            this.tbDescripcion = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.tbTitulo = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.btCrearClase = new CustomButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPlaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTematica)).BeginInit();
            this.SuspendLayout();
            // 
            // btBorrarTodo
            // 
            this.btBorrarTodo.BackColor = System.Drawing.Color.LightCoral;
            this.btBorrarTodo.Location = new System.Drawing.Point(884, 448);
            this.btBorrarTodo.Name = "btBorrarTodo";
            this.btBorrarTodo.Size = new System.Drawing.Size(121, 40);
            this.btBorrarTodo.TabIndex = 1;
            this.btBorrarTodo.Text = "Borrar Todo";
            this.btBorrarTodo.UseVisualStyleBackColor = false;
            this.btBorrarTodo.Click += new System.EventHandler(this.btBorrarTodo_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTitulo.Location = new System.Drawing.Point(114, 442);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(79, 24);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "TÍTULO";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDescripcion.Location = new System.Drawing.Point(603, 98);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(191, 24);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "DESCRIPCIÓN BREVE";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFecha.Location = new System.Drawing.Point(638, 315);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(66, 24);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "FECHA";
            this.toolTip1.SetToolTip(this.lbFecha, "Formato de fecha: DD-MM-AAAA HH:MM");
            // 
            // lbPlazas
            // 
            this.lbPlazas.AutoSize = true;
            this.lbPlazas.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlazas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPlazas.Location = new System.Drawing.Point(603, 382);
            this.lbPlazas.Name = "lbPlazas";
            this.lbPlazas.Size = new System.Drawing.Size(163, 24);
            this.lbPlazas.TabIndex = 5;
            this.lbPlazas.Text = "PLAZAS TOTALES";
            this.toolTip1.SetToolTip(this.lbPlazas, "Tiene que haber al menos 1 plaza");
            // 
            // lbProfesor
            // 
            this.lbProfesor.AutoSize = true;
            this.lbProfesor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfesor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbProfesor.Location = new System.Drawing.Point(627, 218);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.Size = new System.Drawing.Size(102, 24);
            this.lbProfesor.TabIndex = 6;
            this.lbProfesor.Text = "PROFESOR";
            this.toolTip1.SetToolTip(this.lbProfesor, "Es obligatorio asignar un profesor");
            // 
            // numPlaza
            // 
            this.numPlaza.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPlaza.Location = new System.Drawing.Point(825, 383);
            this.numPlaza.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPlaza.Name = "numPlaza";
            this.numPlaza.Size = new System.Drawing.Size(152, 22);
            this.numPlaza.TabIndex = 9;
            this.toolTip1.SetToolTip(this.numPlaza, "Tiene que haber al menos 1 plaza");
            // 
            // pbImagenTematica
            // 
            this.pbImagenTematica.Location = new System.Drawing.Point(122, 58);
            this.pbImagenTematica.Name = "pbImagenTematica";
            this.pbImagenTematica.Size = new System.Drawing.Size(353, 292);
            this.pbImagenTematica.TabIndex = 26;
            this.pbImagenTematica.TabStop = false;
            // 
            // cboxProfesor
            // 
            this.cboxProfesor.FormattingEnabled = true;
            this.cboxProfesor.Location = new System.Drawing.Point(825, 218);
            this.cboxProfesor.Name = "cboxProfesor";
            this.cboxProfesor.Size = new System.Drawing.Size(231, 24);
            this.cboxProfesor.TabIndex = 28;
            this.toolTip1.SetToolTip(this.cboxProfesor, "Es obligatorio asignar un profesor");
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbFecha.Location = new System.Drawing.Point(825, 315);
            this.tbFecha.Mask = "00-00-0000 00:00";
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(152, 22);
            this.tbFecha.TabIndex = 29;
            this.toolTip1.SetToolTip(this.tbFecha, "Formato de fecha: DD-MM-AAAA HH:MM");
            this.tbFecha.Leave += new System.EventHandler(this.tbFecha_Leave);
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("botonImagen1.ButtonImage")));
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(21, 58);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 27;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // btSeleccionTematica
            // 
            this.btSeleccionTematica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSeleccionTematica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeleccionTematica.ForeColor = System.Drawing.Color.Black;
            this.btSeleccionTematica.Location = new System.Drawing.Point(206, 356);
            this.btSeleccionTematica.Name = "btSeleccionTematica";
            this.btSeleccionTematica.Size = new System.Drawing.Size(161, 37);
            this.btSeleccionTematica.TabIndex = 25;
            this.btSeleccionTematica.Text = "Seleccionar Imagen";
            this.btSeleccionTematica.UseVisualStyleBackColor = false;
            this.btSeleccionTematica.Click += new System.EventHandler(this.btSeleccionTematica_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderColor = System.Drawing.Color.Blue;
            this.tbDescripcion.BorderRadius = 15;
            this.tbDescripcion.Location = new System.Drawing.Point(825, 89);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Padding = new System.Windows.Forms.Padding(10);
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.Size = new System.Drawing.Size(362, 93);
            this.tbDescripcion.TabIndex = 8;
            // 
            // tbTitulo
            // 
            this.tbTitulo.BorderColor = System.Drawing.Color.Blue;
            this.tbTitulo.BorderRadius = 15;
            this.tbTitulo.Location = new System.Drawing.Point(219, 434);
            this.tbTitulo.Multiline = true;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Padding = new System.Windows.Forms.Padding(10);
            this.tbTitulo.PasswordChar = '\0';
            this.tbTitulo.Size = new System.Drawing.Size(243, 46);
            this.tbTitulo.TabIndex = 7;
            // 
            // btCrearClase
            // 
            this.btCrearClase.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btCrearClase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCrearClase.ForeColor = System.Drawing.Color.Black;
            this.btCrearClase.Location = new System.Drawing.Point(1076, 448);
            this.btCrearClase.Name = "btCrearClase";
            this.btCrearClase.Size = new System.Drawing.Size(120, 40);
            this.btCrearClase.TabIndex = 0;
            this.btCrearClase.Text = "Guardar";
            this.btCrearClase.UseVisualStyleBackColor = false;
            this.btCrearClase.Click += new System.EventHandler(this.btCrearClase_Click);
            // 
            // CrearEditarClase
            // 
            this.AcceptButton = this.btCrearClase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 519);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.cboxProfesor);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.pbImagenTematica);
            this.Controls.Add(this.btSeleccionTematica);
            this.Controls.Add(this.numPlaza);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbProfesor);
            this.Controls.Add(this.lbPlazas);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btBorrarTodo);
            this.Controls.Add(this.btCrearClase);
            this.MaximumSize = new System.Drawing.Size(1273, 566);
            this.MinimumSize = new System.Drawing.Size(1273, 566);
            this.Name = "CrearEditarClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Clase";
            ((System.ComponentModel.ISupportInitialize)(this.numPlaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTematica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btCrearClase;
        private System.Windows.Forms.Button btBorrarTodo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbPlazas;
        private System.Windows.Forms.Label lbProfesor;
        private ControlesPersonalizados.TextBoxRedondeado tbTitulo;
        private ControlesPersonalizados.TextBoxRedondeado tbDescripcion;
        private System.Windows.Forms.NumericUpDown numPlaza;
        private CustomButton btSeleccionTematica;
        private System.Windows.Forms.PictureBox pbImagenTematica;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private System.Windows.Forms.ComboBox cboxProfesor;
        private System.Windows.Forms.MaskedTextBox tbFecha;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}