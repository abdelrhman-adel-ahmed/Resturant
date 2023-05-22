using Microsoft.EntityFrameworkCore;
using Resturant.Infrastructure.Context;
using Resturnat.Core.Contract;
using Resturnat.Core.Models;
using System.Linq.Expressions;

namespace Resturant.Infrastructure.Repositories
{
    public class MealsRepository : Repository<Meal>, IMealsRepository
    {
        public MealsRepository(ResturantDbContext dbContext)
           : base(dbContext)
        { }

        public Task DeleteAsync(Meal entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Meal>> GetAllAync()
        {
            return await _dbContext.Meals.Where(x => x.Available).ToListAsync();
        }

        public Task<List<Meal>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meal> GetMeal(Expression<Func<Meal, bool>> query)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Meal entity)
        {
            throw new NotImplementedException();
        }
    }
}
