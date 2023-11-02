using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
	public class TemporaryController : Controller
	{
		EduHomeDbContext _context;

		public TemporaryController(EduHomeDbContext context)
		{
			_context = context;
		}

		public IActionResult TempForm()
		{
			return View();
		}

		[HttpPost]
		public IActionResult TempPost(SliderItem sliderItem)
		{

			sliderItem.CreatedDate = DateTime.Now;

			_context.SliderItems.Add(sliderItem);
			_context.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}
