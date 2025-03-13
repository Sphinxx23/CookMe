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

        public Receta ObtenerRecetaPorID(int id)
        {
            return new Datos.Repositories.RecetaRepo().ObtenerRecetaPorId(id);

        }

        public List<Receta> ObtenerTodasLasRecetas()
        {
            return new Datos.Repositories.RecetaRepo().ObtenerTodasLasRecetas();

        }

        public bool EliminarRecetaPorId(int id)
        {
            return new Datos.Repositories.RecetaRepo().EliminarRecetaPorId(id);

        }

    }
}
