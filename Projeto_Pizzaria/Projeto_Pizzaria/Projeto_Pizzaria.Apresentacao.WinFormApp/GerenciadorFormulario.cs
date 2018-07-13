using System.Windows.Forms;

namespace Projeto_Pizzaria.Apresentacao.WinFormApp
{
    public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();

        public abstract UserControl CarregarListagem();

        public abstract string ObtemTipoCadastro();

        public abstract void Excluir();

        public abstract void Editar();

        public abstract void AtualizarLista();
    }
}
