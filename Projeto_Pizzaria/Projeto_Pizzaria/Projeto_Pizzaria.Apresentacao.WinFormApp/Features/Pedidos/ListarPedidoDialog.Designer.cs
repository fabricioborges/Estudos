namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Pedidos
{
    partial class ListarPedidoDialog
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
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lblCpfValor = new System.Windows.Forms.Label();
            this.lblStatusValor = new System.Windows.Forms.Label();
            this.lblTipoDePagamentoValor = new System.Windows.Forms.Label();
            this.lblResponsavelValor = new System.Windows.Forms.Label();
            this.lblDepartamentoValor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipoDePagamento = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblEnderecoValor = new System.Windows.Forms.Label();
            this.lblTelefoneValor = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.Location = new System.Drawing.Point(368, 12);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(317, 485);
            this.listPedidos.TabIndex = 1;
            this.listPedidos.SelectedIndexChanged += new System.EventHandler(this.listPedidos_SelectedIndexChanged);
            this.listPedidos.DoubleClick += new System.EventHandler(this.listPedidos_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblNotaFiscal);
            this.groupBox2.Controls.Add(this.lblCpfValor);
            this.groupBox2.Controls.Add(this.lblStatusValor);
            this.groupBox2.Controls.Add(this.lblTipoDePagamentoValor);
            this.groupBox2.Controls.Add(this.lblResponsavelValor);
            this.groupBox2.Controls.Add(this.lblDepartamentoValor);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTipoDePagamento);
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Controls.Add(this.lblEnderecoValor);
            this.groupBox2.Controls.Add(this.lblTelefoneValor);
            this.groupBox2.Controls.Add(this.lblNomeValor);
            this.groupBox2.Controls.Add(this.listProdutos);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.lblResponsavel);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 486);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pedido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Avançar status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(202, 414);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(67, 13);
            this.lblNotaFiscal.TabIndex = 47;
            this.lblNotaFiscal.Text = "lblNotaFiscal";
            // 
            // lblCpfValor
            // 
            this.lblCpfValor.AutoSize = true;
            this.lblCpfValor.Location = new System.Drawing.Point(87, 148);
            this.lblCpfValor.Name = "lblCpfValor";
            this.lblCpfValor.Size = new System.Drawing.Size(41, 13);
            this.lblCpfValor.TabIndex = 46;
            this.lblCpfValor.Text = "label17";
            // 
            // lblStatusValor
            // 
            this.lblStatusValor.AutoSize = true;
            this.lblStatusValor.Location = new System.Drawing.Point(119, 28);
            this.lblStatusValor.Name = "lblStatusValor";
            this.lblStatusValor.Size = new System.Drawing.Size(41, 13);
            this.lblStatusValor.TabIndex = 45;
            this.lblStatusValor.Text = "label17";
            // 
            // lblTipoDePagamentoValor
            // 
            this.lblTipoDePagamentoValor.AutoSize = true;
            this.lblTipoDePagamentoValor.Location = new System.Drawing.Point(136, 414);
            this.lblTipoDePagamentoValor.Name = "lblTipoDePagamentoValor";
            this.lblTipoDePagamentoValor.Size = new System.Drawing.Size(41, 13);
            this.lblTipoDePagamentoValor.TabIndex = 44;
            this.lblTipoDePagamentoValor.Text = "label17";
            // 
            // lblResponsavelValor
            // 
            this.lblResponsavelValor.AutoSize = true;
            this.lblResponsavelValor.Location = new System.Drawing.Point(100, 178);
            this.lblResponsavelValor.Name = "lblResponsavelValor";
            this.lblResponsavelValor.Size = new System.Drawing.Size(41, 13);
            this.lblResponsavelValor.TabIndex = 43;
            this.lblResponsavelValor.Text = "label17";
            // 
            // lblDepartamentoValor
            // 
            this.lblDepartamentoValor.AutoSize = true;
            this.lblDepartamentoValor.Location = new System.Drawing.Point(100, 208);
            this.lblDepartamentoValor.Name = "lblDepartamentoValor";
            this.lblDepartamentoValor.Size = new System.Drawing.Size(41, 13);
            this.lblDepartamentoValor.TabIndex = 42;
            this.lblDepartamentoValor.Text = "label17";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 13);
            this.lblStatus.TabIndex = 41;
            this.lblStatus.Text = "Status do pedido:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(90, 458);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(28, 13);
            this.lblValor.TabIndex = 38;
            this.lblValor.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 458);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Valor total:";
            // 
            // lblTipoDePagamento
            // 
            this.lblTipoDePagamento.AutoSize = true;
            this.lblTipoDePagamento.Location = new System.Drawing.Point(23, 414);
            this.lblTipoDePagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDePagamento.Name = "lblTipoDePagamento";
            this.lblTipoDePagamento.Size = new System.Drawing.Size(108, 13);
            this.lblTipoDePagamento.TabIndex = 40;
            this.lblTipoDePagamento.Text = "Tipo De Pagamento: ";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(23, 208);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 37;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblEnderecoValor
            // 
            this.lblEnderecoValor.AutoSize = true;
            this.lblEnderecoValor.Location = new System.Drawing.Point(84, 118);
            this.lblEnderecoValor.Name = "lblEnderecoValor";
            this.lblEnderecoValor.Size = new System.Drawing.Size(41, 13);
            this.lblEnderecoValor.TabIndex = 35;
            this.lblEnderecoValor.Text = "label17";
            // 
            // lblTelefoneValor
            // 
            this.lblTelefoneValor.AutoSize = true;
            this.lblTelefoneValor.Location = new System.Drawing.Point(77, 88);
            this.lblTelefoneValor.Name = "lblTelefoneValor";
            this.lblTelefoneValor.Size = new System.Drawing.Size(41, 13);
            this.lblTelefoneValor.TabIndex = 34;
            this.lblTelefoneValor.Text = "label13";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(66, 58);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(41, 13);
            this.lblNomeValor.TabIndex = 33;
            this.lblNomeValor.Text = "label11";
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.HorizontalScrollbar = true;
            this.listProdutos.Location = new System.Drawing.Point(26, 259);
            this.listProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(279, 134);
            this.listProdutos.TabIndex = 32;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(23, 148);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(62, 13);
            this.lblCpf.TabIndex = 31;
            this.lblCpf.Text = "CPF/CNPJ:";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(23, 178);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(72, 13);
            this.lblResponsavel.TabIndex = 29;
            this.lblResponsavel.Text = "Responsavel:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(23, 118);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(23, 88);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Telefone:";
            // 
            // ListarPedidoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarPedidoDialog";
            this.Text = "Listar Pedidos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResponsavelValor;
        private System.Windows.Forms.Label lblDepartamentoValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTipoDePagamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblEnderecoValor;
        private System.Windows.Forms.Label lblTelefoneValor;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label lblCpfValor;
        private System.Windows.Forms.Label lblStatusValor;
        private System.Windows.Forms.Label lblTipoDePagamentoValor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
    }
}