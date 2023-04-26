using STI.DAT.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace STI.BAL.Models.DTOs
{
    public class UserDTO
    {
        //User Details
        public Guid InternalID { get; set; }

        [Required, MaxLength(15)]
        public string Username { get; set; }

        [Required, MaxLength(255)]
        public string Password { get; set; }

        public int Type { get; set; }
        public string TypeDescription { get; set; } = string.Empty;


        //Role Details
        public Guid Role_InternalID { get; set; }
        public virtual Role Role { get; set; }


        //Common Details
        public int Status { get; set; }
        public string StatusDescription { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
