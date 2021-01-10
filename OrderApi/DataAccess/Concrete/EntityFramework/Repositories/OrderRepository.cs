using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderApi.DataAccess.Abstract;
using OrderApi.DataAccess.Concrete.EntityFramework.Context;
using OrderApi.DataAccess.Entities;

namespace OrderApi.DataAccess.Concrete.EntityFramework.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ECommerceContext _context;

        public OrderRepository(ECommerceContext context)
        {
            _context = context;

        }
        public async Task Create(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Order> Get(string code)
        {
            return await _context.Orders.SingleOrDefaultAsync(o => o.Code == code);
        }
    }
}