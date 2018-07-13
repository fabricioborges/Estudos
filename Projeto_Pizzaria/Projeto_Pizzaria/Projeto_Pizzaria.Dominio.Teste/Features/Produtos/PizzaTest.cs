using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Produtos
{
    [TestFixture]
    public class PizzaTest
    {
        Pizza _pizza;
        [SetUp]
        public void Initialize()
        {
            _pizza = ObjectMother.Pizza;
        }

        [Test]
        public void Dominio_Pizza_Validar_Deve_Validar_Com_Sucesso()
        {
            //Ação
            Action validar = () => _pizza.Validar();

            //Saída
            validar.Should().NotThrow<Exception>();
        }

        [Test]
        public void Dominio_Pizza_Media_Validar_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.ValorMedio = 0;

            //Ação
            Action validar = () => _pizza.Validar();

            //Saída
            validar.Should().Throw<ProdutoValorInvalidoException>();
        }

        [Test]
        public void Dominio_Pizza_pequena_Validar_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.ValorPequeno = 0;

            //Ação
            Action validar = () => _pizza.Validar();

            //Saída
            validar.Should().Throw<ProdutoValorInvalidoException>();
        }

        [Test]
        public void Dominio_Pizza_Grande_Validar_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.ValorGrande = 0;

            //Ação
            Action validar = () => _pizza.Validar();

            //Saída
            validar.Should().Throw<ProdutoValorInvalidoException>();
        }

        [Test]
        public void Dominio_Pizza_Pequena_Valor_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.TamanhoEnum = TamanhoEnum.Pequeno;
            double valorEsperado = 1;
            
            //Saída
            _pizza.Valor.Should().Be(valorEsperado);
        }


        [Test]
        public void Dominio_Pizza_Grande_Valor_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.TamanhoEnum = TamanhoEnum.Grande;
            double valorEsperado = 3;

            //Saída
            _pizza.Valor.Should().Be(valorEsperado);
        }

        [Test]
        public void Dominio_Pizza_Padrão_Valor_Deve_Lancar_ProdutoValorInvalidoException()
        {
            //Cenário
            _pizza.TamanhoEnum = TamanhoEnum.Padrao;
            double valorEsperado = 42.35;

            //Saída
            _pizza.Valor.Should().Be(valorEsperado);
        }
    }
}
