using MediatR;
using OrderApi.DataAccess.Entities;

namespace OrderApi.Domain.Queries
{
    public class GetOrderByCodeQuery : IRequest<Order>
    {
        public string Code { get; set; }
        public GetOrderByCodeQuery(string code)
        {
            Code = code;
        }
    }
}