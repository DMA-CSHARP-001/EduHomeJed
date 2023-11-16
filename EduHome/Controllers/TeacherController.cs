using EduHome.Data;
using EduHome.Dtos.Teacher;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        EduHomeDbContext _dbContext;

		public TeacherController(EduHomeDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
        {

            // select id, imagePath, firstName, lastName, degree from Teachers
            var list = _dbContext.Teachers.Select(t => new IndexDto()
            {
                Id = t.Id,
                Image = t.ImagePath,
                FullName = t.FirstName + " " + t.LastName,
				Degree = t.Degree
            }).ToList();

            TeacherVm teacherVm = new TeacherVm();
            teacherVm.Teachers = list;

            return View(teacherVm);
        }

        public IActionResult Detail(string teacherId)
        {
            // Select * from Teachers where id = teacherId
            //var teacher = _dbContext.Teachers.FirstOrDefault(t => t.Id == Guid.Parse(teacherId));
            //var teac = _dbContext.Teachers.Find(teacherId);
            var teac = _dbContext.Teachers.Where(te => te.Id == Guid.Parse(teacherId))
                                            .Include(t => t.Faculties)
                                            .Include(t => t.Hobbies).FirstOrDefault();

            return View(teac);
        }
    }
}
