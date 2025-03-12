using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Controles
{
    public class UsuarioControl
    {
        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            return new Datos.Repositories.UsuarioRepo().ObtenerUsuarioPorEmail(email);
               
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            return new Datos.Repositories.UsuarioRepo().InsertarUsuario(usuario);
            
        }

        public bool EliminarUsuarioPorEmail(string email)
        {
            return new Datos.Repositories.UsuarioRepo().EliminarUsuarioPorEmail(email);

        }


        public string ProbarConexion()
        {
            return new Datos.Repositories.UsuarioRepo().ProbarConexion();
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return new Datos.Repositories.UsuarioRepo().ObtenerTodosUsuarios();
        }



    }
}
