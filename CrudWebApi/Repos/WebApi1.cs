using CrudWebApi.Controllers;
using CrudWebApi.Data;
using CrudWebApi.Interface;

namespace CrudWebApi.Repos
{
	public class WebApi1 : IWebApi1
	{
		public ICustomerTypeRepo Customertyperepo { get; set; }
		private readonly AppDbContext appDbContext;
		public WebApi1(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			Customertyperepo = new CustomerTypeRepo(appDbContext);

		}

		public async Task CompleteAsync()
		{
			await this.appDbContext.SaveChangesAsync();
		}
	}
}
