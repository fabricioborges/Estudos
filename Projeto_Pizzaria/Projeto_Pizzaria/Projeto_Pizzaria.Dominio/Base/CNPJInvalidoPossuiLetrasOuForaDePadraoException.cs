using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    
    public class CNPJInvalidoPossuiLetrasOuForaDePadraoException : Exception
    {

        public CNPJInvalidoPossuiLetrasOuForaDePadraoException() : base("CNPJ possui letras ou está fora do padrão.")
        {
        }

        
    }
}