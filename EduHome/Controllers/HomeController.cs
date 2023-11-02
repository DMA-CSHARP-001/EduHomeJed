using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        EduHomeDbContext _context;

		public HomeController(EduHomeDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            List<SliderItem> list = _context.SliderItems.ToList();

            return View(list);
        }

        public IActionResult About() 
        {
            return View();
        }
        public ActionResult Contact() 
        {
            return View();
        }
    }
}
