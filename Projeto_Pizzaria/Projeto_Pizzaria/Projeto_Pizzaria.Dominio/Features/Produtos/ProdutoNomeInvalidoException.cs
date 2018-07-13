using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public class ProdutoNomeInvalidoException : ExcecaoDominio
    {
        public ProdutoNomeInvalidoException() : base("Produto precisa de um nome")
        {
        }
    }
}
