using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio
{
    public class Bebida : Produto
    {
        public Bebida()
        {
            TipoDoProduto = ProdutoEnum.Bebida;
        }
        public override void Validar()
        {
            base.Validar();
        }
    }
}