namespace HR_Managment.Application.Contracts.Persistence.Common
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : class
    {
        Task<TEntity> Get(TKey id);
        Task<IReadOnlyList<TEntity>> GetAll();//when you use IReadOnlyList change tracker in ef or orms does not track the list because it knows that it won't change  
        Task<TEntity> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
