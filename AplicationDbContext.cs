using Microsoft.EntityFrameworkCore;
using WebApiAutoresV3.Entidades;

namespace WebApiAutoresV3
{
    public class AplicationDbContext : DbContext

    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
