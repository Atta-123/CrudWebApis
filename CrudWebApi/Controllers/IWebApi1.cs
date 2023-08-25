using CrudWebApi.Interface;

namespace CrudWebApi.Controllers
{
	public interface IWebApi1
	{
		ICustomerTypeRepo Customertyperepo { get; }
		Task CompleteAsync();
	}
}
