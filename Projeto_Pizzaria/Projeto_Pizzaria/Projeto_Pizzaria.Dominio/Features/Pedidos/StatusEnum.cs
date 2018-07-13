using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Pedidos
{
    public enum StatusEnum
    {
        AguardandoMontagem = 0,
        EmMontagem = 1,
        AguardandoEntrega = 2,
        EmEntrega = 3,
        PedidoEntregue = 4
    }
}