using Resturnat.Core.Contract;
using Resturnat.Core.Models;

namespace Resturant.Application.Services
{
    public class CartService
    {
        private readonly IOrderRepository _orderRepository;
        public CartService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task PlaceOrderAsync(List<Meal> meals)
        {
            try
            {
                var order = new Order();

                foreach (var meal in meals)
                {
                    var orderMeal = new OrderMeal
                    {
                        Meal = meal,
                        Quantity = 1, //mock (come from mealDTO from front)
                        Order = order
                    };

                    order.OrderMeals.Add(orderMeal);
                }
                await _orderRepository.AddAsync(order);
                await _orderRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //logger
            }
        }
    }
}
