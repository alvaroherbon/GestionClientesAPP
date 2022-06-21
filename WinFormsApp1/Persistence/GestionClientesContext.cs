using GestionClientesAPP.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace GestionClientesAPP.Persistence
{
    public class GestionClientesContext : DbContext
    {
        public GestionClientesContext() : base("BDGestionClientes")
        {
            Database.SetInitializer<GestionClientesContext>(new DropCreateDatabaseIfModelChanges<GestionClientesContext>()); 

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LineaAlbaran> lineasAlbaranes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<FormaDePago> FormasDePago { get; set; }

        public DbSet<Precio> Precios { get; set; }

        public DbSet<Albaran> Albaranes { get; set; }

        public DbSet<Articulo> Articulos { get; set;  }

    }
}
