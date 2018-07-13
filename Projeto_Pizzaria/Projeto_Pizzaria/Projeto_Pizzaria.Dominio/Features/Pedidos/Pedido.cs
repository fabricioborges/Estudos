using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public class Pedido : Entidade
    {

        public double ValorTotal
        {
            get
            {
                return CalcularPrecoTotalPedido();
            }
        }
        public Pedido()
        {
            ItensDoPedido = new List<ItemPedido>();
        }
        public virtual Cliente Cliente {get; set;}

        public virtual List<ItemPedido> ItensDoPedido { get; set; }

        public virtual FormaPagamentoEnum FormaPagamentoEnum { get;set; }

        public bool EmitirNotaFiscal  { get;  set; }

        public string Departamento { get;set; }

        public string Responsavel {get; set; }

        public StatusEnum StatusEnum { get; set; }

        public double CalcularPrecoTotalPedido()
        {
           var valor = 0.0;
            foreach (var item in ItensDoPedido)
            {
                valor += item.ValorTotalDeUmProduto;
            }
            return valor;
        }

        public override void Validar()
        {
            if (ItensDoPedido.Count < 1)
            {
                throw new ListaDeItensPedidosVaziaDoPedidoException();
            }
            if (Cliente == null)
            {
                throw new ClienteVazioDoPedidoException();
            }
        }

        public override string ToString()
        {
            return "Pedido cliente: " + Cliente.Nome + " Numero: " + Id;
        }
    }
}