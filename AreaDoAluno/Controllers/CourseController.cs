using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
