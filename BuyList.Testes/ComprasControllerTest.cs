using Buylist.Api.Controllers;
using Buylist.CommonRepository;
using Buylist.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyList.Testes
{
    public class ComprasControllerTest
    {
        ComprasController _controller;
        IBuyListRepository<Compra, int> _servico;

        public ComprasControllerTest()
        {
            _servico = new CompraFake();
            _controller = new ComprasController(_servico);
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
            var items = Assert.IsType<List<Compra>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}