using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class RecetaRepo
    {

        public Receta ObtenerRecetaPorId(int id)
        {
            try
            {
                Receta receta = null;
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM receta WHERE id = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                receta = new Receta
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Titulo = reader["titulo"] as string ?? string.Empty,
                                    DescripcionBreve = reader["descripcion_breve"] as string ?? string.Empty,
                                    Ingrediente = reader["ingrediente"] as string ?? string.Empty,
                                    Pasos = reader["pasos"] as string ?? string.Empty,
                                    //Foto = reader["foto"] as byte[],
                                    EmailUsuario = reader["email_usuario"] as string ?? string.Empty
                                };

                                return receta;
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


        public List<Receta> ObtenerTodasLasRecetas()
        {
            try
            {
                List<int> listaIds = new List<int>();
                List<Receta> listaRecetas = new List<Receta>();

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT id FROM receta", conexion))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaIds.Add(Convert.ToInt32(reader["id"]));
                            }
                        }
                    }
                }

                foreach (int id in listaIds)
                {
                    Receta receta = ObtenerRecetaPorId(id);
                    if (receta != null)
                    {
                        listaRecetas.Add(receta);
                    }
                }

                return listaRecetas;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool EliminarRecetaPorId(int id)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("DELETE FROM receta WHERE id = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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


        public bool InsertarReceta(Receta receta)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO receta (titulo, descripcion_breve, ingrediente, pasos, foto, email_usuario) VALUES (@Titulo, @DescripcionBreve, @Ingrediente, @Pasos, @Foto, @EmailUsuario)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", string.IsNullOrEmpty(receta.Titulo) ? (object)DBNull.Value : receta.Titulo);
                        cmd.Parameters.AddWithValue("@DescripcionBreve", string.IsNullOrEmpty(receta.DescripcionBreve) ? (object)DBNull.Value : receta.DescripcionBreve);
                        cmd.Parameters.AddWithValue("@Ingrediente", string.IsNullOrEmpty(receta.Ingrediente) ? (object)DBNull.Value : receta.Ingrediente);
                        cmd.Parameters.AddWithValue("@Pasos", string.IsNullOrEmpty(receta.Pasos) ? (object)DBNull.Value : receta.Pasos);
                        cmd.Parameters.AddWithValue("@Foto", receta.Foto == null || receta.Foto.Length == 0 ? (object)DBNull.Value : receta.Foto);
                        cmd.Parameters.AddWithValue("@EmailUsuario", string.IsNullOrEmpty(receta.EmailUsuario) ? (object)DBNull.Value : receta.EmailUsuario);

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
        public bool EditarReceta(int idReceta, Receta receta)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"
                UPDATE receta
                SET titulo = @Titulo,
                    descripcion_breve = @DescripcionBreve,
                    ingrediente = @Ingrediente,
                    pasos = @Pasos,
                    foto = @Foto,
                    email_usuario = @EmailUsuario
                WHERE id = @IdReceta", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdReceta", idReceta);
                        cmd.Parameters.AddWithValue("@Titulo", receta.Titulo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DescripcionBreve", receta.DescripcionBreve ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Ingrediente", receta.Ingrediente ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Pasos", receta.Pasos ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Foto", receta.Foto ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@EmailUsuario", receta.EmailUsuario ?? (object)DBNull.Value);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}
