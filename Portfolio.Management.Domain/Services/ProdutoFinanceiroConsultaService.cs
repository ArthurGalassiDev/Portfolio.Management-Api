using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Domain.Services
{
    public class ProdutoFinanceiroService : IProdutoFinanceiroService
    {
        public async Task<IEnumerable<ProdutoFinanceiro>> GetProdutosAsync()
        {
            return default;
        }

        public async Task<ProdutoFinanceiro> GetProdutoByIdAsync(int id)
        {
            return default;
        }

        public async Task CreateProdutoAsync(ProdutoFinanceiro produto)
        {
            await Task.CompletedTask;
        }

        public async Task UpdateProdutoAsync(ProdutoFinanceiro produto)
        {
         
            await Task.CompletedTask;
        }

        public async Task DeleteProdutoAsync(int id)
        {
            await Task.CompletedTask;
        }
    }
}