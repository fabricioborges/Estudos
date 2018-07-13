using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.InfraDados.Features.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        PizzariaContext _contexto;

        public ClienteRepository(PizzariaContext contexto)
        {
            _contexto = contexto;
        }

        public Cliente Add(Cliente cliente)
        {
            _contexto.Cliente.Add(cliente);
            _contexto.SaveChanges();
            return cliente;
        }

        public void Delete(Cliente cliente)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(cliente);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Cliente.Attach(cliente);
            }

            _contexto.Cliente.Remove(cliente);

            _contexto.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return _contexto.Cliente.ToList();
           // return null;
        }
        public List<Cliente> GetByTelefone(string telefone)
        { 
            var listClientes = _contexto.Cliente
                .Where(x => x.Telefone.Contains(telefone)).ToList();
            return listClientes;
        }

        public Cliente GetById(int Id)
        {
            return _contexto.Cliente.Find(Id);
        }

        public void Update(Cliente cliente)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(cliente);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Cliente.Attach(cliente);
            }

            _contexto.SaveChanges();
        }
    }
}
