using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.DataAccess.Entities;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController : ControllerBase
    {

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        [HttpGet]
        [Route("getbycode")]
        public async Task<IActionResult> GetByCode([FromQuery]string code)
        {
           
            return Ok();
        }
    }
}