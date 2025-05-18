namespace CookMe.Views.VistasProducto
{
    partial class CrearEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEditarProducto));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btGuardar = new CustomButton();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lbFoto1 = new System.Windows.Forms.Label();
            this.lbFoto2 = new System.Windows.Forms.Label();
            this.tbNombre = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.tbPrecio = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.tbCategoria = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.botonImagen1 = new CookMe.ControlesPersonalizados.BotonImagen();
            this.btImgSecundaria = new CookMe.ControlesPersonalizados.BotonImagen();
            this.butImgPrincipal = new CookMe.ControlesPersonalizados.BotonImagen();
            this.pbSecundaria = new System.Windows.Forms.PictureBox();
            this.pbPrincipal = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new CookMe.ControlesPersonalizados.TextBoxRedondeado();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecundaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbNombre.Location = new System.Drawing.Point(95, 81);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(86, 24);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDescripcion.Location = new System.Drawing.Point(95, 148);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(131, 24);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbStock.Location = new System.Drawing.Point(95, 256);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(68, 24);
            this.lbStock.TabIndex = 5;
            this.lbStock.Text = "STOCK";
            this.toolTip1.SetToolTip(this.lbStock, "Tiene que haber al menos 1 producto en Stock");
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPrecio.Location = new System.Drawing.Point(95, 339);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(74, 24);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "PRECIO";
            this.toolTip1.SetToolTip(this.lbPrecio, "Formato aceptado: 17,99");
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCategoria.Location = new System.Drawing.Point(95, 423);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(113, 24);
            this.lbCategoria.TabIndex = 7;
            this.lbCategoria.Text = "CATEGORÍA";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.ForeColor = System.Drawing.Color.Black;
            this.btGuardar.Location = new System.Drawing.Point(1012, 478);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(120, 40);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.LightCoral;
            this.btBorrar.Location = new System.Drawing.Point(837, 478);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(121, 40);
            this.btBorrar.TabIndex = 9;
            this.btBorrar.Text = "Borrar Todo";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lbFoto1
            // 
            this.lbFoto1.AutoSize = true;
            this.lbFoto1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoto1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFoto1.Location = new System.Drawing.Point(592, 230);
            this.lbFoto1.Name = "lbFoto1";
            this.lbFoto1.Size = new System.Drawing.Size(157, 24);
            this.lbFoto1.TabIndex = 10;
            this.lbFoto1.Text = "FOTO PRINCIPAL";
            // 
            // lbFoto2
            // 
            this.lbFoto2.AutoSize = true;
            this.lbFoto2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoto2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFoto2.Location = new System.Drawing.Point(921, 230);
            this.lbFoto2.Name = "lbFoto2";
            this.lbFoto2.Size = new System.Drawing.Size(181, 24);
            this.lbFoto2.TabIndex = 11;
            this.lbFoto2.Text = "FOTO SECUNDARIA";
            // 
            // tbNombre
            // 
            this.tbNombre.BorderColor = System.Drawing.Color.Blue;
            this.tbNombre.BorderRadius = 15;
            this.tbNombre.Location = new System.Drawing.Point(244, 66);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(10);
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.Size = new System.Drawing.Size(965, 52);
            this.tbNombre.TabIndex = 12;
            // 
            // numStock
            // 
            this.numStock.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStock.Location = new System.Drawing.Point(244, 257);
            this.numStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(203, 22);
            this.numStock.TabIndex = 14;
            this.toolTip1.SetToolTip(this.numStock, "Tiene que haber al menos 1 producto en Stock");
            // 
            // tbPrecio
            // 
            this.tbPrecio.BorderColor = System.Drawing.Color.Blue;
            this.tbPrecio.BorderRadius = 15;
            this.tbPrecio.Location = new System.Drawing.Point(244, 332);
            this.tbPrecio.Multiline = true;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Padding = new System.Windows.Forms.Padding(10);
            this.tbPrecio.PasswordChar = '\0';
            this.tbPrecio.Size = new System.Drawing.Size(203, 45);
            this.tbPrecio.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tbPrecio, "Formato aceptado: 17,99");
            this.tbPrecio.Leave += new System.EventHandler(this.tbPrecio_Leave);
            // 
            // tbCategoria
            // 
            this.tbCategoria.BorderColor = System.Drawing.Color.Blue;
            this.tbCategoria.BorderRadius = 15;
            this.tbCategoria.Location = new System.Drawing.Point(244, 420);
            this.tbCategoria.Multiline = true;
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Padding = new System.Windows.Forms.Padding(10);
            this.tbCategoria.PasswordChar = '\0';
            this.tbCategoria.Size = new System.Drawing.Size(203, 43);
            this.tbCategoria.TabIndex = 16;
            // 
            // botonImagen1
            // 
            this.botonImagen1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("botonImagen1.ButtonImage")));
            this.botonImagen1.CornerRadius = 20;
            this.botonImagen1.Location = new System.Drawing.Point(12, 46);
            this.botonImagen1.Name = "botonImagen1";
            this.botonImagen1.Size = new System.Drawing.Size(61, 42);
            this.botonImagen1.TabIndex = 28;
            this.botonImagen1.UseVisualStyleBackColor = true;
            this.botonImagen1.Click += new System.EventHandler(this.botonImagen1_Click);
            // 
            // btImgSecundaria
            // 
            this.btImgSecundaria.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btImgSecundaria.ButtonImage")));
            this.btImgSecundaria.CornerRadius = 20;
            this.btImgSecundaria.Location = new System.Drawing.Point(1151, 319);
            this.btImgSecundaria.Name = "btImgSecundaria";
            this.btImgSecundaria.Size = new System.Drawing.Size(73, 58);
            this.btImgSecundaria.TabIndex = 20;
            this.btImgSecundaria.Text = "botonImagen1";
            this.btImgSecundaria.UseVisualStyleBackColor = true;
            this.btImgSecundaria.Click += new System.EventHandler(this.btImgSecundaria_Click);
            // 
            // butImgPrincipal
            // 
            this.butImgPrincipal.ButtonImage = ((System.Drawing.Image)(resources.GetObject("butImgPrincipal.ButtonImage")));
            this.butImgPrincipal.CornerRadius = 20;
            this.butImgPrincipal.Location = new System.Drawing.Point(637, 448);
            this.butImgPrincipal.Name = "butImgPrincipal";
            this.butImgPrincipal.Size = new System.Drawing.Size(73, 58);
            this.butImgPrincipal.TabIndex = 19;
            this.butImgPrincipal.Text = "botonImagen1";
            this.butImgPrincipal.UseVisualStyleBackColor = true;
            this.butImgPrincipal.Click += new System.EventHandler(this.butImgPrincipal_Click);
            // 
            // pbSecundaria
            // 
            this.pbSecundaria.Location = new System.Drawing.Point(893, 267);
            this.pbSecundaria.Name = "pbSecundaria";
            this.pbSecundaria.Size = new System.Drawing.Size(239, 175);
            this.pbSecundaria.TabIndex = 18;
            this.pbSecundaria.TabStop = false;
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(556, 267);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(239, 175);
            this.pbPrincipal.TabIndex = 17;
            this.pbPrincipal.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderColor = System.Drawing.Color.Blue;
            this.tbDescripcion.BorderRadius = 15;
            this.tbDescripcion.Location = new System.Drawing.Point(244, 139);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Padding = new System.Windows.Forms.Padding(10);
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.Size = new System.Drawing.Size(965, 73);
            this.tbDescripcion.TabIndex = 29;
            // 
            // CrearEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 519);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.botonImagen1);
            this.Controls.Add(this.btImgSecundaria);
            this.Controls.Add(this.butImgPrincipal);
            this.Controls.Add(this.pbSecundaria);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbFoto2);
            this.Controls.Add(this.lbFoto1);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.MaximumSize = new System.Drawing.Size(1273, 566);
            this.MinimumSize = new System.Drawing.Size(1273, 566);
            this.Name = "CrearEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecundaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCategoria;
        private CustomButton btGuardar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lbFoto1;
        private System.Windows.Forms.Label lbFoto2;
        private ControlesPersonalizados.TextBoxRedondeado tbNombre;
        private System.Windows.Forms.NumericUpDown numStock;
        private ControlesPersonalizados.TextBoxRedondeado tbPrecio;
        private ControlesPersonalizados.TextBoxRedondeado tbCategoria;
        private System.Windows.Forms.PictureBox pbPrincipal;
        private System.Windows.Forms.PictureBox pbSecundaria;
        private ControlesPersonalizados.BotonImagen butImgPrincipal;
        private ControlesPersonalizados.BotonImagen btImgSecundaria;
        private ControlesPersonalizados.BotonImagen botonImagen1;
        private ControlesPersonalizados.TextBoxRedondeado tbDescripcion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}