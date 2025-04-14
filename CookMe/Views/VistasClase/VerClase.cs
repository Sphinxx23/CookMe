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

namespace CookMe.Views.VistasClase
{
    public partial class VerClase : Form
    {
        private int idClase, idAccion;
        private string email;

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValorar_Click(object sender, EventArgs e)
        {
            //Añadir funcionalidad
        }

        private void btInscribir_Click(object sender, EventArgs e)
        {
            //Añadir funcionalidad

            if (this.idAccion==1)
            {
                //Apuntarse
            }
            else
            {
                //Borrarse
            }
        }

        public VerClase(int id, string email, int accion)
        {
            InitializeComponent();
            this.email = email;
            this.idClase=id;
            this.idAccion = accion;

            Datos.Modelos.Clase clase = new Logica.Controles.ClaseControl().ObtenerClasePorID(this.idClase);
            lbTitulo.Text = clase.Titulo;
            lbDescripcion.Text = clase.Descripcion;
            lbFecha.Text = clase.Fecha;
            lbPlazas.Text = clase.PlazaOcupada + "/" + clase.PlazaTotal;
            lbValoracion.Text = clase.ValoracionMedia.ToString();
            pbTematica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTematica.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoTematica);

            Datos.Modelos.Usuario usu = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(this.email);
            lbProfesor.Text = this.email;
            pbProfesor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfesor.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(usu.Foto);


            if (this.idAccion==1)
            {
                btInscribir.BackColor = Color.LightSkyBlue;
                btInscribir.Text = "Inscribirse";
                btnValorar.Visible = false;
            }
            else
            {
                btInscribir.BackColor = Color.LightCoral;
                btInscribir.Text = "Borrarse";
                btnValorar.Visible = true;
            }
        }



    }
}
