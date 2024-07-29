using Portfolio.Management.Domain.Entities;

namespace Portfolio.Management.Domain.Services.Abstractions
{
    public interface IEntityService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity produto);
        Task UpdateAsync(TEntity produto);
        Task DeleteAsync(int id);
    }
}