using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Datos.Security
{
    public class CredentialsManager
    {
        private static readonly string configFilePath = "credentials.json";


        /// <summary>
        /// Guarda el json con las credenciales
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        public static void SaveCredentials(string email, string password)
        {
            try
            {
                var credentials = new Credentials { Email = email, Password = password };
                string json = JsonConvert.SerializeObject(credentials, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(configFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error guardando credenciales: {ex.Message}");
            }
        }

        /// <summary>
        /// Carga las credenciales de acceso.
        /// </summary>
        /// <returns></returns>
        public static Credentials LoadCredentials()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    string json = File.ReadAllText(configFilePath);
                    return JsonConvert.DeserializeObject<Credentials>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cargando credenciales: {ex.Message}");
            }
            return null;
        }

        /// <summary>
        /// Elimina credenciales
        /// </summary>
        public static void DeleteCredentials()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    File.Delete(configFilePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error eliminando credenciales: {ex.Message}");
            }
        }
    }

    //Modelo básicode las credenciales
    public class Credentials
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
