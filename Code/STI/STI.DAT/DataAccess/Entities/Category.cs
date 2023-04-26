using System.ComponentModel.DataAnnotations;

namespace STI.DAT.DataAccess.Entities
{
    public class Category
    {
        //Category Details
        [Key]
        public Guid InternalID { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        public int Type { get; set; }


        //Common Details
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
