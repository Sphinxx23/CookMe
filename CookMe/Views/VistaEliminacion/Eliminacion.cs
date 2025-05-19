using Datos.Security;
using Logica.Controles;
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

namespace CookMe.Views.VistaEliminacion
{
    public partial class Eliminacion : Form
    {
        private Form parent;
        private Datos.Modelos.Usuario usuarioSesion;
        public Eliminacion(Form parent, Datos.Modelos.Usuario usu)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = CookMe.Properties.Resources.CookMeG;
            this.parent = parent;
            this.usuarioSesion = usu;
        }

        //Volver atrás
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
        }

        // Comprobación de campos con la bbdd y pregunta de confirmación
        private void btEliminarSi_Click(object sender, EventArgs e)
        {
            if (tbContrasenaLogin.Text.Equals("") || tbContrasenaLogin.Text == null)
            {
                lbErrorCredenciales.Text = "Rellena con tu contraseña";
            }
            else
            {

                if (Hasher.VerifyPassword(tbContrasenaLogin.Text, usuarioSesion.Contrasena))
                {
                    DialogResult result = MessageBox.Show(
                        "¿Está seguro de que deseas eliminar tu cuenta?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        bool eliminado = new Logica.Controles.UsuarioControl().EliminarUsuarioPorEmail(usuarioSesion.Email);

                        if (eliminado)
                        {
                            MessageBox.Show("Cuenta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CredentialsManager.DeleteCredentials();
                            this.Close();
                            parent.Close();

                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
                else
                {
                    lbErrorCredenciales.Text = "   Contraseña incorrecta";
                    lbErrorCredenciales.ForeColor = Color.Red;
                }

            }
        }

        //Visualiza/esconde la contraseña
        private void botonImagen2_Click(object sender, EventArgs e)
        {


            if (tbContrasenaLogin.PasswordChar == '*')
            {
                tbContrasenaLogin.PasswordChar = '\0';
                botonImagen2.ButtonImage = Properties.Resources.invisible;

            }
            else
            {
                tbContrasenaLogin.PasswordChar = '*';
                botonImagen2.ButtonImage = Properties.Resources.ojo1;
            }

        }
    }
}
