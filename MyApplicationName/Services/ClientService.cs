using MyApplicationName.Api.Interfaces;
using MyApplicationName.BLL;
using MyApplicationName.Models;

namespace MyApplicationName.Api.Services
{
	public class ClientService : IClientService
	{
		private ClientBllService ClientBllService { get; set; }

		public ClientService()
		{
			ClientBllService = new ClientBllService();
		}

		public async Task CreateClient(Client client)
		{
			await ClientBllService.CreateClient(client);
		}

		public async Task DeleteClient(int client_id)
		{
			await ClientBllService.DeleteClient(client_id);
		}

		public async Task<Client> GetClient(int client_id)
		{
			return await ClientBllService.GetClient(client_id);
		}

		public async Task<List<Client>> GetClients()
		{
			return await ClientBllService.GetClients();
		}

		public async Task UpdateClient(int client_id, Client client)
		{
			await UpdateClient(client_id, client);
		}
	}
}
