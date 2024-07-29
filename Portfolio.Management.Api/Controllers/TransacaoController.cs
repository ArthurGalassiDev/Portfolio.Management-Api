using Microsoft.AspNetCore.Mvc;
using Portfolio.Management.Domain.Entities;
using Portfolio.Management.Domain.Services.Abstractions;

namespace Portfolio.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController(IEntityService<Transacao> transacaoService, 
                                     IEntityService<ProdutoFinanceiro> produtoService, 
                                     IEntityService<Cliente> clienteService) : ControllerBase
    {
        private readonly IEntityService<Transacao> _transacaoService = transacaoService;
        private readonly IEntityService<ProdutoFinanceiro> _produtoService = produtoService;
        private readonly IEntityService<Cliente> _clienteService = clienteService;

        [HttpGet]
        public ActionResult<IEnumerable<Transacao>> Get()
        {
            var transacoes = _transacaoService.GetAllAsync();
            return Ok(transacoes);
        }

        [HttpGet("{id}")]
        public ActionResult<Transacao> Get(int id)
        {
            var transacao = _transacaoService.GetByIdAsync(id);
            if (transacao == null)
            {
                return NotFound();
            }
            return Ok(transacao);
        }

        [HttpPost("comprar")]
        public ActionResult Comprar([FromBody] Transacao transacao)
        {
            var produto = _produtoService.GetByIdAsync(transacao.ProdutoFinanceiroId);
            var cliente = _clienteService.GetByIdAsync(transacao.ClienteId);

            if (produto == null || cliente == null)
            {
                return BadRequest("Produto ou cliente inválido");
            }

            transacao.Compra = true;
            transacao.DataTransacao = DateTime.UtcNow;

            _transacaoService.CreateAsync(transacao);
            return CreatedAtAction(nameof(Get), new { id = transacao.Id }, transacao);
        }

        [HttpPost("vender")]
        public ActionResult Vender([FromBody] Transacao transacao)
        {
            var produto = _produtoService.GetByIdAsync(transacao.ProdutoFinanceiroId);
            var cliente = _clienteService.GetByIdAsync(transacao.ClienteId);

            if (produto == null || cliente == null)
            {
                return BadRequest("Produto ou cliente inválido");
            }

            transacao.Compra = false;
            transacao.DataTransacao = DateTime.UtcNow;

            _transacaoService.CreateAsync(transacao);
            return CreatedAtAction(nameof(Get), new { id = transacao.Id }, transacao);
        }

        [HttpGet("extrato/{clienteId}")]
        public ActionResult<IEnumerable<Transacao>> Extrato(int clienteId)
        {
            var cliente = _clienteService.GetByIdAsync(clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            var transacoes = _transacaoService.GetAllAsync().Result.Select(x => x.ClienteId == clienteId);

            return Ok(transacoes);
        }
    }
}