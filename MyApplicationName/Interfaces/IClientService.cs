using MyApplicationName.Models;

namespace MyApplicationName.Api.Interfaces
{
	public interface IClientService
	{
		public Task CreateClient(Client client);
		public Task DeleteClient(int client_id);
		public Task<List<Client>> GetClients();
		public Task<Client> GetClient(int client_id);
		public Task UpdateClient(int client_id, Client client);
	}
}
