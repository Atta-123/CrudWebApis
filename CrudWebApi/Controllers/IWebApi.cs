using CrudWebApi.Interface;

namespace CrudWebApi.Controllers
{
	public interface IWebApi
	{
		ICustomerRepo customerrepo { get;  }
		Task CompleteAsync();
	}
}
