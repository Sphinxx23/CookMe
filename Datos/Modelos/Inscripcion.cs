using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    // Modelo de Inscripción con dos constructores y el ToString()
    public class Inscripcion
    {
        public Inscripcion() { }

        public Inscripcion(int Valoracion,bool InscripcionActiva, string EmailUsuario, int IdClase)
        {
            this.Valoracion = Valoracion;
            this.InscripcionActiva = InscripcionActiva;
            this.EmailUsuario = EmailUsuario;
            this.IdClase = IdClase;
        }

        public int Valoracion { get; set; }
        public bool InscripcionActiva { get; set; }
        public string EmailUsuario { get; set; }
        public int IdClase { get; set; }

        public override string ToString()
        {
            return $"Inscripción: {EmailUsuario} en clase {IdClase}, Valoración: {Valoracion}, Activa: {InscripcionActiva}";
        }
    }
}
