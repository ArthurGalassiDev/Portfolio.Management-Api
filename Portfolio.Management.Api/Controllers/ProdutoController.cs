using Microsoft.AspNetCore.Mvc;
using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController(IEntityService<ProdutoFinanceiro> produtoService) : ControllerBase
    {
        private readonly IEntityService<ProdutoFinanceiro> _produtoService = produtoService;

        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {
            var produtos = await _produtoService.GetAllAsync();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduto([FromBody] ProdutoFinanceiro produto)
        {
            await _produtoService.CreateAsync(produto);
            return CreatedAtAction(nameof(GetProdutoById), new { id = produto.Id }, produto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdutoById(int id)
        {
            var produto = await _produtoService.GetByIdAsync(id);
            if (produto == null)
                return NotFound();
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduto(int id, [FromBody] ProdutoFinanceiro produto)
        {
            if (id != produto.Id)
                return BadRequest();

            await _produtoService.UpdateAsync(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }
    }
}