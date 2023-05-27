using WebApplication11.Models;

namespace WebApplication11.Repositories
{
	public interface ITestRepository
	{
		Task<bool> AddAsync(TestModel model);
		Task<TestModel> GetByNameAsync(string name);
		bool IsEmpty();
	}
}
