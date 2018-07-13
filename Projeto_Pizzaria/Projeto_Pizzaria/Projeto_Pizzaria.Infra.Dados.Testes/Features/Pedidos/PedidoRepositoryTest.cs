using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Base;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.Infra.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Dados.Testes.Features.Pedidos
{
    [TestFixture]
    public class PedidoRepositoryTest
    {
        PizzariaContext pizzariaContext;
        PedidoRepository _repository;
        Pedido pedido;
        [SetUp]
        public void Initialize()
        {
            Database.SetInitializer(new InicializadorDb<Pedido>());
            pizzariaContext = new PizzariaContext();
            _repository = new PedidoRepository(pizzariaContext);
            pedido = ObjectMother.Pedido;
        }            

        [Test]
        public void Infra_Pedido_Salvar_Deve_Salvar_Com_Sucesso()
        {
            //Cenário
           
            //Ação
            var Save =_repository.Add(pedido);

            //Saída
            Save.Should().NotBeNull();
        }

        [Test]
        public void Infra_Pedido_Editar_Deve_Editar_Com_Sucesso()
        {
            //Cenário
           
            pedido.Responsavel = "asd";
            var novoPedido = _repository.Add(pedido);
            
            //Ação
            _repository.Update(pedido);

            //Saída
            var GetPedido = _repository.GetById(novoPedido.Id);
            GetPedido.Responsavel.Should().Be(pedido.Responsavel);
        }

        [Test]
        public void Infra_Pedido_Excluir_Deve_Excluir_Com_Sucesso()
        {
            //Cenário
            var novoPedido = _repository.Add(pedido);

            //Ação
            _repository.Delete(pedido);

            //Saída
            var DeletedPedido = _repository.GetById(novoPedido.Id);
            DeletedPedido.Should().BeNull();
        }

        [Test]
        public void Infra_Pedido_GetById_Deve_Retornar_Com_Sucesso()
        {
            //Cenário
            var novoPedido = _repository.Add(pedido);

            //Ação
            var GetPedido = _repository.GetById(novoPedido.Id);

            //Saída
            GetPedido.Responsavel.Should().Be(novoPedido.Responsavel);
        }

        [Test]
        public void Infra_Pedido_GetAll_Deve_Retornar_Com_Sucesso()
        {
            //Cenário           
            var novoPedido = _repository.Add(pedido);

            //Ação
            var GetAll = _repository.GetAll();

            //Saída
            GetAll.Count().Should().BeGreaterThan(0);

            GetAll[0].ItensDoPedido[0].Produto.Should().NotBeNull();
        }

        [Test]
        public void Infra_Pedido_GetAll_Pizza_Deve_Retornar_Com_Sucesso()
        {
            //Cenário     
            pedido = ObjectMother.PedidoPizza;
            var novoPedido = _repository.Add(pedido);

            //Ação
            var GetAll = _repository.GetAll();

            //Saída
            GetAll.Count().Should().BeGreaterThan(0);

            GetAll[0].ItensDoPedido[0].Produto.Should().NotBeNull();
        }
    }
}
