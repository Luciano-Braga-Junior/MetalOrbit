using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _ProdutoRepository;
        //private readonly IProdutoService _ProdutoService;
        
        public ProdutoController(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
            //_ProdutoService = ProdutoService;
        }

        [HttpGet]
        [Route("produto/todos")]
        public async Task<ActionResult> ObterTodasProdutos()
        {
            var listaProdutos = await _ProdutoRepository.ObterTodos();

            if(listaProdutos.Count == 0) return NoContent();

            return Ok(listaProdutos);
        }


        [HttpGet]
        [Route("id")]
        public async Task<ActionResult> ObterUmaProduto(Guid id)
        {
            var Produto = await _ProdutoRepository.ObterPorId(id);
            if (Produto == null) return BadRequest("Produto não encontrada");
            return Ok(Produto);
        }
    }
}
