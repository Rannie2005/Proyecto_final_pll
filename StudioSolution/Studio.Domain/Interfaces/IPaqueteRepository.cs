using Studio.Domain.Entities;

namespace Studio.Domain.Interfaces
{
    public interface IPaqueteRepository : IBaseRepository<Paquete>
    {
        Task<IEnumerable<Paquete>> GetPaquetesActivosAsync();
    }
}