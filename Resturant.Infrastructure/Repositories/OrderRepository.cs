using Resturant.Infrastructure.Context;
using Resturnat.Core.Contract;
using Resturnat.Core.Models;
using System.Linq.Expressions;

namespace Resturant.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ResturantDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Order> GetOrder(Expression<Func<Order, bool>> query)
        {          
            throw new NotImplementedException();
        }
    }
}
