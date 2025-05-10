using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CookMe.Views.Landing.UserContUsuario
{
    public partial class CarritoControl : UserControl
    {
        private Panel listaProductos;
        private Label lblTotalTexto;      

        public Dictionary<int, int> carritoLleno;
        public string userEm;

        public event EventHandler IrAPagoClick;

        public CarritoControl(Dictionary<int, int> carrito, string userEmail)
        {
            InicializarComponentes();
            this.carritoLleno = carrito;
            this.userEm = userEmail;
            CargarCarrito(carritoLleno);
        }

        private void InicializarComponentes()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            
            listaProductos = new Panel()
            {
                Location = new Point(10, 10),
                Size = new Size(640, 290), 
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            
            lblTotalTexto = new Label()
            {
                Text = "",
                Location = new Point(100, listaProductos.Bottom + 10),
                Font = new Font("Comic Sans MS", 14, FontStyle.Bold),
                AutoSize = true
            };

            this.Controls.Add(listaProductos);
            this.Controls.Add(lblTotalTexto);
        }

        public void CargarCarrito(Dictionary<int, int> carrito)
        {
            listaProductos.Controls.Clear();
            decimal total = 0;

            foreach (var item in carrito)
            {
                int id = item.Key;
                int cantidad = item.Value;

                var prod = new Logica.Controles.ProductoControl().ObtenerProductoPorID(id);
                var linea = new LineaProductoCarrito(prod.Nombre, prod.Precio, cantidad);

                linea.Dock = DockStyle.Top; 
                listaProductos.Controls.Add(linea);

                total += prod.Precio * cantidad;
            }

            lblTotalTexto.Text = $"Total a pagar: {total:0.00} €";
        }

    }
}
