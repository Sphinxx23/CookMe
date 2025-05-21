using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Controles
{
    public class RecetaControl
    {

        /// <summary>
        /// Obtener receta por ID.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <returns></returns>
        public Receta ObtenerRecetaPorID(int id)
        {
            return new Datos.Repositories.RecetaRepo().ObtenerRecetaPorId(id);

        }


        /// <summary>
        /// Obtener todas las recetas.
        /// </summary>
        /// <returns></returns>
        public List<Receta> ObtenerTodasLasRecetas()
        {
            return new Datos.Repositories.RecetaRepo().ObtenerTodasLasRecetas();

        }

        /// <summary>
        /// Obtener mis recetas.
        /// </summary>
        /// <param name="email">mi email.</param>
        /// <returns></returns>
        public List<Receta> ObtenerMisRecetas(string email)
        {
            return new Datos.Repositories.RecetaRepo().ObtenerMisRecetas(email);

        }


        /// <summary>
        /// Eliminar receta por ID.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <returns></returns>
        public bool EliminarRecetaPorId(int id)
        {
            return new Datos.Repositories.RecetaRepo().EliminarRecetaPorId(id);

        }


        /// <summary>
        /// Insertar nueva receta.
        /// </summary>
        /// <param name="rec">receta.</param>
        /// <returns></returns>
        public bool InsertarReceta(Receta rec)
        {
            return new Datos.Repositories.RecetaRepo().InsertarReceta(rec);
        }

        /// <summary>
        /// Editar receta.
        /// </summary>
        /// <param name="idRec"> idReceta .</param>
        /// <param name="rec">receta.</param>
        /// <returns></returns>
        public bool EditarReceta(int idRec, Receta rec)
        {
            return new Datos.Repositories.RecetaRepo().EditarReceta(idRec,rec);
        }

    }
}
