using Buylist.CommonRepository;
using Buylist.DataAccess.Context;
using Buylist.Domain;
using Buylist.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Buylist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IBuyListRepository <Produto, int> _repository = new ProdutoRepository(new BuylistContext());

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _repository.All();
        }

        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _repository.ByKey(id);
        }

        [HttpPost]
        public void Post([FromBody] Produto value)
        {
            _repository.Insert(value);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produto value)
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
