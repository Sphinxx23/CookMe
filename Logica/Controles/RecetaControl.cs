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
        public List<Receta> ObtenerMisRecetas(string email)
        {
            return new Datos.Repositories.RecetaRepo().ObtenerMisRecetas(email);

        }

        public bool EliminarRecetaPorId(int id)
        {
            return new Datos.Repositories.RecetaRepo().EliminarRecetaPorId(id);

        }

        public bool InsertarReceta(Receta rec)
        {
            return new Datos.Repositories.RecetaRepo().InsertarReceta(rec);
        }

        public bool EditarReceta(int idRec, Receta rec)
        {
            return new Datos.Repositories.RecetaRepo().EditarReceta(idRec,rec);
        }

    }
}
