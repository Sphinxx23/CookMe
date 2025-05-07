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
    public partial class RecetaBotonContenedor : UserControl
    {
        private Panel panelRecetas;
        private Button btnAgregarReceta;
        private Panel panelContenedor;
        private string email;

        public RecetaBotonContenedor(string email)
        {
            InitializeComponents();
            this.email = email;
            List<Datos.Modelos.Receta> recetas = new Logica.Controles.RecetaControl().ObtenerTodasLasRecetas();
            LoadRecetas(recetas);
        }

        private void InitializeComponents()
        {
            this.Size = new Size(195, 500);

            panelContenedor = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            btnAgregarReceta = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point((this.Width - 50) / 2, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.mas,
                Anchor = AnchorStyles.Top
            };
            btnAgregarReceta.FlatAppearance.BorderSize = 0;
            btnAgregarReceta.Click += BtnAgregarReceta_Click;

            panelRecetas = new Panel()
            {
                Location = new Point(10, 70),
                Size = new Size(880, 530),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            panelContenedor.Controls.Add(btnAgregarReceta);
            panelContenedor.Controls.Add(panelRecetas);
            this.Controls.Add(panelContenedor);
        }

        private void BtnAgregarReceta_Click(object sender, EventArgs e)
        {
            Views.VistasReceta.CrearEditarReceta nuevaReceta = new Views.VistasReceta.CrearEditarReceta(this, -1, this.email);
            this.Visible = false;
            nuevaReceta.ShowDialog();
        }

        public void LoadRecetas(List<Datos.Modelos.Receta> recetas)
        {
            panelRecetas.Controls.Clear();
            int distanciaVertical = 5;

            foreach (var receta in recetas)
            {
                RecetaBoton recetaControl = new RecetaBoton();
                Image img = CookMe.MetodosImages.MetImages.ConvertBytesToImage(receta.Foto);
                recetaControl.AsignarDatosReceta(receta.Id, receta.Titulo, receta.DescripcionBreve, receta.EmailUsuario, img);
                recetaControl.Location = new Point(5, distanciaVertical);
                recetaControl.ItemClicked += (s, e) => AbrirVistaReceta(recetaControl);

                panelRecetas.Controls.Add(recetaControl);
                distanciaVertical += recetaControl.Height + 5;
            }
        }

        private void AbrirVistaReceta(RecetaBoton item)
        {
            Views.VistasReceta.VerReceta verReceta = new Views.VistasReceta.VerReceta(item.id);
            verReceta.ShowDialog();
        }
    }
}
