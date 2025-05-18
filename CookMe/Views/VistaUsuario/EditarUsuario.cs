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

namespace CookMe.Views.VistaUsuario
{
    public partial class EditarUsuario : Form
    {
        private Form parent;
        private string email;
        Datos.Modelos.Usuario usu;
        public EditarUsuario(Form parent, string email)
        {
            InitializeComponent();
            this.parent = parent;
            this.email = email; 

            this.usu = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(this.email);

            if (usu!=null)
            {
                tbNombreRegis.Text = usu.Nombre;
                tbApellidosregis.Text = usu.Apellido;
                tbDireccionRegis.Text = usu.Direccion;
                pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPerfil.Image =  CookMe.MetodosImages.MetImages.ConvertBytesToImage(usu.Foto);
                chbProfesor.Checked = usu.Profesor;
            }
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btVaciarCampos1_Click(object sender, EventArgs e)
        {
            tbNombreRegis.Text = usu.Nombre;
            tbApellidosregis.Text = usu.Apellido;
            tbDireccionRegis.Text = usu.Direccion;
            pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoPerfil.Image = CookMe.MetodosImages.MetImages.ConvertBytesToImage(usu.Foto);
            chbProfesor.Checked = usu.Profesor;
        }

        private void btSeleccion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPerfil.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                Datos.Modelos.Usuario usu2 = CrearUsuario();
                bool cierto = new Logica.Controles.UsuarioControl().EditarUsuario(this.usu.Email, usu2);
                if (cierto)
                {
                    MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al editar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbErrorEditar.Text = "No puedes dejar campos vacios";
                lbErrorEditar.ForeColor = Color.RoyalBlue;
            }
        }

        private bool ComprobarCampos()
        {

            if (tbNombreRegis.Text.Equals("") || tbNombreRegis.Text == null)
            {
                return false;
            }

            if (tbApellidosregis.Text.Equals("") || tbApellidosregis.Text == null)
            {
                return false;
            }

            if (tbDireccionRegis.Text.Equals("") || tbDireccionRegis.Text == null)
            {
                return false;
            }
            return true;
        }

        private Usuario CrearUsuario()
        {
            Datos.Modelos.Usuario usuu = new Datos.Modelos.Usuario();

            usuu.Email = this.usu.Email;
            usuu.Nombre = tbNombreRegis.Text;
            usuu.Apellido = tbApellidosregis.Text;
            usuu.Direccion = tbDireccionRegis.Text;
            usuu.Contrasena = this.usu.Contrasena;
            usuu.Rol = "usuario";
            usuu.Profesor = chbProfesor.Checked;

            if (pbFotoPerfil.Image != null)
            {
                usuu.Foto = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbFotoPerfil.Image);
            }


            return usuu;
        }
    }
}
