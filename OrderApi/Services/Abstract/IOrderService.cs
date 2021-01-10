using System.Threading.Tasks;
using OrderApi.DataAccess.Entities;

namespace OrderApi.Services.Abstract
{
    public interface IOrderService
    {
        Task Create(Order order);
        Task<Order> GetByCode(string code);
    }
}