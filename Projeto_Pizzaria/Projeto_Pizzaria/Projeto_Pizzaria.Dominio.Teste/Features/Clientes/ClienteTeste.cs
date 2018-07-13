using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.ComumTeste.Features;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Clientes
{
    [TestFixture]
    public class ClienteTeste
    {
        Cliente _cliente;
        [SetUp]
        public void Dominio_Cliente_Inicializador()
        {
            _cliente = ObjectMother.Cliente;
        }

        [Test]
        public void Dominio_Cliente_Deve_Ser_Valido()
        {
            Action validarCampos = () => _cliente.Validar();

            validarCampos.Should().NotThrow<Exception>();
        }

        [Test]
        public void Dominio_Cliente_Nome_Vazio_Validar_DeveRetornarExcecao()
        {
            _cliente.Nome = "";

            Action validarNome = () => _cliente.Validar();

            validarNome.Should().Throw<ClienteNomeVazioException>();
        }


        [Test]
        public void Dominio_Cliente_Telefone_Vazio_Validar_DeveRetornarExcecao()
        {
            _cliente.Telefone = "";

            Action validarTelefone = () => _cliente.Validar();

            validarTelefone.Should().Throw<ClienteTelefoneVazioException>();
        }


        [Test]
        public void Dominio_Cliente_Endereco_Nulo_Validar_DeveRetornarExcecao()
        {
            _cliente.Endereco = null;

            Action validarEndereco = () => _cliente.Validar();

            validarEndereco.Should().Throw<ClienteEnderecoInvalidoException>();

        }

        [Test]
        public void Dominio_Cliente_ToString_Deve_Retornar_Uma_String()
        {
            string telefone = "000000000";

            _cliente.Telefone = telefone;

            _cliente.ToString().Should().Be(telefone);
        }

    }
}
