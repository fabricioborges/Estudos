namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos
{
    partial class RealizarPedidoDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPedidoDialog));
            this.lblValor = new System.Windows.Forms.Label();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAdicional = new System.Windows.Forms.CheckBox();
            this.chkSabor2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmbAdicional = new System.Windows.Forms.ComboBox();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblValoUnitario = new System.Windows.Forms.Label();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.lblSabor1 = new System.Windows.Forms.Label();
            this.cmbTipoProduto = new System.Windows.Forms.ComboBox();
            this.cmbSabor1 = new System.Windows.Forms.ComboBox();
            this.cmbSabor2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblSabor2 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txctPesquisarClientePorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chkEmitirNota = new System.Windows.Forms.CheckBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblEnderecoValor = new System.Windows.Forms.Label();
            this.lblTelefoneValor = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnAddProduto = new System.Windows.Forms.ToolStripButton();
            this.btnListarPedidos = new System.Windows.Forms.ToolStripButton();
            this.btnListarClientes = new System.Windows.Forms.ToolStripButton();
            this.brnListProdutos = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(659, 575);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 17);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "0.00";
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(809, 571);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(209, 23);
            this.btnRealizarPedido.TabIndex = 16;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(577, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdicional);
            this.groupBox1.Controls.Add(this.chkSabor2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nupQuantidade);
            this.groupBox1.Controls.Add(this.cmbAdicional);
            this.groupBox1.Controls.Add(this.lblAdicional);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTamanho);
            this.groupBox1.Controls.Add(this.lblValoUnitario);
            this.groupBox1.Controls.Add(this.cmbTamanho);
            this.groupBox1.Controls.Add(this.lblSabor1);
            this.groupBox1.Controls.Add(this.cmbTipoProduto);
            this.groupBox1.Controls.Add(this.cmbSabor1);
            this.groupBox1.Controls.Add(this.cmbSabor2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblSabor2);
            this.groupBox1.Location = new System.Drawing.Point(491, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(568, 416);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Produto";
            // 
            // chkAdicional
            // 
            this.chkAdicional.AutoSize = true;
            this.chkAdicional.Location = new System.Drawing.Point(508, 263);
            this.chkAdicional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAdicional.Name = "chkAdicional";
            this.chkAdicional.Size = new System.Drawing.Size(18, 17);
            this.chkAdicional.TabIndex = 36;
            this.chkAdicional.UseVisualStyleBackColor = true;
            this.chkAdicional.CheckedChanged += new System.EventHandler(this.chkAdicional_CheckedChanged);
            // 
            // chkSabor2
            // 
            this.chkSabor2.AutoSize = true;
            this.chkSabor2.Location = new System.Drawing.Point(508, 207);
            this.chkSabor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSabor2.Name = "chkSabor2";
            this.chkSabor2.Size = new System.Drawing.Size(18, 17);
            this.chkSabor2.TabIndex = 35;
            this.chkSabor2.UseVisualStyleBackColor = true;
            this.chkSabor2.CheckedChanged += new System.EventHandler(this.chkSabor2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantidade:";
            // 
            // nupQuantidade
            // 
            this.nupQuantidade.Location = new System.Drawing.Point(408, 313);
            this.nupQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQuantidade.Name = "nupQuantidade";
            this.nupQuantidade.Size = new System.Drawing.Size(120, 22);
            this.nupQuantidade.TabIndex = 33;
            this.nupQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQuantidade.ValueChanged += new System.EventHandler(this.nupQuantidade_ValueChanged);
            // 
            // cmbAdicional
            // 
            this.cmbAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicional.Enabled = false;
            this.cmbAdicional.FormattingEnabled = true;
            this.cmbAdicional.Location = new System.Drawing.Point(167, 260);
            this.cmbAdicional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAdicional.Name = "cmbAdicional";
            this.cmbAdicional.Size = new System.Drawing.Size(332, 24);
            this.cmbAdicional.TabIndex = 31;
            this.cmbAdicional.SelectedIndexChanged += new System.EventHandler(this.cmbAdicional_SelectedIndexChanged);
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Location = new System.Drawing.Point(69, 263);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(69, 17);
            this.lblAdicional.TabIndex = 30;
            this.lblAdicional.Text = "Adicional:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Adicionar item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Valor unitario:";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(64, 101);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(72, 17);
            this.lblTamanho.TabIndex = 28;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblValoUnitario
            // 
            this.lblValoUnitario.AutoSize = true;
            this.lblValoUnitario.Location = new System.Drawing.Point(168, 348);
            this.lblValoUnitario.Name = "lblValoUnitario";
            this.lblValoUnitario.Size = new System.Drawing.Size(39, 17);
            this.lblValoUnitario.TabIndex = 31;
            this.lblValoUnitario.Text = "valor";
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Location = new System.Drawing.Point(167, 97);
            this.cmbTamanho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(360, 24);
            this.cmbTamanho.TabIndex = 29;
            this.cmbTamanho.SelectedIndexChanged += new System.EventHandler(this.cmbTamanho_SelectedIndexChanged);
            // 
            // lblSabor1
            // 
            this.lblSabor1.AutoSize = true;
            this.lblSabor1.Location = new System.Drawing.Point(75, 149);
            this.lblSabor1.Name = "lblSabor1";
            this.lblSabor1.Size = new System.Drawing.Size(62, 17);
            this.lblSabor1.TabIndex = 0;
            this.lblSabor1.Text = "Sabor 1:";
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProduto.FormattingEnabled = true;
            this.cmbTipoProduto.Location = new System.Drawing.Point(167, 43);
            this.cmbTipoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Size = new System.Drawing.Size(360, 24);
            this.cmbTipoProduto.TabIndex = 18;
            this.cmbTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProduto_SelectedIndexChanged);
            // 
            // cmbSabor1
            // 
            this.cmbSabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSabor1.FormattingEnabled = true;
            this.cmbSabor1.Location = new System.Drawing.Point(167, 145);
            this.cmbSabor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSabor1.Name = "cmbSabor1";
            this.cmbSabor1.Size = new System.Drawing.Size(360, 24);
            this.cmbSabor1.TabIndex = 25;
            this.cmbSabor1.SelectedIndexChanged += new System.EventHandler(this.cmbSabor1_SelectedIndexChanged);
            // 
            // cmbSabor2
            // 
            this.cmbSabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSabor2.Enabled = false;
            this.cmbSabor2.FormattingEnabled = true;
            this.cmbSabor2.Location = new System.Drawing.Point(167, 203);
            this.cmbSabor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSabor2.Name = "cmbSabor2";
            this.cmbSabor2.Size = new System.Drawing.Size(332, 24);
            this.cmbSabor2.TabIndex = 27;
            this.cmbSabor2.SelectedIndexChanged += new System.EventHandler(this.cmbSabor2_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 17);
            this.label18.TabIndex = 24;
            this.label18.Text = "Tipo do Produto:";
            // 
            // lblSabor2
            // 
            this.lblSabor2.AutoSize = true;
            this.lblSabor2.Location = new System.Drawing.Point(75, 207);
            this.lblSabor2.Name = "lblSabor2";
            this.lblSabor2.Size = new System.Drawing.Size(62, 17);
            this.lblSabor2.TabIndex = 26;
            this.lblSabor2.Text = "Sabor 2:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(809, 502);
            this.cmbFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(208, 24);
            this.cmbFormaPagamento.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo De Pagamento: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txctPesquisarClientePorTelefone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.chkEmitirNota);
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Controls.Add(this.lblEnderecoValor);
            this.groupBox2.Controls.Add(this.lblTelefoneValor);
            this.groupBox2.Controls.Add(this.lblNomeValor);
            this.groupBox2.Controls.Add(this.listProdutos);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.txtResponsavel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Location = new System.Drawing.Point(16, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(467, 642);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pedido";
            // 
            // txctPesquisarClientePorTelefone
            // 
            this.txctPesquisarClientePorTelefone.Location = new System.Drawing.Point(37, 58);
            this.txctPesquisarClientePorTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txctPesquisarClientePorTelefone.Name = "txctPesquisarClientePorTelefone";
            this.txctPesquisarClientePorTelefone.Size = new System.Drawing.Size(363, 22);
            this.txctPesquisarClientePorTelefone.TabIndex = 42;
            this.txctPesquisarClientePorTelefone.TextChanged += new System.EventHandler(this.Pesquisar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Pesquisar Cliente por Telefone:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Remover item selecionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkEmitirNota
            // 
            this.chkEmitirNota.AutoSize = true;
            this.chkEmitirNota.Location = new System.Drawing.Point(37, 242);
            this.chkEmitirNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEmitirNota.Name = "chkEmitirNota";
            this.chkEmitirNota.Size = new System.Drawing.Size(133, 21);
            this.chkEmitirNota.TabIndex = 39;
            this.chkEmitirNota.Text = "Emitir nota fiscal";
            this.chkEmitirNota.UseVisualStyleBackColor = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(135, 367);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(265, 22);
            this.txtDepartamento.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Departamento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(135, 286);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(216, 22);
            this.txtDocumento.TabIndex = 36;
            // 
            // lblEnderecoValor
            // 
            this.lblEnderecoValor.AutoSize = true;
            this.lblEnderecoValor.Location = new System.Drawing.Point(139, 206);
            this.lblEnderecoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoValor.Name = "lblEnderecoValor";
            this.lblEnderecoValor.Size = new System.Drawing.Size(54, 17);
            this.lblEnderecoValor.TabIndex = 35;
            this.lblEnderecoValor.Text = "label17";
            // 
            // lblTelefoneValor
            // 
            this.lblTelefoneValor.AutoSize = true;
            this.lblTelefoneValor.Location = new System.Drawing.Point(139, 167);
            this.lblTelefoneValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneValor.Name = "lblTelefoneValor";
            this.lblTelefoneValor.Size = new System.Drawing.Size(54, 17);
            this.lblTelefoneValor.TabIndex = 34;
            this.lblTelefoneValor.Text = "label13";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(139, 128);
            this.lblNomeValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(54, 17);
            this.lblNomeValor.TabIndex = 33;
            this.lblNomeValor.Text = "label11";
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.HorizontalScrollbar = true;
            this.listProdutos.ItemHeight = 16;
            this.listProdutos.Location = new System.Drawing.Point(7, 416);
            this.listProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(452, 164);
            this.listProdutos.TabIndex = 32;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(33, 289);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(73, 17);
            this.lblCpf.TabIndex = 31;
            this.lblCpf.Text = "CPF/CNPJ";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Location = new System.Drawing.Point(135, 332);
            this.txtResponsavel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(265, 22);
            this.txtResponsavel.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Responsavel:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(33, 206);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 128);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(33, 167);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tel. Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(135, 89);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(265, 24);
            this.cmbCliente.TabIndex = 24;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.TextChanged += new System.EventHandler(this.cmbCliente_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.btnAddProduto,
            this.btnListarPedidos,
            this.btnListarClientes,
            this.brnListProdutos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1075, 27);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 24);
            this.toolStripButton3.Text = "Adicionar Cliente";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.Image")));
            this.btnAddProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(134, 24);
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnListarPedidos
            // 
            this.btnListarPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnListarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnListarPedidos.Image")));
            this.btnListarPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.Size = new System.Drawing.Size(104, 24);
            this.btnListarPedidos.Text = "Listar Pedidos";
            this.btnListarPedidos.Click += new System.EventHandler(this.btnListarPedidos_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnListarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListarClientes.Image")));
            this.btnListarClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(104, 24);
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // brnListProdutos
            // 
            this.brnListProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.brnListProdutos.Image = ((System.Drawing.Image)(resources.GetObject("brnListProdutos.Image")));
            this.brnListProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brnListProdutos.Name = "brnListProdutos";
            this.brnListProdutos.Size = new System.Drawing.Size(111, 24);
            this.brnListProdutos.Text = "Listar Produtos";
            this.brnListProdutos.Click += new System.EventHandler(this.brnListProdutos_Click);
            // 
            // RealizarPedidoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 692);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbFormaPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.lblValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealizarPedidoDialog";
            this.Text = "Realizar Pedido";
            this.Load += new System.EventHandler(this.RealizarPedidoDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAdicional;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblValoUnitario;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Label lblSabor1;
        private System.Windows.Forms.ComboBox cmbTipoProduto;
        private System.Windows.Forms.ComboBox cmbSabor1;
        private System.Windows.Forms.ComboBox cmbSabor2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblSabor2;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.Label lblEnderecoValor;
        private System.Windows.Forms.Label lblTelefoneValor;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.CheckBox chkEmitirNota;
        private System.Windows.Forms.NumericUpDown nupQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkAdicional;
        private System.Windows.Forms.CheckBox chkSabor2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnAddProduto;
        private System.Windows.Forms.ToolStripButton btnListarPedidos;
        private System.Windows.Forms.ToolStripButton btnListarClientes;
        private System.Windows.Forms.ToolStripButton brnListProdutos;
        private System.Windows.Forms.MaskedTextBox txctPesquisarClientePorTelefone;
        private System.Windows.Forms.Label label5;
    }
}