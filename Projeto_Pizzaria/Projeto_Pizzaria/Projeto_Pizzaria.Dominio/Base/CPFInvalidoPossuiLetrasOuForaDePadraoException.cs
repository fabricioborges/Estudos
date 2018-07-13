using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    [Serializable]
    public class CPFInvalidoPossuiLetrasOuForaDePadraoException : Exception
    { 

        public CPFInvalidoPossuiLetrasOuForaDePadraoException() : base("CPF possui letras ou está fora de padrão.")
        {
        }
    }
}