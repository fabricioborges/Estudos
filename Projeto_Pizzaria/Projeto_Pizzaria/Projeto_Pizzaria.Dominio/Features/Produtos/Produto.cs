using Projeto_Pizzaria.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public abstract class Produto : Entidade
    {
        public virtual ProdutoEnum TipoDoProduto { get; protected set; }
        public string Nome
        {
            get;
            set;
        }

        public virtual double Valor
        {
            get;
            set;
        }
        public override void Validar()
        {
            ValidarNomeDoProduto();
            ValidarValorDoProduto();
        }

        private void ValidarNomeDoProduto()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                throw new ProdutoNomeInvalidoException();
            }
        }

        private void ValidarValorDoProduto()
        {
            if (Valor <= 0)
            {
                throw new ProdutoValorInvalidoException();
            }
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}