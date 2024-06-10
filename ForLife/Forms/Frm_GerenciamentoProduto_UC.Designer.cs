namespace ForLife.Forms
{
    partial class Frm_GerenciamentoProduto_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GerenciamentoProduto_UC));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_statusProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleProduto = new System.Windows.Forms.Label();
            this.Rbtn_ProdutoInativo = new System.Windows.Forms.RadioButton();
            this.Rbtn_ProdutoAtivo = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_InfoProduto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.Lbl_NomeProduto = new System.Windows.Forms.Label();
            this.Lbl_IdInsumoOrigem = new System.Windows.Forms.Label();
            this.label_PeriodoVenc = new System.Windows.Forms.Label();
            this.Num_Vencimento = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_Colheita = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_ConfigEstoqueColheita = new System.Windows.Forms.GroupBox();
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.botaoPesquisaSimples = new System.Windows.Forms.ImageList(this.components);
            this.Txt_InsumoOrigem = new System.Windows.Forms.TextBox();
            this.Btn_PesquisaInsumo = new System.Windows.Forms.Button();
            this.Btn_VoltarProduto = new System.Windows.Forms.Button();
            this.Btn_BuscarProduto = new System.Windows.Forms.Button();
            this.Btn_ExcluirProduto = new System.Windows.Forms.Button();
            this.Btn_SalvarProduto = new System.Windows.Forms.Button();
            this.Btn_EditarProduto = new System.Windows.Forms.Button();
            this.Btn_NovoProduto = new System.Windows.Forms.Button();
            this.imgPesquisaSimples = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Vencimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Colheita)).BeginInit();
            this.groupBox_ConfigEstoqueColheita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_statusProduto);
            this.panel2.Location = new System.Drawing.Point(-1, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 28);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Location = new System.Drawing.Point(9, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 33);
            this.panel3.TabIndex = 28;
            // 
            // Lbl_statusProduto
            // 
            this.Lbl_statusProduto.AutoSize = true;
            this.Lbl_statusProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_statusProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_statusProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_statusProduto.Location = new System.Drawing.Point(25, 0);
            this.Lbl_statusProduto.Name = "Lbl_statusProduto";
            this.Lbl_statusProduto.Size = new System.Drawing.Size(177, 25);
            this.Lbl_statusProduto.TabIndex = 20;
            this.Lbl_statusProduto.Text = "Status do Produto";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleProduto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 73);
            this.panel1.TabIndex = 28;
            // 
            // Lbl_TitleProduto
            // 
            this.Lbl_TitleProduto.AutoSize = true;
            this.Lbl_TitleProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleProduto.Location = new System.Drawing.Point(17, 14);
            this.Lbl_TitleProduto.Name = "Lbl_TitleProduto";
            this.Lbl_TitleProduto.Size = new System.Drawing.Size(398, 37);
            this.Lbl_TitleProduto.TabIndex = 0;
            this.Lbl_TitleProduto.Text = "Gerenciamento do Produto";
            // 
            // Rbtn_ProdutoInativo
            // 
            this.Rbtn_ProdutoInativo.AutoSize = true;
            this.Rbtn_ProdutoInativo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ProdutoInativo.Location = new System.Drawing.Point(187, 169);
            this.Rbtn_ProdutoInativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_ProdutoInativo.Name = "Rbtn_ProdutoInativo";
            this.Rbtn_ProdutoInativo.Size = new System.Drawing.Size(86, 27);
            this.Rbtn_ProdutoInativo.TabIndex = 31;
            this.Rbtn_ProdutoInativo.Text = "Inativo";
            this.Rbtn_ProdutoInativo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_ProdutoAtivo
            // 
            this.Rbtn_ProdutoAtivo.AutoSize = true;
            this.Rbtn_ProdutoAtivo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ProdutoAtivo.Location = new System.Drawing.Point(47, 169);
            this.Rbtn_ProdutoAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_ProdutoAtivo.Name = "Rbtn_ProdutoAtivo";
            this.Rbtn_ProdutoAtivo.Size = new System.Drawing.Size(74, 27);
            this.Rbtn_ProdutoAtivo.TabIndex = 30;
            this.Rbtn_ProdutoAtivo.Text = "Ativo";
            this.Rbtn_ProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.Lbl_InfoProduto);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 241);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1440, 31);
            this.panel4.TabIndex = 32;
            // 
            // Lbl_InfoProduto
            // 
            this.Lbl_InfoProduto.AutoSize = true;
            this.Lbl_InfoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoProduto.Location = new System.Drawing.Point(25, 0);
            this.Lbl_InfoProduto.Name = "Lbl_InfoProduto";
            this.Lbl_InfoProduto.Size = new System.Drawing.Size(234, 25);
            this.Lbl_InfoProduto.TabIndex = 21;
            this.Lbl_InfoProduto.Text = "Informações do Produto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OliveDrab;
            this.panel5.Location = new System.Drawing.Point(9, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 33);
            this.panel5.TabIndex = 28;
            // 
            // Txt_NomeProduto
            // 
            this.Txt_NomeProduto.AcceptsTab = true;
            this.Txt_NomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProduto.Location = new System.Drawing.Point(47, 343);
            this.Txt_NomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NomeProduto.Name = "Txt_NomeProduto";
            this.Txt_NomeProduto.Size = new System.Drawing.Size(1064, 30);
            this.Txt_NomeProduto.TabIndex = 33;
            // 
            // Lbl_NomeProduto
            // 
            this.Lbl_NomeProduto.AutoSize = true;
            this.Lbl_NomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeProduto.Location = new System.Drawing.Point(41, 309);
            this.Lbl_NomeProduto.Name = "Lbl_NomeProduto";
            this.Lbl_NomeProduto.Size = new System.Drawing.Size(158, 23);
            this.Lbl_NomeProduto.TabIndex = 34;
            this.Lbl_NomeProduto.Text = "Nome do Produto";
            // 
            // Lbl_IdInsumoOrigem
            // 
            this.Lbl_IdInsumoOrigem.AutoSize = true;
            this.Lbl_IdInsumoOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdInsumoOrigem.Location = new System.Drawing.Point(43, 420);
            this.Lbl_IdInsumoOrigem.Name = "Lbl_IdInsumoOrigem";
            this.Lbl_IdInsumoOrigem.Size = new System.Drawing.Size(163, 23);
            this.Lbl_IdInsumoOrigem.TabIndex = 35;
            this.Lbl_IdInsumoOrigem.Text = "Insumo de Origem";
            // 
            // label_PeriodoVenc
            // 
            this.label_PeriodoVenc.AutoSize = true;
            this.label_PeriodoVenc.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PeriodoVenc.ForeColor = System.Drawing.Color.Black;
            this.label_PeriodoVenc.Location = new System.Drawing.Point(33, 37);
            this.label_PeriodoVenc.Name = "label_PeriodoVenc";
            this.label_PeriodoVenc.Size = new System.Drawing.Size(109, 23);
            this.label_PeriodoVenc.TabIndex = 37;
            this.label_PeriodoVenc.Text = "Vencimento";
            // 
            // Num_Vencimento
            // 
            this.Num_Vencimento.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Vencimento.Location = new System.Drawing.Point(39, 65);
            this.Num_Vencimento.Margin = new System.Windows.Forms.Padding(4);
            this.Num_Vencimento.Name = "Num_Vencimento";
            this.Num_Vencimento.Size = new System.Drawing.Size(79, 26);
            this.Num_Vencimento.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dia(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(324, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Dia(s)";
            // 
            // Num_Colheita
            // 
            this.Num_Colheita.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Colheita.Location = new System.Drawing.Point(237, 65);
            this.Num_Colheita.Margin = new System.Windows.Forms.Padding(4);
            this.Num_Colheita.Name = "Num_Colheita";
            this.Num_Colheita.Size = new System.Drawing.Size(79, 26);
            this.Num_Colheita.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(232, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Colheita";
            // 
            // groupBox_ConfigEstoqueColheita
            // 
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label_PeriodoVenc);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label3);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label2);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label1);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.Num_Colheita);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.Num_Vencimento);
            this.groupBox_ConfigEstoqueColheita.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ConfigEstoqueColheita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.groupBox_ConfigEstoqueColheita.Location = new System.Drawing.Point(599, 409);
            this.groupBox_ConfigEstoqueColheita.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_ConfigEstoqueColheita.Name = "groupBox_ConfigEstoqueColheita";
            this.groupBox_ConfigEstoqueColheita.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_ConfigEstoqueColheita.Size = new System.Drawing.Size(432, 101);
            this.groupBox_ConfigEstoqueColheita.TabIndex = 43;
            this.groupBox_ConfigEstoqueColheita.TabStop = false;
            this.groupBox_ConfigEstoqueColheita.Text = "Configurações de estoque/colheita";
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
            // botaoPesquisaSimples
            // 
            this.botaoPesquisaSimples.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("botaoPesquisaSimples.ImageStream")));
            this.botaoPesquisaSimples.TransparentColor = System.Drawing.Color.Transparent;
            this.botaoPesquisaSimples.Images.SetKeyName(0, "PesquisaSimples.png");
            // 
            // Txt_InsumoOrigem
            // 
            this.Txt_InsumoOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.Txt_InsumoOrigem.Location = new System.Drawing.Point(48, 464);
            this.Txt_InsumoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_InsumoOrigem.Name = "Txt_InsumoOrigem";
            this.Txt_InsumoOrigem.Size = new System.Drawing.Size(373, 30);
            this.Txt_InsumoOrigem.TabIndex = 51;
            // 
            // Btn_PesquisaInsumo
            // 
            this.Btn_PesquisaInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PesquisaInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PesquisaInsumo.ImageKey = "Pesquisar.png";
            this.Btn_PesquisaInsumo.ImageList = this.imgList_Usuario;
            this.Btn_PesquisaInsumo.Location = new System.Drawing.Point(435, 464);
            this.Btn_PesquisaInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PesquisaInsumo.Name = "Btn_PesquisaInsumo";
            this.Btn_PesquisaInsumo.Size = new System.Drawing.Size(35, 33);
            this.Btn_PesquisaInsumo.TabIndex = 50;
            this.Btn_PesquisaInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisaInsumo.UseVisualStyleBackColor = true;
            this.Btn_PesquisaInsumo.Click += new System.EventHandler(this.Btn_PesquisaInsumo_Click);
            // 
            // Btn_VoltarProduto
            // 
            this.Btn_VoltarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarProduto.ImageKey = "Voltar.png";
            this.Btn_VoltarProduto.ImageList = this.imgList_Usuario;
            this.Btn_VoltarProduto.Location = new System.Drawing.Point(857, 645);
            this.Btn_VoltarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_VoltarProduto.Name = "Btn_VoltarProduto";
            this.Btn_VoltarProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_VoltarProduto.TabIndex = 49;
            this.Btn_VoltarProduto.Text = "Voltar";
            this.Btn_VoltarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarProduto.UseVisualStyleBackColor = true;
            this.Btn_VoltarProduto.Click += new System.EventHandler(this.Btn_VoltarProduto_Click);
            // 
            // Btn_BuscarProduto
            // 
            this.Btn_BuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarProduto.ImageKey = "Pesquisar.png";
            this.Btn_BuscarProduto.ImageList = this.imgList_Usuario;
            this.Btn_BuscarProduto.Location = new System.Drawing.Point(720, 645);
            this.Btn_BuscarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarProduto.Name = "Btn_BuscarProduto";
            this.Btn_BuscarProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_BuscarProduto.TabIndex = 48;
            this.Btn_BuscarProduto.Text = "Buscar";
            this.Btn_BuscarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarProduto.UseVisualStyleBackColor = true;
            this.Btn_BuscarProduto.Click += new System.EventHandler(this.Btn_BuscarProduto_Click);
            // 
            // Btn_ExcluirProduto
            // 
            this.Btn_ExcluirProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirProduto.ImageKey = "Apagar.png";
            this.Btn_ExcluirProduto.ImageList = this.imgList_Usuario;
            this.Btn_ExcluirProduto.Location = new System.Drawing.Point(584, 645);
            this.Btn_ExcluirProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExcluirProduto.Name = "Btn_ExcluirProduto";
            this.Btn_ExcluirProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_ExcluirProduto.TabIndex = 47;
            this.Btn_ExcluirProduto.Text = "Excluir";
            this.Btn_ExcluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirProduto.UseVisualStyleBackColor = true;
            this.Btn_ExcluirProduto.Click += new System.EventHandler(this.Btn_ExcluirProduto_Click);
            // 
            // Btn_SalvarProduto
            // 
            this.Btn_SalvarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarProduto.ImageKey = "Salvar.png";
            this.Btn_SalvarProduto.ImageList = this.imgList_Usuario;
            this.Btn_SalvarProduto.Location = new System.Drawing.Point(447, 645);
            this.Btn_SalvarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SalvarProduto.Name = "Btn_SalvarProduto";
            this.Btn_SalvarProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_SalvarProduto.TabIndex = 46;
            this.Btn_SalvarProduto.Text = "Salvar";
            this.Btn_SalvarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarProduto.UseVisualStyleBackColor = true;
            this.Btn_SalvarProduto.Click += new System.EventHandler(this.Btn_SalvarProduto_Click);
            // 
            // Btn_EditarProduto
            // 
            this.Btn_EditarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarProduto.ImageKey = "Editar.png";
            this.Btn_EditarProduto.ImageList = this.imgList_Usuario;
            this.Btn_EditarProduto.Location = new System.Drawing.Point(307, 645);
            this.Btn_EditarProduto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_EditarProduto.Name = "Btn_EditarProduto";
            this.Btn_EditarProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_EditarProduto.TabIndex = 45;
            this.Btn_EditarProduto.Text = "Editar";
            this.Btn_EditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarProduto.UseVisualStyleBackColor = true;
            this.Btn_EditarProduto.Click += new System.EventHandler(this.Btn_EditarProduto_Click);
            // 
            // Btn_NovoProduto
            // 
            this.Btn_NovoProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovoProduto.ImageKey = "Adicionar.png";
            this.Btn_NovoProduto.ImageList = this.imgList_Usuario;
            this.Btn_NovoProduto.Location = new System.Drawing.Point(164, 645);
            this.Btn_NovoProduto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_NovoProduto.Name = "Btn_NovoProduto";
            this.Btn_NovoProduto.Size = new System.Drawing.Size(129, 34);
            this.Btn_NovoProduto.TabIndex = 44;
            this.Btn_NovoProduto.Text = "Novo";
            this.Btn_NovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovoProduto.UseVisualStyleBackColor = true;
            this.Btn_NovoProduto.Click += new System.EventHandler(this.Btn_NovoProduto_Click);
            // 
            // imgPesquisaSimples
            // 
            this.imgPesquisaSimples.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPesquisaSimples.ImageStream")));
            this.imgPesquisaSimples.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPesquisaSimples.Images.SetKeyName(0, "Adicionar.png");
            this.imgPesquisaSimples.Images.SetKeyName(1, "Apagar.png");
            this.imgPesquisaSimples.Images.SetKeyName(2, "Editar.png");
            this.imgPesquisaSimples.Images.SetKeyName(3, "Excluir.png");
            this.imgPesquisaSimples.Images.SetKeyName(4, "Pesquisar.png");
            this.imgPesquisaSimples.Images.SetKeyName(5, "Salvar.png");
            this.imgPesquisaSimples.Images.SetKeyName(6, "Voltar.png");
            // 
            // Frm_GerenciamentoProduto_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Txt_InsumoOrigem);
            this.Controls.Add(this.Btn_PesquisaInsumo);
            this.Controls.Add(this.Btn_VoltarProduto);
            this.Controls.Add(this.Btn_BuscarProduto);
            this.Controls.Add(this.Btn_ExcluirProduto);
            this.Controls.Add(this.Btn_SalvarProduto);
            this.Controls.Add(this.Btn_EditarProduto);
            this.Controls.Add(this.Btn_NovoProduto);
            this.Controls.Add(this.Lbl_IdInsumoOrigem);
            this.Controls.Add(this.Lbl_NomeProduto);
            this.Controls.Add(this.Txt_NomeProduto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Rbtn_ProdutoInativo);
            this.Controls.Add(this.Rbtn_ProdutoAtivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_ConfigEstoqueColheita);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GerenciamentoProduto_UC";
            this.Size = new System.Drawing.Size(1200, 738);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Vencimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Colheita)).EndInit();
            this.groupBox_ConfigEstoqueColheita.ResumeLayout(false);
            this.groupBox_ConfigEstoqueColheita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_statusProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleProduto;
        private System.Windows.Forms.RadioButton Rbtn_ProdutoInativo;
        private System.Windows.Forms.RadioButton Rbtn_ProdutoAtivo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_InfoProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_NomeProduto;
        private System.Windows.Forms.Label Lbl_NomeProduto;
        private System.Windows.Forms.Label Lbl_IdInsumoOrigem;
        private System.Windows.Forms.Label label_PeriodoVenc;
        private System.Windows.Forms.NumericUpDown Num_Vencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Num_Colheita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_ConfigEstoqueColheita;
        private System.Windows.Forms.Button Btn_VoltarProduto;
        private System.Windows.Forms.Button Btn_BuscarProduto;
        private System.Windows.Forms.Button Btn_ExcluirProduto;
        private System.Windows.Forms.Button Btn_SalvarProduto;
        private System.Windows.Forms.Button Btn_EditarProduto;
        private System.Windows.Forms.Button Btn_NovoProduto;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_PesquisaInsumo;
        private System.Windows.Forms.ImageList botaoPesquisaSimples;
        private System.Windows.Forms.TextBox Txt_InsumoOrigem;
        private System.Windows.Forms.ImageList imgPesquisaSimples;
    }
}
