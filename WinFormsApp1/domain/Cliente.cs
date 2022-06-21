using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClientesAPP.domain
{
    public class Cliente
    {
        public int clienteID { get; set; }
        public string nombre { get; set; }

        public string razonSocial { get; set; }

        public string telefono1 { get; set;  }

        public string? telefono2 { get; set; }

        public string nif { get; set; }

        public string direccion { get; set; }

        public string CP { get; set; }

        public string poblacion { get; set; }

        public string provincia { get; set; }

        public string pais { get; set; }

        public double? descuento1 { get; set; }

        public double? descuento2 { get; set; }

        public DateTime fechaAlta { get; set; }

        public virtual ICollection<FormaDePago> formasDePago { get; set; }

        public virtual ICollection<Articulo> articulos { get; set; }

        public Cliente() { }
       
        
        public Cliente(string nombre, string razonSocial, string telefono1, string? telefono2, string nif, 
            string direccion, string CP, string poblacion, string provincia, string pais, double? descuento1, 
            double? descuento2, DateTime fechaAlta)
        {
            this.nombre = nombre;
            this.razonSocial = razonSocial;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.nif = nif;
            this.direccion = direccion;
            this.CP = CP;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.pais = pais;
            this.descuento1 = descuento1;
            this.descuento2 = descuento2;
            this.fechaAlta = fechaAlta;
            this.formasDePago = new HashSet<FormaDePago>();
            this.articulos = new HashSet<Articulo>(); 
        }

        public void addArticulo(Articulo articulo)
        {
            this.articulos.Add(articulo);
        }

        public void addFormaPago(FormaDePago formaDePago)
        {
            this.formasDePago.Add(formaDePago);

        }


    }
}
