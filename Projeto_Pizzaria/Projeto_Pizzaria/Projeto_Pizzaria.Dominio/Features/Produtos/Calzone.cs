using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public class Calzone : Produto
    {
        public Calzone()
        {
            TipoDoProduto = ProdutoEnum.Calzone;
        }
        [ExcludeFromCodeCoverage]
        public override void Validar()
        {
            base.Validar();
        }
    }
}