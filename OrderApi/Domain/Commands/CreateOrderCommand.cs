using System;
using MediatR;

namespace OrderApi.Domain.Commands
{
    public class CreateOrderCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}