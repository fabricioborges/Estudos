using Projeto_Pizzaria.Dominio.Features.Clientes;
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
    public partial class ListarClienteDialog : Form
    {

        Cliente _clienteSelecionado;
        public ListarClienteDialog()
        {
            InitializeComponent();
            IncializarVisualizacaoDaTela();
        }

        public void CarregarPedidos(List<Cliente> clientes)
        {
            listClientes.DataSource = clientes;
        }

        private void IncializarVisualizacaoDaTela()
        {
            lblNomeValor.Text = "";
            lblTelefoneValor.Text = "";
            lblEnderecoValor.Text = "";
            lblDocumentoValor.Text = "";         
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clienteSelecionado = listClientes.SelectedItem as Cliente;
        }

        private void CarregarLabelsEListarProdutos()
        {
            lblNomeValor.Text = _clienteSelecionado.Nome;
            lblTelefoneValor.Text = _clienteSelecionado.Telefone;
            lblEnderecoValor.Text = _clienteSelecionado.Endereco.ToString();
            lblDocumentoValor.Text = _clienteSelecionado.Documento.NumeroDoDocumento;
        }


        private void listClientes_DoubleClick(object sender, EventArgs e)
        {
            CarregarLabelsEListarProdutos();
        }
    }
}
