using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public class ClienteVazioDoPedidoException : Exception
    {
        public ClienteVazioDoPedidoException() : base("Pedido Precisa de um cliente")
        {
        }
        
    }
}