using CrudWebApi.Models;

namespace CrudWebApi.Interface
{
	public interface IGenericRepository<T> where T : class
	{
		Task<List<T>> GetAllAsync();
		//List<Customer> GetAll();
		Task<T> GetAsync(int id);
		Task<bool> AddEntity(T entity);

		Task<bool> UpdateEntity(T entity);
		Task<bool> DeleteEntity(int id);

	}
}
