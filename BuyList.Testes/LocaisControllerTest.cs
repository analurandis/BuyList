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
    public class LocaisControllerTest
    {
        LocaisController _controller;
        IBuyListRepository<Local, int> _servico;

        public LocaisControllerTest()
        {
            _servico = new LocalFake();
            _controller = new LocaisController(_servico);
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
            var items = Assert.IsType<List<Local>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }
    }
}