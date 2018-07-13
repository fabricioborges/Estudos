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
    public class ItemPedidoTest
    {
        ItemPedido _itemPedido;

        [SetUp]
        public void Dominio_ItemPedido_Inicializador()
        {
            _itemPedido = ObjectMother.ItemPedido;
        }

        [Test]
        public void Dominio_ItemPedido_Deve_Ser_Valido()
        {
            Action validarCampos = () => _itemPedido.Validar();

            validarCampos.Should().NotThrow<Exception>();
        }

        [Test]
       public void Dominio_ItemPedido_DeveCalcularValorItemPedido_DuasPizzas_UmSabor_DeveSerValido()
        {
            _itemPedido.Produto = ObjectMother.Pizza;

            _itemPedido.Quantidade = 2;

            _itemPedido.CalcularValorItemPedido();

            _itemPedido.ValorTotalDeUmProduto.Should().Be(84.70);
        }

        [Test]
        public void Dominio_ItemPedido_DeveCalcularValorItemPedido_UmaPizza_DoisSabores_DeveSerValido()
        {
            _itemPedido.Produto = ObjectMother.Pizza;

            _itemPedido.Sabor2 = ObjectMother.PizzaValorMaior;

            _itemPedido.Quantidade = 1;

            _itemPedido.CalcularValorItemPedido();

            _itemPedido.ValorTotalDeUmProduto.Should().Be(43.75);
        }

        [Test]
        public void Dominio_ItemPedido_DeveCalcularValorItemPedido_UmaPizza_DoisSabores_PrimeiroSaborMaior_DeveSerValido()
        {
            _itemPedido.Produto = ObjectMother.PizzaValorMaior;

            _itemPedido.Sabor2 = ObjectMother.Pizza;

            _itemPedido.Quantidade = 1;

            _itemPedido.CalcularValorItemPedido();

            _itemPedido.ValorTotalDeUmProduto.Should().Be(43.75);
        }

        [Test]
        public void Dominio_ItemPedido_DeveCalcularValorItemPedido_UmaPizza_UmSabor__UmAdicional_DeveSerValido()
        {
            _itemPedido.Produto = ObjectMother.Pizza;

            _itemPedido.Adicional = ObjectMother.Adicional;

            _itemPedido.Quantidade = 1;

            _itemPedido.CalcularValorItemPedido();

            _itemPedido.ValorTotalDeUmProduto.Should().Be(44.1);
        }

        [Test]
        public void Dominio_ItemPedido_ToString_Deve_Retornar_Uma_String()
        {
             var produtoToString = _itemPedido.Produto = ObjectMother.PizzaValorMaior;

            _itemPedido.Produto = produtoToString;

            _itemPedido.ToString().Should().Contain(produtoToString.Nome);
        }

        [Test]
        public void Dominio_ItemPedido_ToString_DuasPizzas_Deve_Retornar_Uma_String()
        {
            var produtoToString1 = _itemPedido.Produto = ObjectMother.PizzaValorMaior;
            var produtoToString2 = _itemPedido.Sabor2 = ObjectMother.Pizza;
            _itemPedido.Adicional = ObjectMother.Adicional;

            _itemPedido.Produto = produtoToString1;

            _itemPedido.Sabor2 = produtoToString2;

            _itemPedido.ToString().Should().Contain(produtoToString1.Nome);

            _itemPedido.ToString().Should().Contain(produtoToString2.Nome);
        }

        [Test]
        public void Dominio_ItemPedido_ToString_Calzone_Deve_Retornar_Uma_String()
        {
            var produtoToString = _itemPedido.Produto = ObjectMother.Calzone;

            _itemPedido.Produto = produtoToString;

            _itemPedido.ToString().Should().Contain(produtoToString.Nome);
        }

        [Test]
        public void Dominio_ItemPedido_ProdutoNulo_DeveRetornarExcexao()
        {
             _itemPedido.Produto = null;

            Action validarProduto = () => _itemPedido.Validar();

            validarProduto.Should().Throw<ProdutoNuloException>();
        }

    }
}
