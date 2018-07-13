using Projeto_Pizzaria.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Features.Enderecos
{
    public class CEPInvalidoException : ExcecaoDominio
    {
        public CEPInvalidoException() : base("CEP inválido ou vazio")
        {
        }
    }
}
