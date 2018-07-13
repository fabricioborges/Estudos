using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.Dominio.Features.Produtos;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos
{
    public partial class ProdutoControl : UserControl
    {
        ProdutoService _produtoService;

        public ProdutoControl(ProdutoService produtoService)
        {
            InitializeComponent();
            _produtoService = produtoService;
        }

        public void PopularListagemProdutos(IList<Produto> produto)
        {
            
            listProdutos.Items.Clear();

            foreach (Produto item in produto)
            {
                listProdutos.Items.Add(item);
            }
        }

        public Produto ObtemProdutoSelecionado()
        {
            return (Produto)listProdutos.SelectedItem;
        }

        private void listProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
