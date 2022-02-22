using Microsoft.AspNetCore.Mvc;
using PointStore.Domain.Entity;
using PointStore.Domain.Enum;

namespace PointStore.Controllers
{
    public class BaseController : Controller
    {
        public UsuarioCognito RetornaDadosUsuarioCognito()
        {
            var usuarioLogin = HttpContext.User.Claims.ToList();
            var userName = usuarioLogin.FirstOrDefault(login => login.Type == "cognito:username").Value;
            var grupoUsuarioCognito = usuarioLogin.FirstOrDefault(login => login.Type == "cognito:groups").Value;
            var guid = usuarioLogin[0].Value;
            Guid guidCognito = Guid.Parse(guid);
            TipoUsuario validaTipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), grupoUsuarioCognito);
            Usuario dadosUsuarioCognito = new Usuario
            {
                Login = userName,
                Id = guidCognito,
                TipoUsuario = validaTipoUsuario
            };
            return dadosUsuarioCognito;

        }
    }
}
