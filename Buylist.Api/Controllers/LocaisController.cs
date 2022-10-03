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
        private IBuyListRepository<Local, int> _repository;

        public LocaisController(IBuyListRepository<Local, int> repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Local>> Get()
        {
            return Ok(_repository.All());
        }

        [HttpGet("{id}")]
        public ActionResult<Local> Get(int id)
        {
            return Ok(_repository.ByKey(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Local value)
        {
            _repository.Insert(value);
            return Ok();
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Local value)
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