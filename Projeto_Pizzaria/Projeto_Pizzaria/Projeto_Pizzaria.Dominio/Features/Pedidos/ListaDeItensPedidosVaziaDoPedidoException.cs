using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public class ListaDeItensPedidosVaziaDoPedidoException : ExcecaoDominio
    {
        public ListaDeItensPedidosVaziaDoPedidoException() : base("Pedido precisa de pelo menos um produto para ser realizada")
        {
        }
        
    }
}