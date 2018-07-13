using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public class ProdutoValorInvalidoException : ExcecaoDominio
    {
        public ProdutoValorInvalidoException() : base("Produto não pode ter valor menor ou igual a zero")
        {
        }
    }
}
