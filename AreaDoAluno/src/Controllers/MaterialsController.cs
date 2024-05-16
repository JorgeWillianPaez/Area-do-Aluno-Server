using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.src.Controllers
{
    public class MaterialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
