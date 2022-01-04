using Microsoft.EntityFrameworkCore;

namespace CoolApi.Model
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
