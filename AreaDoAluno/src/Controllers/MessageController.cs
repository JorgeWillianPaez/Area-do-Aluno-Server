using Microsoft.AspNetCore.Mvc;

namespace AreaDoAluno.src.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
