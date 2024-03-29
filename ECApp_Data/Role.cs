﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECApp_Data
{
	public class Role : BaseObject
	{
        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}

