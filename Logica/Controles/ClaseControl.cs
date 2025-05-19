using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Controles
{
    public class ClaseControl
    {
        /// <summary>
        /// Obteners clase por ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Clase ObtenerClasePorID(int id)
        {
            return new Datos.Repositories.ClaseRepo().ObtenerClasePorId(id);

        }

        /// <summary>
        /// Obtener todas las clases.
        /// </summary>
        /// <returns></returns>
        public List<Clase> ObtenerTodasLasClases()
        {
            return new Datos.Repositories.ClaseRepo().ObtenerTodasLasClases();

        }


        /// <summary>
        /// Obtener inscripciones por email.
        /// </summary>
        /// <param name="email"> email.</param>
        /// <returns></returns>
        public List<Clase> ObtenerInscripcionesPorEmail(string email)
        {
            return new Datos.Repositories.ClaseRepo().ObtenerInscripcionesPorEmail(email);

        }

        /// <summary>
        /// Eliminar  clase por ID.
        /// </summary>
        /// <param name="id"> identifier.</param>
        /// <returns></returns>
        public bool EliminarClasePorId(int id)
        {
            return new Datos.Repositories.ClaseRepo().EliminarClasePorId(id);

        }

        /// <summary>
        /// Insertar nueva clase.
        /// </summary>
        /// <param name="clase"> clase.</param>
        /// <returns></returns>
        public bool InsertarClase(Clase clase)
        {
            return new Datos.Repositories.ClaseRepo().InsertarClase(clase);

        }

        /// <summary>
        /// Editar clase.
        /// </summary>
        /// <param name="id"> idClase.</param>
        /// <param name="clase"> clase.</param>
        /// <returns></returns>
        public bool EditarClase(int id, Clase clase)
        {
            return new Datos.Repositories.ClaseRepo().EditarClase(id, clase);

        }

    }
}
