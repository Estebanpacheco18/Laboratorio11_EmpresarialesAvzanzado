using Laboratorio11_Empresariales.Domain.Entities;
using Laboratorio11_Empresariales.Infrastructure.Persistence;

namespace Laboratorio11_Empresariales.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}