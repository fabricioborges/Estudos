namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Produtos
{
    partial class CadastroProdutoDialog
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabCalzone = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalzoneNome = new System.Windows.Forms.TextBox();
            this.txtCalzoneValor = new System.Windows.Forms.TextBox();
            this.tabBebida = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBebidaNome = new System.Windows.Forms.TextBox();
            this.txtBebidaValor = new System.Windows.Forms.TextBox();
            this.TabPizza = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePizza = new System.Windows.Forms.TextBox();
            this.txtValorPequenaPizza = new System.Windows.Forms.TextBox();
            this.txtMediaPizza = new System.Windows.Forms.TextBox();
            this.txtGrandePizza = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTipoPizza = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalzone.SuspendLayout();
            this.tabBebida.SuspendLayout();
            this.TabPizza.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(377, 282);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 45);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabCalzone
            // 
            this.tabCalzone.Controls.Add(this.txtCalzoneValor);
            this.tabCalzone.Controls.Add(this.txtCalzoneNome);
            this.tabCalzone.Controls.Add(this.label7);
            this.tabCalzone.Controls.Add(this.label8);
            this.tabCalzone.Location = new System.Drawing.Point(4, 25);
            this.tabCalzone.Name = "tabCalzone";
            this.tabCalzone.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalzone.Size = new System.Drawing.Size(463, 235);
            this.tabCalzone.TabIndex = 3;
            this.tabCalzone.Text = "Calzone";
            this.tabCalzone.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Valor:";
            // 
            // txtCalzoneNome
            // 
            this.txtCalzoneNome.Location = new System.Drawing.Point(58, 6);
            this.txtCalzoneNome.Name = "txtCalzoneNome";
            this.txtCalzoneNome.Size = new System.Drawing.Size(200, 22);
            this.txtCalzoneNome.TabIndex = 6;
            // 
            // txtCalzoneValor
            // 
            this.txtCalzoneValor.Location = new System.Drawing.Point(58, 53);
            this.txtCalzoneValor.Name = "txtCalzoneValor";
            this.txtCalzoneValor.Size = new System.Drawing.Size(200, 22);
            this.txtCalzoneValor.TabIndex = 7;
            // 
            // tabBebida
            // 
            this.tabBebida.Controls.Add(this.txtBebidaValor);
            this.tabBebida.Controls.Add(this.txtBebidaNome);
            this.tabBebida.Controls.Add(this.label6);
            this.tabBebida.Controls.Add(this.label5);
            this.tabBebida.Location = new System.Drawing.Point(4, 25);
            this.tabBebida.Name = "tabBebida";
            this.tabBebida.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebida.Size = new System.Drawing.Size(463, 235);
            this.tabBebida.TabIndex = 2;
            this.tabBebida.Text = "Bebida";
            this.tabBebida.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor:";
            // 
            // txtBebidaNome
            // 
            this.txtBebidaNome.Location = new System.Drawing.Point(57, 6);
            this.txtBebidaNome.Name = "txtBebidaNome";
            this.txtBebidaNome.Size = new System.Drawing.Size(200, 22);
            this.txtBebidaNome.TabIndex = 2;
            // 
            // txtBebidaValor
            // 
            this.txtBebidaValor.Location = new System.Drawing.Point(57, 53);
            this.txtBebidaValor.Name = "txtBebidaValor";
            this.txtBebidaValor.Size = new System.Drawing.Size(200, 22);
            this.txtBebidaValor.TabIndex = 3;
            // 
            // TabPizza
            // 
            this.TabPizza.Controls.Add(this.cbxTipoPizza);
            this.TabPizza.Controls.Add(this.label11);
            this.TabPizza.Controls.Add(this.txtGrandePizza);
            this.TabPizza.Controls.Add(this.txtMediaPizza);
            this.TabPizza.Controls.Add(this.txtValorPequenaPizza);
            this.TabPizza.Controls.Add(this.txtNomePizza);
            this.TabPizza.Controls.Add(this.label4);
            this.TabPizza.Controls.Add(this.label3);
            this.TabPizza.Controls.Add(this.label2);
            this.TabPizza.Controls.Add(this.label1);
            this.TabPizza.Location = new System.Drawing.Point(4, 25);
            this.TabPizza.Name = "TabPizza";
            this.TabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.TabPizza.Size = new System.Drawing.Size(463, 235);
            this.TabPizza.TabIndex = 1;
            this.TabPizza.Text = "Pizza";
            this.TabPizza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Pequena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Média:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Grande:";
            // 
            // txtNomePizza
            // 
            this.txtNomePizza.Location = new System.Drawing.Point(61, 17);
            this.txtNomePizza.Name = "txtNomePizza";
            this.txtNomePizza.Size = new System.Drawing.Size(376, 22);
            this.txtNomePizza.TabIndex = 4;
            // 
            // txtValorPequenaPizza
            // 
            this.txtValorPequenaPizza.Location = new System.Drawing.Point(118, 62);
            this.txtValorPequenaPizza.Name = "txtValorPequenaPizza";
            this.txtValorPequenaPizza.Size = new System.Drawing.Size(319, 22);
            this.txtValorPequenaPizza.TabIndex = 5;
            // 
            // txtMediaPizza
            // 
            this.txtMediaPizza.Location = new System.Drawing.Point(99, 110);
            this.txtMediaPizza.Name = "txtMediaPizza";
            this.txtMediaPizza.Size = new System.Drawing.Size(338, 22);
            this.txtMediaPizza.TabIndex = 6;
            // 
            // txtGrandePizza
            // 
            this.txtGrandePizza.Location = new System.Drawing.Point(109, 156);
            this.txtGrandePizza.Name = "txtGrandePizza";
            this.txtGrandePizza.Size = new System.Drawing.Size(328, 22);
            this.txtGrandePizza.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tipo:";
            // 
            // cbxTipoPizza
            // 
            this.cbxTipoPizza.FormattingEnabled = true;
            this.cbxTipoPizza.Location = new System.Drawing.Point(61, 195);
            this.cbxTipoPizza.Name = "cbxTipoPizza";
            this.cbxTipoPizza.Size = new System.Drawing.Size(376, 24);
            this.cbxTipoPizza.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPizza);
            this.tabControl.Controls.Add(this.tabBebida);
            this.tabControl.Controls.Add(this.tabCalzone);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(471, 264);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // CadastroProdutoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 339);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroProdutoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProdutoDialog";
            this.tabCalzone.ResumeLayout(false);
            this.tabCalzone.PerformLayout();
            this.tabBebida.ResumeLayout(false);
            this.tabBebida.PerformLayout();
            this.TabPizza.ResumeLayout(false);
            this.TabPizza.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabCalzone;
        private System.Windows.Forms.TextBox txtCalzoneValor;
        private System.Windows.Forms.TextBox txtCalzoneNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabBebida;
        private System.Windows.Forms.TextBox txtBebidaValor;
        private System.Windows.Forms.TextBox txtBebidaNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage TabPizza;
        private System.Windows.Forms.ComboBox cbxTipoPizza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGrandePizza;
        private System.Windows.Forms.TextBox txtMediaPizza;
        private System.Windows.Forms.TextBox txtValorPequenaPizza;
        private System.Windows.Forms.TextBox txtNomePizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
    }
}