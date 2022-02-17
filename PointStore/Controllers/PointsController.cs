using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PointStore.Domain.Interface.IService;

namespace PointStore.Controllers
{
    [Authorize]    
    public class PointsController : ControllerBase
    {
        private readonly IPointsService _pointsService;
        private readonly ICadastroService _cadastroService;

        public PointsController(IPointsService pointsService,ICadastroService cadastroService)
        {
            _pointsService = pointsService;
            _cadastroService = cadastroService;
        }
        [HttpGet]        
        public async Task<IActionResult> ConsultarPontosAsync()
        {
            try
            {
                var dadosUser = HttpContext.User.Claims.ToList();
                var userName = dadosUser[3].Value;
                var consultaSeUsuarioEstaCadastrado = await _cadastroService.VerificarSeExisteCadastro(userName);
                if (consultaSeUsuarioEstaCadastrado != null)
                {
                    var consultaPontos = await _pointsService.ConsultarPontosAsync(consultaSeUsuarioEstaCadastrado.UserName);
                    return Ok(consultaPontos);
                }
               
                return NotFound("_ValidarLoginNaLoja");
                
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        [HttpPost]
        
        public async Task<IActionResult> CadastrarUsuariosAsync()
        {
            var dadosUser = HttpContext.User.Claims.ToList();
            return Ok(dadosUser);
        }      

    }
}
