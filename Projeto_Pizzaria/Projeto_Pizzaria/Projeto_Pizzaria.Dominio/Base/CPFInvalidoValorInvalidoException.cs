using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    [Serializable]
    public class CPFInvalidoValorInvalidoException : Exception
    {
        public CPFInvalidoValorInvalidoException() : base("CPF com valor invalído.")
        {
        }
        
    }
}