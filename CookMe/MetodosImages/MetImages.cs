using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.MetodosImages
{
    public class MetImages
    {

        /// <summary>
        /// Convertir la imagen a array para poder guardar en bbdd
        /// </summary>
        /// <param name="image"> imagen</param>
        /// <returns></returns>
        public static byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Convertir el array en la imagen para poder mostrarla al usuario
        /// </summary>
        /// <param name="byteArray"> array.</param>
        /// <returns></returns>
        public static Image ConvertBytesToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir los bytes a imagen: " + ex.Message);
                return null;
            }
        }
    }
}
