using Datos.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class ProductoRepo
    {
        /// <summary>
        /// Obtener producto por ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Producto ObtenerProductoPorId(int id)
        {
            try
            {
                Producto producto = null;
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM producto WHERE id = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                producto = new Producto
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["nombre"] as string ?? string.Empty,
                                    Descripcion = reader["descripcion"] as string ?? string.Empty,
                                    Stock = Convert.ToInt32(reader["stock"]),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    Categoria = reader["categoria"] as string ?? string.Empty,
                                    Foto1 = reader["foto1"] as byte[],
                                    Foto2 = reader["foto2"] as byte[]
                                };
                            }
                        }
                    }
                }
                return producto;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Insertar producto nuevo.
        /// </summary>
        /// <param name="producto"> producto.</param>
        /// <returns></returns>
        public bool InsertarProducto(Producto producto)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"
                        INSERT INTO producto (nombre, descripcion, stock, precio, categoria, foto1, foto2)
                        VALUES (@Nombre, @Descripcion, @Stock, @Precio, @Categoria, @Foto1, @Foto2)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(producto.Nombre) ? (object)DBNull.Value : producto.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(producto.Descripcion) ? (object)DBNull.Value : producto.Descripcion);
                        cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio != null ? (object)producto.Precio : DBNull.Value); ;
                        cmd.Parameters.AddWithValue("@Categoria", string.IsNullOrEmpty(producto.Categoria) ? (object)DBNull.Value : producto.Categoria);
                        cmd.Parameters.AddWithValue("@Foto1", producto.Foto1 == null || producto.Foto1.Length == 0 ? (object)DBNull.Value : producto.Foto1);
                        cmd.Parameters.AddWithValue("@Foto2", producto.Foto2 == null || producto.Foto2.Length == 0 ? (object)DBNull.Value : producto.Foto2);

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
        /// Obtener todos los productos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerTodosLosProductos()
        {
            try
            {
                List<Producto> listaProductos = new List<Producto>();
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT id FROM producto", conexion))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                Producto producto = ObtenerProductoPorId(id);
                                if (producto != null)
                                {
                                    listaProductos.Add(producto);
                                }

                            }
                        }
                    }
                }
                return listaProductos;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Obtener productos de textbox de búsqueda.
        /// </summary>
        /// <param name="aBuscar">a buscar.</param>
        /// <returns></returns>
        public List<Producto> ObtenerProductosBusqueda(string aBuscar)
        {
            try
            {
                List<Producto> listaProductos = new List<Producto>();
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    string query = @"
                            SELECT id 
                            FROM producto 
                            WHERE LOWER(nombre) LIKE LOWER(@busqueda)";

                    using (var cmd = new NpgsqlCommand(query, conexion))
                    {
                        
                        cmd.Parameters.AddWithValue("@busqueda", aBuscar.ToLower() + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                Producto producto = ObtenerProductoPorId(id);
                                if (producto != null)
                                {
                                    listaProductos.Add(producto);
                                }
                            }
                        }
                    }
                }
                return listaProductos;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Eliminar  producto por ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool EliminarProductoPorId(int id)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand("DELETE FROM producto WHERE id = @id", conexion))
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
        /// Editar producto existente.
        /// </summary>
        /// <param name="idProducto">The identifier producto.</param>
        /// <param name="producto">The producto.</param>
        /// <returns></returns>
        public bool EditarProducto(int idProducto, Producto producto)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"
                        UPDATE producto
                        SET nombre = @Nombre,
                            descripcion = @Descripcion,
                            stock = @Stock,
                            precio = @Precio,
                            categoria = @Categoria,
                            foto1 = @Foto1,
                            foto2 = @Foto2
                        WHERE id = @IdProducto", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@Categoria", producto.Categoria ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Foto1", producto.Foto1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Foto2", producto.Foto2 ?? (object)DBNull.Value);

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
        /// Actualizar el stock de un producto.
        /// </summary>
        /// <param name="idProducto">The identifier .</param>
        /// <param name="cantidadARestar">La cantidad a restar.</param>
        /// <returns></returns>
        public bool ActualizarStockProducto(int idProducto, int cantidadARestar)
        {
            try
            {
                using (var conexion = Conexion.Conexion.EstablecerConexion())
                {
                    using (var cmd = new NpgsqlCommand(@"
                        UPDATE producto
                        SET stock = stock - @CantidadARestar
                        WHERE id = @IdProducto AND stock >= @CantidadARestar", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@CantidadARestar", cantidadARestar);

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
