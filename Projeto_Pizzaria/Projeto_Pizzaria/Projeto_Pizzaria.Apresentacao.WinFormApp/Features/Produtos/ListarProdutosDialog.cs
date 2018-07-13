using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos
{
    public partial class ListarProdutosDialog : Form
    {
        Produto ProdutoSelecionado;
        public ListarProdutosDialog()
        {
            InitializeComponent();
            IncializarVisualizacaoDaTela();
        }

        public void CarregarProdutos(List<Produto> produtos)
        {
            listProdutos.DataSource = produtos;
        }

        private void IncializarVisualizacaoDaTela()
        {
            lblNomeValor.Text = "";
            lblValorValor.Text = "";
            lblTamanhoPequenoValor.Text = "";
            lblTamanhoMedioValor.Text = "";
            lblTamanhoGrandeValor.Text = "";
            lblTipoPizzaValor.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoSelecionado = listProdutos.SelectedItem as Produto;
         
        }

        private void listProdutos_DoubleClick(object sender, EventArgs e)
        {
            CarregarLabelsEListarProdutos();
            DesabilitarLabelsConformeProduto();
        }

        private void DesabilitarLabelsConformeProduto()
        {
            if (ProdutoSelecionado is Pizza)
            {
                lblValor.Visible = false;
                lblValorValor.Visible = false;

                lblTamanhoPequenoValor.Visible = true;
                lblTamanhoPequeno.Visible = true;

                lblTamanhoMedioValor.Visible = true;
                lblTamanhoMedio.Visible = true;

                lblTamanhoGrandeValor.Visible = true;
                lblTamanhoGrande.Visible = true;

                lblTipoPizzaValor.Visible = true;
                lblTipoPizza.Visible = true;

            }
            else
            {
                lblValor.Visible = true;
                lblValorValor.Visible = true;

                lblTamanhoPequenoValor.Visible = false;
                lblTamanhoPequeno.Visible = false;

                lblTamanhoMedioValor.Visible = false;
                lblTamanhoMedio.Visible = false;

                lblTamanhoGrandeValor.Visible = false;
                lblTamanhoGrande.Visible = false;

                lblTipoPizzaValor.Visible = false;
                lblTipoPizza.Visible = false;
            }
        }

        private void CarregarLabelsEListarProdutos()
        {
            lblNomeValor.Text = ProdutoSelecionado.Nome;
            lblValorValor.Text = ProdutoSelecionado.Valor.ToString();
            if (ProdutoSelecionado is Pizza)
            {
                var pizza = ProdutoSelecionado as Pizza;

               lblTamanhoPequenoValor.Text = pizza.ValorPequeno.ToString();
               lblTamanhoMedioValor.Text = pizza.ValorMedio.ToString();
               lblTamanhoGrandeValor.Text = pizza.ValorGrande.ToString();
               lblTipoPizzaValor.Text = pizza.TipoPizzaEnum.ToString();
            }     
        }
    }
}
