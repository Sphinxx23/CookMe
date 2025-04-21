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
        public bool InsertarInscripcion(Inscripcion insc)
        {
            return new Datos.Repositories.InscripcionRepo().InsertarInscripcion(insc);
        }

        public bool BorrarInscripcion(Inscripcion insc)
        {
            return new Datos.Repositories.InscripcionRepo().BorrarInscripcion(insc);
        }

        public double ObtenerMediaValoracionClase(int idClase)
        {
            return new Datos.Repositories.InscripcionRepo().ObtenerMediaValoracionClase(idClase);
        }
        
        public bool EditarValoracionInscripcion(string email, int idClase, double valorac)
        {
            return new Datos.Repositories.InscripcionRepo().EditarValoracionInscripcion(email, idClase, valorac);
        }

        public Inscripcion ObtenerInscripcion(string email, int idClase)
        {
            return new Datos.Repositories.InscripcionRepo().ObtenerInscripcion(email, idClase);
        }
    }
}
