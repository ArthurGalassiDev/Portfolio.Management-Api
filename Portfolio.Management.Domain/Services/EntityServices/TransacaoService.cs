using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Domain.Services.EntityServices
{
    public class TransacaoService : IEntityService<Transacao>
    {
        public Task CreateAsync(Transacao produto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transacao>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Transacao> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Transacao produto)
        {
            throw new NotImplementedException();
        }
    }
}