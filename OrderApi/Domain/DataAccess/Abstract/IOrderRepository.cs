using System.Threading.Tasks;
using OrderApi.DataAccess.Entities;

namespace OrderApi.DataAccess.Abstract
{
    public interface IOrderRepository
    {
        Task Create(Order order);
        Task<Order> GetByCode(string code);
    }
}