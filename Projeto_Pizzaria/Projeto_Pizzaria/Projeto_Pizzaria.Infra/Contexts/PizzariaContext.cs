using Projeto_Pizzaria.Dominio;
using Projeto_Pizzaria.Dominio.Features.Base;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using Projeto_Pizzaria.Infra.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Contexts
{
    public class PizzariaContext: DbContext
    {
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
       

        public PizzariaContext() : base("PizzariaBD_SolidOps")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
               .ToTable("TB_Produto");

            modelBuilder.Entity<Cliente>()
               .ToTable("TB_Cliente");

            modelBuilder.Entity<ItemPedido>()
               .ToTable("TB_ItemPedido");

            modelBuilder.Configurations.Add(new PedidoConfiguracao());
        }
    }
}
