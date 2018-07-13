using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Clientes
{
    public class ClienteEnderecoInvalidoException : ExcecaoDominio
    {
        public ClienteEnderecoInvalidoException() : base("Cliente deve ter um endereco valido")
        {
        }
    }
}
