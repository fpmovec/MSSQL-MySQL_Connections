using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using WebApplication11.Models;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebApplication11.Context
{
	public class TestContext : DbContext
	{
		public TestContext(DbContextOptions<TestContext> opt) : base(opt)
		{ }

		public DbSet<TestModel> Tests { get; set; }
	}
}
