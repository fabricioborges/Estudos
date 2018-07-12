using Pizzaria.Dominio.Features.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Dominio.Features.Produtos
{
    public class Pizza : Produto
    {
        public TamanhoPizzaEnum TamanhoPizzaEnum { get; set; }
        public List<Sabor> Sabores { get; set; }

        public override void Validar()
        {
            ValidarNome();
            ValidarValor();
            ValidarTamanho();
        }

        private void ValidarTamanho()
        {
            if (String.IsNullOrEmpty(Nome))
                throw new Exception();
        }

        private void ValidarValor()
        {
            throw new NotImplementedException();
        }

        private void ValidarNome()
        {
            throw new NotImplementedException();
        }
    }
}
