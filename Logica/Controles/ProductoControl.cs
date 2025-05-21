using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Controles
{
    public class ProductoControl
    {

        /// <summary>
        /// Obtener producto por ID.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <returns></returns>
        public Producto ObtenerProductoPorID(int id)
        {
            return new Datos.Repositories.ProductoRepo().ObtenerProductoPorId(id);

        }


        /// <summary>
        /// Obtener todos los productos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerTodosLosProductos()
        {
            return new Datos.Repositories.ProductoRepo().ObtenerTodosLosProductos();

        }


        /// <summary>
        /// Obtener productos busqueda textbox.
        /// </summary>
        /// <param name="aBuscar">a buscar.</param>
        /// <returns></returns>
        public List<Producto> ObtenerProductosBusqueda(string aBuscar)
        {
            return new Datos.Repositories.ProductoRepo().ObtenerProductosBusqueda(aBuscar);

        }

        /// <summary>
        /// Eliminar producto por ID.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <returns></returns>
        public bool EliminarProductoPorId(int id)
        {
            return new Datos.Repositories.ProductoRepo().EliminarProductoPorId(id);

        }

        /// <summary>
        /// Insertar producto.
        /// </summary>
        /// <param name="prod">The product.</param>
        /// <returns></returns>
        public bool InsertarProducto(Producto prod)
        {
            return new Datos.Repositories.ProductoRepo().InsertarProducto(prod);

        }

        /// <summary>
        /// Editar producto.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <param name="prod"> product.</param>
        /// <returns></returns>
        public bool EditarProducto(int id, Producto prod)
        {
            return new Datos.Repositories.ProductoRepo().EditarProducto(id, prod);

        }

        /// <summary>
        /// Actualizars el stock de un producto.
        /// </summary>
        /// <param name="id"> idProducto.</param>
        /// <param name="cantidad"> cantidad a restar</param>
        /// <returns></returns>
        public bool ActualizarStockProducto(int id, int cantidad)
        {
            return new Datos.Repositories.ProductoRepo().ActualizarStockProducto(id, cantidad);
        }

    }
}
