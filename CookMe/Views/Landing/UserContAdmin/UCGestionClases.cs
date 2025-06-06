﻿using CookMe.Properties;
using CookMe.Views.VistasProducto;
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
    public partial class UCGestionClases : UserControl
    {
        private Panel panelClases;
        private Button btnAgregarClase;

        public UCGestionClases()
        {
            InitializeComponents();
            List<Datos.Modelos.Clase> clases = new Logica.Controles.ClaseControl().ObtenerTodasLasClases();
            LoadClases(clases);
        }

        //Creación manual de los elementos que contendrá el "item", darles formato y asignarles los diferentes eventos
        private void InitializeComponents()
        {
            this.Size = new Size(750, 600);

            btnAgregarClase = new Button()
            {
                Size = new Size(50, 50),
                Location = new Point((this.Width - 50) / 2, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Image = Properties.Resources.mas, 
                Anchor = AnchorStyles.Top
            };
            btnAgregarClase.FlatAppearance.BorderSize = 0;
            btnAgregarClase.Click += BtnAgregarClase_Click;

            panelClases = new Panel()
            {
                Location = new Point(0, 70),
                Size = new Size(765, 370),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(btnAgregarClase);
            this.Controls.Add(panelClases);
        }

        // Carga de todos los registros disponibles en bbdd, controlando distancia entre ellos
        public void LoadClases(List<Datos.Modelos.Clase> clases)
        {
            panelClases.Controls.Clear();
            int distanciaVertical = 5;

            foreach (var clase in clases)
            {
                ClaseItemControl claseControl = new ClaseItemControl();
                Image imgTematica = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoTematica);
                Image imgProfe = CookMe.MetodosImages.MetImages.ConvertBytesToImage(clase.FotoProfesor);
                claseControl.AsignarDatosClase(
                    clase.Id,
                    clase.Titulo,
                    clase.Descripcion,
                    clase.Fecha,
                    (clase.PlazaTotal-clase.PlazaOcupada),
                    clase.EmailProfesor,
                    imgTematica,
                    imgProfe
                );
                claseControl.Location = new Point(5, distanciaVertical);
                //Asignamos eventos a cada item que se carga
                claseControl.DeleteClicked += (s, e) => RemoveClase(claseControl);
                claseControl.EditClicked += (s, e) => EditClase(claseControl);

                panelClases.Controls.Add(claseControl);
                distanciaVertical += claseControl.Height + 5;
            }
        }

        //Borrado de item y de registro en bbdd
        private void RemoveClase(ClaseItemControl claseControl)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta clase?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool eliminado = new Logica.Controles.ClaseControl().EliminarClasePorId(claseControl.id);

                if (eliminado)
                {
                    MessageBox.Show("Clase eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClases(new Logica.Controles.ClaseControl().ObtenerTodasLasClases());
                }
                else
                {
                    MessageBox.Show("Error al eliminar la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Edición de item y de registro en bbdd
        private void EditClase(ClaseItemControl claseControl)
        {
            Views.VistasClase.CrearEditarClase crearClase = new Views.VistasClase.CrearEditarClase(this, claseControl.id);
            this.Visible = false;
            var resultado = crearClase.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LoadClases(new Logica.Controles.ClaseControl().ObtenerTodasLasClases());
            }

        }

        //Inserción de nuevo item y registro en bbdd
        private void BtnAgregarClase_Click(object sender, EventArgs e)
        {
            Views.VistasClase.CrearEditarClase crearClase = new Views.VistasClase.CrearEditarClase(this, -1);
            this.Visible = false;
            var resultado = crearClase.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LoadClases(new Logica.Controles.ClaseControl().ObtenerTodasLasClases());
            }

        }
    }
}
