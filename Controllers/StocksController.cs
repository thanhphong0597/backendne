using clothes_backend.Service;
using clothes_backend.Service.DalService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clothes_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        protected readonly IStock stocksdb;

        public StocksController(IStock stocksdb)
        {
            this.stocksdb = stocksdb;
        }

        [HttpPost]
        [Route("addstock")]
        public async Task<IActionResult> AddStock(AddStockModel model)
        {
            try
            {
                var result = await stocksdb.AddStockAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("deletestock")]

        public async Task<IActionResult> DeleteStock(AddStockModel model)
        {
            try
            {
                var result = await stocksdb.DeleteStockAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
