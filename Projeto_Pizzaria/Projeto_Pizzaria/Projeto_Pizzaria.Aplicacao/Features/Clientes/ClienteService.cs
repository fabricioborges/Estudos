using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Aplicacao.Features.Clientes
{
    public class ClienteService : IService<Cliente>
    {
        IClienteRepository _ClienteRepository;
        public ClienteService(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }
        public Cliente Add(Cliente cliente)
        {
            cliente.Validar();
            return _ClienteRepository.Add(cliente);
        }

        public void delete(Cliente cliente)
        {
            _ClienteRepository.Delete(cliente);
        }

        public List<Cliente> GetAll()
        {
            return _ClienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _ClienteRepository.GetById(id);
        }

        public void Update(Cliente cliente)
        {
            cliente.Validar();
            _ClienteRepository.Update(cliente);
        }
        public List<Cliente> GetByTelefone(string telefone) {
            return _ClienteRepository.GetByTelefone(telefone);
        }
    }
}
