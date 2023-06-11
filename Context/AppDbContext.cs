using lanchesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace lanchesMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  // construtor
        {   
        }

        // Nome das tabelas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
