namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos
{
    partial class ListarProdutosDialog
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
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTamanhoMedio = new System.Windows.Forms.Label();
            this.lblTamanhoPequeno = new System.Windows.Forms.Label();
            this.lblTamanhoGrande = new System.Windows.Forms.Label();
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.lblTipoPizzaValor = new System.Windows.Forms.Label();
            this.lblTamanhoGrandeValor = new System.Windows.Forms.Label();
            this.lblTamanhoPequenoValor = new System.Windows.Forms.Label();
            this.lblValorValor = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblTamanhoMedioValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(446, 31);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(313, 394);
            this.listProdutos.TabIndex = 0;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
            this.listProdutos.DoubleClick += new System.EventHandler(this.listProdutos_DoubleClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 84);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblTamanhoMedio
            // 
            this.lblTamanhoMedio.AutoSize = true;
            this.lblTamanhoMedio.Location = new System.Drawing.Point(30, 153);
            this.lblTamanhoMedio.Name = "lblTamanhoMedio";
            this.lblTamanhoMedio.Size = new System.Drawing.Size(114, 13);
            this.lblTamanhoMedio.TabIndex = 4;
            this.lblTamanhoMedio.Text = "Valor Tamanho Médio:";
            // 
            // lblTamanhoPequeno
            // 
            this.lblTamanhoPequeno.AutoSize = true;
            this.lblTamanhoPequeno.Location = new System.Drawing.Point(30, 114);
            this.lblTamanhoPequeno.Name = "lblTamanhoPequeno";
            this.lblTamanhoPequeno.Size = new System.Drawing.Size(128, 13);
            this.lblTamanhoPequeno.TabIndex = 3;
            this.lblTamanhoPequeno.Text = "Valor Tamanho Pequeno:";
            this.lblTamanhoPequeno.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTamanhoGrande
            // 
            this.lblTamanhoGrande.AutoSize = true;
            this.lblTamanhoGrande.Location = new System.Drawing.Point(30, 198);
            this.lblTamanhoGrande.Name = "lblTamanhoGrande";
            this.lblTamanhoGrande.Size = new System.Drawing.Size(120, 13);
            this.lblTamanhoGrande.TabIndex = 5;
            this.lblTamanhoGrande.Text = "Valor Tamanho Grande:";
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Location = new System.Drawing.Point(30, 234);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(74, 13);
            this.lblTipoPizza.TabIndex = 6;
            this.lblTipoPizza.Text = "Tipo de Pizza:";
            // 
            // lblTipoPizzaValor
            // 
            this.lblTipoPizzaValor.AutoSize = true;
            this.lblTipoPizzaValor.Location = new System.Drawing.Point(164, 234);
            this.lblTipoPizzaValor.Name = "lblTipoPizzaValor";
            this.lblTipoPizzaValor.Size = new System.Drawing.Size(74, 13);
            this.lblTipoPizzaValor.TabIndex = 12;
            this.lblTipoPizzaValor.Text = "Tipo de Pizza:";
            // 
            // lblTamanhoGrandeValor
            // 
            this.lblTamanhoGrandeValor.AutoSize = true;
            this.lblTamanhoGrandeValor.Location = new System.Drawing.Point(164, 198);
            this.lblTamanhoGrandeValor.Name = "lblTamanhoGrandeValor";
            this.lblTamanhoGrandeValor.Size = new System.Drawing.Size(120, 13);
            this.lblTamanhoGrandeValor.TabIndex = 11;
            this.lblTamanhoGrandeValor.Text = "Valor Tamanho Grande:";
            // 
            // lblTamanhoPequenoValor
            // 
            this.lblTamanhoPequenoValor.AutoSize = true;
            this.lblTamanhoPequenoValor.Location = new System.Drawing.Point(164, 114);
            this.lblTamanhoPequenoValor.Name = "lblTamanhoPequenoValor";
            this.lblTamanhoPequenoValor.Size = new System.Drawing.Size(128, 13);
            this.lblTamanhoPequenoValor.TabIndex = 9;
            this.lblTamanhoPequenoValor.Text = "Valor Tamanho Pequeno:";
            // 
            // lblValorValor
            // 
            this.lblValorValor.AutoSize = true;
            this.lblValorValor.Location = new System.Drawing.Point(164, 84);
            this.lblValorValor.Name = "lblValorValor";
            this.lblValorValor.Size = new System.Drawing.Size(34, 13);
            this.lblValorValor.TabIndex = 8;
            this.lblValorValor.Text = "Valor:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(164, 53);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(38, 13);
            this.lblNomeValor.TabIndex = 7;
            this.lblNomeValor.Text = "Nome:";
            // 
            // lblTamanhoMedioValor
            // 
            this.lblTamanhoMedioValor.AutoSize = true;
            this.lblTamanhoMedioValor.Location = new System.Drawing.Point(164, 153);
            this.lblTamanhoMedioValor.Name = "lblTamanhoMedioValor";
            this.lblTamanhoMedioValor.Size = new System.Drawing.Size(114, 13);
            this.lblTamanhoMedioValor.TabIndex = 10;
            this.lblTamanhoMedioValor.Text = "Valor Tamanho Médio:";
            // 
            // ListarProdutosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoPizzaValor);
            this.Controls.Add(this.lblTamanhoGrandeValor);
            this.Controls.Add(this.lblTamanhoMedioValor);
            this.Controls.Add(this.lblTamanhoPequenoValor);
            this.Controls.Add(this.lblValorValor);
            this.Controls.Add(this.lblNomeValor);
            this.Controls.Add(this.lblTipoPizza);
            this.Controls.Add(this.lblTamanhoGrande);
            this.Controls.Add(this.lblTamanhoMedio);
            this.Controls.Add(this.lblTamanhoPequeno);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.listProdutos);
            this.Name = "ListarProdutosDialog";
            this.Text = "Listar Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTamanhoMedio;
        private System.Windows.Forms.Label lblTamanhoPequeno;
        private System.Windows.Forms.Label lblTamanhoGrande;
        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.Label lblTipoPizzaValor;
        private System.Windows.Forms.Label lblTamanhoGrandeValor;
        private System.Windows.Forms.Label lblTamanhoPequenoValor;
        private System.Windows.Forms.Label lblValorValor;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label lblTamanhoMedioValor;
    }
}