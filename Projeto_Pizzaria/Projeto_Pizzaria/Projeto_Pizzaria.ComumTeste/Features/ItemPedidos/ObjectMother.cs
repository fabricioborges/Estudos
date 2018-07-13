using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.ComumTeste.Features
{
    public partial class ObjectMother
    {
        public static ItemPedido ItemPedido
        {
            get
            {
                return new ItemPedido
                {
                    Ordem = 1,
                    Quantidade = 1,
                    Produto = Bebida
                };
            }
        }

        public static ItemPedido ItemPedidoPizza
        {
            get
            {
                return new ItemPedido
                {
                    Ordem = 1,
                    Quantidade = 1,
                    Produto = Pizza
                };
            }
        }
    }
}
