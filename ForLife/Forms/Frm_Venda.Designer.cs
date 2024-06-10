namespace ForLife.Forms
{
    partial class Frm_Venda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Venda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleVendas = new System.Windows.Forms.Label();
            this.Rbtn_dinheiro = new System.Windows.Forms.RadioButton();
            this.Rbtn_cartao = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_formaDePagamento = new System.Windows.Forms.Label();
            this.Rdb_Pix = new System.Windows.Forms.RadioButton();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.Btn_VoltarCliente = new System.Windows.Forms.Button();
            this.Btn_BuscarVenda = new System.Windows.Forms.Button();
            this.Btn_ExcluirVenda = new System.Windows.Forms.Button();
            this.Btn_SalvarVenda = new System.Windows.Forms.Button();
            this.Btn_EditarVenda = new System.Windows.Forms.Button();
            this.Btn_NovaVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleVendas);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 59);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_TitleVendas
            // 
            this.Lbl_TitleVendas.AutoSize = true;
            this.Lbl_TitleVendas.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleVendas.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleVendas.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TitleVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleVendas.Name = "Lbl_TitleVendas";
            this.Lbl_TitleVendas.Size = new System.Drawing.Size(95, 30);
            this.Lbl_TitleVendas.TabIndex = 0;
            this.Lbl_TitleVendas.Text = "Vendas";
            // 
            // Rbtn_dinheiro
            // 
            this.Rbtn_dinheiro.AutoSize = true;
            this.Rbtn_dinheiro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_dinheiro.Location = new System.Drawing.Point(145, 418);
            this.Rbtn_dinheiro.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_dinheiro.Name = "Rbtn_dinheiro";
            this.Rbtn_dinheiro.Size = new System.Drawing.Size(86, 24);
            this.Rbtn_dinheiro.TabIndex = 40;
            this.Rbtn_dinheiro.Text = "Dinheiro";
            this.Rbtn_dinheiro.UseVisualStyleBackColor = true;
            // 
            // Rbtn_cartao
            // 
            this.Rbtn_cartao.AutoSize = true;
            this.Rbtn_cartao.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_cartao.Location = new System.Drawing.Point(40, 418);
            this.Rbtn_cartao.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_cartao.Name = "Rbtn_cartao";
            this.Rbtn_cartao.Size = new System.Drawing.Size(71, 24);
            this.Rbtn_cartao.TabIndex = 39;
            this.Rbtn_cartao.Text = "Cartão";
            this.Rbtn_cartao.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_formaDePagamento);
            this.panel2.Location = new System.Drawing.Point(-1, 377);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 23);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Location = new System.Drawing.Point(7, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 27);
            this.panel3.TabIndex = 28;
            // 
            // Lbl_formaDePagamento
            // 
            this.Lbl_formaDePagamento.AutoSize = true;
            this.Lbl_formaDePagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_formaDePagamento.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_formaDePagamento.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_formaDePagamento.Location = new System.Drawing.Point(19, 0);
            this.Lbl_formaDePagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_formaDePagamento.Name = "Lbl_formaDePagamento";
            this.Lbl_formaDePagamento.Size = new System.Drawing.Size(172, 19);
            this.Lbl_formaDePagamento.TabIndex = 20;
            this.Lbl_formaDePagamento.Text = "Forma de pagamento";
            // 
            // Rdb_Pix
            // 
            this.Rdb_Pix.AutoSize = true;
            this.Rdb_Pix.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Pix.Location = new System.Drawing.Point(268, 418);
            this.Rdb_Pix.Margin = new System.Windows.Forms.Padding(2);
            this.Rdb_Pix.Name = "Rdb_Pix";
            this.Rdb_Pix.Size = new System.Drawing.Size(47, 24);
            this.Rdb_Pix.TabIndex = 41;
            this.Rdb_Pix.Text = "Pix";
            this.Rdb_Pix.UseVisualStyleBackColor = true;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // imgList_Usuario
            // 
            this.imgList_Usuario.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Usuario.ImageStream")));
            this.imgList_Usuario.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Usuario.Images.SetKeyName(0, "Adicionar.png");
            this.imgList_Usuario.Images.SetKeyName(1, "Apagar.png");
            this.imgList_Usuario.Images.SetKeyName(2, "Editar.png");
            this.imgList_Usuario.Images.SetKeyName(3, "Excluir.png");
            this.imgList_Usuario.Images.SetKeyName(4, "Pesquisar.png");
            this.imgList_Usuario.Images.SetKeyName(5, "Salvar.png");
            this.imgList_Usuario.Images.SetKeyName(6, "Voltar.png");
            // 
            // Btn_VoltarCliente
            // 
            this.Btn_VoltarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarCliente.ImageKey = "Voltar.png";
            this.Btn_VoltarCliente.ImageList = this.imgList_Usuario;
            this.Btn_VoltarCliente.Location = new System.Drawing.Point(655, 494);
            this.Btn_VoltarCliente.Name = "Btn_VoltarCliente";
            this.Btn_VoltarCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_VoltarCliente.TabIndex = 72;
            this.Btn_VoltarCliente.Text = "Voltar";
            this.Btn_VoltarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarVenda
            // 
            this.Btn_BuscarVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarVenda.ImageKey = "Pesquisar.png";
            this.Btn_BuscarVenda.ImageList = this.imgList_Usuario;
            this.Btn_BuscarVenda.Location = new System.Drawing.Point(552, 494);
            this.Btn_BuscarVenda.Name = "Btn_BuscarVenda";
            this.Btn_BuscarVenda.Size = new System.Drawing.Size(97, 28);
            this.Btn_BuscarVenda.TabIndex = 71;
            this.Btn_BuscarVenda.Text = "Buscar";
            this.Btn_BuscarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirVenda
            // 
            this.Btn_ExcluirVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirVenda.ImageKey = "Apagar.png";
            this.Btn_ExcluirVenda.ImageList = this.imgList_Usuario;
            this.Btn_ExcluirVenda.Location = new System.Drawing.Point(450, 494);
            this.Btn_ExcluirVenda.Name = "Btn_ExcluirVenda";
            this.Btn_ExcluirVenda.Size = new System.Drawing.Size(97, 28);
            this.Btn_ExcluirVenda.TabIndex = 70;
            this.Btn_ExcluirVenda.Text = "Excluir";
            this.Btn_ExcluirVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarVenda
            // 
            this.Btn_SalvarVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarVenda.ImageKey = "Salvar.png";
            this.Btn_SalvarVenda.ImageList = this.imgList_Usuario;
            this.Btn_SalvarVenda.Location = new System.Drawing.Point(347, 494);
            this.Btn_SalvarVenda.Name = "Btn_SalvarVenda";
            this.Btn_SalvarVenda.Size = new System.Drawing.Size(97, 28);
            this.Btn_SalvarVenda.TabIndex = 69;
            this.Btn_SalvarVenda.Text = "Salvar";
            this.Btn_SalvarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarVenda
            // 
            this.Btn_EditarVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarVenda.ImageKey = "Editar.png";
            this.Btn_EditarVenda.ImageList = this.imgList_Usuario;
            this.Btn_EditarVenda.Location = new System.Drawing.Point(242, 494);
            this.Btn_EditarVenda.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_EditarVenda.Name = "Btn_EditarVenda";
            this.Btn_EditarVenda.Size = new System.Drawing.Size(97, 28);
            this.Btn_EditarVenda.TabIndex = 68;
            this.Btn_EditarVenda.Text = "Editar";
            this.Btn_EditarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_NovaVenda
            // 
            this.Btn_NovaVenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovaVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovaVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovaVenda.ImageKey = "Adicionar.png";
            this.Btn_NovaVenda.ImageList = this.imgList_Usuario;
            this.Btn_NovaVenda.Location = new System.Drawing.Point(135, 494);
            this.Btn_NovaVenda.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_NovaVenda.Name = "Btn_NovaVenda";
            this.Btn_NovaVenda.Size = new System.Drawing.Size(97, 28);
            this.Btn_NovaVenda.TabIndex = 67;
            this.Btn_NovaVenda.Text = "Nova";
            this.Btn_NovaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovaVenda.UseVisualStyleBackColor = true;
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_VoltarCliente);
            this.Controls.Add(this.Btn_BuscarVenda);
            this.Controls.Add(this.Btn_ExcluirVenda);
            this.Controls.Add(this.Btn_SalvarVenda);
            this.Controls.Add(this.Btn_EditarVenda);
            this.Controls.Add(this.Btn_NovaVenda);
            this.Controls.Add(this.Rdb_Pix);
            this.Controls.Add(this.Rbtn_dinheiro);
            this.Controls.Add(this.Rbtn_cartao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Venda";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleVendas;
        private System.Windows.Forms.RadioButton Rbtn_dinheiro;
        private System.Windows.Forms.RadioButton Rbtn_cartao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_formaDePagamento;
        private System.Windows.Forms.RadioButton Rdb_Pix;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_VoltarCliente;
        private System.Windows.Forms.Button Btn_BuscarVenda;
        private System.Windows.Forms.Button Btn_ExcluirVenda;
        private System.Windows.Forms.Button Btn_SalvarVenda;
        private System.Windows.Forms.Button Btn_EditarVenda;
        private System.Windows.Forms.Button Btn_NovaVenda;
    }
}
