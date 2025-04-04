﻿using CookMe.Properties;
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

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
        }

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

                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ComprobarCampos()
        {
            string patronPrecio = @"^\d{1,3}(\,\d{1,2})?$";

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
                if (!Regex.IsMatch(tbPrecio.Text, patronPrecio))
                {
                    return false;
                }
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
    }
}
