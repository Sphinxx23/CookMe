using CookMe.Properties;
using CookMe.Views.VistasProducto;
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
    public partial class UCGestionProductos : UserControl
    {
        private Panel panelProductos;
        private Button btnAgregarProducto;

        public UCGestionProductos()
        {
            InitializeComponents();
            List<Datos.Modelos.Producto> productos = new Logica.Controles.ProductoControl().ObtenerTodosLosProductos();
            LoadProductos(productos);
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(750, 600);

            btnAgregarProducto = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point((this.Width - 50) / 2, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.mas,
                Anchor = AnchorStyles.Top
            };
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;

            panelProductos = new Panel()
            {
                Location = new Point(0, 70),
                Size = new Size(765, 350),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(btnAgregarProducto);
            this.Controls.Add(panelProductos);
        }


        //Carga de todos los registros de bbdd en los "items", control de espaciado entre ellos y en este caso, cantidad de 
        // items por fila (3)
        public void LoadProductos(List<Datos.Modelos.Producto> productos)
        {
            panelProductos.Controls.Clear();
            int x = 20, y = 10;
            int columnas = 3, contador = 0;

            foreach (var producto in productos)
            {
                ProductoItemControl item = new ProductoItemControl();
                Image imgProducto = CookMe.MetodosImages.MetImages.ConvertBytesToImage(producto.Foto1);
                item.AsignarDatosProducto(producto.Id, producto.Nombre, producto.Precio, producto.Stock, imgProducto);
                item.Location = new Point(x, y);
                item.DeleteClicked += (s, e) => EliminarProducto(item);
                item.EditClicked += (s, e) => EditarProducto(item);

                panelProductos.Controls.Add(item);

                
                
                // Cuando llegue la fila a 3 items vuelve a la posicion inicial del eje x pero 
                // más bajo de altura en el eje y
                contador++;
                if (contador % columnas == 0)
                {
                    x = 20;
                    y += item.Height + 10;
                }
                else
                {
                    x += item.Width + 10;
                }
            }
        }

        //Eliminación de item y de registro en bbdd
        private void EliminarProducto(ProductoItemControl item)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool eliminado = new Logica.Controles.ProductoControl().EliminarProductoPorId(item.id);
                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductos(new Logica.Controles.ProductoControl().ObtenerTodosLosProductos());
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Edición de item y de registro en bbdd
        private void EditarProducto(ProductoItemControl item)
        {
            Views.VistasProducto.CrearEditarProducto editarProducto = new Views.VistasProducto.CrearEditarProducto(this, item.id);
            this.Visible = false;
            var resultado = editarProducto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LoadProductos(new Logica.Controles.ProductoControl().ObtenerTodosLosProductos());
            }

        }

        //Inserción de nuevo item y registro en bbdd
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Views.VistasProducto.CrearEditarProducto crearProducto = new Views.VistasProducto.CrearEditarProducto(this, -1);
            this.Visible = false;
            var resultado = crearProducto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LoadProductos(new Logica.Controles.ProductoControl().ObtenerTodosLosProductos());
            }
        }
    }
}
