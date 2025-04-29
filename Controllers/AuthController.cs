using gestor_backend.Request;
using gestor_backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gestor_backend.Controllers
{

    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public async Task<ActionResult> LoginController([FromBody] LoginRequest request)
        {
            bool isCredentialsValid = await _authService.ValidateCredentials(request.email, request.password);
            return Ok(new { access_token = "asdd131sadad-asdadasd-asdasda" });
        }
        
    }
}
