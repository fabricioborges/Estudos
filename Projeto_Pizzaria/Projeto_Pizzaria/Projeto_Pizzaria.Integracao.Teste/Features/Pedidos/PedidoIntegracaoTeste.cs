using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.Infra.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Integracao.Teste.Features.Pedidos
{
    [TestFixture]
    class PedidoIntegracaoTeste
    {
        Pedido _pedido;
        PedidoRepository _repositorio;
        PedidoService _service;
        PizzariaContext _contexto;

        [SetUp]
        public void PedidoIntegracao_Teste()
        {
            _contexto = new PizzariaContext();
            _pedido = ObjectMother.Pedido;
            _repositorio = new PedidoRepository(_contexto);
            _service = new PedidoService(_repositorio);
        }

        [Test]
        public void Sistema_Pedido_Deve_Adicionar_Pedido_DeveSerValido()
        {
            _service.Add(_pedido);

            _pedido.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Pedido_Deve_Deletar_Pedido_DeveSerValido()
        {
            _service.Add(_pedido);

            _pedido.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Pedido_Deve_Editar_Pedido_DeveSerValido()
        {

            Pedido pedidoAdicionado = _service.Add(_pedido);

            pedidoAdicionado.Responsavel = "Update";

            _repositorio.Update(pedidoAdicionado);

            Pedido retornaPedido = _service.GetById(_pedido.Id);

            retornaPedido.Responsavel.Should().Be(pedidoAdicionado.Responsavel);
        }

        [Test]
        public void Sistema_Pedido_Deve_ListarUm_Pedido_DeveSerValido()
        {
            Pedido pedidoAdicionado = _service.Add(_pedido);

            Pedido pedidoRetornado = _service.GetById(pedidoAdicionado.Id);

            pedidoRetornado.Should().NotBeNull();
            pedidoRetornado.Id.Should().Be(pedidoAdicionado.Id);
        }

        [Test]
        public void Sistema_Pedido_Deve_ListarTodosOs_Pedidos_DeveSerValido()
        {
            _service.Add(_pedido);

            List<Pedido> pedidoRetornado = _service.GetAll();

            pedidoRetornado.Should().NotBeNull();
        }   
    }
}
