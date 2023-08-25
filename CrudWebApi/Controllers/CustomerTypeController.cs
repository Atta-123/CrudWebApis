using CrudWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerTypeController : ControllerBase
	{
		private readonly IWebApi1 webApi1;
		public CustomerTypeController(IWebApi1 work)
		{
			this.webApi1 = work;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var data = await this.webApi1.Customertyperepo.GetAllAsync();
			return Ok(data);
		}

		[HttpGet("GetByCode/{id}")]
		public async Task<IActionResult> GetByCode(int id)
		{
			var data = await this.webApi1.Customertyperepo.GetAsync(id);
			return Ok(data);
		}

		[HttpPost("Create")]
		public async Task<IActionResult> Create(CustomerType customerType)
		{
			var data =  this.webApi1.Customertyperepo.AddEntity(customerType);
			this.webApi1.CompleteAsync();
			return Ok(data);
		}
		[HttpPost("Update")]
		public async Task<IActionResult> Update(CustomerType cust)
		{
			var data = await this.webApi1.Customertyperepo.UpdateEntity(cust);
			await this.webApi1.CompleteAsync();
			return Ok(data);
		}
		[HttpPost("Remove")]
		public async Task<IActionResult> Remove(int id)
		{
			var data = await this.webApi1.Customertyperepo.DeleteEntity(id);
			await this.webApi1.CompleteAsync();
			return Ok(data);
		}
	}
}
