using CookMe.Properties;
using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        // Depende del idClase que llegue, abre el crear clase con los campos vacíos o el editar una existente 
        // con los campos rellenados con los actuales de esa clase
        public CrearEditarClase(UserControl parent, int idClase)
        {
            this.FormBorderStyle = FormBorderStyle.None;
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
                cboxProfesor.SelectedIndex = ObtenerIndiceSeleccionado(clase);

            }

            
        }

        // Abre diálogo para seleccionar foto
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

        //Volver atrás
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.parent.Visible = true;
        }

        //Si estás en editar, vuelve a los datos iniciales, si estás en crear, vacía todos 
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
                cboxProfesor.SelectedIndex = ObtenerIndiceSeleccionado(clase);
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

        //Carga con los profesores existentes, siempre mete por defecto "Sin profesor" aunque no se pueda seleccionar
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


        //Obtener el índice
        private int ObtenerIndiceSeleccionado(Datos.Modelos.Clase clase)
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

        // Crear o editar la clase según corresponda y devolver OK
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
                        MessageBox.Show("Clase creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else 
                    {
                        MessageBox.Show("Error al crear la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else// Si hay que editar una ya existente
                {
                    Datos.Modelos.Clase clase = CrearClase();
                    bool cierto = new Logica.Controles.ClaseControl().EditarClase(idClase, clase);
                    if (cierto)
                    {
                        MessageBox.Show("Clase editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        parent.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al editar la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        //Creación de clase para inserción/edición
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

        // Busqueda de email en el combobox
        private string BuscarEmailProfesor()
        {
            int indice = cboxProfesor.SelectedIndex-1;
           
            Usuario usu = profesoresGeneral[indice];

            return usu.Email;
        }


        //Comprobar todos los campos para poder crear/editar clase
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

        //Comprueba el formato de la fecha y si existe, si no lo cumple marca el textbox en rojo
        private void tbFecha_Leave(object sender, EventArgs e)
        {
            string texto = tbFecha.Text;

            if (DateTime.TryParseExact(texto, "dd-MM-yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaHora))
            {
                
                tbFecha.BackColor = Color.White;
            }
            else
            {
                
                tbFecha.BackColor = Color.LightCoral;
                MessageBox.Show("Fecha y hora no válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}
