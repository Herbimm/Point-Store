using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PointStore.Controllers
{
    public class ExternalAuthenticationController : Controller
    {
        public IActionResult CallBack()
        {
            //caputure the user object
            return RedirectToAction("Index", "Home");
        }
        public IActionResult SignOut()
        {
            var callbackUrl = Url.Page("/", pageHandler: null, values: null, protocol: Request.Scheme);
            return SignOut(
                new AuthenticationProperties { RedirectUri = callbackUrl },
                CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme
            );
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ObterTokenAsync()
        {

            var token = await HttpContext.GetTokenAsync("access_token");

            var dadosUser = HttpContext.User.Claims.ToList();


            var userName = dadosUser[3].Value;

            return Ok(token);
        }
    }
}
