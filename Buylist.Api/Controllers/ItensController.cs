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

        private IBuyListRepository<Item, int> _repository;//= new ItemRepository(new BuylistContext());

        public ItensController(IBuyListRepository<Item, int> repository)
        {
            this._repository = repository;
        }


        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _repository.All();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _repository.ByKey(id);
        }

        [HttpPost]
        public void Post([FromBody] Item value)
        {
            _repository.Insert(value);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            _repository.Update(value);
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.DeleteByKey(id);
        }
    }
}