using Capa_Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.BaseDatos
{
    public class RentaVideoContext:DbContext
    {
        public RentaVideoContext() : base("name=RentaVideo")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Renta> Renta { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
