using Microsoft.EntityFrameworkCore;

namespace EduHome.Data
{
    public class EduHomeDbContext:DbContext
    {
        public EduHomeDbContext(DbContextOptions<EduHomeDbContext> options):base(options) { }
    }
}
