using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.ControlesPersonalizados
{
    public partial class BotonImagen : Button
    {
        public Image ButtonImage { get; set; }
        private int _cornerRadius = 20;

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate(); // Redibujar el botón cuando cambie el radio
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Crear ruta gráfica con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, 0, CornerRadius, CornerRadius), 270, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - CornerRadius, CornerRadius, CornerRadius), 90, 90);
            path.CloseFigure();

            // Establece la región del botón
            this.Region = new Region(path);

            // Dibujar el fondo del botón
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillPath(new SolidBrush(this.BackColor), path);

            // Dibujar la imagen en el centro del botón, si se ha establecido
            if (ButtonImage != null)
            {
                int imageX = (this.Width - ButtonImage.Width) / 2;
                int imageY = (this.Height - ButtonImage.Height) / 2;
                pevent.Graphics.DrawImage(ButtonImage, imageX, imageY, ButtonImage.Width, ButtonImage.Height);
            }
        }
    }
}
