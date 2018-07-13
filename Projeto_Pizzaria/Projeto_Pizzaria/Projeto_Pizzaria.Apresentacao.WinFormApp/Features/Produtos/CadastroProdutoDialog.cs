using Projeto_Pizzaria.Dominio;
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
    public partial class CadastroProdutoDialog : Form
    {
        private Produto _produto;
        private ProdutoEnum _tipoProduto;

        public CadastroProdutoDialog()
        {
            InitializeComponent();
            popularComboBox();
        }

        public void popularComboBox()
        {
            cbxTipoPizza.DataSource = Enum.GetNames(typeof(TipoPizzaEnum));
        }
        public Produto produto
        {
            get
            {
                switch (_tipoProduto)
                {
                    case ProdutoEnum.Pizza:
                        return MontarPizza();
                    case ProdutoEnum.Calzone:
                        return MontarCalzone();
                    case ProdutoEnum.Bebida:
                        return MontarBebida();
                    default:
                        throw new Exception();
                }
            }
            set
            {
                produto = value;
                switch (produto.TipoDoProduto)
                {
                    case ProdutoEnum.Pizza:
                        SetarCamposDaPizza();
                        break;
                    case ProdutoEnum.Calzone:
                        SetarCamposDoCalzone();
                        break;
                    case ProdutoEnum.Bebida:
                        SetarCamposDaBebida();
                        break;
                }
            }
        }

        private void SetarCamposDaPizza()
        {
            Pizza pizza = produto as Pizza;
            tabControl.SelectedTab = TabPizza;
            txtNomePizza.Text = pizza.Nome;
            txtValorPequenaPizza.Text = pizza.ValorPequeno.ToString();
            txtMediaPizza.Text = pizza.ValorMedio.ToString();
            txtGrandePizza.Text = pizza.ValorGrande.ToString();
            cbxTipoPizza.SelectedIndex = (int)pizza.TipoPizzaEnum;
            _produto = pizza;
        }

        private void SetarCamposDoCalzone()
        {
            Calzone calzone = produto as Calzone;
            tabControl.SelectedTab = tabCalzone;
            txtCalzoneNome.Text = calzone.Nome;
            txtCalzoneValor.Text = calzone.Valor.ToString();
            _produto = calzone;
        }

        private void SetarCamposDaBebida()
        {
            Bebida bebida = produto as Bebida;
            tabControl.SelectedTab = tabBebida;
            txtBebidaNome.Text = bebida.Nome;
            txtBebidaValor.Text = bebida.Valor.ToString();
            _produto = bebida;
        }
        private Produto MontarPizza()
        {
            return new Pizza
            {
                Nome = txtNomePizza.Text,
                Valor = Convert.ToDouble(txtMediaPizza.Text),
                ValorMedio = Convert.ToDouble(txtMediaPizza.Text),
                ValorPequeno = Convert.ToDouble(txtValorPequenaPizza.Text),
                ValorGrande = Convert.ToDouble(txtGrandePizza.Text),
                TipoPizzaEnum = (TipoPizzaEnum)cbxTipoPizza.SelectedIndex
            };
        }

        private Produto MontarCalzone()
        {
            return new Calzone
            {
                Nome = txtCalzoneNome.Text,
                Valor = Convert.ToDouble(txtCalzoneValor.Text)
            };
        }

        private Produto MontarBebida()
        {
            return new Bebida
            {
                Nome = txtBebidaNome.Text,
                Valor = Convert.ToDouble(txtBebidaValor.Text)
            };
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl.SelectedTab == tabCalzone)
                _tipoProduto = ProdutoEnum.Calzone;
            if (tabControl.SelectedTab == tabBebida)
                _tipoProduto = ProdutoEnum.Bebida;
            if (tabControl.SelectedTab == TabPizza)
                _tipoProduto = ProdutoEnum.Pizza;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _produto = produto;

            try
            {
                _produto.Validar();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
