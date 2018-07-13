using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Base;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.InfraDados.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Dados.Testes.Features.Clientes
{
    [TestFixture]
    public class ClienteDataRepositoryTeste
    {
        
        PizzariaContext _contextoTeste;
        ClienteRepository _repositorio;
        Cliente _cliente;

        [SetUp]
        public void ClienteRepositorio_Inicializador()
        {
            Database.SetInitializer(new InicializadorDb<Cliente>());
            
             _contextoTeste = new PizzariaContext();

            _repositorio = new ClienteRepository(_contextoTeste);

            _cliente = ObjectMother.Cliente;

            _contextoTeste.Database.Initialize(true);

        }

        [Test]
        public void Repositorio_Cliente_Deve_Adicionar_Cliente_DeveSerValido()
        {
            Cliente clienteAdicionado = _repositorio.Add(_cliente);

            clienteAdicionado.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Repositorio_Cliente_Deve_Deletar_Cliente_DeveSerValido()
        {
            Cliente clienteDeletado = _repositorio.Add(_cliente);

            _repositorio.Delete(clienteDeletado);

            clienteDeletado.Id.Should().BeGreaterThan(0);

            Cliente retornoGet = _repositorio.GetById(clienteDeletado.Id);

            retornoGet.Should().BeNull();

        }

        [Test]
        public void Repositorio_Cliente_Deve_Alterar_Cliente_DeveSerValido()
        {
            Cliente clienteAdicionado = _repositorio.Add(_cliente);
            
            clienteAdicionado.Nome = "Update";

           _repositorio.Update(clienteAdicionado);

            Cliente retornaCliente = _repositorio.GetById(_cliente.Id);

            retornaCliente.Nome.Should().Be(clienteAdicionado.Nome);
        }

        [Test]
        public void Repositorio_Cliente_Deve_BuscarPorId_Cliente_DeveSerValido()
        {
            Cliente clienteAdicionado = _repositorio.Add(_cliente);
            
            Cliente retornaCliente = _repositorio.GetById(_cliente.Id);

            retornaCliente.Nome.Should().Be(clienteAdicionado.Nome);
            retornaCliente.Id.Should().Be(clienteAdicionado.Id);
        }

        [Test]
        public void Repositorio_Cliente_Deve_BuscarTodosOs_Clientes_DeveSerValido()
        {
            Cliente clienteAdicionado = _repositorio.Add(_cliente);

            var retornaCliente = _repositorio.GetAll();

            retornaCliente.Count.Should().BeGreaterThan(0);

        }
        [Test]
        public void Repositorio_Cliente_Deve_BuscarTodosOsClientesQueTemOTelefone_DeveSerValido()
        {
            _cliente.Telefone = "111";
            Cliente clienteAdicionado = _repositorio.Add(_cliente);

            var retornaClientes = _repositorio.GetByTelefone(_cliente.Telefone);

            retornaClientes.Count.Should().BeGreaterThan(0);

        }

    }
}
