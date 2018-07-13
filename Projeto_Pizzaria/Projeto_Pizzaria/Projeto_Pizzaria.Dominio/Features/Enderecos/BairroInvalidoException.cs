using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Enderecos
{
    public class BairroInvalidoException : ExcecaoDominio

    {
        public BairroInvalidoException() : base("Bairro vazio ou inválido")
        {
        }
    }
}
