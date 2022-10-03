using Buylist.Common.Repository.Entity;
using Buylist.CommonRepository;
using Buylist.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyList.Testes
{
    public class ProdutoFake : IBuyListRepository<Produto, int>
    {
        private readonly List<Produto> _produtos;
        public ProdutoFake()
        {
            _produtos = new List<Produto>()
            {
                new Produto(){ Id=1,  Nome="Feijão Carioca Camil", CodigoBarras="7896006744115",Descricao="Feijão tipo Carioca" },
                new Produto(){ Id=2,  Nome="Arroz Tio João", CodigoBarras="7893500036029",Descricao="Arroz padrão 1" },
                new Produto(){ Id=3,  Nome="Macarrão Dona Benta", CodigoBarras="7896005286524",Descricao="Macarrão espaguete " },
                new Produto(){ Id=4,  Nome="Pó de café Pindense", CodigoBarras="7897044600067",Descricao="Pó de café torrado e moido" },
            };
        }
        public List<Produto> All()
        {
            return _produtos;
        }

        public Produto ByKey(int key)
        {
            return _produtos.Where(a => a.Id == key)
                .FirstOrDefault();
        }

        public void Delete(Produto entity)
        {
            _produtos.Remove(entity);
        }

        public void DeleteByKey(int key)
        {
            var item = this.ByKey(key);
            _produtos.Remove(item);
        }

        public void Insert(Produto entity)
        {
            entity.Id = GeraId();
            _produtos.Add(entity);
        }

        public void Update(Produto entity)
        {
            int index = _produtos.FindIndex(a => a.Id == entity.Id);
            _produtos[index] = entity;

        }

        private int GeraId()
        {
            return _produtos.OrderByDescending(a => a.Id).FirstOrDefault().Id ;
        }
    }
}
