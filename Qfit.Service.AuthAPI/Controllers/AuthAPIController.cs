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
        public async Task<IActionResult> Login([FromBody] LoginReqeustDTO model)
        {
            var loginResponse = await _authService.login(model);
            if (loginResponse.Member == null)
            {
                _response.IsSuccess = false;
                _response.Message = "UserName or password is incorrect";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);

        }


        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistarationRequsetDTO model)
        {
            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignRoleSuccessful)
            {
                _response.IsSuccess = false;
                _response.Message = "Error Encountered";
                return BadRequest(_response);
            }

            return Ok(_response);

        }
    }
}
