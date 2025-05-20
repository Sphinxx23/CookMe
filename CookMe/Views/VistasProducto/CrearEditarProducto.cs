using CookMe.Properties;
using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.VistasProducto
{
    public partial class CrearEditarProducto : Form
    {
        private UserControl parent;
        private int idProd;
        public CrearEditarProducto(UserControl parent, int idProd)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.idProd = idProd;
            InitializeComponent();
            this.parent = parent;
            pbPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSecundaria.SizeMode = PictureBoxSizeMode.StretchImage;

            if (this.idProd == -1)
            {
                pbPrincipal.Image = Resources.imgPpal;
                pbSecundaria.Image = Resources.imgSecun;

            }
            else
            {
                Datos.Modelos.Producto prod = new Logica.Controles.ProductoControl().ObtenerProductoPorID(idProd);

                pbPrincipal.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto1);
                pbSecundaria.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto2);
                tbNombre.Text = prod.Nombre;
                tbDescripcion.Text = prod.Descripcion;
                tbPrecio.Text = prod.Precio.ToString();
                numStock.Value = prod.Stock;
                tbCategoria.Text = prod.Categoria;

            }
        }

        // Abre cuadro de diálogo para seleccionar foto
        private void butImgPrincipal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPrincipal.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Abre cuadro de diálogo para seleccionar foto
        private void btImgSecundaria_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSecundaria.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSecundaria.Image = Image.FromFile(ofd.FileName);
            }
        }

        //Volver atrás
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.parent.Visible = true;
        }

        // Dependiendo del ID que le venga, vaciará todos los campos o los dejará con los datos iniciales del producto
        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (idProd != -1)
            {
                Datos.Modelos.Producto prod = new Logica.Controles.ProductoControl().ObtenerProductoPorID(idProd);

                pbPrincipal.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto1);
                pbSecundaria.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(prod.Foto2);
                tbNombre.Text = prod.Nombre;
                tbDescripcion.Text = prod.Descripcion;
                tbPrecio.Text = prod.Precio.ToString();
                numStock.Value = prod.Stock;
                tbCategoria.Text = prod.Categoria;
            }
            else
            {
                pbPrincipal.Image = Resources.imgPpal;
                pbSecundaria.Image = Resources.imgSecun;
                tbNombre.ResetText();
                tbDescripcion.ResetText();
                tbCategoria.ResetText();
                tbPrecio.ResetText();
                numStock.Value = 0;
            }
        }

        // Guarda un producto nuevo o edita uno existente dependiendo del ID que le llegue
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {

                // Si hay que crear producto nuevo
                if (idProd == -1)
                {
                    Datos.Modelos.Producto producto = CrearProducto();
                    bool cierto = new Logica.Controles.ProductoControl().InsertarProducto(producto);
                    if (cierto)
                    {
                        MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else// Si hay que editar uno ya existente
                {
                    Datos.Modelos.Producto producto = CrearProducto();
                    bool cierto = new Logica.Controles.ProductoControl().EditarProducto(idProd, producto);
                    if (cierto)
                    {
                        MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos Incorrectos, revise sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Comprobación de campos del producto 
        private bool ComprobarCampos()
        {
            string patronPrecio = @"^\d+(,\d{1,2})?$";

            if (tbNombre.Text == null || tbNombre.Text.Equals(""))
            {
                return false;
            }
            if (tbDescripcion.Text == null || tbDescripcion.Text.Equals(""))
            {
                return false;
            }
            if (tbPrecio.Text == null || tbPrecio.Text.Equals(""))
            {
                return false;
            }
            if (!Regex.IsMatch(tbPrecio.Text, patronPrecio))
            {
                return false;
            }
            if (numStock.Value <= 0 || numStock.Value > 1000)
            {
                return false;
            }
            if (tbCategoria.Text == null || tbCategoria.Text.Equals(""))
            {
                return false;
            }

            return true;
        }


        //Creación de un producto
        private Producto CrearProducto()
        {
            Datos.Modelos.Producto prodd = new Datos.Modelos.Producto();

            prodd.Nombre = tbNombre.Text;
            prodd.Descripcion = tbDescripcion.Text;
            prodd.Precio = Convert.ToDecimal(tbPrecio.Text);
            prodd.Stock = Convert.ToInt32(numStock.Value);
            prodd.Categoria = tbCategoria.Text;


            if (pbPrincipal.Image != null)
            {
                prodd.Foto1 = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbPrincipal.Image);
            }
            if (pbSecundaria.Image != null)
            {
                prodd.Foto2 = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbSecundaria.Image);
            }

            return prodd;
        }


        // Comprobar formato del precio y marcar el textbox en rojo si es incorrecto
        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            string texto = tbPrecio.Text;

            if (Regex.IsMatch(texto, @"^\d+(,\d{1,2})?$"))
            {
                tbPrecio.BackColor = Color.White;
            }
            else
            {
                tbPrecio.BackColor = Color.LightCoral;
                MessageBox.Show("Precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}
