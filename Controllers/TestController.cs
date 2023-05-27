using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;
using WebApplication11.Repositories;

namespace WebApplication11.Controllers
{
	[Route("api/[controller]")]
	public class TestController : Controller
	{
		private readonly ITestRepository _testRepository;
		public TestController(ITestRepository test)
		{
			_testRepository = test;
		}

		[HttpGet]
		[Route("file/{name}")]
		public async Task<IActionResult> GetByNameAsync(string name)
		{
			if (_testRepository.IsEmpty())
				return NotFound();

			var model = await _testRepository.GetByNameAsync(name);

			if (model == null)
				return NotFound();

			return new OkObjectResult(model);
			
		}

		[HttpPost]
		[Route("addfile")]
		public async Task<IActionResult> AddAsync([FromBody]TestModel model)
		{
			await _testRepository.AddAsync(model);
			return StatusCode(201);
		}
	}
}
