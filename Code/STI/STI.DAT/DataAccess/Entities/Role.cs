using System.ComponentModel.DataAnnotations;

namespace STI.DAT.DataAccess.Entities
{
    public class Role
    {
        //Role Details
        [Key]
        public Guid InternalID { get; set; }

        [Required, MaxLength(15)]
        public string Name { get; set; }

        public int Permissions { get; set; }

        //Common Details
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
