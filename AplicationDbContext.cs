using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace apiTienda
{
    public class AplicationDbContext : IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions option) : base(option)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /* modelBuilder.Entity<ProductoTienda>().HasKey(
                ProductoTienda => new { ProductoTienda.ProductoId, ProductoTienda.TiendaId }
                );
            modelBuilder.Entity<PreventaProducto>().HasKey(
                PreventaProductoTienda => new { PreventaProductoTienda.PreventaId, PreventaProductoTienda.ProductoId }
          ); */

        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<VendedorArchivo> VendedorArchivo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<ProductoTienda> ProductoTienda { get; set; }
        public DbSet<Caracteristica> Caracteristica { get; set; }
        public DbSet<PreventaProducto> PreventaProducto { get; set; }
    }
}