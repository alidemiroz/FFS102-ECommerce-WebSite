using System;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class Order : BaseObject
	{
        [Required]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        public string OrderCode { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(250)]
        public string Adress { get; set; }


    }
}

