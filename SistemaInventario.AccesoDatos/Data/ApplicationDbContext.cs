using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaInventario.AccesoDatos.Repositorio;
using SistemaInventario.Modelos;
using System.Reflection;

namespace SistemaInventario.AccesoDatos.Data
{
    public class ApplicationDbContext
        : IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bodega> Bodegas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }

        // Removed obsolete implicit conversion to ApplicationDBContext (duplicate/empty type removed)
    }
}