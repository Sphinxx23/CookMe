﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    // Modelo de Clase con dos constructores y el ToString()
    public class Clase
    {
        public Clase() { }

        public Clase(int Id, string Titulo ,int PlazaTotal, int PlazaOcupada, string Descripcion, string Fecha, byte[] FotoTematica, decimal ValoracionMedia, byte[] FotoProfesor, string EmailProfesor)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.PlazaTotal = PlazaTotal;
            this.PlazaOcupada = PlazaOcupada;
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;
            this.FotoTematica = FotoTematica;
            this.ValoracionMedia = ValoracionMedia;
            this.FotoProfesor = FotoProfesor;
            this.EmailProfesor = EmailProfesor;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public int PlazaTotal { get; set; }
        public int PlazaOcupada { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public byte[] FotoTematica { get; set; }
        public decimal ValoracionMedia { get; set; }
        public byte[] FotoProfesor { get; set; }
        public string EmailProfesor { get; set; }

        public override string ToString()
        {
            return $"Clase: {Descripcion}, Fecha: {Fecha}, Profesor: {EmailProfesor}, Valoración Media: {ValoracionMedia}, Plaza Total: {PlazaTotal}, Plaza Ocupada: {PlazaOcupada}";
        }
    }
}
