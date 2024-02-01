using System;
using System.ComponentModel.DataAnnotations;

namespace App_Data
{
	public class OrderItem : BaseObject
	{
        [Required]
        public int OrderId { get; set; }

        [Required]
		public int ProductId { get; set; }

        [Required]
        [MinLength(1)]
        public byte Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }


    }
}

