using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Infra.Data.Context;
using Portfolio.Management.Infra.Data.Repositories.Abstractions;

namespace Portfolio.Management.Infra.Data.Repositories
{
    public class ProdutoFinanceiroRepository(ApplicationDbContext context) : IRepository<ProdutoFinanceiro>
    {
        private readonly ApplicationDbContext _context = context;

        public void AdicionarProduto(ProdutoFinanceiro produto)
        {
            _context.ProdutosFinanceiros.Add(produto);
            _context.SaveChanges();
        }

        public void AtualizarProduto(ProdutoFinanceiro produto)
        {
            var produtoExistente = _context.ProdutosFinanceiros.Find(produto.Id);
            if (produtoExistente != null)
            {
                _context.Entry(produtoExistente).CurrentValues.SetValues(produto);
                _context.SaveChanges();
            }
        }

        public void RemoverProduto(int id)
        {
            var produto = _context.ProdutosFinanceiros.Find(id);
            if (produto != null)
            {
                _context.ProdutosFinanceiros.Remove(produto);
                _context.SaveChanges();
            }
        }

        public ProdutoFinanceiro? ObterProduto(int id)
        {
            return _context.ProdutosFinanceiros.Find(id);
        }

        public IEnumerable<ProdutoFinanceiro> ObterTodosProdutos()
        {
            return _context.ProdutosFinanceiros.ToList();
        }

        public Task<IEnumerable<ProdutoFinanceiro>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoFinanceiro> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(ProdutoFinanceiro entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProdutoFinanceiro entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            var produto = _context.ProdutosFinanceiros.Find(id);
            if (produto != null)
            {
                _context.ProdutosFinanceiros.Remove(produto);
                _context.SaveChanges();
            }
        }
    }
}