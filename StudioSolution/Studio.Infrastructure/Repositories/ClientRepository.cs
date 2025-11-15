using Studio.Domain.Entities;
using Studio.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<IEnumerable<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
