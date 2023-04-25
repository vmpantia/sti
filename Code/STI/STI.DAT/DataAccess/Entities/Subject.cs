using System.ComponentModel.DataAnnotations;

namespace STI.DAT.DataAccess.Entities
{
    public class Subject
    {
        //Subject Details
        public Guid InternalID { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        public int Unit { get; set; }

        public int Type { get; set; }

        //Category Details
        public Guid Category_InternalID { get; set; }

        //Common Details
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
