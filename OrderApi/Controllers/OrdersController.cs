using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.DataAccess.Entities;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {
            
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(Order order)
        {
            return Ok();
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get(string orderCode)
        {
            return Ok();
        }
    }
}