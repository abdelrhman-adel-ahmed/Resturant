using Resturnat.Core.Models;
using System.Linq.Expressions;

namespace Resturnat.Core.Contract
{
    public interface IMealsRepository : IRepository<Meal>
    {
        IEnumerable<Meal> GetMeal(Expression<Func<Meal, bool>> query);
        Task<IEnumerable<Meal>> GetAllAync();   
    }
}
