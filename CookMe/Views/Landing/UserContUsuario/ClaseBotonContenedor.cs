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

        private void AbrirVistaClase(ClaseBoton item)
        {
            Views.VistasClase.VerClase verClase = new Views.VistasClase.VerClase(item.id, this.email, this.idAccion);
            verClase.ShowDialog();
        }
    }
}

