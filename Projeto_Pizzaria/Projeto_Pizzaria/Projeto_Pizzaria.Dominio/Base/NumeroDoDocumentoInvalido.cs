using System;
using System.Runtime.Serialization;

namespace Projeto_Pizzaria.Dominio.Features.Base
{
    [Serializable]
    public class NumeroDoDocumentoInvalido : Exception
    {
        public NumeroDoDocumentoInvalido() : base("O numero do docuemnto está inválido")
        {
        }
    }
}