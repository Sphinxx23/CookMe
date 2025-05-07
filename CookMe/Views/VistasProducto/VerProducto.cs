using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.VistasProducto
{
    public partial class VerProducto : Form
    {
        private int idProd;
        public VerProducto(int idProducto)
        {
            InitializeComponent();
            this.idProd = idProducto;

            Datos.Modelos.Producto prod = new Logica.Controles.ProductoControl().ObtenerProductoPorID(idProducto);

            lbCategoria.Text = prod.Categoria;
            lbDescripcion.Text = prod.Descripcion;
            lbNombre.Text = prod.Nombre;
            lbPrecio.Text = prod.Precio.ToString() + " €/ud";
            pbFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto1.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto1); ;
            pbFoto2.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto2); ;
            lbStock.Text = prod.Stock.ToString();

        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
