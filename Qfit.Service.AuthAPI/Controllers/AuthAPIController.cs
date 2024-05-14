using Microsoft.AspNetCore.Mvc;
using Qfit.Service.AuthAPI.Models.DTO;
using Qfit.Service.AuthAPI.Service.IService;

namespace Qfit.Service.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {

        private readonly IAuthService _authService;
        protected ResponseDTO _response;
        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }




        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistarationRequsetDTO model)
        {
            var errorMessages = await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessages))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessages;
                return BadRequest(_response);
            }
            return Ok(_response);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
