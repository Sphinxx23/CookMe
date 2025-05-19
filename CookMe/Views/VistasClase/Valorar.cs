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
    public partial class Valorar : Form
    {
        private int idClase;
        private string email;
        private Form parent;
        public Valorar(int idClase, string email, Form parent)
        {
            InitializeComponent();
            this.email = email;
            this.idClase = idClase;
            this.parent = parent;
            pbStar3.Visible = false;
            pbStar4.Visible = false;
            pbStar5.Visible = false;
        }


        // Edita la inscripción en bbdd, cambiando la valoración por una nueva (1-5)
        private void btnValorarFinal_Click(object sender, EventArgs e)
        { 
            double valoracNueva = tBValoracion.Value;
            bool editarValInsc = new Logica.Controles.InscripcionControl().EditarValoracionInscripcion(this.email, this.idClase, valoracNueva);
            if (editarValInsc)
            {
                Datos.Modelos.Clase clas = new Logica.Controles.ClaseControl().ObtenerClasePorID(this.idClase);
                double media = new Logica.Controles.InscripcionControl().ObtenerMediaValoracionClase(this.idClase);
                clas.ValoracionMedia = Convert.ToDecimal(media);
                bool edicionClase = new Logica.Controles.ClaseControl().EditarClase(clas.Id, clas);

                if (edicionClase)
                {
                    MessageBox.Show("Valorada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al valorar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al valorar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            this.parent.Close();
        }


        //Lógica para mostrar u ocultar las estrellas según la barra slider
        private void tBValoracion_ValueChanged(object sender, EventArgs e)
        {
            PictureBox[] values = { pbStar1, pbStar2, pbStar3, pbStar4, pbStar5 };
            int valor = tBValoracion.Value;
            for (int i = 0; i < valor; i++)
            {
                values[i].Visible = true;
            }

            if (values.Length - valor > 0)
            {
                for (int j = valor; j < values.Length; j++)
                {
                    values[j].Visible = false;
                }
            }
        }
    }
}
