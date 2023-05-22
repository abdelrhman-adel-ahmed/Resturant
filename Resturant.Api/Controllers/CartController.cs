using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Resturant.Application.Services;
using Resturnat.Core.Models;

namespace Resturant.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        private CartService _CartService;
        public CartController(CartService cartService)
        {
            _CartService = cartService;
        }
        [HttpPost]
        public async Task PlaceOrder(List<Meal> meals)
        {
            /*
             * workFlow could be like this : 
             * 1- user place order 
             * 2- chef start preper the order 
             * 3- set order status during process 
             * 4- if the ingrediant to prepare spcific dish is not present , we may have 
             * event driven approach to notify the supplier to supply us with the ingredaiant 
             * and remove the dish from the Available meals 
             * 5- either we manuly control the avilablity of the dish or we can have event
             * driven approach that listen to the ingriant table and set the avilable amount of
             * dishes we can make using those ingriant (chef must supply the equation for each
             * dish)
             */
            await _CartService.PlaceOrderAsync(meals);
        }
    }
}
