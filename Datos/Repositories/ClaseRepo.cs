﻿using Datos.Modelos;
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

        /// <summary>
        /// Obteners clase por ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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
                                    Fecha =reader["fecha"] as string ?? string.Empty,
                                    FotoTematica = reader["foto_tematica"] as byte[],
                                    ValoracionMedia = Convert.ToDecimal(reader["valoracion_media"]),
                                    FotoProfesor = reader["foto_profesor"] as byte[],
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

        /// <summary>
        /// Insertar nueva clase.
        /// </summary>
        /// <param name="clase">The clase.</param>
        /// <returns></returns>
        public bool InsertarClase(Clase clase)
        {
            try
            {
                Usuario usuProfesor = new Datos.Repositories.UsuarioRepo().ObtenerUsuarioPorEmail(clase.EmailProfesor);

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    
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


        /// <summary>
        /// Obtener todas las clases.
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Eliminar clase por ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Editar clase existente.
        /// </summary>
        /// <param name="idClase">The identifier clase.</param>
        /// <param name="clase">The clase.</param>
        /// <returns></returns>
        public bool EditarClase(int idClase, Clase clase)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    Usuario usuProfesor = new Datos.Repositories.UsuarioRepo().ObtenerUsuarioPorEmail(clase.EmailProfesor);

                    using (var cmd = new NpgsqlCommand(@"
                        UPDATE clase 
                        SET titulo = @Titulo,
                            plaza_total = @PlazaTotal,
                            plaza_ocupada = @PlazaOcupada,
                            descripcion = @Descripcion,
                            fecha = @Fecha,
                            foto_tematica = @FotoTematica,
                            valoracion_media = @ValoracionMedia,
                            foto_profesor = @FotoProfesor,
                            email_profesor = @EmailProfesor
                        WHERE id = @IdClase", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.Parameters.AddWithValue("@Titulo", string.IsNullOrEmpty(clase.Titulo) ? (object)DBNull.Value : clase.Titulo);
                        cmd.Parameters.AddWithValue("@PlazaTotal", clase.PlazaTotal);
                        cmd.Parameters.AddWithValue("@PlazaOcupada", clase.PlazaOcupada);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(clase.Descripcion) ? (object)DBNull.Value : clase.Descripcion);
                        cmd.Parameters.AddWithValue("@Fecha", clase.Fecha);
                        cmd.Parameters.AddWithValue("@FotoTematica", clase.FotoTematica == null || clase.FotoTematica.Length == 0 ? (object)DBNull.Value : clase.FotoTematica);
                        cmd.Parameters.AddWithValue("@ValoracionMedia", clase.ValoracionMedia != null ? (object)clase.ValoracionMedia : DBNull.Value);
                        cmd.Parameters.AddWithValue("@FotoProfesor", usuProfesor.Foto == null || usuProfesor.Foto.Length == 0 ? (object)DBNull.Value : usuProfesor.Foto);
                        cmd.Parameters.AddWithValue("@EmailProfesor", string.IsNullOrEmpty(clase.EmailProfesor) ? (object)DBNull.Value : clase.EmailProfesor);

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


        /// <summary>
        /// Obtener inscripciones por email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public List<Clase> ObtenerInscripcionesPorEmail(string email)
        {
            try
            {
                List<int> listaIds = new List<int>();
                List<Clase> listaClase = new List<Clase>();

                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT id_clase FROM inscripcion WHERE email_usuario = @Email AND inscripcion_activa=TRUE", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaIds.Add(Convert.ToInt32(reader["id_clase"]));
                            }
                        }
                    }
                }

                foreach (int id in listaIds)
                {
                    Clase clase = ObtenerClasePorId(id);
                    if (clase != null)
                    {
                        listaClase.Add(clase);
                    }
                }

                return listaClase;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



    }

}
