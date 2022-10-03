using Autofac.Core;
using Buylist.CommonRepository;
using Buylist.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyList.Testes
{
    public class CompraFake : IBuyListRepository<Compra, int>
    {
        private readonly List<Compra> _compra;
        private IBuyListRepository<Item, int> _itens;

        public CompraFake()
        {
            _itens = new ItemFake();
            _compra = new List<Compra>()
            {
                new Compra(){ Id=1, Descricao= "Compra de Utensilios", Data = DateTime.Now, Finalizada = true, Itens = _itens.All().Where(p=> p.CompraId == 1).ToList(), LocalId = 1 },
                new Compra(){ Id=2, Descricao= "Compra de Mensal", Data = DateTime.Now, Finalizada = false, Itens = _itens.All().Where(p=> p.CompraId == 2).ToList(), LocalId = 2 },
                new Compra(){ Id=3, Descricao= "Compra de Semanal", Data = DateTime.Now, Finalizada = true, Itens = _itens.All().Where(p=> p.CompraId ==3).ToList(), LocalId = 3 },

            };
        }
        public List<Compra> All()
        {
            return _compra;
        }

        public Compra ByKey(int key)
        {
            return _compra.Where(a => a.Id == key)
                .FirstOrDefault();
        }

        public void Delete(Compra entity)
        {
            _compra.Remove(entity);
        }

        public void DeleteByKey(int key)
        {
            var item = this.ByKey(key);
            _compra.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Insert(Compra entity)
        {
            entity.Id = GeraId();
            _compra.Add(entity);
        }

        public void Update(Compra entity)
        {
            int index = _compra.FindIndex(a => a.Id == entity.Id);
            _compra[index] = entity;

        }

        private int GeraId()
        {
            return _compra.OrderByDescending(a => a.Id).FirstOrDefault().Id;
        }
    }
}
