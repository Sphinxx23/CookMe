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
        public Clase ObtenerClasePorID(int id)
        {
            return new Datos.Repositories.ClaseRepo().ObtenerClasePorId(id);

        }

        public List<Clase> ObtenerTodasLasClases()
        {
            return new Datos.Repositories.ClaseRepo().ObtenerTodasLasClases();

        }

        public bool EliminarClasePorId(int id)
        {
            return new Datos.Repositories.ClaseRepo().EliminarClasePorId(id);

        }

        public bool InsertarClase(Clase clase)
        {
            return new Datos.Repositories.ClaseRepo().InsertarClase(clase);

        }

        public bool EditarClase(int id, Clase clase)
        {
            return new Datos.Repositories.ClaseRepo().EditarClase(id, clase);

        }

    }
}
