using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiTienda
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
    }
}