using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Produtos
{
    [TestFixture]
    public class ProdutoTest
    {
        Produto _produto;
        [SetUp]
        public void Initialize()
        {
            _produto = ObjectMother.Bebida;
                      
        }

        [Test]
        public void Dominio_Produto_Validar_Deve_Validar_Com_Sucesso()
        {
            //Ação
            Action validar = () => _produto.Validar();

            //Saida
            validar.Should().NotThrow<Exception>();

        }

        [Test]
        public void Dominio_Produto_Validar_Deve_Lancar_ProdutoNomeInvalidoException()
        {
            //Cenário
            _produto.Nome = "";

            //Ação
            Action validar = () => _produto.Validar();

            //Saida
            validar.Should().Throw<ProdutoNomeInvalidoException>();

        }

        [Test]
        public void Dominio_Produto_Validar_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _produto.Valor = 0;

            //Ação
            Action validar = () => _produto.Validar();

            //Saida
            validar.Should().Throw<ProdutoValorInvalidoException>();

        }

        [Test]
        public void Dominio_Produto_ToString_Deve_Restornar_String_Esperada()
        {
            //Cenário
            string nomeEsperado = "Pepsi";

            //Ação
            _produto.Nome = nomeEsperado;

            //Saída
            _produto.ToString().Should().Be(nomeEsperado);
        }
    }
}
