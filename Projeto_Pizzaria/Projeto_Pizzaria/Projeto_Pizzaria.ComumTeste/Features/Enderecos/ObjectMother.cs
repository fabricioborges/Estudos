using Projeto_Pizzaria.Dominio.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.ComumTeste.Features
{
    public static partial class ObjectMother
    {
        public static Endereco Endereco
        {
            get
            {
                return new Endereco
                {
                    CEP = "99999999",
                    Bairro = "São Cristovão",
                    Rua = "Rua Pará",
                    Estado = "SC",
                    Municipio = "Lages",
                    Numero = 22,
                };
            }
        }



    }
}
