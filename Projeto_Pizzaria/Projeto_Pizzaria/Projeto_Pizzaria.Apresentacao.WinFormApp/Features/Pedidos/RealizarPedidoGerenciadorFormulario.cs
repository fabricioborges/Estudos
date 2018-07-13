using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.Dominio.Features.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos
{
    public class PedidoGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly PedidoService _PedidoService;
        private readonly ClienteService _ClienteService;
        private readonly ProdutoService _ProdutoService;

        public PedidoGerenciadorFormulario(PedidoService pedidoService, ClienteService clienteService, ProdutoService produtoService)
        {
            _PedidoService = pedidoService;
            _ClienteService = clienteService;
            _ProdutoService = produtoService;
        }

        public override void Adicionar()
        {
            RealizarPedidoDialog pedidoDialog = new RealizarPedidoDialog(_ClienteService,_ProdutoService,_PedidoService);

            DialogResult resultado = pedidoDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _PedidoService.Add(pedidoDialog.Pedido);
                ListarPedido();
            }
        }

        private void ListarPedido()
        {
            //IList<Pedido> pedidos = _PedidoService.GetAll();

            //_PedidoControl.PopularListagemPedidos(pedidos);
        }

        //TODO: ANALISAR NOME
        public override UserControl CarregarListagem()
        {
            //if (_PedidoControl == null)
            //    _PedidoControl = new PedidoControl(_PedidoService);

            return null;
        }

        public override void Excluir()
        {
            //Pedido pedidoSelecionada = _PedidoControl.ObtemPedidoSelecionada();

            //if (pedidoSelecionada != null)
            //{
            //    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a Pedido "
            //        + pedidoSelecionada.Nome, "Excluir Pedido",
            //        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (resultado == DialogResult.OK)
            //    {
            //        try
            //        {
            //            _PedidoService.delete(pedidoSelecionada);
            //        }
            //        catch (Exception e)
            //        {
            //            MessageBox.Show(e.Message);
            //        }

            //        ListarPedido();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um Pedido!");
            //}
        }

        public override void Editar()
        {
            //Pedido pedidoSelecionada = _PedidoControl.ObtemPedidoSelecionada();

            //if (pedidoSelecionada != null)
            //{
            //    RealizarPedidoDialog dialog = new RealizarPedidoDialog(pedidoSelecionada);
            //    DialogResult resultado = dialog.ShowDialog();

            //    if (resultado == DialogResult.OK)
            //    {
            //        _PedidoService.Update(pedidoSelecionada);
            //    }

            //    ListarPedido();
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um Pedido!");
            //}
        }

        public override string ObtemTipoCadastro()
        {
            return "RealizarPedido";
        }

        public override void AtualizarLista()
        {
         //   ListarPedido();
        }
    }
}
