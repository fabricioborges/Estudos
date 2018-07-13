namespace Projeto_Pizzaria.Apresentacao.WinFormApp.Features.Clientes
{
    partial class ClienteControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCliente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCliente
            // 
            this.listCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 16;
            this.listCliente.Location = new System.Drawing.Point(0, 0);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(150, 150);
            this.listCliente.TabIndex = 0;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // ClienteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listCliente);
            this.Name = "ClienteControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCliente;
    }
}
