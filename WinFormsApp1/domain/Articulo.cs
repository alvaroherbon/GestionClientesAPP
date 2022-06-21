using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClientesAPP.domain
{
    public class Articulo
    {
        public int ArticuloId { get; set; }

        public string descripcion { get; set; }

        public float precio { get; set; }

        public double tipoImpuesto { get; set; }


        public Articulo() { }

        public Articulo(string descripcion, float precio, double tipoImpuesto)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.tipoImpuesto = tipoImpuesto; 
        }

    }
}
