using Microsoft.AspNetCore.Mvc;

namespace PointStore.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
