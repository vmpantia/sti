using STI.DAT.DataAccess.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace STI.BAL.Models.DTOs
{
    public class StudentDTO
    {
        //Student Details
        [Key]
        public Guid InternalID { get; set; }

        [Required, MaxLength(15), DisplayName("Student ID")]
        public string ID { get; set; }

        public int Type { get; set; }
        public string TypeDescription { get; set; } = string.Empty;


        //Personal Details
        [Required, MaxLength(40), DisplayName("First Name")]
        public string FirstName { get; set; }

        [MaxLength(40), DisplayName("Middle Name")]
        public string MiddleName { get; set; } = string.Empty;

        [Required, MaxLength(40), DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required, MaxLength(6)]
        public string Gender { get; set; }

        public DateTime Birthdate { get; set; }


        //Contact Details (Personal)
        [Required, MaxLength(15), DisplayName("Contact No.")]
        public string PersonalContactNo { get; set; }

        [Required, MaxLength(50), DisplayName("Email Address")]
        public string PersonalEmailAddress { get; set; }


        //Contact Details (In case of emergency)
        [Required, MaxLength(120), DisplayName("Full Name")]
        public string ICOEFullName { get; set; }

        [Required, MaxLength(15), DisplayName("Contact No.")]
        public string ICOEContactNo { get; set; }

        [Required, MaxLength(100), DisplayName("Address")]
        public string ICOEAddress { get; set; }

        [Required, MaxLength(100), DisplayName("Relation")]
        public string ICOEReletion { get; set; }


        //Location Details
        [Required, MaxLength(100)]
        public string PresentAddress { get; set; }

        [Required, MaxLength(100)]
        public string PermanentAddress { get; set; }

        [MaxLength(100)]
        public string ProvincialAddress { get; set; }


        //User Details
        public Guid? User_InternalID { get; set; }
        public virtual User? User { get; set; }


        //Common Details
        public int Status { get; set; }
        public string StatusDescription { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
