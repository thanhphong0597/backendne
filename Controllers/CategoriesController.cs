using clothes_backend.Service.DalService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clothes_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        protected readonly ICategory categoryDb;

        public CategoriesController(ICategory categoryDb)
        {
            this.categoryDb = categoryDb;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                return Ok(await categoryDb.GetCategoriesAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
