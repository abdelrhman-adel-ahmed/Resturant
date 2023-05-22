using Microsoft.AspNetCore.Mvc;
using Resturant.Application.Services;
using Resturnat.Core.Models;

namespace Resturant.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealsController : Controller
    {
        private readonly MealOrderService _mealOrderService;

        public MealsController(MealOrderService mealOrderService)
        {
            _mealOrderService = mealOrderService;
        }
            
        [HttpGet]
        public async Task<IEnumerable<Meal>> GetMeals()
        {
            return await _mealOrderService.GetMealsAsync();
        }
    }
}
