using Microsoft.EntityFrameworkCore;
using Resturant.Application.Services;
using Resturant.Infrastructure.Context;
using Resturant.Infrastructure.Repositories;
using Resturnat.Core.Contract;

namespace Resturant.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            DIContainerRegister(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseCors(options => options.AllowAnyOrigin());

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            
            app.Run();
        }

        private static void DIContainerRegister(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ResturantDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ResturantDb"));
            });
            builder.Services.AddScoped<CartService>();
            builder.Services.AddScoped<MealOrderService>();
            builder.Services.AddScoped<IMealsRepository, MealsRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}