using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Pizzaria.Dominio.Features.Enderecos
{
    public class Endereco
    {
        public string Rua
        {
            get;
            set;

        }

        public int Numero
        {
            get;
            set;

        }

        public string Bairro
        {
            get;
            set;
           
        }

        public string Municipio { get; set; }
        public string Estado
        {
            get;
            set;
            
        }

        public string CEP
        {
            get;
            set;
            
        }

        public void Validar()
        {
            ValidarRua();
            ValidarCEP();
            ValidarBairro();
            ValidarNumero();
            ValidarMunicipio();
            ValidarEstado();
        }

        private void ValidarEstado()
        {
            if (String.IsNullOrEmpty(Estado))
                throw new EstadoInvalidoException();
        }

        private void ValidarMunicipio()
        {
            if (String.IsNullOrEmpty(Municipio))
                throw new MunicipioInvalidoException();
        }

        private void ValidarNumero()
        {
            if (Numero < 1)
                throw new NumeroInvalidoException();
        }

        private void ValidarBairro()
        {
            if (String.IsNullOrEmpty(Bairro))
                throw new BairroInvalidoException();
        }

        private void ValidarCEP()
        {
            if (String.IsNullOrEmpty(CEP))
                throw new CEPInvalidoException();
        }

        private void ValidarRua()
        {
            if (String.IsNullOrEmpty(Rua))
                throw new RuaInvalidoException();
        }

        public override string ToString()
        {
            return "Bairro: " + Bairro + " Rua: " + Rua + " Numero: " + Numero;
        }
    }
}