using STI.BAL.Extensions;
using STI.BAL.Models.DTOs;
using STI.BAL.Models.Requests;
using STI.Common.Extensions;
using STI.DAT.Contractors;
using STI.DAT.DataAccess.Entities;

namespace STI.BAL.Services
{
    public class StudentService
    {
        private readonly IUnitOfWork _uow;
        public StudentService(IUnitOfWork uow) => _uow = uow;

        public async Task<int> CountStudentsAsync() 
            => await _uow.StudentRepository.CountAllAsync();

        public async Task<List<StudentDTO>> GetStudentsAsync()
        {
            var result = await _uow.StudentRepository.GetAllAsync();
            return result.Select(data => data.ConvertToDTO()).ToList();
        }

        public async Task<StudentDTO> GetStudentByIDAsync(Guid internalID)
        {
            var result = await _uow.StudentRepository.GetByIDAsync(internalID);
            return result.ConvertToDTO();
        }

        public async Task SaveStudentAsync(SaveStudentDTORequest request)
        {
            var student = new Student();
            student.Transfer(request.inputStudentDTO);

            var isAdd = student.InternalID == Guid.Empty;
            student.InternalID = isAdd ? Guid.NewGuid() : student.InternalID;
            student.CreatedDate = isAdd ? DateTime.Now : student.CreatedDate;
            student.ModifiedDate = isAdd ? null : DateTime.Now;

            if (isAdd)
                await _uow.StudentRepository.AddAsync(student);
            else
                await _uow.StudentRepository.UpdateAsync(student.InternalID,
                    new
                    {
                        student.Type,
                        student.FirstName,
                        student.MiddleName,
                        student.LastName,
                        student.Gender,
                        student.Birthdate,
                        student.PersonalContactNo,
                        student.PersonalEmailAddress,
                        student.ICOEFullName,
                        student.ICOEContactNo,
                        student.ICOEAddress,
                        student.ICOEReletion,
                        student.PresentAddress,
                        student.PermanentAddress,
                        student.ProvincialAddress,
                        student.Status,
                        student.ModifiedDate
                    });

            await _uow.SaveAsync();
        }
    }
}
