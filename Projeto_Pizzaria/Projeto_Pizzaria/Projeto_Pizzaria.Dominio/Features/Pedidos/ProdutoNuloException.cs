using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public class ProdutoNuloException : ExcecaoDominio
    {
        public ProdutoNuloException() : base("Produto não pode ser vázio")
        {
        }
    }
}
