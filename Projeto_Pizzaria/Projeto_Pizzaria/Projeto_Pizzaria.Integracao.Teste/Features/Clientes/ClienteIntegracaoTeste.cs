using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.InfraDados.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Integracao.Teste.Features.Clientes
{
    [TestFixture]
    class ClienteIntegracaoTeste
    {
        Cliente _cliente;
        ClienteRepository _repositorio;
        ClienteService _service;
        PizzariaContext _contexto;

        [SetUp]
        public void ClienteIntegracao_Teste()
        {
            _contexto = new PizzariaContext();
            _cliente = ObjectMother.Cliente;
            _repositorio = new ClienteRepository(_contexto);
            _service = new ClienteService(_repositorio);
        }

        [Test]
        public void Sistema_Cliente_Deve_Adicionar_Cliente_DeveSerValido()
        {
            _service.Add(_cliente);

            _cliente.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Cliente_Deve_Deletar_Cliente_DeveSerValido()
        {
            _service.Add(_cliente);

            _cliente.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Cliente_Deve_Editar_Cliente_DeveSerValido()
        {
           
            Cliente clienteAdicionado = _service.Add(_cliente);

            clienteAdicionado.Nome = "Update";

            _repositorio.Update(clienteAdicionado);

            Cliente retornaCliente = _service.GetById(_cliente.Id);

            retornaCliente.Nome.Should().Be(clienteAdicionado.Nome);
        }

        [Test]
        public void Sistema_Cliente_Deve_ListarUm_Cliente_DeveSerValido()
        {
            Cliente clienteAdicionado = _service.GetById(_cliente.Id);

            Cliente clienteRetornado = _service.GetById(clienteAdicionado.Id);

            clienteRetornado.Should().NotBeNull();
            clienteRetornado.Id.Should().Be(clienteAdicionado.Id);
        }

        [Test]
        public void Sistema_Cliente_Deve_ListarTodosOs_Clientes_DeveSerValido()
        {
            _service.Add(_cliente);

            List<Cliente> clienteRetornado = _service.GetAll();

            clienteRetornado.Should().NotBeNull();
        }

        [Test]
        public void Sistema_Cliente_Deve_ListarPorTelefone_Cliente_DeveSerValido()
        {
            _cliente.Telefone = "111";
            Cliente clienteAdicionado = _service.Add(_cliente);

            var retornaClientes = _service.GetByTelefone(_cliente.Telefone);

            retornaClientes.Count.Should().BeGreaterThan(0);


        }

    }
}
