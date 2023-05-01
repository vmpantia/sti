using STI.BAL.Models.DTOs;
using STI.Common;
using STI.Common.Extensions;
using STI.DAT.DataAccess.Entities;

namespace STI.BAL.Extensions
{
    public static class StudentExtension
    {
        public static StudentDTO ConvertToDTO(this Student student)
        {
            var studentDTO = new StudentDTO();
            studentDTO.Transfer(student);
            studentDTO.TypeDescription = Parser.ParseType(student.Type);
            studentDTO.StatusDescription = Parser.ParseStatus(student.Type);
            return studentDTO;
        }
    }
}
