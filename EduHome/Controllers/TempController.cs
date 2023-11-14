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

        public async Task<IActionResult> PostTeachers()
        {

            #region Teachers

            List<Teacher> teachers = new List<Teacher>()
            {
                new()
                {
        Id = Guid.NewGuid(),
        FirstName = "Mary",
        LastName = "Smith",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Masters",
        Experience = "5",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "English",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Traveling",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "David",
        LastName = "Jones",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Phd",
        Experience = "10",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "History",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Music",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Sarah",
        LastName = "Williams",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Masters",
        Experience = "7",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Art",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Hiking",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Michael",
        LastName = "Brown",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Phd",
        Experience = "12",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Math",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Cooking",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Jessica",
        LastName = "Johnson",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Masters",
        Experience = "9",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Science",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Photography",
                CreatedDate = DateTime.Now
            }
        }
    },
   new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Robert",
        LastName = "Miller",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Phd",
        Experience = "14",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Engineering",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Coding",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Ashley",
        LastName = "Davis",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Masters",
        Experience = "11",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Business",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Investing",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Christopher",
        LastName = "Wilson",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Phd",
        Experience = "16",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Medicine",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Volunteering",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Lauren",
        LastName = "Taylor",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Masters",
        Experience = "13",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Law",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Reading",
                CreatedDate = DateTime.Now
            }
        }
    },
    new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Daniel",
        LastName = "Moore",
        AboutMe = "lorem ipsum dolor sit amet",
        CreatedDate = DateTime.Now,
        Degree = "Phd",
        Experience = "18",
        ImagePath = "teacher-details.jpg",
        Faculties = new List<Faculty>()
        {
            new Faculty()
            {
                Id = Guid.NewGuid(),
                FacultyName = "Philosophy",
                CreatedDate = DateTime.Now
            }
        },
        Hobbies = new List<Hobby>()
        {
            new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Writing",
                CreatedDate = DateTime.Now
            }
        }
    }
            };

            #endregion

            await _context.Teachers.AddRangeAsync(teachers);
            await _context.SaveChangesAsync();

            return Ok();

        }

    }
}
