using Microsoft.AspNetCore.Mvc;
using MyApplicationName.Api.Interfaces;
using MyApplicationName.Models;

namespace MyApplicationName.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientController : ControllerBase
	{
		private IClientService _clientService;

		public ClientController(IClientService clientService) 
		{
			_clientService = clientService;
		}
		// GET: api/<ClientController>
		[HttpGet]
		public async Task<List<Client>> GetClients()
		{
			return await _clientService.GetClients();
		}

		// GET api/<ClientController>/5
		[HttpGet("{id}")]
		public async Task<Client> GetClient(int id)
		{
			return await _clientService.GetClient(id);
		}

		// POST api/<ClientController>
		[HttpPost]
		public async Task Post([FromBody] Client client)
		{
			await _clientService.CreateClient(client);
		}

		// PUT api/<ClientController>/5
		[HttpPut("{id}")]
		public async Task Put(int id, [FromBody] Client value)
		{
			await _clientService.UpdateClient(id, value);
		}

		// DELETE api/<ClientController>/5
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			await _clientService.DeleteClient(id);
		}
	}
}
