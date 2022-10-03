using Buylist.CommonRepository;
using Buylist.DataAccess.Context;
using Buylist.Domain;
using Buylist.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buylist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {

        private IBuyListRepository<Compra, int> _repository;

        public  ComprasController(IBuyListRepository<Compra, int> repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Compra>> Get()
        {
            return Ok(_repository.All());
        }

        [HttpGet("{id}")]
        public ActionResult<Compra> Get(int id)
        {
            return Ok(_repository.ByKey(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Compra value)
        {
            _repository.Insert(value);
            return Ok();
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Compra value)
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