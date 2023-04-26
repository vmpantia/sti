using STI.BAL.Models.DTOs;

namespace STI.BAL.Models.Requests
{
    public class SaveStudentDTORequest : BaseRequest
    {
        public StudentDTO inputStudentDTO { get; set; }
    }
}
