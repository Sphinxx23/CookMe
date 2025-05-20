using CookMe.Properties;
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
    public partial class UCGestionRecetas : UserControl
    {
        private Panel panelRecetas;

        public UCGestionRecetas()
        {
            InitializeComponents();
            List<Datos.Modelos.Receta> recetas = new Logica.Controles.RecetaControl().ObtenerTodasLasRecetas();
            LoadRecipes(recetas);
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(750, 600);

            panelRecetas = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(panelRecetas);
        }


        //Carga de todos los registros de bbdd, controlando el espaciado vertical entre ellos
        public void LoadRecipes(List<Datos.Modelos.Receta> recetas)
        {
            panelRecetas.Controls.Clear();
            int distanciaVertical = 5;

            foreach (var receta in recetas)
            {
                RecetaItemControl recetaControl = new RecetaItemControl();
                Image img = CookMe.MetodosImages.MetImages.ConvertBytesToImage(receta.Foto);
                recetaControl.AsignarDatosReceta(receta.Id,receta.Titulo, receta.DescripcionBreve, receta.EmailUsuario, img);
                recetaControl.Location = new Point(5, distanciaVertical);
                recetaControl.DeleteClicked += (s, e) => RemoveRecipe(recetaControl);
                recetaControl.EditClicked += (s, e) => EditRecipe(recetaControl);

                panelRecetas.Controls.Add(recetaControl);
                distanciaVertical += recetaControl.Height + 5;
            }
        }

        //Eliminación de item y de registro en bbdd
        private void RemoveRecipe(RecetaItemControl recetaControl)
        {

            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta receta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool eliminado = new Logica.Controles.RecetaControl().EliminarRecetaPorId(recetaControl.id);

                if (eliminado)
                {
                    MessageBox.Show("Receta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelRecetas.Controls.Remove(recetaControl);
                    panelRecetas.Controls.Clear();

                    List<Datos.Modelos.Receta> recetas = new Logica.Controles.RecetaControl().ObtenerTodasLasRecetas();
                    LoadRecipes(recetas);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //edición de item y de registro en bbdd
        private void EditRecipe(RecetaItemControl item)
        {
            Views.VistasReceta.CrearEditarReceta editarReceta = new Views.VistasReceta.CrearEditarReceta(this, item.id, "");
            this.Visible = false;
            var resultado = editarReceta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                List<Datos.Modelos.Receta> recetas = new Logica.Controles.RecetaControl().ObtenerTodasLasRecetas();
                LoadRecipes(recetas);
            }


        }
    }
}
