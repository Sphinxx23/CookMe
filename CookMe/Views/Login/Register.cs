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

namespace CookMe.Views.Login
{
    public partial class Register : Form
    {
        private Form parent;
        public Register(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ctrHas = Hasher.HashPassword("raul1");
            
            Datos.Modelos.Usuario usu;
            usu = new Usuario
            (
                "raulote147@gmail.com",
                "raul",
                "oteizza",
                "duqeus de najera 5",
                ctrHas,
                "perfil.jpg",
                "usuario",
                true);

            bool cierto = new Logica.Controles.UsuarioControl().InsertarUsuario(usu);


            if (cierto)
            {
                Views.Login.Login log = new Views.Login.Login(parent);
                log.Show();
                this.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ctrHas = Hasher.HashPassword("admin2");
            Datos.Modelos.Usuario usu;
            usu = new Usuario
            (
                "segundoadmin@gmail.com",
                "el segundo",
                "aaadmin",
                "calle calle",
                ctrHas,
                "perfil.jpg",
                "administrador",
                false);

            bool cierto = new Logica.Controles.UsuarioControl().InsertarUsuario(usu);


            if (cierto)
            {
                Views.Login.Login log = new Views.Login.Login(parent);
                log.Show();
                this.Close();

            }
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Visible = true;
        }
    }
}
