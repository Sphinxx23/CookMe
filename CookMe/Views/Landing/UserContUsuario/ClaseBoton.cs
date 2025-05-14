using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Landing.UserContUsuario
{
    public partial class ClaseBoton : UserControl
    {
        private PictureBox picFotoClase;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblFecha;
        private Label lblPlazas;
        private PictureBox picFotoProfesor;
        private Label lblEmailProfesor;
        public int id;
        public string emailProfe;

        public event EventHandler ItemClicked;

        public ClaseBoton()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(870, 150);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
           
            this.Click += ClaseBoton_Click;
            this.MouseEnter += Control_MouseEnter;
            this.MouseLeave += Control_MouseLeave;

            picFotoClase = new PictureBox()
            {
                Size = new Size(120, 120),
                Location = new Point(20, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            picFotoClase.Click += ClaseBoton_Click;
            picFotoClase.MouseEnter += Control_MouseEnter;
            picFotoClase.MouseLeave += Control_MouseLeave;

            lblTitulo = new Label()
            {
                Location = new Point(160, 22),
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            lblTitulo.Click += ClaseBoton_Click;
            lblTitulo.MouseEnter += Control_MouseEnter;
            lblTitulo.MouseLeave += Control_MouseLeave;

            lblDescripcion = new Label()
            {
                Location = new Point(160, 50),
                Size = new Size(325, 100),
                Font = new Font("Arial", 9),
                AutoEllipsis = true
            };
            lblDescripcion.Click += ClaseBoton_Click;
            lblDescripcion.MouseEnter += Control_MouseEnter;
            lblDescripcion.MouseLeave += Control_MouseLeave;

            lblFecha = new Label()
            {
                Location = new Point(510, 50),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            lblFecha.Click += ClaseBoton_Click;
            lblFecha.MouseEnter += Control_MouseEnter;
            lblFecha.MouseLeave += Control_MouseLeave;

            lblPlazas = new Label()
            {
                Location = new Point(510, 80),
                AutoSize = true,
                Font = new Font("Arial", 10)
            };
            lblPlazas.Click += ClaseBoton_Click;
            lblPlazas.MouseEnter += Control_MouseEnter;
            lblPlazas.MouseLeave += Control_MouseLeave;

            picFotoProfesor = new PictureBox()
            {
                Size = new Size(80, 80),
                Location = new Point(750, 28),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            picFotoProfesor.Click += ClaseBoton_Click;
            picFotoProfesor.MouseEnter += Control_MouseEnter;
            picFotoProfesor.MouseLeave += Control_MouseLeave;

            lblEmailProfesor = new Label()
            {
                Location = new Point(720, 113),
                Size = new Size(140, 50),
                Font = new Font("Arial", 9, FontStyle.Italic)
            };
            lblEmailProfesor.Click += ClaseBoton_Click;
            lblEmailProfesor.MouseEnter += Control_MouseEnter;
            lblEmailProfesor.MouseLeave += Control_MouseLeave;

            

            this.Controls.Add(picFotoClase);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(lblFecha);
            this.Controls.Add(lblPlazas);
            this.Controls.Add(picFotoProfesor);
            this.Controls.Add(lblEmailProfesor);

        }

        private void ClaseBoton_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public void AsignarDatosClase(int id, string titulo, string descripcion, string fecha, int plazas, string emailProfesor, Image fotoClase, Image fotoProfesor)
        {
            this.id = id;
            this.emailProfe = emailProfesor;
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

