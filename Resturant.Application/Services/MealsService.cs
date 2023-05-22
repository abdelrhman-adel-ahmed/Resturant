using Resturant.Infrastructure.Repositories;
using Resturnat.Core.Contract;
using Resturnat.Core.Models;

namespace Resturant.Application.Services
{
    public class MealOrderService
    {
        IMealsRepository _mealsRepository;
        public MealOrderService(IMealsRepository mealsRepository)
        {
            _mealsRepository = mealsRepository;
        }

        public async Task<IEnumerable<Meal>> GetMealsAsync()
        {
            return await _mealsRepository.GetAllAync();
        }
    }
}
