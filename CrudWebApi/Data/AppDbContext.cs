using CrudWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApi.Data
{
	public class AppDbContext :DbContext
	{
		
		public AppDbContext(DbContextOptions<AppDbContext> options)
			:base(options)
		{

		}
		public DbSet<CustomerType> customerTypes { get; set; }
		public DbSet<Customer> customers { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CustomerType>().HasData(
				new CustomerType { CustomerTypeId = 1, Name = "SalaMan" },
				new CustomerType { CustomerTypeId = 2, Name = "Driver" }

				);
			modelBuilder.Entity<Customer>().HasData(
				new Customer
				{
					Id = 1,
					Name = "Atta",
					Description = "Test",
					Address = "Pesh",
					State = "Pak",
					City = "Pesh",
					Zip = "100",
					LastDate = DateTime.Now,
					CustomerTypeId = 1
				},
				new Customer
				{
					Id = 2,
					Name = "Afridi",
					Description = "Test",
					Address = "Pesh",
					State = "Pak",
					City = "Pesh",
					Zip = "100",
					LastDate = DateTime.Now,
					CustomerTypeId = 2
				}


				);
		}
	}
}
