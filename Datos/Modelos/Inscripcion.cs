using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Inscripcion
    {
        public Inscripcion() { }

        public Inscripcion(DateTime FechaInscripcion, int Valoracion, string Resena, bool InscripcionActiva, string EmailUsuario, int IdClase)
        {
            this.FechaInscripcion = FechaInscripcion;
            this.Valoracion = Valoracion;
            this.Resena = Resena;
            this.InscripcionActiva = InscripcionActiva;
            this.EmailUsuario = EmailUsuario;
            this.IdClase = IdClase;
        }

        public DateTime FechaInscripcion { get; set; }
        public int Valoracion { get; set; }
        public string Resena { get; set; }
        public bool InscripcionActiva { get; set; }
        public string EmailUsuario { get; set; }
        public int IdClase { get; set; }

        public override string ToString()
        {
            return $"Inscripción: {EmailUsuario} en clase {IdClase}, Fecha: {FechaInscripcion.ToShortDateString()}, Valoración: {Valoracion}, Activa: {InscripcionActiva}, Reseña: {Resena}";
        }
    }
}
