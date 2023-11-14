using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Data
{
    public class EduHomeDbContext:DbContext
    {
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Faculty> Faculties{ get; set; }

        public EduHomeDbContext(DbContextOptions<EduHomeDbContext> options):base(options) { }
    }
}
