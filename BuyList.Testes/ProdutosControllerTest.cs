using Buylist.Api.Controllers;
using Buylist.Common.Repository.Entity;
using Buylist.CommonRepository;
using Buylist.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BuyList.Testes
{
    public class ProdutosControllerTest
    {
        ProdutosController _controller;
        IBuyListRepository<Produto, int> _servico;

        public  ProdutosControllerTest()
        {
            _servico = new ProdutoFake();
            _controller = new ProdutosController(_servico);
        }


        [Fact]
        public void Get_Called_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_Called_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Produto>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }
    }
}