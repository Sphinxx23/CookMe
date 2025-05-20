using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Landing.UserContUsuario
{
    public partial class LineaProductoCarrito : UserControl
    {
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCantidad;

        //Creación manual de los elementos que contendrá el "item", darles formato 
        public LineaProductoCarrito(string nombre, decimal precio, int cantidad)
        {
            Height = 40;
            Dock = DockStyle.Top;
            BackColor = Color.LightSkyBlue;

            lblNombre = new Label()
            {
                Text = nombre,
                AutoSize = false,
                Width = 200,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(100, 10)
            };

            lblPrecio = new Label()
            {
                Text = $"{precio:0.00} €/ud",
                AutoSize = false,
                Width = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(280, 10)
            };

            lblCantidad = new Label()
            {
                Text = "x"+cantidad.ToString(),
                AutoSize = false,
                Width = 60,
                TextAlign = ContentAlignment.MiddleRight,
                Location = new Point(430, 10)
            };

            this.Controls.Add(lblNombre);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(lblCantidad);
        }
    }

}
