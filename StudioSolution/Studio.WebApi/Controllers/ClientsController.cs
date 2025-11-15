using Studio.Domain.Interfaces;
using Studio.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Studio.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _repo;

        public ClientsController(IClientRepository repo) => _repo = repo;

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) =>
            (await _repo.GetByIdAsync(id)) is Client c ? Ok(c) : NotFound();

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Client client)
        {
            await _repo.AddAsync(client);
            return Ok("Cliente creado exitosamente.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Client client)
        {
            if (id != client.Id) return BadRequest();
            await _repo.UpdateAsync(client);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}