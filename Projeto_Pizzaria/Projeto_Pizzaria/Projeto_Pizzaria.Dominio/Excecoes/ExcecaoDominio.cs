using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Excecoes
{
    public class ExcecaoDominio : Exception
    {
        public ExcecaoDominio(string message) : base(message)
        {
        }
    }
}
