using FluentAssertions;
using Moq;
using NUnit.Framework;
using Prova1.API.Controllers.Products;
using Prova1.Application.Features.Products;
using Prova1.Common.Tests.Features.ObjectMothers;
using Prova1.Controller.Tests.Initializer;
using Prova1.Domain.Products;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace Prova1.Controller.Tests.Features.Products
{
    [TestFixture]
    public class ProductsControllerTests : TestControllerBase
    {
        private ProductsController _productsController;
        private Mock<IProductService> _productServiceMock;

        private Mock<Product> _product;
    
        [SetUp]
        public void Initialize()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            _productServiceMock = new Mock<IProductService>();
            _productsController = new ProductsController()
            {
                Request = request,
                _productService = _productServiceMock.Object,
            };
            _product = new Mock<Product>();
        }

        #region GET

        [Test]
        public void Products_Controller_Get_ShouldOk()
        {
            // Arrange
            var product = ObjectMother.GetProductValid();
            var response = new List<Product>() { product }.AsQueryable();
            _productServiceMock.Setup(s => s.GetAll()).Returns(response);
            // Action
            var callback = _productsController.Get();
            //Assert
            _productServiceMock.Verify(s => s.GetAll(), Times.Once);
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<List<Product>>>().Subject;
            httpResponse.Content.Should().NotBeNullOrEmpty();
            httpResponse.Content.First().Id.Should().Be(product.Id);
        }

        [Test]
        public void Products_Controller_GetById_ShouldBeOk()
        {
            // Arrange
            var product = ObjectMother.GetProductValid();
            _productServiceMock.Setup(c => c.GetById(product.Id)).Returns(product);
            // Action
            IHttpActionResult callback = _productsController.GetById(product.Id);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<Product>>().Subject;
            httpResponse.Content.Should().NotBeNull();
            httpResponse.Content.Id.Should().Be(product.Id);
            _productServiceMock.Verify(s => s.GetById(product.Id), Times.Once);
        }

        #endregion

        #region POST

        [Test]
        public void Products_Controller_Post_ShouldBeOk()
        {
            // Arrange
            var product = ObjectMother.GetProductValid();
            _productServiceMock.Setup(c => c.Add(product)).Returns(product.Id);
            // Action
            IHttpActionResult callback = _productsController.Post(product);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<int>>().Subject;
            httpResponse.Content.Should().Be(product.Id);
            _productServiceMock.Verify(s => s.Add(product), Times.Once);
        }
  
        #endregion

        #region PUT

        [Test]
        public void Products_Controller_Put_ShouldBeOk()
        {
            // Arrange
            var product = ObjectMother.GetProductValidToUpdate();
            var isUpdated = true;
            _productServiceMock.Setup(c => c.Update(product)).Returns(isUpdated);
            // Action
            IHttpActionResult callback = _productsController.Update(product);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<bool>>().Subject;
            httpResponse.Content.Should().BeTrue();
            _productServiceMock.Verify(s => s.Update(product), Times.Once);
        }
 
        #endregion

        #region DELETE

        [Test]
        public void Products_Controller_Delete_ShouldBeOk()
        {
            // Arrange
            var product = ObjectMother.GetProductValidToRemove();
            var isUpdated = true;
            _productServiceMock.Setup(c => c.Remove(product)).Returns(isUpdated);
            // Action
            IHttpActionResult callback = _productsController.Delete(product);
            // Assert
            var httpResponse = callback.Should().BeOfType<OkNegotiatedContentResult<bool>>().Subject;
            _productServiceMock.Verify(s => s.Remove(product), Times.Once);
            httpResponse.Content.Should().BeTrue();
        }

        #endregion

    }
}
