using System.ComponentModel.DataAnnotations;

namespace STI.BAL.Models
{
    public class StudentDTO
    {
        //Student Details
        public Guid InternalID { get; set; }

        [Required, MaxLength(15)]
        public string ID { get; set; }

        public int Type { get; set; }
        public string TypeDescription { get; set; } = string.Empty;

        //Personal Details
        [Required, MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string MiddleName { get; set; } = string.Empty;

        [Required, MaxLength(40)]
        public string LastName { get; set; }

        [Required, MaxLength(6)]
        public string Gender { get; set; }

        public DateTime Birthdate { get; set; }


        //Contact Details (Personal)
        [Required, MaxLength(15)]
        public string PersonalContactNo { get; set; }

        [Required, MaxLength(50)]
        public string PersonalEmailAddress { get; set; }


        //Contact Details (In case of emergency)
        [Required, MaxLength(120)]
        public string ICOEFullName { get; set; }

        [Required, MaxLength(15)]
        public string ICOEContactNo { get; set; }

        [Required, MaxLength(100)]
        public string ICOEAddress { get; set; }

        [Required, MaxLength(100)]
        public string ICOEReletion { get; set; }


        //Location Details
        [Required, MaxLength(100)]
        public string PresentAddress { get; set; }

        [Required, MaxLength(100)]
        public string PermanentAddress { get; set; }

        [MaxLength(100)]
        public string ProvincialAddress { get; set; }

        //Common Details
        public int Status { get; set; }
        public string StatusDescripton { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
