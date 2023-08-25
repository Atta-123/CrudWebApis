using CrudWebApi.Controllers;
using CrudWebApi.Data;
using CrudWebApi.Interface;

namespace CrudWebApi.Repos
{
	public class WebApi : IWebApi
	{
		//public ICustomerRepo customerRepo { get; private set; }

		public ICustomerRepo customerrepo { get; set; }


		private readonly AppDbContext appDbContext;
		public WebApi(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			customerrepo = new CustomerRepo(appDbContext);
		}

		public async Task CompleteAsync()
		{
			await this.appDbContext.SaveChangesAsync();
		}
	}
}
