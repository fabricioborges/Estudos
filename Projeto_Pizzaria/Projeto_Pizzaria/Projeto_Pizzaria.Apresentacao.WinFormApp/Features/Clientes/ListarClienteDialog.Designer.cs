namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes
{
    partial class ListarClienteDialog
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
            this.listClientes = new System.Windows.Forms.ListBox();
            this.lblEnderecoValor = new System.Windows.Forms.Label();
            this.lblTelefoneValor = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDocumentoValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(383, 12);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(220, 329);
            this.listClientes.TabIndex = 0;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            this.listClientes.DoubleClick += new System.EventHandler(this.listClientes_DoubleClick);
            // 
            // lblEnderecoValor
            // 
            this.lblEnderecoValor.AutoSize = true;
            this.lblEnderecoValor.Location = new System.Drawing.Point(97, 104);
            this.lblEnderecoValor.Name = "lblEnderecoValor";
            this.lblEnderecoValor.Size = new System.Drawing.Size(41, 13);
            this.lblEnderecoValor.TabIndex = 53;
            this.lblEnderecoValor.Text = "label17";
            // 
            // lblTelefoneValor
            // 
            this.lblTelefoneValor.AutoSize = true;
            this.lblTelefoneValor.Location = new System.Drawing.Point(97, 63);
            this.lblTelefoneValor.Name = "lblTelefoneValor";
            this.lblTelefoneValor.Size = new System.Drawing.Size(41, 13);
            this.lblTelefoneValor.TabIndex = 52;
            this.lblTelefoneValor.Text = "label13";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(97, 22);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(41, 13);
            this.lblNomeValor.TabIndex = 51;
            this.lblNomeValor.Text = "label11";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(20, 145);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(59, 13);
            this.lblCpf.TabIndex = 50;
            this.lblCpf.Text = "CPF/CNPJ";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(20, 104);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 47;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 22);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 63);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 45;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDocumentoValor
            // 
            this.lblDocumentoValor.AutoSize = true;
            this.lblDocumentoValor.Location = new System.Drawing.Point(97, 145);
            this.lblDocumentoValor.Name = "lblDocumentoValor";
            this.lblDocumentoValor.Size = new System.Drawing.Size(41, 13);
            this.lblDocumentoValor.TabIndex = 54;
            this.lblDocumentoValor.Text = "label17";
            // 
            // ListarClienteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 356);
            this.Controls.Add(this.lblDocumentoValor);
            this.Controls.Add(this.lblEnderecoValor);
            this.Controls.Add(this.lblTelefoneValor);
            this.Controls.Add(this.lblNomeValor);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.listClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarClienteDialog";
            this.Text = "Listar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label lblEnderecoValor;
        private System.Windows.Forms.Label lblTelefoneValor;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDocumentoValor;
    }
}