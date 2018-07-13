using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using Projeto_Pizzaria.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.ComumTeste.Base
{
    public class InicializadorDb<T> : DropCreateDatabaseAlways<PizzariaContext>
    {
        protected override void Seed(PizzariaContext context)
        {

            context.Cliente.Add(ObjectMother.Cliente);
            context.Cliente.Add(ObjectMother.ClienteCNPJ);
            context.Produto.Add(ObjectMother.Bebida);
            context.Produto.Add(ObjectMother.Pizza);
            context.Produto.Add(ObjectMother.PizzaValorMaior);
            context.Produto.Add(ObjectMother.Calzone);
        //    context.Produto.Add(ObjectMother.Adicional);
            context.Produto.Add(ObjectMother.AdicionalCheddar);

            ItemPedido itemPedido = ObjectMother.ItemPedido;

            context.ItemPedido.Add(itemPedido);
            
            Pedido pedido = ObjectMother.Pedido;
            pedido.Cliente = ObjectMother.Cliente;
            pedido.ItensDoPedido.Add(itemPedido);

            context.Pedido.Add(pedido);

            context.SaveChanges();

            base.Seed(context);
        }
        
        

    }
}
