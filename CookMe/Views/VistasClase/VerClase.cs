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
            Views.VistasClase.Valorar val = new Views.VistasClase.Valorar(this.idClase, this.email, this);
            val.ShowDialog();
        }

        private void btInscribir_Click(object sender, EventArgs e)
        {          
            Inscripcion inscApuntar = CrearInscripcion();
            Inscripcion comprobarInsc = new Logica.Controles.InscripcionControl().ObtenerInscripcion(this.email, this.idClase);

            if (comprobarInsc == null)
            {
                if (this.idAccion == 1)
                {
                    Clase clas = new Logica.Controles.ClaseControl().ObtenerClasePorID(this.idClase);
                    if (clas.PlazaOcupada<clas.PlazaTotal)
                    {
                        //Apuntarse               
                        bool creacion = new Logica.Controles.InscripcionControl().InsertarInscripcion(inscApuntar);
                        clas.PlazaOcupada += 1;
                        bool edicionClase = new Logica.Controles.ClaseControl().EditarClase(clas.Id, clas);
                        MessageBox.Show("Inscrito correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        MessageBox.Show("Plazas llenas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                
                }
            }
            else if(comprobarInsc != null && this.idAccion == 1)
            {
                MessageBox.Show("No puedes volver a inscribirte a esta Clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(this.idAccion != 1)
            {
                //Borrarse
                bool borrado = new Logica.Controles.InscripcionControl().BorrarInscripcion(inscApuntar);
                Datos.Modelos.Clase clas = new Logica.Controles.ClaseControl().ObtenerClasePorID(this.idClase);
                clas.PlazaOcupada -= 1;
                bool edicionClase = new Logica.Controles.ClaseControl().EditarClase(clas.Id, clas);
                MessageBox.Show("Borrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private Inscripcion CrearInscripcion()
        {
            Inscripcion insc = new Inscripcion();
            insc.EmailUsuario = this.email;
            insc.IdClase = this.idClase;
            insc.InscripcionActiva = true;
            insc.Valoracion = 0;
            return insc;
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
