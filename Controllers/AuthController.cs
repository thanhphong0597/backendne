using clothes_backend.Entities.Client;
using clothes_backend.Service;
using clothes_backend.Service.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace testauthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        protected readonly IAuth authRepo;

        public AuthController(IAuth authRepo)
        {
            this.authRepo = authRepo;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await authRepo.LoginAsync(model);
            if (result != string.Empty) return Ok(result);
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await authRepo.RegisterAsync(model);
            if(result.Status=="Success") return Ok (result);
            else return StatusCode(StatusCodes.Status500InternalServerError,result);
        }
        [HttpPost]
        [Route("register-admin")]

        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var result = await authRepo.RegisterAdminAsync(model);
            if(result.Status == "Success") return Ok (result);
            return StatusCode(StatusCodes.Status500InternalServerError,result);
        }
      
    }
}
