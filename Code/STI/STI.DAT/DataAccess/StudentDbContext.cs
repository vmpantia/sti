using Microsoft.EntityFrameworkCore;
using STI.DAT.DataAccess.Entities;

namespace STI.DAT.DataAccess
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
