using Pizzaria.Dominio.Features.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Dominio.Features.Produtos
{
    public abstract class Produto : Entidade
    {
        public virtual string Nome { get; set; }
        public virtual double Valor { get; set; }
    }
}
