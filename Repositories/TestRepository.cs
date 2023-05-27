using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Context;
using WebApplication11.Models;

namespace WebApplication11.Repositories
{
	public class TestRepository : ITestRepository
	{
		private readonly TestContext _context;
		public TestRepository(TestContext context)
		{
			_context = context;
		}

		public async Task<bool> AddAsync(TestModel model)
		{
			await _context.Tests.AddAsync(model);
			await _context.SaveChangesAsync();
			return await Task.FromResult(true);
		}

		public async Task<TestModel?> GetByNameAsync(string name)
		{
			return await _context.Tests.FirstOrDefaultAsync(i => i.Name == name);
		}

		public bool IsEmpty()
		{
			return _context.Tests.Count() == 0;
		}

		
	}
}
