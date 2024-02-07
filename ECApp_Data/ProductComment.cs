using System;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class ProductComment : BaseObject
	{
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public byte StarCount { get; set; }

        [Required]
        public bool IsConfirmed { get; set; } = false;
    }
}

