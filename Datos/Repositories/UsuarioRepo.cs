using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Datos.Repositories
{
    public class UsuarioRepo
    {
        public Usuario ObtenerUsuarioPorEmail(string email)
        {
            try
            {
                Usuario usu = null;
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM usuario WHERE email = @email", conexion))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                usu = new Usuario
                                {
                                    Email = reader["email"] as string ?? string.Empty,
                                    Nombre = reader["nombre"] as string ?? string.Empty,
                                    Apellido = reader["apellido"] as string ?? string.Empty,
                                    Direccion = reader["direccion"] as string ?? string.Empty,
                                    Contrasena = reader["contrasena"] as string ?? string.Empty,
                                    Foto = reader["foto"] as byte[],
                                    Rol = reader["rol"] as string ?? string.Empty,
                                    Profesor = reader["profesor"] != DBNull.Value && Convert.ToBoolean(reader["profesor"])
                                };

                                return usu;
                            }
                            else
                            {

                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO usuario (email, nombre, apellido, direccion, contrasena, foto, rol, profesor) VALUES (@Email, @Nombre, @Apellido, @Direccion, @Contrasena, @Foto, @Rol, @Profesor)", conexion))
                    {

                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(usuario.Email) ? (object)DBNull.Value : usuario.Email);
                        cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(usuario.Nombre) ? (object)DBNull.Value : usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", string.IsNullOrEmpty(usuario.Apellido) ? (object)DBNull.Value : usuario.Apellido);
                        cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(usuario.Direccion) ? (object)DBNull.Value : usuario.Direccion);
                        cmd.Parameters.AddWithValue("@Contrasena", string.IsNullOrEmpty(usuario.Contrasena) ? (object)DBNull.Value : usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@Foto", usuario.Foto == null || usuario.Foto.Length == 0 ? (object)DBNull.Value : usuario.Foto);
                        cmd.Parameters.AddWithValue("@Rol", string.IsNullOrEmpty(usuario.Rol) ? (object)DBNull.Value : usuario.Rol);
                        cmd.Parameters.AddWithValue("@Profesor", usuario.Profesor);


                        int filasAfectadas = cmd.ExecuteNonQuery();


                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public List<Usuario> ObtenerTodosUsuarios()
        {
            try
            {
                List<string> listaCorreos = new List<string>();
                List<Usuario> listaUsuarios = new List<Usuario>();

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT email FROM usuario WHERE rol='usuario'", conexion))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaCorreos.Add(reader["email"] as string ?? string.Empty);
                            }
                        }
                    }
                }

                foreach (string correo in listaCorreos)
                {
                    listaUsuarios.Add(ObtenerUsuarioPorEmail(correo));
                }

                return listaUsuarios;
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        public bool EliminarUsuarioPorEmail(string email)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("DELETE FROM usuario WHERE email = @email", conexion))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        // Ejecutamos el comando y verificamos si se eliminaron filas
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Si se eliminaron filas, devolvemos true
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, devolvemos false
                return false;
            }
        }






        public string ProbarConexion()
        {
            try
            {
                var conexion = Conexion.Conexion.EstablecerConexion();

                // Intentar abrir la conexión
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    return "Conexión exitosa!";
                }


                return "wtf";
            }
            catch (NpgsqlException npgEx)
            {

                return $"Error de conexión con PostgreSQL: {npgEx.Message}";
            }
            catch (Exception ex)
            {

                return $"Error general: {ex.Message}";
            }
        }

    }
}
