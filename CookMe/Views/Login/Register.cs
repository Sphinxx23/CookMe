using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Login
{
    public partial class Register : Form
    {
        private Form parent;
        public Register(Form parent)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            pbFotoPerfil.SizeMode=PictureBoxSizeMode.StretchImage;  
            pbFotoPerfil.Image = CookMe.Properties.Resources.anonimoG;
            this.parent = parent;
        }

               
        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
        }

        
        private Usuario CrearUsuario()
        {
            Datos.Modelos.Usuario usuu = new Datos.Modelos.Usuario();

            usuu.Email=tbEmailRegis.Text;
            usuu.Nombre=tbNombreRegis.Text; 
            usuu.Apellido=tbApellidosregis.Text;
            usuu.Direccion=tbDireccionRegis.Text;
            usuu.Contrasena=  Hasher.HashPassword(tbCtraRegis1.Text);
            usuu.Rol = "usuario";
            usuu.Profesor = chbProfesor.Checked;

            if (pbFotoPerfil.Image != null)
            {
                usuu.Foto = CookMe.MetodosImages.MetImages.ConvertImageToBytes(pbFotoPerfil.Image);
            }


            return usuu;
        }

        private bool ComprobarConcordanciaContrasenas()
        {
            bool concuerdanContrasenas = tbCtraRegis1.Text.Equals(tbCtraRegis2.Text) ? true : false;
            return concuerdanContrasenas;
        }


      //Devuelve true si ya existe en bbdd  
        private bool ComprobarExistenciaEmail()
        {
            Datos.Modelos.Usuario usu = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(tbEmailRegis.Text);

            bool existeUsuario = usu != null ? true : false;
            return existeUsuario;
        }

        private bool ComprobarCampos()
        {
            if (tbEmailRegis.Text.Equals("")||tbEmailRegis.Text == null)
            {
                return false;
            }

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

            if (tbCtraRegis1.Text.Equals("") || tbCtraRegis1.Text == null)
            {
                return false;
            }

            if (tbCtraRegis2.Text.Equals("") || tbCtraRegis2.Text == null)
            {
                return false;
            }

            return true;
        }

        private bool ValidateGmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d).{6,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void botonImagen2_Click(object sender, EventArgs e)
        {

            if (tbCtraRegis1.PasswordChar == '*')
            {
                tbCtraRegis1.PasswordChar = '\0';
                botonImagen2.ButtonImage = Properties.Resources.invisible;

            }
            else
            {
                tbCtraRegis1.PasswordChar = '*';
                botonImagen2.ButtonImage = Properties.Resources.ojo1;
            }
        }

        private void botonImagen3_Click(object sender, EventArgs e)
        {
            if (tbCtraRegis2.PasswordChar == '*')
            {
                tbCtraRegis2.PasswordChar = '\0';
                botonImagen3.ButtonImage = Properties.Resources.invisible;

            }
            else
            {
                tbCtraRegis2.PasswordChar = '*';
                botonImagen3.ButtonImage = Properties.Resources.ojo1;
            }
        }

        

        private void btSeleccion_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "Images (*.png;*.jpg)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPerfil.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btVaciarCampos1_Click(object sender, EventArgs e)
        {
            tbEmailRegis.ResetText();
            tbNombreRegis.ResetText();
            tbApellidosregis.ResetText();
            tbDireccionRegis.ResetText();
            tbCtraRegis1.ResetText();
            tbCtraRegis2.ResetText();
            chbProfesor.Checked = false;
            lbError.ResetText();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos())
            {
                lbError.Text = "                           No puedes dejar campos sin rellenar";
                lbError.ForeColor = Color.Red;
            }
            else if (!ValidateGmail(tbEmailRegis.Text))
            {

                lbError.Text = "           Formato de GMAIL inválido, solo se acepta @gmail.com";
                lbError.ForeColor = Color.Red;

            }
            else if (ComprobarExistenciaEmail())
            {
                lbError.Text = "     Ya existe una cuenta asociada a este Email, inicie sesión en ella";
                lbError.ForeColor = Color.Blue;

            }
            else if (!ValidatePassword(tbCtraRegis1.Text))
            {
                // , mínimo 6 caracteres y un número
                lbError.Text = "                                Formato de Contraseña inválido";
                lbError.ForeColor = Color.Red;

            }
            else if (!ComprobarConcordanciaContrasenas())
            {
                lbError.Text = "                                  Las contraseñas no coinciden";
                lbError.ForeColor = Color.Red;
            }
            else
            {
                Datos.Modelos.Usuario usu = CrearUsuario();
                bool cierto = new Logica.Controles.UsuarioControl().InsertarUsuario(usu);
                if (cierto)
                {
                    Views.Login.Login land = new Views.Login.Login(parent);
                    land.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error de creación de usuario");
                }
            }
        }

        private void tbCtraRegis1_Leave(object sender, EventArgs e)
        {
            string password = tbCtraRegis1.Text;

            if (Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d).{6,}$"))
            {
                tbCtraRegis1.BackColor = Color.White;
            }
            else
            {
                tbCtraRegis1.BackColor = Color.LightCoral;
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres, con letras y al menos un número.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void tbCtraRegis2_Leave(object sender, EventArgs e)
        {
            if (!ComprobarConcordanciaContrasenas())
            {
                tbCtraRegis2.BackColor = Color.LightCoral;
                MessageBox.Show("Las contraseñas no coinciden", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                tbCtraRegis2.BackColor = Color.White;
            }
        }

        private void tbEmailRegis_Leave(object sender, EventArgs e)
        {

            if (ValidateGmail(tbEmailRegis.Text))
            {
                tbEmailRegis.BackColor = Color.White;
            }
            else
            {
                tbEmailRegis.BackColor = Color.LightCoral;
                MessageBox.Show("Introduce un correo válido que termine en @gmail.com", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
