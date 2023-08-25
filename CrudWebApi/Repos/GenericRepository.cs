using CrudWebApi.Data;
using CrudWebApi.Interface;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApi.Repos
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected AppDbContext dbcontext;
		internal DbSet<T> dbSet { get; set; }
		public GenericRepository(AppDbContext dbcontext)
		{
			this.dbcontext = dbcontext;
			this.dbSet = dbcontext.Set<T>();
		}

		public virtual Task<bool> AddEntity(T entity)
		{
			throw new NotImplementedException();
		}

		public virtual Task<bool> DeleteEntity(int id)
		{
			throw new NotImplementedException();
		}

		public virtual Task<List<T>> GetAllAsync()
		{
			return this.dbSet.ToListAsync();
		}

		//public virtual Task<T> GetAsync(int id)
		//{
		//	throw new NotImplementedException();
		//}

		public virtual Task<bool> UpdateEntity(T entity)
		{
			throw new NotImplementedException();
		}

		public virtual Task<T> GetAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
