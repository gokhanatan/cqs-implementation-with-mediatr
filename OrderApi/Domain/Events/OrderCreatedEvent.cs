using System;
using MediatR;

namespace OrderApi.Domain.Events
{
    public class OrderCreatedEvent : INotification
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }

    }
}