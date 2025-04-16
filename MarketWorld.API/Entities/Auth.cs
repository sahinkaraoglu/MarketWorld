using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketWorld.Api.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {

        public class RegisterRequestModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class LoginRequestModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class ForgetPasswordRequestModel
        {
            public string Email { get; set; }
        }

        public class ResetPasswordRequestModel
        {
            public string Email { get; set; }
            public string Token { get; set; }
            public string Password { get; set; }
        }
    }
}
