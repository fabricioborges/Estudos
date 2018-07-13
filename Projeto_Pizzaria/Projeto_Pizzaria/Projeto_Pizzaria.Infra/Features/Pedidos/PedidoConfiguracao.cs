using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Features.Pedidos
{
    public class PedidoConfiguracao : EntityTypeConfiguration<Pedido>
    {

        public PedidoConfiguracao()
        {
            ToTable("TB_Pedido");
            
        }
    }
}
