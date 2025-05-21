using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookMe.Views.Landing.UserContAdmin
{

    public partial class UCGestionUsuarios : UserControl
    {
        private Panel panelUsuarios;
        

        public UCGestionUsuarios()
        {
            InitializeComponents();
            
            List<Datos.Modelos.Usuario> usuarios = new Logica.Controles.UsuarioControl().ObtenerTodosUsuarios();
            LoadUsers(usuarios);
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(450, 600);

            panelUsuarios = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(panelUsuarios);
        }

        //Carga de todos los registros de bbdd y control del espaciado vertical
        public void LoadUsers(List<Datos.Modelos.Usuario> usuarios)
        {
            panelUsuarios.Controls.Clear();
            int distanciaVertical = 5;

            foreach (var user in usuarios)
            {
                UserItemControl userControl = new UserItemControl();
                Image img = CookMe.MetodosImages.MetImages.ConvertBytesToImage(user.Foto);
                userControl.AsignarDatosLabels(user.Nombre, user.Apellido ,user.Email, img);
                userControl.Location = new Point(5, distanciaVertical);
                userControl.DeleteClicked += (s, e) => EliminarUser(userControl);

                panelUsuarios.Controls.Add(userControl);
                distanciaVertical += userControl.Height + 5;
            }
        }

        //Eliminación de item y de registro en bbdd
        private void EliminarUser(UserItemControl userControl)
        {
            
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool eliminado = new Logica.Controles.UsuarioControl().EliminarUsuarioPorEmail(userControl.lblCorreo.Text);

                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelUsuarios.Controls.Remove(userControl);
                    panelUsuarios.Controls.Clear();

                    List<Datos.Modelos.Usuario> usuarios = new Logica.Controles.UsuarioControl().ObtenerTodosUsuarios();
                    LoadUsers(usuarios);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }
    }

}
