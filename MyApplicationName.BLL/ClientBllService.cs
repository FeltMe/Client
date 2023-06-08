using Microsoft.EntityFrameworkCore;
using MyApplicationName.Models;

namespace MyApplicationName.BLL
{
	public class ClientBllService
	{
		public async Task CreateClient(Client client)
		{
			using MyDbContext myDbContext = new MyDbContext();
			await myDbContext.Clients.AddAsync(client);
		}

		public async Task DeleteClient(int client_id)
		{
			using MyDbContext myDbContext = new MyDbContext();
			var client = await myDbContext.Clients.FirstOrDefaultAsync(x => x.client_id == client_id);
			myDbContext.Clients.Remove(client);
		}

		public async Task<Client> GetClient(int client_id)
		{
			using MyDbContext myDbContext = new MyDbContext();
			return await myDbContext.Clients.FirstOrDefaultAsync(x=> x.client_id == client_id);
		}

		public async Task<List<Client>> GetClients()
		{
			using MyDbContext myDbContext = new MyDbContext();
			return await myDbContext.Clients.ToListAsync();
		}

		public async Task UpdateClient(int client_id, Client client)
		{
			using MyDbContext myDbContext = new MyDbContext();
			myDbContext.Clients.Update(client);
		}
	}
}