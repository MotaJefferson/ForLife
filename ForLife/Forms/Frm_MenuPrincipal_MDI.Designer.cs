namespace ForLife.Forms
{
    partial class Frm_MenuPrincipal_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.plantioToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.fecharGuiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.arquivoToolStripMenuItem.Text = "Login";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.cadastroToolStripMenuItem.Text = "Gerenciamento";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumoToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.insumoToolStripMenuItem.Text = "Insumo";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // plantioToolStripMenuItem
            // 
            this.plantioToolStripMenuItem.Name = "plantioToolStripMenuItem";
            this.plantioToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.plantioToolStripMenuItem.Text = "Plantio";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // realizarVendaToolStripMenuItem
            // 
            this.realizarVendaToolStripMenuItem.Name = "realizarVendaToolStripMenuItem";
            this.realizarVendaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.realizarVendaToolStripMenuItem.Text = "Realizar Venda";
            // 
            // fecharGuiaToolStripMenuItem
            // 
            this.fecharGuiaToolStripMenuItem.Name = "fecharGuiaToolStripMenuItem";
            this.fecharGuiaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.fecharGuiaToolStripMenuItem.Text = "Fechar Aba Atual";
            this.fecharGuiaToolStripMenuItem.Click += new System.EventHandler(this.fecharGuiaToolStripMenuItem_Click);
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.HotTrack = true;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 28);
            this.Tbc_Aplicacoes.Margin = new System.Windows.Forms.Padding(2);
            this.Tbc_Aplicacoes.MinimumSize = new System.Drawing.Size(900, 600);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(904, 609);
            this.Tbc_Aplicacoes.TabIndex = 3;
            this.Tbc_Aplicacoes.SelectedIndexChanged += new System.EventHandler(this.Tbc_Aplicacoes_SelectedIndexChanged);
            // 
            // Frm_MenuPrincipal_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 637);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(918, 675);
            this.Name = "Frm_MenuPrincipal_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForLife";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVendaToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ToolStripMenuItem fecharGuiaToolStripMenuItem;
    }
}