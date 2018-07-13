using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Aplicacao.Features.Pedidos
{
    public class PedidoService : IService<Pedido>
    {
        IPedidoRepository _PedidoRepository;
        public PedidoService(IPedidoRepository PedidoRepository)
        {
            _PedidoRepository = PedidoRepository;
        }
        public Pedido Add(Pedido cliente)
        {
            cliente.Validar();
            return _PedidoRepository.Add(cliente);
        }

        public void delete(Pedido cliente)
        {
            _PedidoRepository.Delete(cliente);
        }

        public List<Pedido> GetAll()
        {
            return _PedidoRepository.GetAll();
        }

        public Pedido GetById(int id)
        {
            return _PedidoRepository.GetById(id);
        }

        public void Update(Pedido cliente)
        {
            cliente.Validar();
            _PedidoRepository.Update(cliente);
        }
        
    }
}
