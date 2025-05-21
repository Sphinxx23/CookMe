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
        /// <summary>
        /// Obtener el usuario por email.
        /// </summary>
        /// <param name="email">El email.</param>
        /// <returns></returns>
        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            return new Datos.Repositories.UsuarioRepo().ObtenerUsuarioPorEmail(email);
               
        }

        /// <summary>
        /// Insertar  usuario.
        /// </summary>
        /// <param name="usuario"> usuario.</param>
        /// <returns></returns>
        public bool InsertarUsuario(Usuario usuario)
        {
            return new Datos.Repositories.UsuarioRepo().InsertarUsuario(usuario);
            
        }

        /// <summary>
        /// Editar usuario.
        /// </summary>
        /// <param name="emailViejo"> email viejo.</param>
        /// <param name="usuario"> usuario.</param>
        /// <returns></returns>
        public bool EditarUsuario(string emailViejo, Usuario usuario)
        {
            return new Datos.Repositories.UsuarioRepo().EditarUsuario(emailViejo, usuario);

        }

        /// <summary>
        /// Eliminar usuario por email.
        /// </summary>
        /// <param name="email"> email.</param>
        /// <returns></returns>
        public bool EliminarUsuarioPorEmail(string email)
        {
            return new Datos.Repositories.UsuarioRepo().EliminarUsuarioPorEmail(email);

        }

        /// <summary>
        /// Obtener todos usuarios.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return new Datos.Repositories.UsuarioRepo().ObtenerTodosUsuarios();
        }

        /// <summary>
        /// Obtener profesores.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerProfesores()
        {
            return new Datos.Repositories.UsuarioRepo().ObtenerProfesores();
        }



    }
}
