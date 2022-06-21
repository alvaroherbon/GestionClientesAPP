using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClientesAPP.domain
{
    public class Albaran
    {
        public int AlbaranId { get; set; }

        public DateTime fecha { get; set;  }
        
        public string numAlbaran { get; set;  }

        public Cliente cliente { get; set;}

        public string direccion { get; set; }

        public string ciudadProvinciaCP { get; set; }

        public ICollection<LineaAlbaran> lineas { get; set; }

        public string? observaciones { get; set; }

        public Albaran(DateTime fecha, string numAlbaran, Cliente cliente, string direccion, string ciudadProvinciaCP, ICollection<LineaAlbaran> lineas, string? observaciones)
        {
            this.fecha = fecha;
            this.numAlbaran = numAlbaran;
            this.cliente = cliente;
            this.direccion = direccion;
            this.ciudadProvinciaCP = ciudadProvinciaCP;
            this.lineas = lineas;
            this.observaciones = observaciones; 
        }


    }
}
