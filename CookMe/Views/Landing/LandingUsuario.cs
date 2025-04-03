using Datos.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Landing
{
    public partial class LandingUsuario : Form
    {
        private Form parent;
        private Datos.Modelos.Usuario usuarioSesion;
        public LandingUsuario(Form parent, Datos.Modelos.Usuario usu)
        {
            InitializeComponent();
            this.parent = parent;
            this.usuarioSesion = usu;

            lbBienvenidaAdmin.Text = usuarioSesion.Nombre + " " + usuarioSesion.Apellido;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(usuarioSesion.Foto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CredentialsManager.DeleteCredentials();

            this.Close();
            parent.Show();
        }

        private void btnMisClases_Click(object sender, EventArgs e)
        {

        }

        private void btEliminarCuenta_Click(object sender, EventArgs e)
        {
            Views.VistaEliminacion.Eliminacion elim = new Views.VistaEliminacion.Eliminacion(this, usuarioSesion);
            elim.Show();
        }
    }
}
