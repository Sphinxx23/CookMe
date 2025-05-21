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

namespace CookMe.Views.Landing.UserContUsuario
{
    public partial class ClaseBotonContenedor : UserControl
    {
        private Panel panelContenedor;
        private string email;
        private int idAccion;

        //Dependiendo del id que llegue, carga todas las clases o solo las clases en las que este apuntado el usuario
        public ClaseBotonContenedor(string email, int id )
        {
            InitializeComponents();
            this.email = email;
            this.idAccion = id;
            List<Datos.Modelos.Clase> clases;

            if (this.idAccion == 1)
            {
                clases = new Logica.Controles.ClaseControl().ObtenerTodasLasClases();
            }
            else
            {
                clases = new Logica.Controles.ClaseControl().ObtenerInscripcionesPorEmail(this.email);
            }

            LoadClases(clases);
        }

        //Creación manual de los elementos que contendrá el "item"
        private void InitializeComponents()
        {
            this.Size = new Size(195, 500);

            panelContenedor = new Panel()
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            this.Controls.Add(panelContenedor);
        }

        //Carga de registros de bbdd controlando su espaciado vertical
        public void LoadClases(List<Datos.Modelos.Clase> clases)
        {
            panelContenedor.Controls.Clear();
            int distanciaVertical = 5;

            foreach (var clase in clases)
            {
                ClaseBoton claseControl = new ClaseBoton();
                Image imgClase = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoTematica);
                Image imgProf = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoProfesor);
                claseControl.AsignarDatosClase(clase.Id, clase.Titulo,clase.Descripcion ,clase.Fecha, (clase.PlazaTotal-clase.PlazaOcupada), clase.EmailProfesor, imgClase, imgProf);
                claseControl.Location = new Point(5, distanciaVertical);
                claseControl.ItemClicked += (s, e) => AbrirVistaClase(claseControl);

                panelContenedor.Controls.Add(claseControl);
                distanciaVertical += claseControl.Height + 5;
            }
        }

        //Abrir formulario para ver las clases, dependiendo del id que le llegue buscará todas
        // o únicamente en las que está apuntado actualmente el usuario
        private void AbrirVistaClase(ClaseBoton item)
        {
            Views.VistasClase.VerClase verClase = new Views.VistasClase.VerClase(item.id, this.email,item.emailProfe, this.idAccion);
            var resultado = verClase.ShowDialog();
            List<Datos.Modelos.Clase> clases;
            if (resultado == DialogResult.OK && this.idAccion == 1)
            {
                clases = new Logica.Controles.ClaseControl().ObtenerTodasLasClases();
                LoadClases(clases);
            }
            else if(resultado == DialogResult.OK && this.idAccion != 1)
            {
                clases = new Logica.Controles.ClaseControl().ObtenerInscripcionesPorEmail(this.email);
                LoadClases(clases);
            }
            
        }
    }
}

