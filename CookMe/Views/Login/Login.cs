
using Datos.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CookMe.Views.Login
{
    public partial class Login : Form
    {
        private Form parent;
        public Login(Form parent)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = CookMe.Properties.Resources.CookMeG;
            this.parent = parent;
        }

        //Volver atrás
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
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
        //VAcia los campos
        private void btBorrarCamposLogin1_Click(object sender, EventArgs e)
        {
            tbEmailLogin.ResetText();
            tbContrasenaLogin.ResetText();
            lbErrorCredenciales.ResetText();
        }

        //Comprueba las credenciales en bbdd y abre el landing correspondiente
        private void btAccederLogin1_Click(object sender, EventArgs e)
        {
            if (tbEmailLogin.Text.Equals("") || tbEmailLogin.Text == null)
            {
                lbErrorCredenciales.Text = "          El campo EMAIL no puede estar vacío";
                lbErrorCredenciales.ForeColor = Color.Red;
            }
            else if (tbContrasenaLogin.Text.Equals("") || tbContrasenaLogin.Text == null)
            {
                lbErrorCredenciales.Text = "   El campo CONTRASEÑA no puede estar vacío";
                lbErrorCredenciales.ForeColor = Color.Red;
            }
            else
            {
                Datos.Modelos.Usuario usu = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(tbEmailLogin.Text);
                if (usu != null)
                {
                    if (Hasher.VerifyPassword(tbContrasenaLogin.Text, usu.Contrasena))
                    {
                        if (usu.Rol.Equals("administrador"))
                        {
                            Views.Landing.LandingAdmin landingAdmin = new Views.Landing.LandingAdmin(parent, usu);
                            CredentialsManager.SaveCredentials(usu.Email, usu.Contrasena);
                            landingAdmin.Show();
                            this.Close();
                        }
                        else
                        {
                            Views.Landing.LandingUsuario landingUsu = new Views.Landing.LandingUsuario(parent, usu);
                            CredentialsManager.SaveCredentials(usu.Email, usu.Contrasena);
                            landingUsu.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        lbErrorCredenciales.Text = "                       Credenciales incorrectas";
                        lbErrorCredenciales.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lbErrorCredenciales.Text = "                       Credenciales incorrectas";
                    lbErrorCredenciales.ForeColor = Color.Red;
                }
            }
        }
    }
}