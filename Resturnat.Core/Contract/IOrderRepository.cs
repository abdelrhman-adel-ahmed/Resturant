using Resturnat.Core.Models;
using System.Linq.Expressions;

namespace Resturnat.Core.Contract
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrder(Expression<Func<Order, bool>> query);
        
    }
}
