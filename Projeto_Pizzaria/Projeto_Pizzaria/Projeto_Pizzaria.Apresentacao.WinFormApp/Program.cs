using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.Aplicacao.Features.Pedidos;
using Projeto_Pizzaria.Aplicacao.Features.Produtos;
using Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos;
using Projeto_Pizzaria.Infra.Contexts;
using Projeto_Pizzaria.Infra.Features.Pedidos;
using Projeto_Pizzaria.InfraDados.Features.Clientes;
using Projeto_Pizzaria.InfraDados.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp
{
    static class Program
    {
        private static ClienteRepository _clienteRepository;
        private static ProdutoRepository _produtoRepository;
        private static PedidoRepository _pedidoRepository;
        private static ClienteService _clienteService;
        private static ProdutoService _produtoService;
        private static PedidoService _pedidoService;
        private static PizzariaContext _pizzariaContext;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _pizzariaContext = new PizzariaContext();
            _clienteRepository = new ClienteRepository(_pizzariaContext);
            _produtoRepository = new ProdutoRepository(_pizzariaContext);
            _pedidoRepository = new PedidoRepository(_pizzariaContext);
            _clienteService = new ClienteService(_clienteRepository);
            _pedidoService = new PedidoService(_pedidoRepository);
            _produtoService = new ProdutoService(_produtoRepository);

            Application.Run(new RealizarPedidoDialog(_clienteService, _produtoService, _pedidoService));
        }
        
    }
}
