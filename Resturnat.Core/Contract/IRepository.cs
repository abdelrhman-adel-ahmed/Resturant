namespace Resturnat.Core.Contract
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAsync();

        void Delete(T entity);
        Task AddAsync(T entity);
        Task SaveChangesAsync();
    }
}
