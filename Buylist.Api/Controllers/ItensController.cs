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
    public class ItensController : ControllerBase
    {

        private IBuyListRepository<Item, int> _repository;

        public ItensController(IBuyListRepository<Item, int> repository)
        {
            this._repository = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            return Ok( _repository.All());
        }

        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            return Ok( _repository.ByKey(id));

        }

        [HttpPost]
        public ActionResult Post([FromBody] Item value)
        {
            _repository.Insert(value);
            return Ok();
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Item value)
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