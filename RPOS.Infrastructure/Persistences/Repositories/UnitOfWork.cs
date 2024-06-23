using RPOS.Infrastructure.Persistences.Contexts;
using RPOS.Infrastructure.Persistences.Interfaces;

namespace RPOS.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RPOSContext _context;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(RPOSContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
