using CookMe.Facturacion;
using CookMe.Views.Landing.UserContUsuario;
using Datos.Modelos;
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
        public string userEm;
        public Dictionary<int, int> carritLleno;
        public Carrito(Dictionary<int, int> carrit, string user)
        {
            InitializeComponent();
            this.userEm = user;
            this.carritLleno = carrit;
            Usuario usuario= new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(this.userEm);
            lb1.Text += " " + usuario.Nombre + " " + usuario.Apellido;
            LoadUserControl(new Landing.UserContUsuario.CarritoControl(carrit, userEm));

        }

        private void LoadUserControl(UserControl userControl)
        {

            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void botonImagen1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            bool control = false;   
            foreach (var item in carritLleno)
            {
                bool correcto = new Logica.Controles.ProductoControl().ActualizarStockProducto(item.Key, item.Value);
                control = correcto;
                if (!correcto)
                {
                    MessageBox.Show("Error al actualizar el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }


            if (control)
            {
                
                MessageBox.Show("Pago Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // imprimir factura con hilo
                //Aqui

                Factura.GenerarTicket(userEm, carritLleno);

                carritLleno = new Dictionary<int, int>();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            
        }
   
    }
}

