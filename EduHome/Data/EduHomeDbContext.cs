using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Data
{
    public class EduHomeDbContext:DbContext
    {
        public DbSet<SliderItem> SliderItems { get; set; }


        public EduHomeDbContext(DbContextOptions<EduHomeDbContext> options):base(options) { }
    }
}
