using System.ComponentModel.DataAnnotations;

namespace STI.DAT.DataAccess.Entities
{
    public class Course
    {
        //Course Details
        [Key]
        public Guid InternalID { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        public int TotalUnit { get; set; }


        //Category Details
        public virtual Category Category { get; set; }


        //Common Details
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
