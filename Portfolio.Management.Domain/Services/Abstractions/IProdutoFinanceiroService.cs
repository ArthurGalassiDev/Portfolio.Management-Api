using Portfolio.Management.Domain.Entities;

namespace Portfolio.Management.Domain.Services.Abstractions
{
    public interface IProdutoFinanceiroService
    {
        Task<IEnumerable<ProdutoFinanceiro>> GetProdutosAsync();
        Task<ProdutoFinanceiro> GetProdutoByIdAsync(int id);
        Task CreateProdutoAsync(ProdutoFinanceiro produto);
        Task UpdateProdutoAsync(ProdutoFinanceiro produto);
        Task DeleteProdutoAsync(int id);
    }
}
