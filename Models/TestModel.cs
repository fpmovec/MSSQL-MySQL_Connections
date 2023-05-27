using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
	public class TestModel
	{
		public int Id { get; set; }

		[Column(TypeName = "varchar(30)")]
		public string? Name { get; set; }
		[Column(TypeName = "varchar(100)")]
		public string? Description { get; set; }
	}
}
