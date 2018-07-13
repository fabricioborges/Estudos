using FluentAssertions;
using NUnit.Framework;
using Projeto_Pizzaria.Dominio.Features.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pizzaria.Dominio.Teste.Features.Documentos
{
    public class DocumentoTeste
    {
        NumeroDocumento NumeroDoDocumento;
        string CnpjValido;
        string CpfValido1;
        string CpfValido2;
        [SetUp]
        public void Set()
        {
            CnpjValido = "60.353.014/0001-10";
            CpfValido1 = "111.111.112-00";
            CpfValido2 = "078.463.799-76";
            NumeroDoDocumento = new NumeroDocumento();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_string_para_CPF_OK()
        {
            //Arrange - Action 
            Action testePrimeiroCPF = () => NumeroDoDocumento = CpfValido1;
            Action testeSegundoCPF = () => NumeroDoDocumento = CpfValido2;

            //Assert
            testePrimeiroCPF.Should().NotThrow<Exception>();
            testeSegundoCPF.Should().NotThrow<Exception>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_CPF_para_string_OK()
        {
            //Arrange
            NumeroDoDocumento = CpfValido1;

            //Action 
            string teste = (string)NumeroDoDocumento;

            //Assert
            teste.Should().Be(CpfValido1);
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_string_para_CNPJ_OK()
        {

            //Arrange - Action
            Action testeCNPJ = () => NumeroDoDocumento = CnpjValido;

            //Assert
            testeCNPJ.Should().NotThrow<Exception>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_CNPJ_para_string_OK()
        {

            //Arrange
            NumeroDoDocumento = CnpjValido;

            //Action 
            string teste = (string)NumeroDoDocumento;

            //Assert
            teste.Should().Be(CnpjValido);
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCPFComLetras_DeveJogarException()
        {

            //Arrange
            string cpfInvalido = "asdasdasdasdas";

            //Action 
            Action alvo = () => NumeroDoDocumento = cpfInvalido;

            //Assert
            alvo.Should().Throw<CPFInvalidoPossuiLetrasOuForaDePadraoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringInvalida_StringVazia_DeveJogarException()
        {
            //Arrange
            string numeroDeDocumentoInvalido = "";

            //Action 
            Action alvo = () => NumeroDoDocumento = numeroDeDocumentoInvalido;

            //Assert
            alvo.Should().Throw<NumeroDocumentoVazioOuNuloException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringComTodosOsNumerosIguais_DeveJogarException()
        {
            //Arrange
            string cpfInvalido = "111.111.111-11";

            //Action 
            Action alvo = () => NumeroDoDocumento = cpfInvalido;

            //Assert
            alvo.Should().Throw<NumeroDoDocumentoInvalido>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCPFComCaracterEspecial_DeveJogarException()
        {

            //Arrange
            string cpfInvalido = "078.473.799=76";

            //Action
            Action alvo = () => NumeroDoDocumento = cpfInvalido;

            //Assert
            alvo.Should().Throw<CPFInvalidoPossuiLetrasOuForaDePadraoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCPFInvalido_DeveJogarException()
        {

            //Arrange
            string cpfInvalido = "078.473.799-79";

            //Action
            Action alvo = () => NumeroDoDocumento = cpfInvalido;

            //Assert
            alvo.Should().Throw<CPFInvalidoValorInvalidoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCNPJComLetra_DeveJogarException()
        {
            //Arrange
            string cnpjInvalido = "asdasdasdasdasdasd";

            //Action
            Action alvo = () => NumeroDoDocumento = cnpjInvalido;

            //Assert
            alvo.Should().Throw<CNPJInvalidoPossuiLetrasOuForaDePadraoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCNPJComCaracterEspecial_DeveJogarException()
        {
            //Arrange
            string cnpjInvalido = "60.353.014/0001@10";

            //Action
            Action alvo = () => NumeroDoDocumento = cnpjInvalido;

            //Assert
            alvo.Should().Throw<CNPJInvalidoPossuiLetrasOuForaDePadraoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringCNPJinvalido_DeveJogarException()
        {
            //Arrange
            string cnpjInvalido = "60.353.014/0001-11";

            //Action
            Action alvo = () => NumeroDoDocumento = cnpjInvalido;

            //Assert
            alvo.Should().Throw<CNPJInvalidoValorInvalidoException>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_Converter_StringComNumerosInvalidos_DeveJogarException()
        {
            //Arrange
            string cnpjInvalido = "123";

            //Action
            Action alvo = () => NumeroDoDocumento = cnpjInvalido;

            //Assert
            alvo.Should().Throw<NumeroDoDocumentoInvalido>();
        }
        [Test]
        public void Dominio_NumeroDeDocumento_DescobrirTipoDeDocumento_Deve_Retornar_CPF_Quando_O_Objeto_Possui_Um_CPF()
        {
            //Arrange
            NumeroDoDocumento = CpfValido1;
            //Action
            var stringTestCPF = NumeroDoDocumento.DescobrirTipoDeDocumento();
            //Assert
            stringTestCPF.Should().Be("CPF");
        }
        [Test]
        public void Dominio_NumeroDeDocumento_DescobrirTipoDeDocumento_Deve_Retornar_CNPJ_Quando_O_Objeto_Possui_Um_CNPJ()
        {
            //Arrange
            NumeroDoDocumento = CnpjValido;
            //Action
            var stringTestCNPJ = NumeroDoDocumento.DescobrirTipoDeDocumento();
            //Assert
            stringTestCNPJ.Should().Be("CNPJ");
        }
    }
}
