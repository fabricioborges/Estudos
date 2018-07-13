using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    [Serializable]
    public class NumeroDocumentoVazioOuNuloException : Exception
    {

        public NumeroDocumentoVazioOuNuloException() : base("Número do documento invalido ou nulo.")
        {
        }
        
    }
}