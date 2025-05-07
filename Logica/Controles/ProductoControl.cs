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

        public Producto ObtenerProductoPorID(int id)
        {
            return new Datos.Repositories.ProductoRepo().ObtenerProductoPorId(id);

        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return new Datos.Repositories.ProductoRepo().ObtenerTodosLosProductos();

        }


        public List<Producto> ObtenerProductosBusqueda(string aBuscar)
        {
            return new Datos.Repositories.ProductoRepo().ObtenerProductosBusqueda(aBuscar);

        }

        public bool EliminarProductoPorId(int id)
        {
            return new Datos.Repositories.ProductoRepo().EliminarProductoPorId(id);

        }

        public bool InsertarProducto(Producto prod)
        {
            return new Datos.Repositories.ProductoRepo().InsertarProducto(prod);

        }

        public bool EditarProducto(int id, Producto prod)
        {
            return new Datos.Repositories.ProductoRepo().EditarProducto(id, prod);

        }



    }
}
