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
        private Button btnIrAPago;

        public event EventHandler IrAPagoClick;

        public CarritoControl(Dictionary<int, int> carrito)
        {
            InicializarComponentes();
            CargarCarrito(carrito);
        }

        private void InicializarComponentes()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            
            listaProductos = new Panel()
            {
                Location = new Point(10, 10),
                Size = new Size(640, 300), 
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            
            lblTotalTexto = new Label()
            {
                Text = "",
                Location = new Point(100, listaProductos.Bottom + 25),
                Font = new Font("Comic Sans MS", 14, FontStyle.Bold),
                AutoSize = true
            };

            
            btnIrAPago = new Button()
            {
                Text = "Ir al pago",
                Size = new Size(130, 40),
                Location = new Point(500, 330),
                BackColor = Color.LightSkyBlue
            };
            btnIrAPago.Click += BtnIrAlPago_Click;

            this.Controls.Add(listaProductos);
            this.Controls.Add(lblTotalTexto);
            this.Controls.Add(btnIrAPago);
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

        private void BtnIrAlPago_Click(object sender, EventArgs e)
        {
            // a pagra a pagar
            MessageBox.Show("A pagar a pagar");
        }
    }
}
