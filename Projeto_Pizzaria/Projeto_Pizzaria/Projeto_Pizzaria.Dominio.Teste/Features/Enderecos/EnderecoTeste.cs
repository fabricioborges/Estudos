using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Enderecos
{
    [TestFixture]
    public class EnderecoTeste
    {
        Endereco _endereco;
        [SetUp]
        public void Dominio_Endereco_Inicializador()
        {
            _endereco = ObjectMother.Endereco;
        }

        [Test]
        public void Dominio_Endereco_DeveSerValido()
        {
            Action validarCampos = () => _endereco.Validar();

            validarCampos.Should().NotThrow<Exception>();
        }

        [Test]
        public void Dominio_Endereco_Rua_Vazia_DeveRetornarExcecao()
        {
            _endereco.Rua = "";

            Action validarRua = () => _endereco.Validar();

            validarRua.Should().Throw<RuaInvalidoException>();
        }

        [Test]
        public void Dominio_Endereco_CEP_Vazio_DeveRetornarExcecao()
        {
            _endereco.CEP = "";

            Action validarCEP = () => _endereco.Validar();

            validarCEP.Should().Throw<CEPInvalidoException>();
        }

        [Test]
        public void Dominio_Endereco_Estado_Vazio_DeveRetornarExcecao()
        {
            _endereco.Estado = "";

            Action validarEstado = () => _endereco.Validar();

            validarEstado.Should().Throw<EstadoInvalidoException>();
        }

        [Test]
        public void Dominio_Endereco_Numero_Vazio_DeveRetornarExcecao()
        {
            _endereco.Numero = 0;

            Action validarNumero = () => _endereco.Validar();

            validarNumero.Should().Throw<NumeroInvalidoException>();
        }
        
        [Test]
        public void Dominio_Endereco_Municipio_Vazio_DeveRetornarExcecao()
        {
            _endereco.Municipio = "";

            Action validarMunicipio = () => _endereco.Validar();

            validarMunicipio.Should().Throw<MunicipioInvalidoException>();
        }

        [Test]
        public void Dominio_Endereco_Bairro_Vazio_DeveRetornarExcecao()
        {
            _endereco.Bairro = "";

            Action validarBairro = () => _endereco.Validar();

            validarBairro.Should().Throw<BairroInvalidoException>();
        }
    }
}
