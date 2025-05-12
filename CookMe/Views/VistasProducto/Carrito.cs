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
using System.Threading;
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
              
                Thread facturaThread = new Thread(() =>
                {                 
                    Factura.GenerarTicket(userEm, carritLleno);
                });


                // single-threaded apartment puede acceder a objetos el solo, es lento y se puede usar con SaveFileDialog
                // multi-threaded apartment pueden acceder varios hilos a los mismos objetos simultaneamente, es más rapido

                facturaThread.SetApartmentState(ApartmentState.STA);  // Lo tengo que hacer como STA porque si es MTA no deja abrir el SaveFileDialog
                facturaThread.Start();
                facturaThread.Join(); // Espera a que termine el hilo 

                MessageBox.Show("   Pago realizado con exito    ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

