using CookMe.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CookMe.Views.VistasClase
{
    public partial class CrearEditarClase : Form
    {
        private UserControl parent;
        private int idClase;
        List<Datos.Modelos.Usuario> profesoresGeneral;
        public CrearEditarClase(UserControl parent, int idClase)
        {
            this.idClase = idClase;
            InitializeComponent();
            this.parent = parent;
            pbImagenTematica.SizeMode = PictureBoxSizeMode.StretchImage;
            CargarComboBoxProfesor();

            if (this.idClase==-1)
            {                              
                pbImagenTematica.Image = Resources.clase21;
            }
            else
            {
                Datos.Modelos.Clase clase = new Logica.Controles.ClaseControl().ObtenerClasePorID(idClase);

                pbImagenTematica.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoTematica);                
                tbTitulo.Text = clase.Titulo;
                tbDescripcion.Text = clase.Descripcion;
                tbFecha.Text = clase.Fecha.ToString();
                numPlaza.Value=clase.PlazaTotal;
                cboxProfesor.SelectedIndex = ObtenerSelectedIndexCbox(clase);

            }

            
        }

        private void btSeleccionTematica_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagenTematica.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagenTematica.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
        }

        private void btBorrarTodo_Click(object sender, EventArgs e)
        {
            if (idClase!=-1)
            {
                Datos.Modelos.Clase clase = new Logica.Controles.ClaseControl().ObtenerClasePorID(idClase);
                pbImagenTematica.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoTematica);
                tbTitulo.Text = clase.Titulo;
                tbDescripcion.Text = clase.Descripcion;
                tbFecha.Text = clase.Fecha.ToString();
                numPlaza.Value = clase.PlazaTotal;
                cboxProfesor.SelectedIndex = ObtenerSelectedIndexCbox(clase);
            }
            else
            {
                pbImagenTematica.Image = Resources.clase21;
                tbTitulo.ResetText();
                tbDescripcion.ResetText();
                cboxProfesor.SelectedIndex = 0;
                tbFecha.ResetText();
                numPlaza.Value = 0;
            }

        }
        private void CargarComboBoxProfesor()
        {
            List<Datos.Modelos.Usuario> profesores = new Logica.Controles.UsuarioControl().ObtenerProfesores();
            List<string> nombresProfesores = new List<string>();

            nombresProfesores.Add("Sin Profesor");
            foreach (Datos.Modelos.Usuario profesor in profesores)
            {
                nombresProfesores.Add(profesor.Nombre + " " + profesor.Apellido);
            }
            profesoresGeneral = profesores;
            cboxProfesor.DataSource = nombresProfesores;
        }

        private int ObtenerSelectedIndexCbox(Datos.Modelos.Clase clase)
        {
            int indice = 0;
            int indFinal = 0;
            string email = clase.EmailProfesor;

            foreach (Datos.Modelos.Usuario item in profesoresGeneral)
            {
                if (item.Email.Equals(email))
                {
                    indFinal = indice;
                }
                else
                {
                    indice++;
                }
            }

            return indFinal+1;
        }

        private void btCrearClase_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {

                // Si hay que crear una nueva clase
                if (idClase == -1)
                {
                    Datos.Modelos.Clase clase = CrearClase();
                    bool cierto = new Logica.Controles.ClaseControl().InsertarClase(clase);
                    if (cierto)
                    {
                        MessageBox.Show("Clase añadida correctamente");
                        this.Close();
                        parent.Visible = true;
                    }
                    else 
                    {
                        MessageBox.Show("Error de creación de la clase");
                    }
                }
                else// Si hay que editar una ya existente
                {
                    Datos.Modelos.Clase clase = CrearClase();
                    bool cierto = new Logica.Controles.ClaseControl().EditarClase(idClase, clase);
                    if (cierto)
                    {
                        MessageBox.Show("Clase editada correctamente");
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error de edición de la clase");
                    }
                }
            }
            
        }

        private Clase CrearClase()
        {
            Datos.Modelos.Clase clase = new Datos.Modelos.Clase();

            clase.Titulo = tbTitulo.Text;
            clase.Descripcion = tbDescripcion.Text;
            clase.PlazaTotal = Convert.ToInt32(numPlaza.Value);
            clase.EmailProfesor = BuscarEmailProfesor();
            clase.Fecha= tbFecha.Text;

            if (idClase==-1)
            {
                clase.PlazaOcupada = 0;
                clase.ValoracionMedia=0;


            }
            else
            {
                Datos.Modelos.Clase claseVieja = new Logica.Controles.ClaseControl().ObtenerClasePorID(idClase);
                clase.ValoracionMedia = claseVieja.ValoracionMedia;
                clase.PlazaOcupada = claseVieja.PlazaOcupada;
            }
            
            if (pbImagenTematica.Image != null)
            {
                clase.FotoTematica = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbImagenTematica.Image);
            }

            return clase;
        }

        private string BuscarEmailProfesor()
        {
            int indice = cboxProfesor.SelectedIndex-1;
           
            Usuario usu = profesoresGeneral[indice];

            return usu.Email;
        }

        private bool ComprobarCampos()
        {
            if (tbTitulo.Text==null || tbTitulo.Text.Equals(""))
            {
                return false;
            }
            if (tbDescripcion.Text == null || tbDescripcion.Text.Equals(""))
            {
                return false;
            }
            if (tbFecha.Text == null || tbFecha.Text.Equals(""))
            {
                return false;
            }
            if (numPlaza.Value<=0||numPlaza.Value>25)
            {
                return false;
            }
            if (cboxProfesor.SelectedIndex==0)
            {
                return false;
            }

            return true;

        }
    }
}
