using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.src.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
