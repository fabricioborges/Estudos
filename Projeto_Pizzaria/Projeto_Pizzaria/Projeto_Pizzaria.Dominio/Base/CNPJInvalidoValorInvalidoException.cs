using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    [Serializable]
    public class CNPJInvalidoValorInvalidoException : Exception
    {
        
        public CNPJInvalidoValorInvalidoException( ) : base("CNPJ com valor invalido")
        {
        }

        
    }
}