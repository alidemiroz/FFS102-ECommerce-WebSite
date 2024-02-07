using System;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class Category : BaseObject
	{
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(3)]
        [MaxLength(6)]
        public string Color { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string IconCssClass { get; set; }
    }
}

