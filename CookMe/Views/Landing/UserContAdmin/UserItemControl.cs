using CookMe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CookMe.Views.Landing.UserContAdmin
{
   
    public partial class UserItemControl : UserControl
    {
        private PictureBox picFoto;
        private Label lblNombre;
        private Label lblApellido;
        public Label lblCorreo;
        private Button btnEliminar;

        private Label nom;
        private Label ape;
        private Label email;

        public event EventHandler DeleteClicked;

        public UserItemControl()
        {
            InitializeComponents();
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(750, 60);
            this.BorderStyle = BorderStyle.FixedSingle;

            picFoto = new PictureBox()
            {
                Size = new Size(50, 50),
                Location = new Point(10, 5),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            nom = new Label()
            {
                Location = new Point(90, 10),
                AutoSize = true,
                Font = new Font("Arial", 9 )
            };

            lblNombre = new Label()
            {
                Location = new Point(150, 10),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            ape = new Label()
            {
                Location = new Point(280, 10),
                AutoSize = true,
                Font = new Font("Arial", 9)
            };

            lblApellido = new Label()
            {
                Location = new Point(340, 10),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            email = new Label()
            {
                Location = new Point(90, 30),
                AutoSize = true,
                Font = new Font("Arial", 9)
            };

            lblCorreo = new Label()
            {
                Location = new Point(140, 30),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnEliminar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(650, 9),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White
            };

            btnEliminar.FlatAppearance.BorderSize = 0;;            
            btnEliminar.Image = Resources.papelera; 
            btnEliminar.Click += BtnEliminar_Click;

            this.Controls.Add(picFoto);
            this.Controls.Add(nom);
            this.Controls.Add(lblNombre);
            this.Controls.Add(ape);
            this.Controls.Add(lblApellido);
            this.Controls.Add(email);
            this.Controls.Add(lblCorreo);
            this.Controls.Add(btnEliminar);
        }


        //Evento que se controla en el control de usuario CONTENEDOR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
            
        }

        //Asignar datos reales al item
        public void AsignarDatosLabels(string nombre, string apellido ,string correo,Image foto)
        {
            lblNombre.Text = nombre;
            lblApellido.Text = apellido; 
            lblCorreo.Text = correo;
            picFoto.Image = foto;

            nom.Text = " Nombre: ";
            ape.Text = " Apellido: ";
            email.Text = " Email: ";
        }
    }

}
