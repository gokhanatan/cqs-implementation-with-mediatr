using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderApi.DataAccess.Entities;
using OrderApi.Domain.Commands;
using OrderApi.Domain.Queries;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(CreateOrderCommand createOrderCommand)
        {
            await _mediator.Send(createOrderCommand);
            return Ok();
        }

        [HttpGet]
        [Route("getbycode")]
        public async Task<IActionResult> GetByCode([FromQuery] string code)
        {
            GetOrderByCodeQuery query = new GetOrderByCodeQuery(code);
            var order = await _mediator.Send(query);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
    }
}