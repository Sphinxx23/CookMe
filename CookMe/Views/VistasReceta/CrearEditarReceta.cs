using CookMe.Properties;
using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.VistasReceta
{
    public partial class CrearEditarReceta : Form
    {
        private UserControl parent;
        private int idRec;
        private string emailUs;

        // Crea el form con los campos vacíos o llenos con los datos de una receta dependiendo del id
        public CrearEditarReceta(UserControl parent, int idRec, string emailUs)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.idRec = idRec;
            this.emailUs = emailUs;
            InitializeComponent();
            this.parent = parent;
            pbFotoTematica.SizeMode = PictureBoxSizeMode.StretchImage;


            if (this.idRec == -1)
            {
                pbFotoTematica.Image = Resources.imgSecun;

            }
            else
            {
                Datos.Modelos.Receta rece = new Logica.Controles.RecetaControl().ObtenerRecetaPorID(idRec);

                pbFotoTematica.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(rece.Foto);
                tbTitulo.Text = rece.Titulo;
                tbDescripcion.Text = rece.DescripcionBreve;
                tbIngredientes.Text = rece.Ingrediente;
                tbPasos.Text = rece.Pasos;

            }
        }

        // Abre cuadro de diálogo para seleccionar foto
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoTematica.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoTematica.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Vacía los campos o los deja con los datos iniciales dependiendo del id 
        private void btBorrarR_Click(object sender, EventArgs e)
        {
            if (idRec != -1)
            {
                Datos.Modelos.Receta rece = new Logica.Controles.RecetaControl().ObtenerRecetaPorID(idRec);

                pbFotoTematica.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(rece.Foto);
                tbTitulo.Text = rece.Titulo;
                tbDescripcion.Text = rece.DescripcionBreve;
                tbIngredientes.Text = rece.Ingrediente;
                tbPasos.Text = rece.Pasos;
            }
            else
            {
                pbFotoTematica.Image = Resources.imgSecun;
                tbTitulo.ResetText();
                tbDescripcion.ResetText();
                tbIngredientes.ResetText();
                tbPasos.ResetText();
            }
        }

        // Guarda y crea una nueva receta o edita una existente dependiendo del ID
        private void btGuardarR_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {

                // Si hay que crear receta nueva
                if (idRec == -1)
                {
                    Datos.Modelos.Receta receta = CrearReceta();
                    bool cierto = new Logica.Controles.RecetaControl().InsertarReceta(receta);
                    if (cierto)
                    {
                        MessageBox.Show("Receta creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else// Si hay que editar una ya existente
                {
                    Datos.Modelos.Receta receta = CrearReceta();
                    bool cierto = new Logica.Controles.RecetaControl().EditarReceta(idRec, receta);
                    if (cierto)
                    {
                        MessageBox.Show("Receta editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al editar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Crear una receta
        private Receta CrearReceta()
        {
            Datos.Modelos.Receta rece = new Datos.Modelos.Receta();

            rece.Titulo = tbTitulo.Text;
            rece.Ingrediente=tbIngredientes.Text;
            rece.DescripcionBreve=tbDescripcion.Text;
            rece.Pasos = tbPasos.Text;

            if (idRec==-1)
            {
                rece.EmailUsuario = emailUs;
            }
            else
            {
                Datos.Modelos.Receta rec = new Logica.Controles.RecetaControl().ObtenerRecetaPorID(idRec);
                rece.EmailUsuario = rec.EmailUsuario;

            }

            if (pbFotoTematica.Image != null)
            {
                rece.Foto = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbFotoTematica.Image);
            }

            return rece;
        }

        //Comprobacion de campos del form
        private bool ComprobarCampos()
        {
            if (tbTitulo.Text == null || tbTitulo.Text.Equals(""))
            {
                return false;
            }
            if (tbDescripcion.Text == null || tbDescripcion.Text.Equals(""))
            {
                return false;
            }
            if (tbIngredientes.Text == null || tbIngredientes.Text.Equals(""))
            {              
                    return false;              
            }
            if (tbPasos.Text == null || tbPasos.Text.Equals(""))
            {
                return false;
            }
            return true;
        }


        //Volver atrás
        private void botonImagen2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.parent.Visible = true;
        }

    }
}
