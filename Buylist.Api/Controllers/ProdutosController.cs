using Buylist.CommonRepository;
using Buylist.DataAccess.Context;
using Buylist.Domain;
using Buylist.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Buylist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IBuyListRepository<Produto, int> _repository;

        public ProdutosController(IBuyListRepository<Produto, int> repository)
        {
            this._repository = repository;

        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(_repository.All());
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            return Ok(_repository.ByKey(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Produto value)
        {
            _repository.Insert(value);
            return Ok();
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Produto value)
        {
            _repository.Update(value);
            return Ok();
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.DeleteByKey(id);
            return Ok();
        }
    }
}
