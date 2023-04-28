using STI.BAL.Models.DTOs;
using STI.BAL.Models.Requests;

namespace STI.BAL.Contractors
{
    public interface IStudentService
    {
        Task<int> CountStudentsAsync();
        Task<StudentDTO> GetStudentByIDAsync(Guid internalID);
        Task<List<StudentDTO>> GetStudentsAsync();
        Task SaveStudentAsync(SaveStudentDTORequest request);
    }
}