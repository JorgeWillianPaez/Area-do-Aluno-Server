using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.src.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
