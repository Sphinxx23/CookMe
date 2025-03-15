using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class ClaseRepo
    {
        public Clase ObtenerClasePorId(int id)
        {
            try
            {
                Clase clase = null;
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM clase WHERE id = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clase = new Clase
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Titulo = reader["titulo"] as string ?? string.Empty,
                                    PlazaTotal = Convert.ToInt32(reader["plaza_total"]),
                                    PlazaOcupada = Convert.ToInt32(reader["plaza_ocupada"]),
                                    Descripcion = reader["descripcion"] as string ?? string.Empty,
                                    Fecha = Convert.ToDateTime(reader["fecha"]),
                                    //FotoTematica = reader["foto_tematica"] as byte[],
                                    ValoracionMedia = Convert.ToDecimal(reader["valoracion_media"]),
                                    //FotoProfesor = reader["foto_profesor"] as byte[],
                                    EmailProfesor = reader["email_profesor"] as string ?? string.Empty
                                };

                                return clase;
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

        public bool InsertarClase(Clase clase)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {

                    Usuario usuProfesor = new Datos.Repositories.UsuarioRepo().ObtenerUsuarioPorEmail(clase.EmailProfesor);


                    using (var cmd = new NpgsqlCommand(@"
                        INSERT INTO clase (titulo, plaza_total, plaza_ocupada, descripcion, fecha, foto_tematica, valoracion_media, foto_profesor, email_profesor)
                        VALUES (@Titulo, @PlazaTotal, @PlazaOcupada, @Descripcion, @Fecha, @FotoTematica, @ValoracionMedia, @FotoProfesor, @EmailProfesor)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", string.IsNullOrEmpty(clase.Titulo) ? (object)DBNull.Value : clase.Titulo);
                        cmd.Parameters.AddWithValue("@PlazaTotal", clase.PlazaTotal);
                        cmd.Parameters.AddWithValue("@PlazaOcupada", clase.PlazaOcupada);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(clase.Descripcion) ? (object)DBNull.Value : clase.Descripcion);
                        cmd.Parameters.AddWithValue("@Fecha", clase.Fecha);
                        cmd.Parameters.AddWithValue("@FotoTematica", clase.FotoTematica == null || clase.FotoTematica.Length == 0 ? (object)DBNull.Value : clase.FotoTematica);
                        cmd.Parameters.AddWithValue("@ValoracionMedia", clase.ValoracionMedia!=null ? (object)clase.ValoracionMedia : DBNull.Value);
                        cmd.Parameters.AddWithValue("@FotoProfesor", usuProfesor.Foto == null || usuProfesor.Foto.Length == 0 ? (object)DBNull.Value : usuProfesor.Foto);
                        cmd.Parameters.AddWithValue("@EmailProfesor", string.IsNullOrEmpty(clase.EmailProfesor) ? (object)DBNull.Value : clase.EmailProfesor);

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

        public List<Clase> ObtenerTodasLasClases()
        {
            try
            {
                List<int> listaIds = new List<int>();
                List<Clase> listaClases = new List<Clase>();

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT id FROM clase", conexion))
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
                    Clase clase = ObtenerClasePorId(id);
                    if (clase != null)
                    {
                        listaClases.Add(clase);
                    }
                }

                return listaClases;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public bool EliminarClasePorId(int id)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("DELETE FROM clase WHERE id = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
