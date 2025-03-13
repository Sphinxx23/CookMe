using CookMe.Properties;
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
    public partial class RecetaItemControl : UserControl
    {
        private PictureBox picFoto;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblEmail;
        private Button btnEliminar;
        private Button btnEditar;
        public int id;

        public event EventHandler DeleteClicked;
        public event EventHandler EditClicked;

        public RecetaItemControl()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(750, 120);
            this.BorderStyle = BorderStyle.FixedSingle;

            picFoto = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblTitulo = new Label()
            {
                Location = new Point(150, 25),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            lblDescripcion = new Label()
            {
                Location = new Point(150, 55),
                Size = new Size(500, 60),
                Font = new Font("Arial", 10),
                AutoEllipsis = true
            };

            lblEmail = new Label()
            {
                Location = new Point(450, 10),
                AutoSize = true,
                Font = new Font("Arial", 9, FontStyle.Italic)
            };

            btnEliminar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(680, 15),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.papelera
            };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += BtnEliminar_Click;

            btnEditar = new Button()
            {
                Size = new Size(34, 34),
                Location = new Point(680, 65),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.lapiz
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Click += BtnEditar_Click;

            this.Controls.Add(picFoto);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblDescripcion);
            this.Controls.Add(lblEmail);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnEditar);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        public void AsignarDatosReceta(int id, string titulo, string descripcion, string email, Image foto)
        {
            lblTitulo.Text = titulo;
            lblDescripcion.Text = descripcion;
            lblEmail.Text = email;
            //Cambiar el resources... por foto
            picFoto.Image = Resources.CookMeG;
            this.id = id;
        }
    }
}
