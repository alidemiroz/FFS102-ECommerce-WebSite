using System;
using System.ComponentModel.DataAnnotations;

namespace App_Data
{
	public class Category : BaseObject
	{
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(6)]
        public string Color { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string IconCssClass { get; set; }
	}
}

