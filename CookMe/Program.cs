using CookMe.Views.Landing;
using Datos.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var credentials = CredentialsManager.LoadCredentials();
            if (credentials != null)
            {
                Datos.Modelos.Usuario usu = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(credentials.Email);
                if (usu != null)
                {
                    if (usu.Rol.Equals("administrador"))
                    {
                        Application.Run(new LandingAdmin(new Form1(), usu));
                    }
                    else
                    {
                        Application.Run(new LandingUsuario(new Form1(), usu));
                    }
                }

            }
            else
            {
                Application.Run(new Form1());
            }





        }
    }
}