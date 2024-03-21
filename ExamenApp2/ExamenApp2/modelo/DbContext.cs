using Microsoft.EntityFrameworkCore;

namespace ExamenApp2.Modelo
{
    public class AppDbContext : DbContext
    {
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}
