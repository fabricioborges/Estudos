using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public class ItemPedido : Entidade
    {

        public double ValorTotalDeUmProduto
        {
            get
            {
                return CalcularValorItemPedido();
            }
        }
        public virtual Adicional Adicional { get; set; }
        public virtual Pizza Sabor2 { get; set; }
        public virtual Produto Produto
        {
            get;
            set;
        }

        public int Quantidade
        {
            get;
            set;
        }

        public int Ordem
        {
            get;
            set;

        }

        public double CalcularValorItemPedido()
        {
            double valorItem = 0;
            if (Sabor2 != null)
            {
                if (Sabor2.Valor > Produto.Valor)
                {
                    valorItem = Sabor2.Valor * Quantidade;
                }
                else
                {
                    valorItem = Produto.Valor * Quantidade;
                }
            }
            else
            {
                valorItem = Produto.Valor * Quantidade;
            }

            if (Adicional != null)
                valorItem += Adicional.Valor;

            return valorItem;
        }

        public override void Validar()
        {
            ValidarProduto();
        }

        private void ValidarProduto()
        {
            if (Produto == null)
                throw new ProdutoNuloException();
        }

        public override string ToString()
        {
            string adicional = this.Adicional != null ? " Adicional de: " + Adicional.Nome : "";

            if (Sabor2 != null && Produto.Nome != Sabor2.Nome)
            {
                var pizza = Produto as Pizza;

                return "Pizza de " + pizza.Nome + " e " + Sabor2.Nome + adicional + " Tamanho: " + pizza.TamanhoEnum.ToString() + " Valor: R$" + pizza.Valor * Quantidade + " Quantidade: " + Quantidade;

            } else if (Produto is Pizza)
            {
                var pizza = Produto as Pizza;

                return "Pizza de " + Produto.Nome + adicional + " Tamanho: " + pizza.TamanhoEnum.ToString() + " Valor: R$" + pizza.Valor*Quantidade + " Quantidade: " + Quantidade;
            }
            else
                return Produto.Nome + " Valor: R$" + Produto.Valor + " Quantidade: " + Quantidade;

        }


    }
}
