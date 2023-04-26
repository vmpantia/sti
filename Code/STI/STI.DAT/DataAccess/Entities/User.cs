﻿using System.ComponentModel.DataAnnotations;

namespace STI.DAT.DataAccess.Entities
{
    public class User
    {
        //User Details
        [Key]
        public Guid InternalID { get; set; }

        [Required, MaxLength(15)]
        public string Username { get; set; }

        [Required, MaxLength(255)]
        public string Password { get; set; }

        //Role Details
        public Guid Role_InternalID { get; set; }

        //Common Details
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Role Role { get; set; }

    }
}