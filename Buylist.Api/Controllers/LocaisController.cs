using Buylist.CommonRepository;
using Buylist.DataAccess.Context;
using Buylist.Domain;
using Buylist.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Buylist.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocaisController : ControllerBase 
    { 
        private IBuyListRepository<Local, int> _repository = new LocalRepository(new BuylistContext());

        [HttpGet]
        public IEnumerable<Local> Get()
        {
            return _repository.All();
        }

        [HttpGet("{id}")]
        public Local Get(int id)
        {
            return _repository.ByKey(id);
        }

        [HttpPost]
        public void Post([FromBody] Local value)
        {
            _repository.Insert(value);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Local value)
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