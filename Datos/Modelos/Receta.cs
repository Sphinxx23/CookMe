using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Receta
    {
        public Receta() { }

        public Receta(int Id, string Titulo, string DescripcionBreve, string Ingrediente, string Pasos, string Foto, string EmailUsuario)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.DescripcionBreve = DescripcionBreve;
            this.Ingrediente = Ingrediente;
            this.Pasos = Pasos;
            this.Foto = Foto;
            this.EmailUsuario = EmailUsuario;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string DescripcionBreve { get; set; }
        public string Ingrediente { get; set; }
        public string Pasos { get; set; }
        public string Foto { get; set; }
        public string EmailUsuario { get; set; }

        public override string ToString()
        {
            return $"Receta: {Titulo}, Descripción: {DescripcionBreve}, Ingredientes: {Ingrediente}, Pasos: {Pasos}, Foto: {Foto}, Usuario: {EmailUsuario}";
        }
    }
}
