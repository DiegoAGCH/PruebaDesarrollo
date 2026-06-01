using Microsoft.EntityFrameworkCore;
using PruebaDesarrollo.Models;


namespace PruebaDesarrollo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
