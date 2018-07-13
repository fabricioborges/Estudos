using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Base;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.InfraDados.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Dados.Testes.Features.Produtos
{
    [TestFixture]
    public class ProdutoRepositoryTest
    {
        PizzariaContext _contextoTeste;
        ProdutoRepository _repositorio;
        Produto _produto;

        [SetUp]
        public void ProdutoRepositorio_Inicializador()
        {
            Database.SetInitializer(new InicializadorDb<Produto>());

            _contextoTeste = new PizzariaContext();

            _repositorio = new ProdutoRepository(_contextoTeste);

            _produto = ObjectMother.Bebida;

            _contextoTeste.Database.Initialize(true);

        }

        [Test]
        public void Repositorio_Produto_Deve_Adicionar_Produto_DeveSerValido()
        {
            Produto produtoAdicionado = _repositorio.Add(_produto);

            produtoAdicionado.Id.Should().BeGreaterThan(0);
        }

        [Test]
        public void Repositorio_Produto_Deve_Deletar_Produto_DeveSerValido()
        {
            Produto produtoDeletado = _repositorio.Add(_produto);

            _repositorio.Delete(produtoDeletado);

            produtoDeletado.Id.Should().BeGreaterThan(0);

            Produto retornoGet = _repositorio.GetById(produtoDeletado.Id);

            retornoGet.Should().BeNull();

        }

        [Test]
        public void Repositorio_Produto_Deve_Alterar_Produto_DeveSerValido()
        {
            Produto produtoAdicionado = _repositorio.Add(_produto);

            produtoAdicionado.Nome = "Update";

            _repositorio.Update(produtoAdicionado);

            Produto retornaProduto = _repositorio.GetById(_produto.Id);

            retornaProduto.Nome.Should().Be(produtoAdicionado.Nome);
        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarPorId_Produto_DeveSerValido()
        {
            Produto produtoAdicionado = _repositorio.Add(_produto);

            Produto retornaProduto = _repositorio.GetById(_produto.Id);

            retornaProduto.Nome.Should().Be(produtoAdicionado.Nome);
            retornaProduto.Id.Should().Be(produtoAdicionado.Id);
        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarTodosOs_Produtos_DeveSerValido()
        {
            Produto produtoAdicionado = _repositorio.Add(_produto);

            var retornaProduto = _repositorio.GetAll();

            retornaProduto.Count.Should().BeGreaterThan(0);

        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarTodosOs_Adicionais_DeveSerValido()
        {
            _produto = ObjectMother.Adicional;
            Produto produtoAdicionado = _repositorio.Add(_produto);

            var retornaProduto = _repositorio.GetAllAdicional();

            retornaProduto.Count.Should().BeGreaterThan(0);

        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarTodosAs_Bebidas_DeveSerValido()
        {
            _produto = ObjectMother.Bebida;
            Produto produtoAdicionado = _repositorio.Add(_produto);

            var retornaProduto = _repositorio.GetAllBebida();

            retornaProduto.Count.Should().BeGreaterThan(0);

        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarTodosAs_Pizzas_DeveSerValido()
        {
            _produto = ObjectMother.Pizza;
            Produto produtoAdicionado = _repositorio.Add(_produto);

            var retornaProduto = _repositorio.GetAllPizza();

            retornaProduto.Count.Should().BeGreaterThan(0);

        }

        [Test]
        public void Repositorio_Produto_Deve_BuscarTodosOs_Calzones_DeveSerValido()
        {
            _produto = ObjectMother.Calzone;
            Produto produtoAdicionado = _repositorio.Add(_produto);

            var retornaProduto = _repositorio.GetAllCalzone();

            retornaProduto.Count.Should().BeGreaterThan(0);

        }
    }
}
