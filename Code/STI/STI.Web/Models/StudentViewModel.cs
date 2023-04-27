using STI.BAL.Models.DTOs;

namespace STI.Web.Models
{
    public class StudentViewModel
    {
        public List<StudentDTO> studentList { get; set; }
        public StudentDTO inputStudent { get; set; }
    }
}
