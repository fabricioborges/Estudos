using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes;
using Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos;
using Projeto_Pizzaria.Dominio;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos
{
    public partial class RealizarPedidoDialog : Form
    {
        ClienteService _clienteService;
        ProdutoService _produtoService;
        PedidoService _pedidoService;
        ItemPedido _itemPedidoSelecionado;
        Pedido _pedido;
        GerenciadorFormulario _gerenciadorFormulario;

        public RealizarPedidoDialog()
        {
            InitializeComponent();
        }
        public RealizarPedidoDialog(ClienteService clienteService, ProdutoService produtoService, PedidoService pedidoService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _produtoService = produtoService;
            _pedidoService = pedidoService;
            PopularOsComboBoxes();
        }

        private void PopularOsComboBoxes()
        {
            cmbCliente.DataSource = _clienteService.GetAll();
            cmbTipoProduto.DataSource = Enum.GetNames(typeof(TipoProdutoEnum));
            cmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamentoEnum));
            PopularComboBoxTamanho();
        }

        private void PopularComboBoxTamanho()
        {
            cmbTamanho.Items.Clear();
            cmbTamanho.Items.Add(TamanhoEnum.Pequeno.ToString());
            cmbTamanho.Items.Add(TamanhoEnum.Medio.ToString());
            cmbTamanho.Items.Add(TamanhoEnum.Grande.ToString());
            cmbTamanho.SelectedIndex = 0;
        }

        public Pedido Pedido
        {
            get
            {
                Pedido pedido = new Pedido();
                pedido.Cliente = (Cliente)cmbCliente.SelectedItem;

                pedido.Departamento = txtDepartamento.Text;
                pedido.Responsavel = txtResponsavel.Text;

                pedido.ItensDoPedido = listProdutos.Items.Cast<ItemPedido>().ToList();
                pedido.EmitirNotaFiscal = chkEmitirNota.Checked;
                pedido.FormaPagamentoEnum = (FormaPagamentoEnum)cmbFormaPagamento.SelectedIndex;
                pedido.StatusEnum = StatusEnum.AguardandoMontagem;
                pedido.CalcularPrecoTotalPedido();
                return pedido;
            }
            set
            {
                //_pedido = value;

                ////cliente
                //txtNome.Text = _cliente.Nome;
                //txtTelefone.Text = _cliente.Telefone;

                ////Endereco
                //txtBairro.Text = _cliente.Endereco.Bairro;
                //txtRua.Text = _cliente.Endereco.Rua;
                //txtNumero.Text = _cliente.Endereco.Numero.ToString();
                //txtEstado.Text = _cliente.Endereco.Estado;
                //txtCEP.Text = _cliente.Endereco.CEP;
            }
        }
        private void RealizarPedidoDialog_Load(object sender, EventArgs e)
        {

        }

        private void cmbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var pizzas = _produtoService.GetAllPizza();
            cmbSabor1.DataSource = _produtoService.GetAllPizza();
            cmbSabor2.DataSource = _produtoService.GetAllPizza();
            cmbSabor2.SelectedIndex = -1;
            cmbAdicional.DataSource = _produtoService.GetAllAdicional();
            cmbAdicional.SelectedIndex = -1;
            AtualizarValorUnitarioProduto();
        }

        private void AtualizarValorUnitarioProduto()
        {
            lblValoUnitario.Text = "0.00";
            if (cmbSabor1.Items.Count > 0)
            {
                var itemSelecionado = (TipoProdutoEnum)cmbTipoProduto.SelectedIndex;
                switch (itemSelecionado)
                {
                    case TipoProdutoEnum.Pizza:

                        _itemPedidoSelecionado = CriarProduto(cmbSabor1.SelectedItem as Pizza);

                        break;
                    case TipoProdutoEnum.Calzone:

                        _itemPedidoSelecionado = CriarProduto(cmbSabor1.SelectedItem as Calzone);

                        break;
                    case TipoProdutoEnum.Bebida:

                        _itemPedidoSelecionado = CriarProduto(cmbSabor1.SelectedItem as Bebida);

                        break;
                    default:
                        break;
                }

                lblValoUnitario.Text = _itemPedidoSelecionado.ValorTotalDeUmProduto.ToString();
            }
        }

        private ItemPedido CriarProduto(Produto produtoSabor)
        {
            ItemPedido produtoItem = new ItemPedido();

            

            if (produtoSabor is Pizza)
            {
                Pizza pizza = produtoSabor as Pizza;
                pizza.TamanhoEnum = (TamanhoEnum)Enum.Parse(typeof(TamanhoEnum), cmbTamanho.SelectedItem.ToString());
                if (cmbSabor2.SelectedIndex != -1)
                {
                    var sabor2 = cmbSabor2.SelectedItem as Pizza;
                    produtoItem.Sabor2 = sabor2;
                   
                }
                produtoItem.Adicional = cmbAdicional.SelectedItem as Adicional;
                produtoItem.Ordem = listProdutos.Items.Count;
                produtoSabor = pizza;
            }

            produtoItem.Produto = produtoSabor;

            produtoItem.Quantidade = Convert.ToInt32(nupQuantidade.Value);
            produtoItem.CalcularValorItemPedido();
            return produtoItem;
        }

        private void cmbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCamposDeProduto();
        }

        private void AtualizarCamposDeProduto()
        {
            var itemSelecionado = (TipoProdutoEnum)cmbTipoProduto.SelectedIndex;

            cmbSabor1.DataSource = new List<String>();
            cmbAdicional.DataSource = new List<String>();
            cmbSabor2.DataSource = new List<String>();
            cmbSabor2.SelectedIndex = -1;
            cmbAdicional.SelectedIndex = -1;


            switch (itemSelecionado)
            {
                case TipoProdutoEnum.Pizza:
                    HabilitarCampos();
                    lblSabor1.Text = "Sabor 1";

                    PopularComboBoxTamanho();
                    break;

                case TipoProdutoEnum.Calzone:

                    lblSabor1.Text = "Sabor";
                    DesabilitarCampos();

                    cmbSabor1.DataSource = _produtoService.GetAllCalzone();
                    break;
                case TipoProdutoEnum.Bebida:

                    lblSabor1.Text = "Sabor";
                    DesabilitarCampos();

                    cmbSabor1.DataSource = _produtoService.GetAllBebida();
                    break;
                default:
                    break;
            }

            AtualizarValorUnitarioProduto();
        }

        private void DesabilitarCampos()
        {
            cmbTamanho.Visible = false;
            lblTamanho.Visible = false;

            cmbSabor1.Visible = true;

            cmbSabor2.Visible = false;
            lblSabor2.Visible = false;
            chkSabor2.Visible = false;
            chkAdicional.Visible = false;

            cmbAdicional.Visible = false;
            lblAdicional.Visible = false;
        }

        private void HabilitarCampos()
        {
            cmbTamanho.Visible = true;
            lblTamanho.Visible = true;

            cmbSabor1.Visible = true;

            cmbSabor2.Visible = true;
            lblSabor2.Visible = true;
            chkSabor2.Visible = true;
            chkAdicional.Visible = true;

            cmbAdicional.Visible = true;
            lblAdicional.Visible = true;
        }

        private void cmbSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorUnitarioProduto();
        }

        private void cmbSabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorUnitarioProduto();
        }

        private void cmbAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorUnitarioProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Add(_itemPedidoSelecionado);

            AtualizarValorTotal();
        }

        private void AtualizarValorTotal()
        {
            double valor = 0.0;

            foreach (var item in listProdutos.Items)
            {
                var produto = item as ItemPedido;
                valor += produto.ValorTotalDeUmProduto;
            }

            lblValor.Text = valor.ToString();
        }

        private void nupQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValorUnitarioProduto();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteSelecionado = cmbCliente.SelectedItem as Cliente;
            lblNomeValor.Text = clienteSelecionado.Nome;
            lblTelefoneValor.Text = clienteSelecionado.Telefone;
            lblEnderecoValor.Text = clienteSelecionado.Endereco.Rua + " " + clienteSelecionado.Endereco.Numero;
            txtDocumento.Text = clienteSelecionado.Documento.NumeroDoDocumento;
            txtDepartamento.Text = "";
            txtResponsavel.Text = "";
            txtDepartamento.Enabled = clienteSelecionado.Documento.EpessoaJuridica;
            txtResponsavel.Enabled = txtDepartamento.Enabled;
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedItem != null)
            {
                listProdutos.Items.Remove(listProdutos.SelectedItem);
                AtualizarValorTotal();
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            _pedido = Pedido;

            try
            {
                if (!string.IsNullOrEmpty(txtDocumento.Text))
                {
                    _pedido.Cliente.Documento = txtDocumento.Text;
                    _clienteService.Update(_pedido.Cliente);

                }
                _pedidoService.Add(_pedido);
                MessageBox.Show("Pedido feito com sucesso!!!!!!!!!!!!!!!!!!!!!");
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }

        private void chkSabor2_CheckedChanged(object sender, EventArgs e)
        {
            cmbSabor2.Enabled = !cmbSabor2.Enabled;
            cmbSabor2.SelectedIndex = -1;
        }

        private void chkAdicional_CheckedChanged(object sender, EventArgs e)
        {
            cmbAdicional.Enabled = !cmbAdicional.Enabled;
            cmbAdicional.SelectedIndex = -1;
        }
        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void Pesquisar_TextChanged(object sender, EventArgs e)
        {
            LimparCamposDoCliente();
            ProcurarClientePorTelefone();
        }

        private void ProcurarClientePorTelefone()
        {
            var listCliente = _clienteService.GetByTelefone(txctPesquisarClientePorTelefone.Text);
            cmbCliente.DataSource = listCliente;
        }

        private void LimparCamposDoCliente()
        {
            lblNomeValor.Text = "";
            lblTelefoneValor.Text = "";
            lblEnderecoValor.Text = "";
            txtDocumento.Text = "";
            txtDepartamento.Text = "";
            txtResponsavel.Text = "";
            txtDepartamento.Enabled = false;
            txtResponsavel.Enabled = false;
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            ListarPedidoDialog realizarPedidoDialog = new ListarPedidoDialog(_pedidoService);
            realizarPedidoDialog.CarregarPedidos(_pedidoService.GetAll());
            realizarPedidoDialog.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _gerenciadorFormulario = new ClienteGerenciadorFormulario(_clienteService);
            _gerenciadorFormulario.Adicionar();
            cmbCliente.DataSource = _clienteService.GetAll();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            _gerenciadorFormulario = new ProdutoGerenciadorFormulario(_produtoService);
            _gerenciadorFormulario.Adicionar();
            AtualizarCamposDeProduto();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarClienteDialog listarClienteDialog = new ListarClienteDialog();
            listarClienteDialog.CarregarPedidos(_clienteService.GetAll());
            listarClienteDialog.ShowDialog();
        }

        private void brnListProdutos_Click(object sender, EventArgs e)
        {
            ListarProdutosDialog listarProdutosDialog = new ListarProdutosDialog();
            listarProdutosDialog.CarregarProdutos(_produtoService.GetAll());
            listarProdutosDialog.ShowDialog();
        }
    }
}