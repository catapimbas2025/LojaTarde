namespace UILoja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            adicionaToolStripMenuItem = new ToolStripMenuItem();
            selecionarClientesToolStripMenuItem = new ToolStripMenuItem();
            excluirClientesToolStripMenuItem = new ToolStripMenuItem();
            alterarClientersToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarProdutosToolStripMenuItem = new ToolStripMenuItem();
            selecionarProdutosToolStripMenuItem = new ToolStripMenuItem();
            excluirProdutosToolStripMenuItem = new ToolStripMenuItem();
            alterarProdutosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionaToolStripMenuItem, selecionarClientesToolStripMenuItem, excluirClientesToolStripMenuItem, alterarClientersToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // adicionaToolStripMenuItem
            // 
            adicionaToolStripMenuItem.Name = "adicionaToolStripMenuItem";
            adicionaToolStripMenuItem.Size = new Size(180, 22);
            adicionaToolStripMenuItem.Text = "Cadastrar Clientes";
            adicionaToolStripMenuItem.Click += adicionaToolStripMenuItem_Click;
            // 
            // selecionarClientesToolStripMenuItem
            // 
            selecionarClientesToolStripMenuItem.Name = "selecionarClientesToolStripMenuItem";
            selecionarClientesToolStripMenuItem.Size = new Size(180, 22);
            selecionarClientesToolStripMenuItem.Text = "Selecionar Clientes";
            // 
            // excluirClientesToolStripMenuItem
            // 
            excluirClientesToolStripMenuItem.Name = "excluirClientesToolStripMenuItem";
            excluirClientesToolStripMenuItem.Size = new Size(180, 22);
            excluirClientesToolStripMenuItem.Text = "Excluir Clientes";
            // 
            // alterarClientersToolStripMenuItem
            // 
            alterarClientersToolStripMenuItem.Name = "alterarClientersToolStripMenuItem";
            alterarClientersToolStripMenuItem.Size = new Size(180, 22);
            alterarClientersToolStripMenuItem.Text = "Alterar Clienters";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProdutosToolStripMenuItem, selecionarProdutosToolStripMenuItem, excluirProdutosToolStripMenuItem, alterarProdutosToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarProdutosToolStripMenuItem
            // 
            adicionarProdutosToolStripMenuItem.Name = "adicionarProdutosToolStripMenuItem";
            adicionarProdutosToolStripMenuItem.Size = new Size(179, 22);
            adicionarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            // 
            // selecionarProdutosToolStripMenuItem
            // 
            selecionarProdutosToolStripMenuItem.Name = "selecionarProdutosToolStripMenuItem";
            selecionarProdutosToolStripMenuItem.Size = new Size(179, 22);
            selecionarProdutosToolStripMenuItem.Text = "Selecionar Produtos";
            // 
            // excluirProdutosToolStripMenuItem
            // 
            excluirProdutosToolStripMenuItem.Name = "excluirProdutosToolStripMenuItem";
            excluirProdutosToolStripMenuItem.Size = new Size(179, 22);
            excluirProdutosToolStripMenuItem.Text = "Excluir Produtos";
            // 
            // alterarProdutosToolStripMenuItem
            // 
            alterarProdutosToolStripMenuItem.Name = "alterarProdutosToolStripMenuItem";
            alterarProdutosToolStripMenuItem.Size = new Size(179, 22);
            alterarProdutosToolStripMenuItem.Text = "Alterar Produtos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Loja";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem adicionaToolStripMenuItem;
        private ToolStripMenuItem selecionarClientesToolStripMenuItem;
        private ToolStripMenuItem excluirClientesToolStripMenuItem;
        private ToolStripMenuItem alterarClientersToolStripMenuItem;
        private ToolStripMenuItem adicionarProdutosToolStripMenuItem;
        private ToolStripMenuItem selecionarProdutosToolStripMenuItem;
        private ToolStripMenuItem excluirProdutosToolStripMenuItem;
        private ToolStripMenuItem alterarProdutosToolStripMenuItem;
    }
}
