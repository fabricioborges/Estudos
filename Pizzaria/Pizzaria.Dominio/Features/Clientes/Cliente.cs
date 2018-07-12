using Pizzaria.Dominio.Features.Enderecos;
using Pizzaria.Dominio.Features.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Dominio.Features.Clientes
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataNascimento{ get; set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
