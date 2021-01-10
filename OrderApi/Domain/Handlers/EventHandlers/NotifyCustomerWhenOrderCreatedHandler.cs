using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderApi.Domain.Events;

namespace OrderApi.Domain.Handlers.EventHandlers
{
    public class NotifyCustomerWhenOrderCreatedHandler : INotificationHandler<OrderCreatedEvent>
    {
        
        public NotifyCustomerWhenOrderCreatedHandler()
        {
        }

        public async Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
        {
            var userName = "Gokhan ATAN"; //Get User from Repository.

            System.Console.WriteLine($"Dear {userName}, your order was created successfully");

            await Task.Yield();
        }
    }
}