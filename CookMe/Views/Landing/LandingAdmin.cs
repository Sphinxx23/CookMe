using CookMe.Views.Landing.UserContAdmin;
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
    public partial class LandingAdmin : Form
    {
        private Form parent;
        private Datos.Modelos.Usuario usuarioSesion;
        public LandingAdmin(Form parent, Datos.Modelos.Usuario usu)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.parent = parent;
            this.usuarioSesion = usu;
            lbBienvenidaAdmin.Text = usuarioSesion.Nombre + " " + usuarioSesion.Apellido;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image= CookMe.MetodosImages.MetImages.ConvertBytesToImage(usuarioSesion.Foto);    
        }

        private void LoadUserControl(UserControl userControl)
        {
           
            panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill; 
            panel2.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CredentialsManager.DeleteCredentials();

            this.Close();
            parent.Show();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCGestionProductos());
        }
        

        private void customButton5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCGestionUsuarios());          
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCGestionRecetas());
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCGestionClases());
        }

    }
}
