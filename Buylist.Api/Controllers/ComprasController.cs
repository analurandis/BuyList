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

        private IBuyListRepository<Compra, int> _repository;//= new CompraRepository(new BuylistContext());

        [HttpGet]
        public IEnumerable<Compra> Get()
        {
            return _repository.All();
        }

        [HttpGet("{id}")]
        public Compra Get(int id)
        {
            return _repository.ByKey(id);
        }

        [HttpPost]
        public void Post([FromBody] Compra value)
        {
            _repository.Insert(value);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Compra value)
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