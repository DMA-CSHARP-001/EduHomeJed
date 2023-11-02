using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TemporaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
