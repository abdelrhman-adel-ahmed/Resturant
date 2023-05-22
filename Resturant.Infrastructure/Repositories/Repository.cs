using Microsoft.EntityFrameworkCore;
using Resturant.Infrastructure.Context;
using Resturnat.Core.Contract;

namespace Resturant.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public ResturantDbContext _dbContext { get; set; }
        public Repository(ResturantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<T>> GetAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public void UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
