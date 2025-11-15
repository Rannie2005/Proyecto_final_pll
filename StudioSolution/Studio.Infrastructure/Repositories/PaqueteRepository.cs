using Studio.Domain.Entities;
using Studio.Domain.Interfaces;
using Studio.Infrastructure.Context;

namespace Studio.Infrastructure.Repositories
{
    public class PaqueteRepository : BaseRepository<Paquete>, IPaqueteRepository
    {
        public PaqueteRepository(StudioContext context) : base(context) { }

        public async Task<IEnumerable<Paquete>> GetPaquetesActivosAsync()
        {
            return await FindAsync(p => p.Activo);
        }
    }
}