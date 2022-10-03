using Buylist.CommonRepository;
using Buylist.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyList.Testes
{
    public class LocalFake : IBuyListRepository<Local, int>
    {
        private readonly List<Local> _local;
        public LocalFake()
        {  
            _local = new List<Local>()
            {
                new Local(){ Id=1,  Nome="Supermercado Semar", Localizacao="Auto Cardoso"},
                new Local(){ Id=2,  Nome="Spani Atacadista", Localizacao="Av.Nossa Senhora do Bom Sucesso"  },
                new Local(){ Id=3,  Nome="Tenda Atacado", Localizacao="Av. José Henrique" },
                new Local(){ Id=4,  Nome="Supermercado Shibata", Localizacao="Av. Monteiro Lobato" },
            };
        }
        public List<Local> All()
        {
            return _local;
        }

        public Local ByKey(int key)
        {
            return _local.Where(a => a.Id == key)
                .FirstOrDefault();
        }

        public void Delete(Local entity)
        {
            _local.Remove(entity);
        }

        public void DeleteByKey(int key)
        {
            var item = this.ByKey(key);
            _local.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Insert(Local entity)
        {
            entity.Id = GeraId();
            _local.Add(entity);
        }

        public void Update(Local entity)
        {
            int index = _local.FindIndex(a => a.Id == entity.Id);
            _local[index] = entity;

        }

        private int GeraId()
        {
            return _local.OrderByDescending(a => a.Id).FirstOrDefault().Id;
        }
    }
}
