using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Modelos
{
    public class Producto
    {
        public Producto() { }

        public Producto(int Id, string Nombre, string Descripcion, int Stock, decimal Precio, string Categoria, string Foto1, string Foto2)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Stock = Stock;
            this.Precio = Precio;
            this.Categoria = Categoria;
            this.Foto1 = Foto1;
            this.Foto2 = Foto2;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }

        public override string ToString()
        {
            return $"Producto: {Nombre}, Descripción: {Descripcion}, Precio: {Precio:C}, Stock: {Stock}, Categoría: {Categoria}, Fotos: {Foto1}, {Foto2}";
        }
    }
}


