using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.DataAccess.Entities;
using OrderApi.Services.Abstract;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(Order order)
        {
            await _orderService.Create(order);
            return Ok();
        }

        [HttpGet]
        [Route("getbycode")]
        public async Task<IActionResult> GetByCode([FromQuery]string code)
        {
            var order = await _orderService.GetByCode(code);
            return Ok(order);
        }
    }
}