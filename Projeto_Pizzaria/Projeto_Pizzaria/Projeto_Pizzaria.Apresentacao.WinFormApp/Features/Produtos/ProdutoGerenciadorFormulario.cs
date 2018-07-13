using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.Dominio.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos
{
    public class ProdutoGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly ProdutoService _produtoService;

        private ProdutoControl _produtoControl;

        public ProdutoGerenciadorFormulario(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public override void Adicionar()
        {
            CadastroProdutoDialog produtoDialog = new CadastroProdutoDialog();

            DialogResult resultado = produtoDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _produtoService.Add(produtoDialog.produto);
                ListarProduto();
            }
        }

        private void ListarProduto()
        {
            //IList<Produto> produtos = _produtoService.GetAll();


            //_produtoControl.PopularListagemProdutos(produtos);
        }

        public override void AtualizarLista()
        {
            ListarProduto();
        }

        public override UserControl CarregarListagem()
        {
            if (_produtoControl == null)
                _produtoControl = new ProdutoControl(_produtoService);

            return _produtoControl;
        }

        public override void Editar()
        {
            Produto produtoSelecionado = _produtoControl.ObtemProdutoSelecionado();

            if (produtoSelecionado != null)
            {
                CadastroProdutoDialog dialog = new CadastroProdutoDialog();
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _produtoService.Update(produtoSelecionado);
                }

                ListarProduto();
            }
            else
            {
                MessageBox.Show("Selecione um Produto!");
            }
        }

        public override void Excluir()
        {
            Produto produtoSelecionado = _produtoControl.ObtemProdutoSelecionado();
            if (produtoSelecionado != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse Produto "
                    + produtoSelecionado.Nome, "Excluir Produto",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _produtoService.delete(produtoSelecionado);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    ListarProduto();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Produto";
        }
    }
}
