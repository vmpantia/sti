using STI.DAT.Contractors;
using STI.DAT.DataAccess;
using STI.DAT.DataAccess.Entities;
using STI.DAT.Repositories;

namespace STI.DAT
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly StudentDbContext _db;
        private IBaseRepository<Category> _categoryRepo;
        private IBaseRepository<Course> _courseRepo;
        private IBaseRepository<Student> _studentRepo;
        private IBaseRepository<Subject> _subjectRepo;
        public UnitOfWork(StudentDbContext db) => _db = db;

        public IBaseRepository<Category> CategoryRepoistory
        {
            get
            {
                if (_categoryRepo == null)
                    _categoryRepo = new BaseRepository<Category>(_db);

                return _categoryRepo;
            }
        }
        public IBaseRepository<Course> CourseRepository
        {
            get
            {
                if (_courseRepo == null)
                    _courseRepo = new BaseRepository<Course>(_db);

                return _courseRepo;
            }
        }
        public IBaseRepository<Student> StudentRepository
        {
            get
            {
                if (_studentRepo == null)
                    _studentRepo = new BaseRepository<Student>(_db);

                return _studentRepo;
            }
        }
        public IBaseRepository<Subject> SubjectRepository
        {
            get
            {
                if (_subjectRepo == null)
                    _subjectRepo = new BaseRepository<Subject>(_db);

                return _subjectRepo;
            }
        }

        public async Task SaveAsync()
        {
            var result = await _db.SaveChangesAsync();

            if (result == 0)
                throw new Exception();
        }
        public void Dispose()
        {
            _db.Dispose();
            _categoryRepo = null;
            _courseRepo = null;
            _studentRepo = null;
            _subjectRepo = null;
        }
    }
}
