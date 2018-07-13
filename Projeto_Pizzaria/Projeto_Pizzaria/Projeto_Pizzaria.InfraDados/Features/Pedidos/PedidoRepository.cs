using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Infra.Features.Pedidos
{
    public class PedidoRepository : IPedidoRepository
    {
        PizzariaContext _context;

        public PedidoRepository(PizzariaContext context)
        {
            _context = context;
        }

        public Pedido Add(Pedido entity)
        {
            _context.Pedido.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(Pedido entity)
        {
            _context.Pedido.Remove(entity);
            _context.SaveChanges();
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedido.ToList();
        }

        public Pedido GetById(int Id)
        {
            return _context.Pedido.Find(Id);
        }

        public void Update(Pedido entity)
        {
            _context.Pedido.Attach(entity);
        }
    }
}
