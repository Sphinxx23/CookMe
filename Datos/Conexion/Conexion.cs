using Npgsql;
using System;

namespace Datos.Conexion
{
    public static class Conexion
    {
        private static string connectionString = "Host=ep-icy-poetry-a9l2uiid-pooler.gwc.azure.neon.tech;Database=cookme;Username=neondb_owner;Password=npg_0JLabDUQ5etN;SSL Mode=Require";


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
