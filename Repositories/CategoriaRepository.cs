using lanchesMVC.Context;
using lanchesMVC.Models;
using lanchesMVC.Repositories.Interfaces;

namespace lanchesMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
