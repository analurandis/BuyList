using Buylist.Api.Controllers;
using Buylist.Common.Repository.Entity;
using Buylist.CommonRepository;
using Buylist.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BuyList.Testes
{
    public class ProdutosControllerTest
    {
        ProdutoController _controller;
        IBuyListRepository<Produto, int> _servico;

        public  ProdutosControllerTest()
        {
            _servico = new ProdutoFake();
            _controller = new ProdutoController(_servico);
        }


        [Fact]
        public void Get_Called_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}