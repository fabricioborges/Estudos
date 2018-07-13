using FluentAssertions;
using Moq;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Aplicacao.Teste.Features.Pedidos
{
    [TestFixture]
    public class PedidoServiceTest
    {
        Mock<IPedidoRepository> _pedidoRepository;
        PedidoService _pedidoService;
        Mock<Pedido> _pedido;

        [SetUp]
        public void PedidoSet()
        {
            _pedidoRepository = new Mock<IPedidoRepository>();
            _pedidoService = new PedidoService(_pedidoRepository.Object);
            _pedido = new Mock<Pedido>();
        }

        [Test]
        public void ApplService_Destinatario_Add_Deve_Chamar_OsMetodos_Validar_E_Add()
        {
            //Arrange
            var dest = new Pedido() { Id = 1 };
            _pedidoRepository.Setup(x => x.Add(_pedido.Object)).Returns(dest);
            _pedido.Setup(x => x.Validar());

            //Action
            var obtido = _pedidoService.Add(_pedido.Object);

            //Assert
            obtido.Id.Should().Be(dest.Id);
            _pedidoRepository.Verify(x => x.Add(_pedido.Object));
            _pedido.Verify(x => x.Validar());
            _pedido.VerifyNoOtherCalls();
            _pedidoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Delete_Deve_Chamar_OMetodo_Delete()
        {
            //Arrange
            Pedido pedido = ObjectMother.Pedido;

            _pedidoRepository.Setup(x => x.Delete(pedido));

            //Action
            Action enderecoDeleteAction = () => _pedidoService.delete(pedido);

            //Assert
            enderecoDeleteAction.Should().NotThrow<Exception>();
            _pedidoRepository.Verify(x => x.Delete(pedido), Times.Once());
            _pedidoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Update_Deve_Chamar_OsMetodos_Validar_E_Update()
        {
            //Arrange
            _pedidoRepository.Setup(x => x.Update(_pedido.Object));
            _pedido.Setup(x => x.Validar());

            //Action
            _pedidoService.Update(_pedido.Object);

            //Assert
            _pedidoRepository.Verify(x => x.Update(_pedido.Object));
            _pedido.Verify(x => x.Validar());
            _pedido.VerifyNoOtherCalls();
            _pedidoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Get_Deve_Chamar_OMetodo_Get()
        {
            //Arrange
            Pedido endereco = ObjectMother.Pedido;
            _pedidoRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(endereco);

            //Action
            Pedido enderecoResult = _pedidoService.GetById(endereco.Id);

            //Assert
            _pedidoRepository.Verify(p => p.GetById(It.IsAny<int>()), Times.Once());
            enderecoResult.Should().NotBeNull();
            enderecoResult.Id.Should().Be(endereco.Id);
            _pedidoRepository.VerifyNoOtherCalls();
        }

        [Test]
        public void ApplService_Destinatario_GetAll_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Pedido> enderecoList = ObjectMother.ListPedido;
            _pedidoRepository.Setup(x => x.GetAll()).Returns(enderecoList);

            //Action
            List<Pedido> resultEnderecoList = _pedidoService.GetAll();

            //Assert
            _pedidoRepository.Verify(x => x.GetAll());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _pedidoRepository.VerifyNoOtherCalls();
        }
    }
}
