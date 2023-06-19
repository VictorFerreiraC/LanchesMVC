using lanchesMVC.Context;
using lanchesMVC.Models;
using lanchesMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lanchesMVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(l => l.LanchePrerido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int IdLanche)
        {
            return _context.Lanches.FirstOrDefault(l => l.IdLanche == IdLanche);
        }
    }
}
