using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Domain.Services.EntityServices
{
    public class ProdutoFinanceiroService : IEntityService<ProdutoFinanceiro>
    {
        public async Task CreateAsync(ProdutoFinanceiro produto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProdutoFinanceiro>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoFinanceiro> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProdutoFinanceiro produto)
        {
            throw new NotImplementedException();
        }
    }
}