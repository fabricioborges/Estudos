using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes
{
    public partial class CadastrarClienteDialog : Form
    {
        private Cliente _cliente;

        public Cliente Cliente
        {
            get {
                //cliente
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Telefone = txtTelefone.Text;

                //Endereco
                cliente.Endereco = new Endereco();
                cliente.Endereco.Bairro = txtBairro.Text;
                cliente.Endereco.Rua = txtRua.Text;
                cliente.Endereco.Numero = int.Parse(txtNumero.Text);
                cliente.Endereco.Estado = txtEstado.Text;
                cliente.Endereco.CEP = txtCEP.Text;
                return cliente;
            }
            set
            {
                _cliente = value;
                
                //cliente
                txtNome.Text = _cliente.Nome;
                txtTelefone.Text = _cliente.Telefone;

                //Endereco
                txtBairro.Text = _cliente.Endereco.Bairro;
                txtRua.Text = _cliente.Endereco.Rua;
                txtNumero.Text = _cliente.Endereco.Numero.ToString();
                txtEstado.Text = _cliente.Endereco.Estado;
                txtCEP.Text = _cliente.Endereco.CEP;
            }
        }

        public CadastrarClienteDialog()
        {
            InitializeComponent();
        }

        public CadastrarClienteDialog(Cliente clienteSelecionada)
        {
            InitializeComponent();

            Cliente = clienteSelecionada;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                _cliente = new Cliente();
            }

            _cliente = Cliente;

            try
            {
                _cliente.Validar();
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
