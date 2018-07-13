using FluentAssertions;
using Moq;
using NUnit.Framework;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Aplicacao.Teste.Features.Produtos
{
    [TestFixture]
    public class ProdutoServiceTest
    {
        Mock<IProdutoRepository> _produtoRepository;
        ProdutoService _produtoService;
        Mock<Produto> _produto;

        [SetUp]
        public void ProdutoSet()
        {
            _produtoRepository = new Mock<IProdutoRepository>();
            _produtoService = new ProdutoService(_produtoRepository.Object);
            _produto = new Mock<Produto>();
        }

        [Test]
        public void ApplService_Destinatario_Add_Deve_Chamar_OsMetodos_Validar_E_Add()
        {
            //Arrange
            var dest = new Bebida() { Id = 1 };
            _produtoRepository.Setup(x => x.Add(_produto.Object)).Returns(dest);
            _produto.Setup(x => x.Validar());

            //Action
            var obtido = _produtoService.Add(_produto.Object);

            //Assert
            obtido.Id.Should().Be(dest.Id);
            _produtoRepository.Verify(x => x.Add(_produto.Object));
            _produto.Verify(x => x.Validar());
            _produto.VerifyNoOtherCalls();
            _produtoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Delete_Deve_Chamar_OMetodo_Delete()
        {
            //Arrange
            Produto produto = ObjectMother.Bebida;

            _produtoRepository.Setup(x => x.Delete(produto));

            //Action
            Action enderecoDeleteAction = () => _produtoService.delete(produto);

            //Assert
            enderecoDeleteAction.Should().NotThrow<Exception>();
            _produtoRepository.Verify(x => x.Delete(produto), Times.Once());
            _produtoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Update_Deve_Chamar_OsMetodos_Validar_E_Update()
        {
            //Arrange
            _produtoRepository.Setup(x => x.Update(_produto.Object));
            _produto.Setup(x => x.Validar());

            //Action
            _produtoService.Update(_produto.Object);

            //Assert
            _produtoRepository.Verify(x => x.Update(_produto.Object));
            _produto.Verify(x => x.Validar());
            _produto.VerifyNoOtherCalls();
            _produtoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_Get_Deve_Chamar_OMetodo_Get()
        {
            //Arrange
            Produto produto = ObjectMother.Bebida;
            _produtoRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(produto);

            //Action
            Produto enderecoResult = _produtoService.GetById(produto.Id);

            //Assert
            _produtoRepository.Verify(p => p.GetById(It.IsAny<int>()), Times.Once());
            enderecoResult.Should().NotBeNull();
            enderecoResult.Id.Should().Be(produto.Id);
            _produtoRepository.VerifyNoOtherCalls();
        }

        [Test]
        public void ApplService_Destinatario_GetAllPizza_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Produto> List = ObjectMother.ListaPizzas;
            _produtoRepository.Setup(x => x.GetAllPizza()).Returns(List);

            //Action
            List<Produto> resultEnderecoList = _produtoService.GetAllPizza();

            //Assert
            _produtoRepository.Verify(x => x.GetAllPizza());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _produtoRepository.VerifyNoOtherCalls();
        }

        [Test]
        public void ApplService_Destinatario_GetAll_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Produto> List = ObjectMother.ListaProduto;
            _produtoRepository.Setup(x => x.GetAll()).Returns(List);

            //Action
            List<Produto> resultEnderecoList = _produtoService.GetAll();

            //Assert
            _produtoRepository.Verify(x => x.GetAll());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _produtoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_GetAllBebida_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Produto> List = ObjectMother.ListaBebida;
            _produtoRepository.Setup(x => x.GetAllBebida()).Returns(List);

            //Action
            List<Produto> resultEnderecoList = _produtoService.GetAllBebida();

            //Assert
            _produtoRepository.Verify(x => x.GetAllBebida());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _produtoRepository.VerifyNoOtherCalls();
        }

        [Test]
        public void ApplService_Destinatario_GetAllAdiconal_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Produto> List = ObjectMother.ListaAdicionais;
            _produtoRepository.Setup(x => x.GetAllAdicional()).Returns(List);

            //Action
            List<Produto> resultEnderecoList = _produtoService.GetAllAdicional();

            //Assert
            _produtoRepository.Verify(x => x.GetAllAdicional());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _produtoRepository.VerifyNoOtherCalls();
        }
        [Test]
        public void ApplService_Destinatario_GetAllCalzone_Deve_Chamar_OMetodo_GetAll()
        {
            //Arrange
            List<Produto> List = ObjectMother.ListaCalzone;
            _produtoRepository.Setup(x => x.GetAllCalzone()).Returns(List);

            //Action
            List<Produto> resultEnderecoList = _produtoService.GetAllCalzone();

            //Assert
            _produtoRepository.Verify(x => x.GetAllCalzone());
            resultEnderecoList.Should().NotBeNull();
            resultEnderecoList.Count.Should().BeGreaterThan(0);
            _produtoRepository.VerifyNoOtherCalls();
        }

    }
}