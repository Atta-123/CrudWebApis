using CrudWebApi.Data;
using CrudWebApi.Interface;
using CrudWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApi.Repos
{
	public class CustomerTypeRepo : GenericRepository<CustomerType>, ICustomerTypeRepo
	{
		public CustomerTypeRepo(AppDbContext dbcontext) : base(dbcontext)
		{
		}
		public override Task<List<CustomerType>> GetAllAsync()
		{
			return base.GetAllAsync();
		}
		public override async Task<CustomerType> GetAsync(int id)
		{
			return await dbSet.FirstOrDefaultAsync(item => item.CustomerTypeId == id);
		}

		public override async Task<bool> AddEntity(CustomerType entity)
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
		public override async Task<bool> UpdateEntity(CustomerType entity)
		{
			try
			{
				var data = await dbSet.FirstOrDefaultAsync(item => item.CustomerTypeId == entity.CustomerTypeId);
				if (data != null)
				{
					data.Name = entity.Name;
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
		public override Task<bool> DeleteEntity(int id)
		{
			return base.DeleteEntity(id);
		}


	}
	}

