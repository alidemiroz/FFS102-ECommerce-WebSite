using System;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class Product : BaseObject
	{
        [Required]
        public int SellerId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [MaxLength(1000)]
        public string Details { get; set; }

        [Required]
        public byte StockAmount { get; set; }

        [Required]
        public bool Enabled { get; set; } = true;

    }
}

