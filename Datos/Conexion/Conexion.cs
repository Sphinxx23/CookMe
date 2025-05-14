using Npgsql;
using System;

namespace Datos.Conexion
{
    public static class Conexion
    {
        private static string connectionString = "Host=ep-calm-tree-a9nj4css-pooler.gwc.azure.neon.tech;Database=CookMe;Username=CookMe_owner;Password=npg_h6J5pxwgUViC;SSL Mode=Require";


        // Método para establecer la conexión 
        public static NpgsqlConnection EstablecerConexion()
        {
            try
            {
                var nuevaConexion = new NpgsqlConnection(connectionString);
                nuevaConexion.Open();
                return nuevaConexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

    }
}
