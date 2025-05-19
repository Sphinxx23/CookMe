using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Controles
{
    public class InscripcionControl
    {

        /// <summary>
        /// Insertar inscripcion.
        /// </summary>
        /// <param name="insc"> inscripcion</param>
        /// <returns></returns>
        public bool InsertarInscripcion(Inscripcion insc)
        {
            return new Datos.Repositories.InscripcionRepo().InsertarInscripcion(insc);
        }


        /// <summary>
        /// Borrar inscripcion (poner el flag de activo a false)
        /// </summary>
        /// <param name="insc"> inscripcion</param>
        /// <returns></returns>
        public bool BorrarInscripcion(Inscripcion insc)
        {
            return new Datos.Repositories.InscripcionRepo().BorrarInscripcion(insc);
        }


        /// <summary>
        /// Obtener la media de valoracion de una clase.
        /// </summary>
        /// <param name="idClase"> id clase.</param>
        /// <returns></returns>
        public double ObtenerMediaValoracionClase(int idClase)
        {
            return new Datos.Repositories.InscripcionRepo().ObtenerMediaValoracionClase(idClase);
        }


        /// <summary>
        /// Editars the valoracion inscripcion.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="idClase">The identifier clase.</param>
        /// <param name="valorac">The valorac.</param>
        /// <returns></returns>
        public bool EditarValoracionInscripcion(string email, int idClase, double valorac)
        {
            return new Datos.Repositories.InscripcionRepo().EditarValoracionInscripcion(email, idClase, valorac);
        }


        /// <summary>
        /// Obtener inscripcion.
        /// </summary>
        /// <param name="email"> email.</param>
        /// <param name="idClase"> id clase.</param>
        /// <returns></returns>
        public Inscripcion ObtenerInscripcion(string email, int idClase)
        {
            return new Datos.Repositories.InscripcionRepo().ObtenerInscripcion(email, idClase);
        }
    }
}
