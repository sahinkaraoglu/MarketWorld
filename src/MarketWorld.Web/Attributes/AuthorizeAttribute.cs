using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace MarketWorld.Web.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // UserId context items'da varsa kullanıcı giriş yapmış demektir
            var userId = context.HttpContext.Items["UserId"];
            if (userId == null)
            {
                // Giriş yapılmamışsa login sayfasına yönlendir
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }
        }
    }
} 