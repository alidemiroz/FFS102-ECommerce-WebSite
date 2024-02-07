using System;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class ProductImage : BaseObject
	{
		[Required]
		public int ProductId { get; set; }

		[Required]
		[DataType(DataType.Url)]
		[MinLength(50)]
		[MaxLength(250)]
		public string Url { get; set; }
	}
}

