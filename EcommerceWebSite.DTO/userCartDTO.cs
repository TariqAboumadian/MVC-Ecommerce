﻿using EcommerceWebSite.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebSite.DTO
{
	public class userCartDTO
	{
		public int Id { get; set; }

		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name Length Must Be Between 3 to 50 char")]
		public String Name { get; set; }
		public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set;}
	}
}
