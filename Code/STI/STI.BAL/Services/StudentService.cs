using STI.BAL.Extensions;
using STI.BAL.Models;
using STI.DAT.Contractors;

namespace STI.BAL.Services
{
    public class StudentService
    {
        private readonly IUnitOfWork _uow;
        public StudentService(IUnitOfWork uow) => _uow = uow;

        public async Task<List<StudentDTO>> GetStudentsAsync()
        {
            var result = await _uow.StudentRepository.GetAllAsync();
            return result.Select(data => data.ConvertToDTO()).ToList();
        }

    }
}
