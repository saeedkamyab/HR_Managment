namespace HR_Managment.Application.Contracts.Persistence.Common
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : class
    {
        Task<TEntity> Get(TKey id);
        Task<IReadOnlyList<TEntity>> GetAll();
        Task<TEntity> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TKey id);
    }
}
