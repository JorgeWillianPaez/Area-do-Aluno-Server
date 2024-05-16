using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.src.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
