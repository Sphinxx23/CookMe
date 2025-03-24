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
                item.DeleteClicked += (s, e) => RemoveProducto(item);
                item.EditClicked += (s, e) => EditProducto(item);

                panelProductos.Controls.Add(item);

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

        private void RemoveProducto(ProductoItemControl item)
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

        private void EditProducto(ProductoItemControl item)
        {
            Views.VistasProducto.CrearEditarProducto editarProducto = new Views.VistasProducto.CrearEditarProducto(this, item.id);
            this.Visible = false;
            editarProducto.Show();

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Views.VistasProducto.CrearEditarProducto crearProducto = new Views.VistasProducto.CrearEditarProducto(this, -1);
            this.Visible = false;
            crearProducto.Show();
        }
    }
}
