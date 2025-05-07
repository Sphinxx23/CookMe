using CookMe.Views.Landing.UserContUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.VistasProducto
{
    public partial class Carrito : Form
    {
        public Carrito(Dictionary<int, int> carrit)
        {
            InitializeComponent();

            LoadUserControl(new Landing.UserContUsuario.CarritoControl(carrit));

        }

        private void LoadUserControl(UserControl userControl)
        {

            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
