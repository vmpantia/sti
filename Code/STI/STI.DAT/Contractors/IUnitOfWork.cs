using STI.DAT.DataAccess.Entities;

namespace STI.DAT.Contractors
{
    public interface IUnitOfWork
    {
        IBaseRepository<Category> CategoryRepoistory { get; }
        IBaseRepository<Course> CourseRepository { get; }
        IBaseRepository<Student> StudentRepository { get; }
        IBaseRepository<Subject> SubjectRepository { get; }
        Task SaveAsync();
        void Dispose();
    }
}