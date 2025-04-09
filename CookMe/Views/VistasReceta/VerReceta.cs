using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.VistasReceta
{
    public partial class VerReceta : Form
    {
        private int idReceta;
        public VerReceta(int id)
        {
            InitializeComponent();
            this.idReceta = id;
            Datos.Modelos.Receta receta = new Logica.Controles.RecetaControl().ObtenerRecetaPorID(this.idReceta);
            lblTituloVer.Text =receta.Titulo;
            lblDescripcionVer.Text = receta.DescripcionBreve;
            lblUsuarioVer.Text =receta.EmailUsuario;
            lblPasosVer.Text =receta.Pasos;
            lblIngredientesVer.Text = receta.Ingrediente;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(receta.Foto);
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
