using Projeto_Pizzaria.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Clientes
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        List<Cliente> GetByTelefone(string telefone);
    }
}
