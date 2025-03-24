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
    public partial class ProductoItemControl : UserControl
    {
        private PictureBox picFotoProducto;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Button btnEliminar;
        private Button btnEditar;
        public int id;

        public event EventHandler DeleteClicked;
        public event EventHandler EditClicked;

        public ProductoItemControl()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(230, 255);
            this.BorderStyle = BorderStyle.FixedSingle;

            picFotoProducto = new PictureBox()
            {
                Size = new Size(180, 120),
                Location = new Point(25, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblNombre = new Label()
            {
                Location = new Point(10, 140),
                Size = new Size(210, 20),
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            lblPrecio = new Label()
            {
                Location = new Point(10, 165),
                Size = new Size(210, 20),
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            lblStock = new Label()
            {
                Location = new Point(10, 185),
                Size = new Size(210, 20),
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnEditar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(50, 210),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.lapiz
            };
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Click += BtnEditar_Click;

            btnEliminar = new Button()
            {
                Size = new Size(38, 38),
                Location = new Point(140, 210),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.papelera
            };
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Click += BtnEliminar_Click;

            this.Controls.Add(picFotoProducto);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(lblStock);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnEliminar);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        public void AsignarDatosProducto(int id, string nombre, decimal precio, int stock,Image fotoProducto)
        {
            this.id = id;
            lblNombre.Text = nombre;
            lblPrecio.Text = "Precio: " + precio.ToString("0.00") + " €";
            lblStock.Text = "Stock: " + stock + " unidades";
            picFotoProducto.Image = fotoProducto;
        }
    }
}
