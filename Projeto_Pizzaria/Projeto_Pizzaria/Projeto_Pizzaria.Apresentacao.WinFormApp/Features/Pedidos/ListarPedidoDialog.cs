using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos
{
    public partial class ListarPedidoDialog : Form
    {
        Pedido PedidoSelecionado;
        PedidoService _pedidoService;
        public ListarPedidoDialog(PedidoService pedidoService)
        {
            InitializeComponent();
            IncializarVisualizacaoDaTela();
            _pedidoService = pedidoService;
        }

        private void IncializarVisualizacaoDaTela()
        {
            lblCpfValor.Text = "";
            lblDepartamentoValor.Text = "";
            lblEnderecoValor.Text = "";
            lblNomeValor.Text = "";
            lblResponsavelValor.Text = "";
            lblResponsavel.Text = "";
            lblStatusValor.Text = "";
            lblTelefoneValor.Text = "";
            lblTipoDePagamentoValor.Text = "";
            lblValor.Text = "";
            lblDepartamento.Text = "";
            lblNotaFiscal.Text = "";
        }

        public void CarregarPedidos(List<Pedido> pedidos)
        {
            listPedidos.DataSource = pedidos;
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PedidoSelecionado = listPedidos.SelectedItem as Pedido;
        }

        private void listPedidos_DoubleClick(object sender, EventArgs e)
        {
            CarregarLabelsEListarProdutos();
        }

        private void CarregarLabelsEListarProdutos()
        {
            lblCpfValor.Text = PedidoSelecionado.Cliente.Documento.NumeroDoDocumento;
            lblDepartamentoValor.Text = PedidoSelecionado.Cliente.Documento.EpessoaJuridica ? PedidoSelecionado.Departamento : "";
            lblEnderecoValor.Text = PedidoSelecionado.Cliente.Endereco.ToString();
            lblNomeValor.Text = PedidoSelecionado.Cliente.Nome;
            lblResponsavelValor.Text = PedidoSelecionado.Cliente.Documento.EpessoaJuridica ? PedidoSelecionado.Responsavel : "";
            lblResponsavel.Text = PedidoSelecionado.Cliente.Documento.EpessoaJuridica ? "Resposavel: " : "";
            lblStatusValor.Text = PedidoSelecionado.StatusEnum.ToString();
            lblTelefoneValor.Text = PedidoSelecionado.Cliente.Telefone;
            lblTipoDePagamentoValor.Text = PedidoSelecionado.FormaPagamentoEnum.ToString();
            
            lblValor.Text = PedidoSelecionado.ValorTotal.ToString();
            lblDepartamento.Text = PedidoSelecionado.Cliente.Documento.EpessoaJuridica ? "Departamento: " : "";
            lblNotaFiscal.Text = PedidoSelecionado.EmitirNotaFiscal ? "Necessita a nota fiscal" : "Não precisa da nota fiscal";
            listProdutos.DataSource = PedidoSelecionado.ItensDoPedido;
            if (StatusEnum.PedidoEntregue == PedidoSelecionado.StatusEnum)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StatusEnum.PedidoEntregue == PedidoSelecionado.StatusEnum)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                PedidoSelecionado.StatusEnum++;
                lblStatusValor.Text = PedidoSelecionado.StatusEnum.ToString();
                if (StatusEnum.PedidoEntregue == PedidoSelecionado.StatusEnum)
                {
                    button1.Enabled = false;
                }
            }
            _pedidoService.Update(PedidoSelecionado);
        }
    }
}
