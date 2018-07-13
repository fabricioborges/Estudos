using Projeto_Pizzaria.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        List<Produto> GetAllPizza();
        List<Produto> GetAllBebida();
        List<Produto> GetAllAdicional();
        List<Produto> GetAllCalzone();
    }
}
