using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderApi.DataAccess.Abstract;
using OrderApi.DataAccess.Entities;
using OrderApi.Domain.Queries;

namespace OrderApi.Domain.Handlers.QueryHandlers
{
    public class GetOrderByCodeQueryHandler : IRequestHandler<GetOrderByCodeQuery, Order>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByCodeQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }
        public Task<Order> Handle(GetOrderByCodeQuery request, CancellationToken cancellationToken)
        {
            //Business Validation...
            var order = _orderRepository.GetByCode(request.Code);
            return order;
        }
    }
}