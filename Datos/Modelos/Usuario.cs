using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    // Modelo de Usuario con dos constructores y el ToString()
    public class Usuario
    {
        public Usuario() { }
        public Usuario(string Email, string Nombre, string Apellido, string Direccion, string Contrasena, byte[] Foto, string Rol, bool Profesor)
        {
            this.Email = Email;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Contrasena = Contrasena;
            this.Foto = Foto;
            this.Rol = Rol;
            this.Profesor = Profesor;
        }

        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Contrasena { get; set; }
        public byte[] Foto { get; set; }
        public string Rol { get; set; }
        public bool Profesor { get; set; }


        public override string ToString()
        {
            return $"Usuario: {Nombre} {Apellido}, Email: {Email}, Rol: {Rol}, Profesor: {Profesor}, Dirección: {Direccion}, Foto: {Foto}";
        }
    }
}
