using Facturas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Facturas.Datos
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {
            
        }

        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalles { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrdenDetalle>()
                .HasKey(od => new {od.OrdenId, od.ProductoId});

            modelBuilder.Entity<OrdenDetalle>()
                .HasOne(od => od.Orden)
                .WithMany(o => o.OrdenDetalles)
                .HasForeignKey(od => od.OrdenId);
            
            modelBuilder.Entity<OrdenDetalle>()
                .HasOne(od => od.Producto)
                .WithMany(p => p.OrdenDetalles)
                .HasForeignKey(od => od.ProductoId);
        }
    }
}