using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.InfraDados.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Integracao.Teste.Features.Produtos
{
    [TestFixture]
    public class ProdutoIntegracaoTeste
    {
        Produto _produto;
        ProdutoRepository _repositorio;
        ProdutoService _service;
        PizzariaContext _contexto;

        [SetUp]
        public void ProdutoIntegracao_Teste()
        {
            _contexto = new PizzariaContext();
            _produto = ObjectMother.Bebida;
            _repositorio = new ProdutoRepository(_contexto);
            _service = new ProdutoService(_repositorio);
        }

        [Test]
        public void Sistema_Produto_Deve_Adicionar_Produto_DeveSerValido()
        {
            _service.Add(_produto);

            _produto.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Produto_Deve_Deletar_Produto_DeveSerValido()
        {
            _service.Add(_produto);

            _produto.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Sistema_Produto_Deve_Editar_Produto_DeveSerValido()
        {

            Produto produtoAdicionado = _service.Add(_produto);

            produtoAdicionado.Nome = "Update";

            _repositorio.Update(produtoAdicionado);

            Produto retornaProduto = _service.GetById(_produto.Id);

            retornaProduto.Nome.Should().Be(produtoAdicionado.Nome);
        }

        [Test]
        public void Sistema_Produto_Deve_ListarUm_Produto_DeveSerValido()
        {
            Produto produtoAdicionado = _service.Add(_produto);

            Produto produtoRetornado = _service.GetById(produtoAdicionado.Id);

            produtoRetornado.Should().NotBeNull();
            produtoRetornado.Id.Should().Be(produtoAdicionado.Id);
        }

        [Test]
        public void Sistema_Produto_Deve_ListarTodosOs_Produtos_DeveSerValido()
        {
            _service.Add(_produto);

            List<Produto> produtoRetornado = _service.GetAll();

            produtoRetornado.Should().NotBeNull();
        }

        [Test]
        public void Sistema_Produto_Deve_ListarTodosOs_Calzones_DeveSerValido()
        {
            _produto = ObjectMother.Calzone;
            _service.Add(_produto);

            List<Produto> produtoRetornado = _service.GetAllCalzone();

            produtoRetornado.Should().NotBeNull();
        }

        [Test]
        public void Sistema_Produto_Deve_ListarTodosAs_Bebidas_DeveSerValido()
        {
            _produto = ObjectMother.Bebida;
            _service.Add(_produto);

            List<Produto> produtoRetornado = _service.GetAll();

            produtoRetornado.Should().NotBeNull();
        }

        [Test]
        public void Sistema_Produto_Deve_ListarTodosOs_Adicionais_DeveSerValido()
        {
            _produto = ObjectMother.Adicional;
            _service.Add(_produto);

            List<Produto> produtoRetornado = _service.GetAll();

            produtoRetornado.Should().NotBeNull();
        }

        [Test]
        public void Sistema_Produto_Deve_ListarTodosAs_Pizzas_DeveSerValido()
        {
            _produto = ObjectMother.Pizza;
            _service.Add(_produto);

            List<Produto> produtoRetornado = _service.GetAll();

            produtoRetornado.Should().NotBeNull();
        }
    }
}
