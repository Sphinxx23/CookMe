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
    public partial class ProductoBoton : UserControl
    {
        private PictureBox picFotoProducto;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Button btnAgregarCarrito;
        public int id;

        public event EventHandler ItemClicked;
        public event EventHandler AgregarAlCarritoClicked;

        public ProductoBoton()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(200, 230);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;

            this.Click += ProductoBoton_Click;
            this.MouseEnter += Control_MouseEnter;
            this.MouseLeave += Control_MouseLeave;

            picFotoProducto = new PictureBox()
            {
                Size = new Size(160, 90),
                Location = new Point((this.Width - 160) / 2, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            picFotoProducto.Click += ProductoBoton_Click;
            picFotoProducto.MouseEnter += Control_MouseEnter;
            picFotoProducto.MouseLeave += Control_MouseLeave;

            lblNombre = new Label()
            {
                Location = new Point(10, 110),
                Size = new Size(this.Width - 20, 20),
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lblNombre.Click += ProductoBoton_Click;
            lblNombre.MouseEnter += Control_MouseEnter;
            lblNombre.MouseLeave += Control_MouseLeave;

            lblPrecio = new Label()
            {
                Location = new Point(10, 130),
                Size = new Size(this.Width - 20, 18),
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lblPrecio.Click += ProductoBoton_Click;
            lblPrecio.MouseEnter += Control_MouseEnter;
            lblPrecio.MouseLeave += Control_MouseLeave;

            lblStock = new Label()
            {
                Location = new Point(10, 150),
                Size = new Size(this.Width - 20, 18),
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lblStock.Click += ProductoBoton_Click;
            lblStock.MouseEnter += Control_MouseEnter;
            lblStock.MouseLeave += Control_MouseLeave;

            btnAgregarCarrito = new Button()
            {
                Text = "Añadir al carrito",
                Size = new Size(140, 30),
                Location = new Point((this.Width - 140) / 2, 180),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGreen,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Cursor = Cursors.Default
            };
            btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            btnAgregarCarrito.Click += BtnAgregarCarrito_Click;

            this.Controls.Add(picFotoProducto);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(lblStock);
            this.Controls.Add(btnAgregarCarrito);
        }


        private void ProductoBoton_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarAlCarritoClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public void AsignarDatosProducto(int id, string nombre, decimal precio, int stock, Image fotoProducto)
        {
            this.id = id;
            lblNombre.Text = nombre;
            lblPrecio.Text = "Precio: " + precio.ToString("0.00") + " €";
            lblStock.Text = "Stock: " + stock + " unidades";
            picFotoProducto.Image = fotoProducto;

            btnAgregarCarrito.Enabled = stock > 0;
            btnAgregarCarrito.BackColor = stock > 0 ? Color.LightGreen : Color.LightGray;
        }
    }
}