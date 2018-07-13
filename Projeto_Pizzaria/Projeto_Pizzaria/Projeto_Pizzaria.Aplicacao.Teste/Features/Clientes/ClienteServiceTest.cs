using Moq;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using FluentAssertions;
using System.Collections.Generic;
using Projeto_Pizzaria.ComumTeste.Features;

namespace Projeto_Pizzaria.Aplicacao.Teste.Features.Clientes
{
    [TestFixture]
    public class ClienteServiceTest
    {
        Mock<IClienteRepository> _clienteRepository;
        ClienteService _clienteService;
        Mock<Cliente> _cliente;

        [SetUp]
        public void ClienteSet()
        {
            _clienteRepository = new Mock<IClienteRepository>();
            _clienteService = new ClienteService(_clienteRepository.Object);
            _cliente = new Mock<Cliente>();
        }

        [Test]
        public void ApplService_Destinatario_Add_Deve_Chamar_OsMetodos_Validar_E_Add()
        {
            //Arrange
            var dest = new Cliente() { Id = 1 };
            _clienteRepository.Setup(x => x.Add(_cliente.Object)).Returns(dest);
            _cliente.Setup(x => x.Validar());

            //Action
            var obtido = _clienteService.Add(_cliente.Object);

            //Assert
            obtido.Id.Should().Be(dest.Id);
            _clienteRepository.Verify(x => x.Add(_cliente.Object));
            _cliente.Verify(x => x.Validar());
            _cliente.VerifyNoOtherCalls();
            _clienteRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Delete_Deve_Chamar_OMetodo_Delete()
        {
            //Arrange
            Cliente cliente = ObjectMother.Cliente;

            _clienteRepository.Setup(x => x.Delete(cliente));

            //Action
            Action enderecoDeleteAction = () => _clienteService.delete(cliente);

            //Assert
            enderecoDeleteAction.Should().NotThrow<Exception>();
            _clienteRepository.Verify(x => x.Delete(cliente), Times.Once());
            _clienteRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Update_Deve_Chamar_OsMetodos_Validar_E_Update()
        {
            //Arrange
            _clienteRepository.Setup(x => x.Update(_cliente.Object));
            _cliente.Setup(x => x.Validar());

            //Action
            _clienteService.Update(_cliente.Object);

            //Assert
            _clienteRepository.Verify(x => x.Update(_cliente.Object));
            _cliente.Verify(x => x.Validar());
            _cliente.VerifyNoOtherCalls();
            _clienteRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Get_Deve_Chamar_OMetodo_Get()
        {
            //Arrange
            Cliente endereco = ObjectMother.Cliente;
            _clienteRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(endereco);

            //Action
            Cliente enderecoResult = _clienteService.GetById(endereco.Id);

            //Assert
            _clienteRepository.Verify(p => p.GetById(It.IsAny<int>()), Times.Once());
            enderecoResult.Should().NotBeNull();
            enderecoResult.Id.Should().Be(endereco.Id);
            _clienteRepository.VerifyNoOtherCalls();
        }

        [Test]
        public void ApplService_Destinatario_GetAll_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Cliente> enderecoList = ObjectMother.ListCliente;
            _clienteRepository.Setup(x => x.GetAll()).Returns(enderecoList);

            //Action
            List<Cliente> resultEnderecoList = _clienteService.GetAll();

            //Assert
            _clienteRepository.Verify(x => x.GetAll());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _clienteRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_GetByTelefone_Deve_Chamar_O_Metodo_GetByTelefone()
        {
            //Arrange
            List<Cliente> clienteList = ObjectMother.ListCliente;
            string telefone = It.IsAny<string>();
            _clienteRepository.Setup(x => x.GetByTelefone(telefone)).Returns(clienteList);

            //Action
            List<Cliente> resultEnderecoList = _clienteService.GetByTelefone(telefone);

            //Assert
            _clienteRepository.Verify(x => x.GetByTelefone(telefone));
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _clienteRepository.VerifyNoOtherCalls();
        }
    }
}
