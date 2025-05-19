using Datos.Modelos;
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


            LoadUserControl(new UserContUsuario.ProductoBotonContenedor(usuarioSesion.Email));

        }

        //Método para cargar el control de usuario correspondiente
        private void LoadUserControl(UserControl userControl)
        {

            panelCentral.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CredentialsManager.DeleteCredentials();

            this.Close();
            parent.Show();
        }

        private void btnMisClases_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserContUsuario.ClaseBotonContenedor(usuarioSesion.Email, -2));
        }


        //Abrir vista de eliminación de cuenta
        private void btEliminarCuenta_Click(object sender, EventArgs e)
        {
            Views.VistaEliminacion.Eliminacion elim = new Views.VistaEliminacion.Eliminacion(this, usuarioSesion);
            elim.ShowDialog();
        }


        //Abrir vista de editar perfil, en caso de devolver OK recarga página para actualizar datos
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            Views.VistaUsuario.EditarUsuario edit = new Views.VistaUsuario.EditarUsuario(this, usuarioSesion.Email);
            var resultado = edit.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                recargarNombre(usuarioSesion.Email);
            }
        }

        private void btnMisRecetas_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserContUsuario.UCRecetasUsuario(usuarioSesion.Email));
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserContUsuario.RecetaBotonContenedor(usuarioSesion.Email));
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserContUsuario.ClaseBotonContenedor(usuarioSesion.Email, 1));
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserContUsuario.ProductoBotonContenedor(usuarioSesion.Email));
        }

        //Cambio de datos al editar usuario
        private void recargarNombre( string email)
        {
            Usuario usuRec = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(email);
            lbBienvenidaAdmin.Text = usuRec.Nombre + " " + usuRec.Apellido;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(usuRec.Foto);
        }
    }
}
