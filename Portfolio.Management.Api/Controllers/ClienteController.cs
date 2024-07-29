using Microsoft.AspNetCore.Mvc;
using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController(IEntityService<Cliente> clienteService) : ControllerBase
    {
        private readonly IEntityService<Cliente> _clienteService = clienteService;

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var clientes = _clienteService.GetAllAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _clienteService.GetByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _clienteService.CreateAsync(cliente);
            return CreatedAtAction(nameof(Get), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cliente cliente)
        {
            var clienteExistente = _clienteService.GetByIdAsync(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            _clienteService.UpdateAsync(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cliente = _clienteService.GetByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _clienteService.DeleteAsync(id);
            return NoContent();
        }
    }
}