using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public class Adicional : Produto
    {
        public Adicional()
        {
            TipoDoProduto = ProdutoEnum.Adicional;
        }
        public TamanhoEnum TamanhoEnum { get; set; }
        [ExcludeFromCodeCoverage]
        public override void Validar()
        {
            base.Validar();
        }

     
    }
}