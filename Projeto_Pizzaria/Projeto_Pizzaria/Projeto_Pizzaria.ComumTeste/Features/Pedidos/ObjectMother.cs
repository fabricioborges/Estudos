using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.ComumTeste.Features
{
    public static partial class ObjectMother
    {
        public static Pedido Pedido
        {
            get
            {
                return new Pedido
                {
                    Cliente = Cliente,
                    Departamento = "Academia",
                    Responsavel = "Vini",
                    StatusEnum = StatusEnum.EmMontagem,
                    FormaPagamentoEnum = FormaPagamentoEnum.Dinheiro,
                    EmitirNotaFiscal = false,
                    ItensDoPedido = new List<ItemPedido>()
                    {
                        ItemPedido
                    }                    
                };
            }
        }

        public static Pedido PedidoPizza
        {
            get
            {
                return new Pedido
                {
                    Cliente = Cliente,
                    Departamento = "Academia",
                    Responsavel = "Vini",
                    StatusEnum = StatusEnum.EmMontagem,
                    FormaPagamentoEnum = FormaPagamentoEnum.Dinheiro,
                    EmitirNotaFiscal = false,
                    ItensDoPedido = new List<ItemPedido>()
                    {
                        ItemPedidoPizza
                    }
                };
            }
        }

        public static List<Pedido> ListPedido
        {
            get
            {
                List<Pedido> pedidos = new List<Pedido>();
                pedidos.Add(Pedido);
                pedidos.Add(Pedido);
                pedidos.Add(Pedido);
                pedidos.Add(Pedido);
                return pedidos;
            }
        }
    }
}
