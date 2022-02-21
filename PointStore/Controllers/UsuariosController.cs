using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PointStore.Domain.Interface.IService;

namespace PointStore.Controllers
{
    public class UsuariosController : BaseController
    {
        private readonly IUsuarioService _usuariosService;

        public UsuariosController(IUsuarioService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ValidacaoLoginAsync()
        {
            try
            {
                var dadosUsuario = RetornaDadosUsuarioCognito();            
                var validaUsuario = await _usuariosService.ValidarUsuarioAsync(dadosUsuario.Id);     
                if (validaUsuario == null)
                {
                    return View("");
                }
                return View("Index");              
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult CallBack()
        {           
            return RedirectToAction("ValidacaoLoginAsync", "Usuarios");
        }

        public IActionResult SignOut()
        {
            var callbackUrl = Url.Page("/", pageHandler: null, values: null, protocol: Request.Scheme);
            return SignOut(
                new AuthenticationProperties { RedirectUri = callbackUrl },
                CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme
            );
        }
    }
}
