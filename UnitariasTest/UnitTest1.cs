using Datos.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitariasTest
{
    [TestClass]
    public class UnitTest1
    {

        // Usuario
        [TestMethod]
        public void AnadirNuevoUsuario()
        {
            var nuevoUsuario = new Usuario
            {
                Email = "testemailll@gmail.com",
                Nombre = "Test",
                Apellido = "User",
                Direccion = "Calle Falsa 123",
                Contrasena = "1234",
                Foto = null,
                Rol = "usuario",
                Profesor = false
            };

            var resultado = new Datos.Repositories.UsuarioRepo().InsertarUsuario(nuevoUsuario);
            Assert.IsTrue(resultado, "No se pudo insertar el usuario");
        }

        [TestMethod]
        public void EditarUsuarioExistente()
        {
            var usuarioModificado = new Usuario
            {
                Email = "peditar@gmail.com",
                Nombre = "Modificado",
                Apellido = "Usuario",
                Direccion = "Nueva Dirección",
                Contrasena = "4321",
                Foto = new byte[0],
                Rol = "usuario",
                Profesor = true
            };

            var resultado = new Datos.Repositories.UsuarioRepo().EditarUsuario("peditar@gmail.com", usuarioModificado);
            Assert.IsTrue(resultado, "No se pudo editar el usuario");
        }

        [TestMethod]
        public void EliminarUsuarioExistente()
        {
            var resultado = new Datos.Repositories.UsuarioRepo().EliminarUsuarioPorEmail("piripi@gmail.com");
            Assert.IsTrue(resultado, "No se pudo eliminar el usuario");
        }


        //Producto
        [TestMethod]
        public void AnadirNuevoProductoo()
        {
            var producto = new Producto
            {
                Nombre = "Test Producto",
                Descripcion = "Descripción de prueba",
                Stock = 17,
                Precio = 9.99m,
                Categoria = "Test",
                Foto1 = new byte[0],
                Foto2 = new byte[0]
            };

            var resultado = new Datos.Repositories.ProductoRepo().InsertarProducto(producto);
            Assert.IsTrue(resultado, "No se pudo insertar el producto");
        }

        [TestMethod]
        public void EditarProductooExistente()
        {
            var productoModificado = new Producto
            {
                Nombre = "Producto Editado jeje",
                Descripcion = "Descripción modificada",
                Stock = 5,
                Precio = 4.99m,
                Categoria = "Modificado",
                Foto1 = new byte[0],
                Foto2 = new byte[0]
            };

            var resultado = new Datos.Repositories.ProductoRepo().EditarProducto(  10   , productoModificado); 
            Assert.IsTrue(resultado, "No se pudo editar el producto");
        }

        [TestMethod]
        public void EliminarProductooExistente()
        {
            var resultado = new Datos.Repositories.ProductoRepo().EliminarProductoPorId(   7   );
            Assert.IsTrue(resultado, "No se pudo eliminar el producto");
        }

        //Receta
        [TestMethod]
        public void AnadirNuevaReceta()
        {
            var receta = new Receta
            {
                Titulo = "Receta TestAAAAAAAAAAAAA",
                DescripcionBreve = "Breve descripción",
                Ingrediente = "Agua, Sal",
                Pasos = "1. Hacer esto\n2. Hacer lo otro",
                Foto = new byte[0],
                EmailUsuario = "maria@gmail.com"
            };

            var resultado = new Datos.Repositories.RecetaRepo().InsertarReceta(receta);
            Assert.IsTrue(resultado, "No se pudo insertar la receta");
        }

        [TestMethod]
        public void EditarRecetaExistente()
        {
            var recetaModificada = new Receta
            {
                Titulo = "Receta Modificada jeje",
                DescripcionBreve = "Otra descripción",
                Ingrediente = "Pan, Agua",
                Pasos = "1. Cambiar",
                Foto = new byte[0],
                EmailUsuario = "maria@gmail.com"
            };

            var resultado = new Datos.Repositories.RecetaRepo().EditarReceta( 9   , recetaModificada);
            Assert.IsTrue(resultado, "No se pudo editar la receta");
        }

        [TestMethod]
        public void EliminarRecetaExistente()
        {
            var resultado = new Datos.Repositories.RecetaRepo().EliminarRecetaPorId(   7   );
            Assert.IsTrue(resultado, "No se pudo eliminar la receta");
        }


        //Clase
        [TestMethod]
        public void AnadirNuevaClase()
        {
            var clase = new Clase
            {
                Titulo = "Clase de PruebaAAAAAAAA",
                PlazaTotal = 10,
                PlazaOcupada = 0,
                Descripcion = "Clase de cocina básica",
                Fecha = "12-11-2025 17:30",
                FotoTematica = new byte[0],
                ValoracionMedia = 0,
                FotoProfesor = new byte[0],
                EmailProfesor = "maria@gmail.com"
            };

            var resultado = new Datos.Repositories.ClaseRepo().InsertarClase(clase);
            Assert.IsTrue(resultado, "No se pudo insertar la clase");
        }

        [TestMethod]
        public void EditarClaseExistente()
        {
            var claseModificada = new Clase
            {
                Titulo = "Clase Avanzada editada",
                PlazaTotal = 15,
                PlazaOcupada = 5,
                Descripcion = "Clase de cocina avanzada",
                Fecha = "20-20-2020 20:20",
                FotoTematica = new byte[0],
                ValoracionMedia = 4.5m,
                FotoProfesor = new byte[0],
                EmailProfesor = "maria@gmail.com"
            };

            var resultado = new Datos.Repositories.ClaseRepo().EditarClase(  6  , claseModificada);
            Assert.IsTrue(resultado, "No se pudo editar la clase");
        }

        [TestMethod]
        public void EliminarClaseExistente()
        {
            var resultado = new Datos.Repositories.ClaseRepo().EliminarClasePorId(  8 );
            Assert.IsTrue(resultado, "No se pudo eliminar la clase");
        }


        //Inscripcion
        [TestMethod]
        public void AnadirNuevAInscripcion()
        {
            var inscripcion = new Inscripcion
            {
                EmailUsuario = "maria@gmail.com",
                IdClase = 10,
                Valoracion = 0,
                InscripcionActiva = true
            };

            var resultado = new Datos.Repositories.InscripcionRepo().InsertarInscripcion(inscripcion);
            Assert.IsTrue(resultado, "No se pudo insertar la inscripción");
        }

        [TestMethod]
        public void BorrarInscripcionExistente()
        {
            var inscripcionModificada = new Inscripcion
            {
                EmailUsuario = "maria@gmail.com",
                IdClase = 6,
                Valoracion = 2,
                InscripcionActiva = false
            };
            var resultado = new Datos.Repositories.InscripcionRepo().BorrarInscripcion( inscripcionModificada);
            Assert.IsTrue(resultado, "No se pudo editar la inscripción");
        }


    }
}
