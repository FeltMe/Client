using Microsoft.EntityFrameworkCore;
using MyApplicationName.Models;

namespace MyApplicationName.BLL
{
	internal class MyDbContext : DbContext
	{
		public MyDbContext()
		{
		}

		public DbSet<Client> Clients { get; set; }
	}
}
