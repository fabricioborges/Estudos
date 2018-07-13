using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.ComumTeste.Features
{
    public static partial class ObjectMother
    {
        public static Cliente Cliente
        {
            get
            {
                return new Cliente
                {
                    Id = 1,
                    Nome = "Fabricio",
                    Telefone = "(49) 999186215",
                    Documento = "090.909.519-11",
                    Endereco = Endereco
                };
            }
        }
        public static Cliente ClienteCNPJ
        {
            get
            {
                return new Cliente
                {
                    Id = 1,
                    Nome = "Fabricio com cnpj",
                    Telefone = "(49) 999186215",
                    Documento = "57.413.763/0001-81",
                    Endereco = Endereco
                };
            }
        }

        public static List<Cliente> ListCliente
        {
            get
            {
                List<Cliente> clientes = new List<Cliente>();
                clientes.Add(Cliente);
                clientes.Add(Cliente);
                clientes.Add(Cliente);
                clientes.Add(Cliente);
                return clientes;
            }
        }
    }
}
