using System;
using System.ComponentModel.DataAnnotations;

namespace App_Data
{
	public class CartItem : BaseObject
	{
		[Required]
		public int UserId { get; set; }

		[Required]
		public int ProductId { get; set; }

		[Required]
		[MinLength(1)]
		public byte Quantity { get; set; }

	}
}

