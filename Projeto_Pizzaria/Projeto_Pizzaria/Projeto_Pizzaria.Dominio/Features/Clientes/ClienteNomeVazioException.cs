using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Clientes
{
    public class ClienteNomeVazioException : ExcecaoDominio
    {
        public ClienteNomeVazioException() : base("Nome não pode ser vazio")
        {
        }
    }
}
