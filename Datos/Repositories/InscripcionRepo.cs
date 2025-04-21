using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class InscripcionRepo
    {

        public bool InsertarInscripcion(Inscripcion insc)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"INSERT INTO inscripcion 
                                                  (email_usuario, id_clase, valoracion, inscripcion_activa) 
                                                  VALUES (@Email, @IdClase, @Valoracion, TRUE)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Email", insc.EmailUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", insc.IdClase);
                        cmd.Parameters.AddWithValue("@Valoracion", insc.Valoracion);

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

        public bool BorrarInscripcion(Inscripcion insc)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"UPDATE inscripcion 
                                                  SET inscripcion_activa = FALSE 
                                                  WHERE email_usuario = @Email AND id_clase = @IdClase", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Email", insc.EmailUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", insc.IdClase);

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

        public double ObtenerMediaValoracionClase(int idClase)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"SELECT AVG(valoracion) 
                                                  FROM inscripcion 
                                                  WHERE id_clase = @IdClase", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != DBNull.Value && resultado != null)
                        {
                            return Convert.ToDouble(resultado);
                        }

                        return 0.0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0.0;
            }
        }

        public bool EditarValoracionInscripcion(string emailUsuario, int idClase, double nuevaVal)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"UPDATE inscripcion 
                                                  SET valoracion = @Valoracion
                                                  WHERE email_usuario = @Email AND id_clase = @IdClase", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Valoracion", Convert.ToDecimal(nuevaVal));
                        cmd.Parameters.AddWithValue("@Email", emailUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", idClase);

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

        public Inscripcion ObtenerInscripcion(string emailUsuario, int idClase)
        {
            try
            {
                Inscripcion inscripcion = null;

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM inscripcion WHERE email_usuario = @Email AND id_clase = @IdClase", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailUsuario);
                        cmd.Parameters.AddWithValue("@IdClase", idClase);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                inscripcion = new Inscripcion
                                {
                                    EmailUsuario = reader["email_usuario"] as string ?? string.Empty,
                                    IdClase = Convert.ToInt32(reader["id_clase"]),
                                    Valoracion = reader["valoracion"] != DBNull.Value ? Convert.ToInt32(reader["valoracion"]) : 0,
                                    InscripcionActiva = Convert.ToBoolean(reader["inscripcion_activa"])
                                };

                                return inscripcion;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
