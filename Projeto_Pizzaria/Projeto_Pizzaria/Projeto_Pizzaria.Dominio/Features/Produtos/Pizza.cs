using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public class Pizza : Produto
    {
        public double ValorPequeno{ get; set; }
        public double ValorMedio{ get; set; }
        public double ValorGrande{ get; set; }
        public virtual TamanhoEnum TamanhoEnum {get; set;}
        public virtual TipoPizzaEnum TipoPizzaEnum { get; set; }
        public override double Valor { get {
                switch (TamanhoEnum)
                {
                    case TamanhoEnum.Pequeno:
                        return ValorPequeno;
                    case TamanhoEnum.Medio:
                        return ValorMedio;
                    case TamanhoEnum.Grande:
                        return ValorGrande;
                }
                return base.Valor;
            }  }
        public override void Validar()
        {
            ValidarValorPequeno();
            ValidarValorMedio();
            ValidarValorGrande();
            base.Validar();
        }

        private void ValidarValorPequeno()
        {
            if (ValorPequeno <= 0)
            {
                throw new ProdutoValorInvalidoException();
            }
        }
        private void ValidarValorMedio()
        {
            if (ValorMedio <= 0)
            {
                throw new ProdutoValorInvalidoException();
            }
        }
        private void ValidarValorGrande()
        {
            if (ValorGrande <= 0)
            {
                throw new ProdutoValorInvalidoException();
            }
        }

        public Pizza()
        {
            this.TipoDoProduto = ProdutoEnum.Pizza;
        }

       
    }
}