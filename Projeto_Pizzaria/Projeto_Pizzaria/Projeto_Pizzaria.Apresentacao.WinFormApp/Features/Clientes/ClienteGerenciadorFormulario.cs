using Projeto_Pizzaria.Aplicacao.Features.Clientes;
using Projeto_Pizzaria.Dominio.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes
{
    public class ClienteGerenciadorFormulario : GerenciadorFormulario
    {
        private readonly ClienteService _ClienteService;

        private ClienteControl _ClienteControl;

        public ClienteGerenciadorFormulario(ClienteService clienteService)
        {
            _ClienteService = clienteService;
        }

        public override void Adicionar()
        {
            CadastrarClienteDialog clienteDialog = new CadastrarClienteDialog();

            DialogResult resultado = clienteDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _ClienteService.Add(clienteDialog.Cliente);

            }
        }

        private void ListarCliente()
        {

        }

        //TODO: ANALISAR NOME
        public override UserControl CarregarListagem()
        {
            if (_ClienteControl == null)
                _ClienteControl = new ClienteControl(_ClienteService);

            return _ClienteControl;
        }

        public override void Excluir()
        {
            Cliente clienteSelecionada = _ClienteControl.ObtemClienteSelecionada();

            if (clienteSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a Cliente "
                    + clienteSelecionada.Nome, "Excluir Cliente",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        _ClienteService.delete(clienteSelecionada);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                    ListarCliente();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente!");
            }
        }

        public override void Editar()
        {
            Cliente clienteSelecionada = _ClienteControl.ObtemClienteSelecionada();

            if (clienteSelecionada != null)
            {
                CadastrarClienteDialog dialog = new CadastrarClienteDialog(clienteSelecionada);
                DialogResult resultado = dialog.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _ClienteService.Update(clienteSelecionada);
                }

                ListarCliente();
            }
            else
            {
                MessageBox.Show("Selecione um Cliente!");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Cliente";
        }

        public override void AtualizarLista()
        {
            ListarCliente();
        }

    }
}