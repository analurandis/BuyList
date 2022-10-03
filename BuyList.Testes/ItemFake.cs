using Buylist.CommonRepository;
using Buylist.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyList.Testes
{
    public class ItemFake : IBuyListRepository<Item, int>
    {
        private readonly List<Item> _item;
        public ItemFake()
        {
            _item = new List<Item>()
            {
                new Item(){ Id=1, CompraId=1, ProdutoId=1, Total=10, Quantidade=1, Valor= 10},
                new Item(){ Id=2, CompraId=1, ProdutoId=2, Total=20, Quantidade=2, Valor= 10},
                new Item(){ Id=3, CompraId=2, ProdutoId=2, Total=40, Quantidade=4, Valor= 10},
                new Item(){ Id=4, CompraId=3, ProdutoId=3, Total=15, Quantidade=1, Valor= 15},
            };
        }
        public List<Item> All()
        {
            return _item;
        }

        public Item ByKey(int key)
        {
            return _item.Where(a => a.Id == key)
                .FirstOrDefault();
        }

        public void Delete(Item entity)
        {
            _item.Remove(entity);
        }

        public void DeleteByKey(int key)
        {
            var item = this.ByKey(key);
            _item.Remove(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Insert(Item entity)
        {
            entity.Id = GeraId();
            _item.Add(entity);
        }

        public void Update(Item entity)
        {
            int index = _item.FindIndex(a => a.Id == entity.Id);
            _item[index] = entity;

        }

        private int GeraId()
        {
            return _item.OrderByDescending(a => a.Id).FirstOrDefault().Id;
        }
    }
}
