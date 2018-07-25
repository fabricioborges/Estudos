using FluentAssertions;
using Moq;
using Prova1.API.Controllers.Orders;
using NUnit.Framework;
using Prova1.Application.Features.Orders;
using Prova1.Domain.Orders;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Prova1.Domain.Exceptions;
using Prova1.Controller.Tests.Initializer;
using Prova1.Common.Tests.Features.ObjectMothers;
using Prova1.API.Exceptions;

namespace Prova1.Controller.Tests.Features.Orders
{
    [TestFixture]
    public class OrdersControllerTests : TestControllerBase
    {
        private OrdersController _ordersController;
        private Mock<IOrderService> _orderServiceMock;
        private Mock<Order> _order;

        [SetUp]
        public void Initialize()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            _orderServiceMock = new Mock<IOrderService>();
            _ordersController = new OrdersController()
            {
                Request = request,
                _ordersService = _orderServiceMock.Object,
            };
            _order = new Mock<Order>();
        }

        #region GET

        [Test]
        public void Orders_Controller_Get_ShouldOk()
        {
            // Arrange
            var order = ObjectMother.GetOrderValid();
            var response = new List<Order>() { order }.AsQueryable();
            _orderServiceMock.Setup(s => s.GetAll()).Returns(response);
            // Action
            var callback = _ordersController.Get();
            //Assert
            _orderServiceMock.Verify(s => s.GetAll(), Times.Once);
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<List<Order>>>().Subject;
            httpResponse.Content.Should().NotBeNullOrEmpty();
            httpResponse.Content.First().Id.Should().Be(order.Id);
        }

        [Test]
        public void Orders_Controller_GetById_ShouldBeOk()
        {
            // Arrange
            var id = 1;
            _order.Setup(p => p.Id).Returns(id);
            _orderServiceMock.Setup(c => c.GetById(id)).Returns(_order.Object);
            // Action
            IHttpActionResult callback = _ordersController.GetById(id);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<Order>>().Subject;
            httpResponse.Content.Should().NotBeNull();
            httpResponse.Content.Id.Should().Be(id);
            _orderServiceMock.Verify(s => s.GetById(id), Times.Once);
            _order.Verify(p => p.Id, Times.Once);
        }

        #endregion

        #region POST

        [Test]
        public void Orders_Controller_Post_ShouldBeOk()
        {
            // Arrange
            var id = 1;
            _orderServiceMock.Setup(c => c.Add(_order.Object)).Returns(id);
            // Action
            IHttpActionResult callback = _ordersController.Post(_order.Object);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<int>>().Subject;
            httpResponse.Content.Should().Be(id);
            _orderServiceMock.Verify(s => s.Add(_order.Object), Times.Once);
        }

        #endregion

        #region PUT

        [Test]
        public void Orders_Controller_Put_ShouldBeOk()
        {
            // Arrange
            var isUpdated = true;
            _orderServiceMock.Setup(c => c.Update(_order.Object)).Returns(isUpdated);
            // Action
            IHttpActionResult callback = _ordersController.Update(_order.Object);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<bool>>().Subject;
            httpResponse.Content.Should().BeTrue();
            _orderServiceMock.Verify(s => s.Update(_order.Object), Times.Once);
        }

        [Test]
        public void Orders_Controller_Put_ShouldHandleNotFoundexception()
        {
            // Arrange
            _orderServiceMock.Setup(c => c.Update(_order.Object)).Throws<NotFoundException>();
            // Action
            IHttpActionResult callback = _ordersController.Update(_order.Object);
            // Assert
            var httpResponse = callback.Should().BeOfType<NegotiatedContentResult<ExceptionPayload>>().Subject;
            httpResponse.Content.ErrorCode.Should().Be((int)ErrorCodes.NotFound);
            // Perceba que é um cenário onde o servico disporou a exception. Logo, ele deve ser chamado.
            _orderServiceMock.Verify(s => s.Update(_order.Object), Times.Once);
        }

        #endregion

        #region DELETE

        [Test]
        public void Orders_Controller_Delete_ShouldBeOk()
        {
            // Arrange
            var isUpdated = true;
            _orderServiceMock.Setup(c => c.Remove(_order.Object)).Returns(isUpdated);
            // Action
            IHttpActionResult callback = _ordersController.Delete(_order.Object);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<bool>>().Subject;
            _orderServiceMock.Verify(s => s.Remove(_order.Object), Times.Once);
            httpResponse.Content.Should().BeTrue();
        }

        #endregion
    }
}
