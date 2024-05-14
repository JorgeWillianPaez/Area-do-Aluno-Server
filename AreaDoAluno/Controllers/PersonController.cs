using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
