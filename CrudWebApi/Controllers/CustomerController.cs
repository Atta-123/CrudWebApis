using CrudWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;

namespace CrudWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly IWebApi webApi;
		public CustomerController(IWebApi work)
		{
			this.webApi = work;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var data = await this.webApi.customerrepo.GetAllAsync();
			return Ok(data);
		}

		[HttpGet("GetByCode/{id}")]
		public async Task<IActionResult> GetByCode(int id)
		{
			var data = await this.webApi.customerrepo.GetAsync(id);
			return Ok(data);
		}

		[HttpPost("Create")]
		public async Task<IActionResult> Create(Customer cust)
		{
			var data = await this.webApi.customerrepo.AddEntity(cust);
			await this.webApi.CompleteAsync();
			return Ok(data);
		}
		[HttpPut("Update")]
		public async Task<IActionResult> Update(Customer cust)
		{
			var data = await this.webApi.customerrepo.UpdateEntity(cust);
			await this.webApi.CompleteAsync();
			return Ok(data);
		}
		[HttpDelete("Remove")]
		public async Task<IActionResult> Remove(int id)
		{
			var data = await this.webApi.customerrepo.DeleteEntity(id);
			await this.webApi.CompleteAsync();
			return Ok(data);
		}
		
	}
}
