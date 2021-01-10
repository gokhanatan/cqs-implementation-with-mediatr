using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderApi.DataAccess.Abstract;
using OrderApi.DataAccess.Entities;
using OrderApi.Domain.Commands;
using OrderApi.Domain.Events;

namespace OrderApi.Domain.Handlers.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IMediator _mediator;
        private readonly IOrderRepository _orderRepository;
        public CreateOrderCommandHandler(IMediator mediator, IOrderRepository orderRepository)
        {
            _mediator = mediator;
            _orderRepository = orderRepository;
        }
        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order()
            {
                Code = request.Code,
                CreateDate = DateTime.Now,
                TotalPrice = request.TotalPrice,
                UserId = request.UserId,
                Status = "Created"
            };

            await _orderRepository.Create(order);

            OrderCreatedEvent orderCreatedEvent = new OrderCreatedEvent()
            {
                Id = order.Id,
                Code = order.Code,
                CreateDate = order.CreateDate,
                TotalPrice = order.TotalPrice,
                UserId = order.UserId,
                Status = order.Status
            };
            
            await _mediator.Publish(orderCreatedEvent, cancellationToken);

            return Unit.Value;
        }
    }
}