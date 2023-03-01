using clothes_backend.Service;
using clothes_backend.Service.DalService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clothes_backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected readonly IProduct productService;

        public ProductsController(IProduct productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        //[Authorize(Roles = UserRoles.User)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                return Ok(await productService.GetProductsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                var data = await productService.GetProductAsync(id);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
          
        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model)
        {
            try
            {
                var result = await productService.EditProductAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("editname")]
        public async Task<IActionResult> EditProductName(ProductNameModel model)
        {
            try
            {
                var result = await productService.EditProductNameAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("editstock")]
        public async Task<IActionResult> EditProductStock(ProductStockModel model)
        {
            try
            {
                var result = await productService.EditProductStockAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("addproduct")]
        public async Task<IActionResult> AddProduct(ProductAddModel model)
        {
            try
            {
                var result = await productService.AddProductAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        
        public async Task<IActionResult> DeleteProductStock(int id)
        {
            try
            {
                var result = await productService.DeleteProductAsync(id);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
