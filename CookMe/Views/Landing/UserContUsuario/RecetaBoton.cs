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
    public partial class RecetaBoton : UserControl
    {
        private PictureBox picFoto;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblEmail;

        public int id;
        public event EventHandler ItemClicked;

        public RecetaBoton()
        {
            InitializeComponents();
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(849, 120);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;

            this.Click += RecetaBoton_Click;

            this.MouseEnter += Control_MouseEnter;
            this.MouseLeave += Control_MouseLeave;

            picFoto = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(30, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            picFoto.Click += RecetaBoton_Click;
            picFoto.MouseEnter += Control_MouseEnter;
            picFoto.MouseLeave += Control_MouseLeave;

            lblTitulo = new Label()
            {
                Location = new Point(170, 25),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            lblTitulo.Click += RecetaBoton_Click;
            lblTitulo.MouseEnter += Control_MouseEnter;
            lblTitulo.MouseLeave += Control_MouseLeave;

            lblDescripcion = new Label()
            {
                Location = new Point(170, 55),
                Size = new Size(560, 60),
                Font = new Font("Arial", 10),
                AutoEllipsis = true
            };
            lblDescripcion.Click += RecetaBoton_Click;
            lblDescripcion.MouseEnter += Control_MouseEnter;
            lblDescripcion.MouseLeave += Control_MouseLeave;

            lblEmail = new Label()
            {
                Location = new Point(580, 15),
                AutoSize = true,
                Font = new Font("Arial", 9, FontStyle.Italic)
            };
            lblEmail.Click += RecetaBoton_Click;
            lblEmail.MouseEnter += Control_MouseEnter;
            lblEmail.MouseLeave += Control_MouseLeave;

            this.Controls.Add(picFoto);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(lblEmail);
        }

        // //Evento que se controla en el control de usuario CONTENEDOR
        private void RecetaBoton_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }
        //Al entrar con el ratón hace un cambio de color
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        //Al salir con el ratón hace un cambio de color
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        //Asignar datos reales al item
        public void AsignarDatosReceta(int id, string titulo, string descripcion, string email, Image foto)
        {
            lblTitulo.Text = titulo;
            lblDescripcion.Text = descripcion;
            lblEmail.Text = email;
            picFoto.Image = foto;
            this.id = id;
        }
    }
}
