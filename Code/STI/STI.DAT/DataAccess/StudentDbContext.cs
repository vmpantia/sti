using Microsoft.EntityFrameworkCore;
using STI.DAT.DataAccess.Entities;

namespace STI.DAT.DataAccess
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
