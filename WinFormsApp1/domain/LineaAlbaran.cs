using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientesAPP.domain
{
    public class LineaAlbaran
    {
        public int LineaAlbaranID { get; set; }
        public string concepto { get; set; }
        public int unidades { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public float importe { get; set; }

        public LineaAlbaran(string concepto, int unidades, double ancho, double alto, float importe)
        {
            this.concepto = concepto;
            this.unidades = unidades;
            this.ancho = ancho;
            this.alto = alto;
            this.importe = importe;

        }










    }
}
