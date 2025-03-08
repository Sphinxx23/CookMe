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
            lbBienvenidaUsuario.Text = "BIENVENIDO  " + usuarioSesion.Nombre + "  " + usuarioSesion.Apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CredentialsManager.DeleteCredentials();

            this.Close();
        }
    }
}
