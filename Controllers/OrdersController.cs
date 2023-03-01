using clothes_backend.Service;
using clothes_backend.Service.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clothes_backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        protected readonly IOrder orderService;
        public OrdersController(IOrder orderService)
        {
            this.orderService = orderService;
        }


        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderModel model)
        {
            try
            {
                var newOrder = await orderService.AddOrderAsync(model);
                return Ok(newOrder);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
