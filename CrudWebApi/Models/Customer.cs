﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWebApi.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }
		public string City { get; set; } 
		public string State { get; set; }
		public string Zip { get; set; }
		public DateTime LastDate { get; set; }

		public int CustomerTypeId { get; set; }
		public CustomerType? CustomerType { get; set; }
	}
}
