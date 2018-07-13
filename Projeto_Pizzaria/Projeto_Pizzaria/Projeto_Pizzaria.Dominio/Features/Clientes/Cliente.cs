using Projeto_Pizzaria.Dominio.Base;
using Projeto_Pizzaria.Dominio.Features.Base;
using Projeto_Pizzaria.Dominio.Features.Enderecos;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Clientes
{
    public class Cliente : Entidade
    {
        public virtual Endereco Endereco { get; set; }
        public virtual NumeroDocumento Documento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
            Documento = new NumeroDocumento();
        }

        public override void Validar()
        {
            ValidarNome();
            ValidarTelefone();
            ValidarEndereco();
        }

        private void ValidarEndereco()
        {
            if (Endereco == null)
                throw new ClienteEnderecoInvalidoException();
        }

        private void ValidarTelefone()
        {
            if (String.IsNullOrEmpty(Telefone))
                throw new ClienteTelefoneVazioException();
        }
        private void ValidarNome()
        {
            if (String.IsNullOrEmpty(Nome))
                throw new ClienteNomeVazioException();
        }


        public override string ToString()
        {
            return Telefone;
        }
    }
}