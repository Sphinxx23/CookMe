using Datos.Modelos;
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
    public partial class ProductoBotonContenedor : UserControl
    {
        private Panel panelContenedor;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCarrito;
        private string email;

        // idProducto----cantidad
        public Dictionary<int, int> carrito;

        public List<Datos.Modelos.Producto> productos;

        public ProductoBotonContenedor(string email)
        {
            this.email = email;
            InitializeComponents();
            carrito = new Dictionary<int, int>();
            productos = new Logica.Controles.ProductoControl().ObtenerTodosLosProductos();
            LoadProductos(productos);
        }

        private void InitializeComponents()
        {
            this.Size = new Size(195, 500);

            txtBuscar = new TextBox()
            {
                Location = new Point(50, 23),
                Size = new Size(450, 35),
                Font = new Font("Arial", 9),
                BackColor = Color.LightSkyBlue
            };

            btnBuscar = new Button()
            {
                Location = new Point(510, 12),
                Size = new Size(45, 45),
                FlatStyle = FlatStyle.Flat,
                Image = Properties.Resources.lupapeq,
                BackColor = Color.White
            };
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Click += BtnBuscar_Click;

            btnCarrito = new Button()
            {
                Location = new Point(820, 12),
                Size = new Size(45, 45),
                FlatStyle = FlatStyle.Flat,
                Image = Properties.Resources.carrito3,
                BackColor = Color.White
            };
            btnCarrito.FlatAppearance.BorderSize = 0;
            btnCarrito.Click += BtnCarrito_Click;

            panelContenedor = new Panel()
            {
                Location = new Point(3, 65),
                Size = new Size(890, 540),
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            this.Controls.Add(txtBuscar);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(btnCarrito);
            this.Controls.Add(panelContenedor);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }


        public void Busqueda()
        {
            string aBuscar = txtBuscar.Text;

            if (aBuscar != null)
            {
                List<Datos.Modelos.Producto> pB = new Logica.Controles.ProductoControl().ObtenerProductosBusqueda(aBuscar);

                foreach (Producto item in pB)
                {
                    foreach (var pCarro in carrito)
                    {
                        if (pCarro.Key == item.Id)
                        {
                            item.Stock -= pCarro.Value;
                        }

                    }
                }

                LoadProductos(pB);
            }
            else if (aBuscar.Equals(""))
            {
               
                LoadProductos(productos);
            }
        }

        private void BtnCarrito_Click(object sender, EventArgs e)
        {


            if (carrito.Count>0)
            {
                Views.VistasProducto.Carrito carro = new Views.VistasProducto.Carrito(carrito, email);

                var resultado = carro.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    carrito = new Dictionary<int, int>();
                }
            }
            else
            {
                MessageBox.Show("Carrito Vacío, añade algún producto para ir ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void LoadProductos(List<Datos.Modelos.Producto> productos)
        {
            panelContenedor.Controls.Clear();

            int columnas = 4;
            int espaciadoHorizontal = 15;
            int espaciadoVertical = 20;
            int margenIzquierdo = 20;
            int margenSuperior = 10;

            int x = margenIzquierdo;
            int y = margenSuperior;
            int contador = 0;

            foreach (var producto in productos)
            {
                ProductoBoton productoControl = new ProductoBoton();

                Image img = CookMe.MetodosImages.MetImages.ConvertBytesToImage(producto.Foto1);
                productoControl.AsignarDatosProducto(producto.Id, producto.Nombre, producto.Precio, producto.Stock, img);

                productoControl.Location = new Point(x, y);

                productoControl.ItemClicked += (s, e) => AbrirVistaProducto(productoControl);
                productoControl.AgregarAlCarritoClicked += (s, e) => AñadirProductoAlCarrito(productoControl);

                panelContenedor.Controls.Add(productoControl);

                contador++;
                if (contador % columnas == 0)
                {
                    x = margenIzquierdo;
                    y += productoControl.Height + espaciadoVertical;
                }
                else
                {
                    x += productoControl.Width + espaciadoHorizontal;
                }
            }
        }

        private void AbrirVistaProducto(ProductoBoton producto)
        {
            Views.VistasProducto.VerProducto ver = new Views.VistasProducto.VerProducto(producto.id);
            ver.ShowDialog();
        }

        private void AñadirProductoAlCarrito(ProductoBoton producto)
        {

            if (carrito.ContainsKey(producto.id))
            {
                carrito[producto.id] += 1;
                MessageBox.Show("Producto añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                carrito.Add(producto.id, 1);
                MessageBox.Show("Producto añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            foreach (Producto item in productos)
            {
                
                if (producto.id == item.Id)
                {
                    item.Stock -= 1;
                }

                
            }

            if (txtBuscar.Text== null || txtBuscar.Text.Equals(""))
            {
                LoadProductos(productos);
            }
            else
            {
                Busqueda();
            }

            
        }

    }
}
