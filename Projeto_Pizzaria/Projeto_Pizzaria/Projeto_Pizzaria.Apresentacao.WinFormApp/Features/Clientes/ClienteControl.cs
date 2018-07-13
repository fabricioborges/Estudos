using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using Projeto_Pizzaria.Aplicacao.Features.Clientes;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private ClienteService _clienteService;

        public ClienteControl(ClienteService disciplinaService)
        {

            InitializeComponent();

            _clienteService = disciplinaService;

        }

        public void PopularListagemClientes(IList<Cliente> cliente)
        {
            listCliente.Items.Clear();

            foreach (Cliente item in cliente)
            {
                listCliente.Items.Add(item);
            }
        }

        public Cliente ObtemClienteSelecionada()
        {
            return (Cliente)listCliente.SelectedItem;
        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
