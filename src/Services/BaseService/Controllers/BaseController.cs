using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BaseService.Controllers
{
    public class BaseController : ControllerBase
    {
        [NonAction]
        public string GetUserId()
        {
            var req = (User.Identity as ClaimsIdentity).Claims.FirstOrDefault(e => e.Type == ClaimTypes.NameIdentifier);

            if (req == null)
            {
                throw new Exception("Name identifier not found in claims");
            }

            return req.Value;
        }

    }
}
