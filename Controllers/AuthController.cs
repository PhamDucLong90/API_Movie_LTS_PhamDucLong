using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_XemPhim.PayLoad.DataRequest;
using Project_XemPhim.Services.Implement;
using Project_XemPhim.Services.Interface;

namespace Project_XemPhim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IEmailServices emailservices;
        private readonly IUserServices userservices;
        private readonly IConfiguration _configuration;
        public AuthController(IEmailServices _emailservices, IUserServices _userservices, IConfiguration configuration)
        {
           emailservices = _emailservices;
            userservices = _userservices;
            _configuration = configuration;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromForm] Request_Register request)
        {
            return Ok(userservices.Register(request));
        }
        [HttpGet("ConfirmEmailRegister")]
        public IActionResult ConfirmEmailRegister(string code)
        {
            return Ok(userservices.ConfirmEmail_Register(code));
        }
        [HttpPost("login")]
        public IActionResult Login([FromForm] Request_Login request)
        {
            return Ok(userservices.Login(request));
        }

    }
}
