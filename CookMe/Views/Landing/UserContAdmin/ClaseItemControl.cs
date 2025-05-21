using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Landing.UserContAdmin
{
    public partial class ClaseItemControl : UserControl
    {
        private PictureBox picFotoClase;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblFecha;
        private Label lblPlazas;
        private PictureBox picFotoProfesor;
        private Label lblEmailProfesor;
        private Button btnEliminar;
        private Button btnEditar;
        public int id;

        public event EventHandler DeleteClicked;
        public event EventHandler EditClicked;

        public ClaseItemControl()
        {
            InitializeComponents();
        }


        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(750, 150);
            this.BorderStyle = BorderStyle.FixedSingle;

            picFotoClase = new PictureBox()
            {
                Size = new Size(120, 120),
                Location = new Point(10, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblTitulo = new Label()
            {
                Location = new Point(140, 15),
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };

            lblDescripcion = new Label()
            {
                Location = new Point(140, 45),
                Size = new Size(185, 100),
                Font = new Font("Arial", 9),
                AutoEllipsis = true
            };

            lblFecha = new Label()
            {
                Location = new Point(350, 60),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            lblPlazas = new Label()
            {
                Location = new Point(350, 90),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };

            picFotoProfesor = new PictureBox()
            {
                Size = new Size(80, 80),
                Location = new Point(560, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblEmailProfesor = new Label()
            {
                Location = new Point(525, 100),
                Size = new Size(140, 50),
                Font = new Font("Arial", 9, FontStyle.Italic)
            };

            btnEliminar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(670, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.papelera
            };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += BtnEliminar_Click;

            btnEditar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(670, 80),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.lapiz
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Click += BtnEditar_Click;

            this.Controls.Add(picFotoClase);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(lblFecha);
            this.Controls.Add(lblPlazas);
            this.Controls.Add(picFotoProfesor);
            this.Controls.Add(lblEmailProfesor);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnEditar);
        }

        //Evento que se controla en el control de usuario CONTENEDOR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        //Evento que se controla en el control de usuario CONTENEDOR
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        // Asigna los datos reales al item
        public void AsignarDatosClase(int id, string titulo, string descripcion, string fecha, int plazas, string emailProfesor, Image fotoClase, Image fotoProfesor)
        {
            this.id = id;
            lblTitulo.Text = titulo;
            lblDescripcion.Text = descripcion;
            lblFecha.Text = "Fecha: " + fecha;
            lblPlazas.Text = "Plazas libres: " + plazas;
            lblEmailProfesor.Text = emailProfesor;
            picFotoClase.Image = fotoClase;
            picFotoProfesor.Image = fotoProfesor;
        }
    }
}
