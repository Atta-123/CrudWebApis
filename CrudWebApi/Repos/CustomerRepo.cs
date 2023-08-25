using CrudWebApi.Data;
using CrudWebApi.Interface;
using CrudWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApi.Repos
{
	public class CustomerRepo : GenericRepository<Customer>, ICustomerRepo
	{
		public CustomerRepo(AppDbContext dbcontext) : base(dbcontext)
		{

		}

		public override Task<List<Customer>> GetAllAsync()
		{
			return base.GetAllAsync();
		}
		public override async Task<Customer> GetAsync(int id)
		{
			return await dbSet.FirstOrDefaultAsync(item => item.Id == id);
		}
		public override async Task<bool> AddEntity(Customer entity)
		{
			try
			{
				await dbSet.AddAsync(entity);
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
		public override async Task<bool> UpdateEntity(Customer entity)
		{
			try
			{
				var data = await dbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
				if (data != null)
				{
					data.Name = entity.Name;
					data.Description = entity.Description;
					data.Address = entity.Address;
					data.City = entity.City;
					data.State = entity.State;
					data.Zip = entity.Zip;
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//public override async Task<bool> DeleteEntity(int id)
		//{
		//	var data = await dbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
		//	if (data != null)
		//	{
		//		await dbSet.Remove(data);
		//		return true;
		//	}
		//	else
		//	{
		//		return false;
		//	}
		//}
	}
		
}
