using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Pedidos
{
    [TestFixture]
    public class PedidoTeste
    {
        Pedido _pedido; 

        [SetUp]
        public void Dominio_Pedido_Initialize()
        {
            _pedido = ObjectMother.Pedido;
        }

        [Test]
        public void Dominio_Pedido_Validar_Deve_Validar_Com_Sucesso()
        {
            Action PedidoValidar = () => _pedido.Validar();

            PedidoValidar.Should().NotThrow<Exception>();
        }

        [Test]
        public void Dominio_Pedido_Validar_Deve_Lancar_ClienteVazioDoPedidoException()
        {
            _pedido.Cliente = null;

            Action PedidoValidar = () => _pedido.Validar();

            PedidoValidar.Should().Throw<ClienteVazioDoPedidoException>();
        }

        [Test]
        public void Dominio_Pedido_Validar_Deve_Lancar_ListaDeItensPedidosVaziaDoPedidoException()
        {
            _pedido.ItensDoPedido = new List<ItemPedido>();

            Action PedidoValidar = () => _pedido.Validar();

            PedidoValidar.Should().Throw<ListaDeItensPedidosVaziaDoPedidoException>();
        }

        [Test]
        public void Dominio_Pedido_CalcularPrecoTotalPedido_Deve_Retornar_ValorEsperado()
        {
            double valorEsperado = 2.35;

            _pedido.CalcularPrecoTotalPedido();

            _pedido.ValorTotal.Should().Be(valorEsperado);
        }
    }
}
