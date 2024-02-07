using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class User : BaseObject
	{
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public bool Enabled { get; set; } = true;
    }
}

