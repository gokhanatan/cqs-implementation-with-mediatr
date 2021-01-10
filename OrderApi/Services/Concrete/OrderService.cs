using System.Threading.Tasks;
using OrderApi.DataAccess.Abstract;
using OrderApi.DataAccess.Entities;
using OrderApi.Services.Abstract;

namespace OrderApi.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }
        public async Task Create(Order order)
        {
            await _orderRepository.Create(order);
        }

        public async Task<Order> GetByCode(string code)
        {
            return await _orderRepository.GetByCode(code);
        }
    }
}