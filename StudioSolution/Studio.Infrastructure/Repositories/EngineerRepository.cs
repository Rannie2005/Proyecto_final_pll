using Microsoft.EntityFrameworkCore;
using Studio.Domain.Entities;
using Studio.Domain.Interfaces;
using Studio.Infrastructure.Context;

namespace Studio.Infrastructure.Repositories
{
    public class EngineerRepository : IEngineerRepository
    {
        private readonly StudioContext _context;

        public EngineerRepository(StudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Engineer>> GetAllAsync()
        {
            return await _context.Engineers.ToListAsync();
        }

        public async Task<Engineer?> GetByIdAsync(int id)
        {
            return await _context.Engineers.FindAsync(id);
        }

        public async Task<Engineer> AddAsync(Engineer engineer)
        {
            _context.Engineers.Add(engineer);
            await _context.SaveChangesAsync();
            return engineer;
        }

        public async Task UpdateAsync(Engineer engineer)
        {
            _context.Engineers.Update(engineer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var engineer = await _context.Engineers.FindAsync(id);
            if (engineer != null)
            {
                _context.Engineers.Remove(engineer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
