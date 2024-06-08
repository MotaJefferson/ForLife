namespace ForLife.Forms
{
    partial class Frm_CadastroProduto_UC
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
            this.comboBox_InsumoOrigem = new System.Windows.Forms.ComboBox();
            this.label_PeriodoVenc = new System.Windows.Forms.Label();
            this.numericUpDown_venc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Colheita = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_ConfigEstoqueColheita = new System.Windows.Forms.GroupBox();
            this.Btn_VoltarProduto = new System.Windows.Forms.Button();
            this.Btn_BuscarProduto = new System.Windows.Forms.Button();
            this.Btn_ExcluirProduto = new System.Windows.Forms.Button();
            this.Btn_SalvarProduto = new System.Windows.Forms.Button();
            this.Btn_EditarProduto = new System.Windows.Forms.Button();
            this.Btn_NovoProduto = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_venc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Colheita)).BeginInit();
            this.groupBox_ConfigEstoqueColheita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_statusProduto);
            this.panel2.Location = new System.Drawing.Point(-1, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 23);
            this.panel2.TabIndex = 29;
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
            // Lbl_statusProduto
            // 
            this.Lbl_statusProduto.AutoSize = true;
            this.Lbl_statusProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_statusProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_statusProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_statusProduto.Location = new System.Drawing.Point(19, 0);
            this.Lbl_statusProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_statusProduto.Name = "Lbl_statusProduto";
            this.Lbl_statusProduto.Size = new System.Drawing.Size(146, 19);
            this.Lbl_statusProduto.TabIndex = 20;
            this.Lbl_statusProduto.Text = "Status do produto";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleProduto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 59);
            this.panel1.TabIndex = 28;
            // 
            // Lbl_TitleProduto
            // 
            this.Lbl_TitleProduto.AutoSize = true;
            this.Lbl_TitleProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleProduto.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TitleProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleProduto.Name = "Lbl_TitleProduto";
            this.Lbl_TitleProduto.Size = new System.Drawing.Size(315, 30);
            this.Lbl_TitleProduto.TabIndex = 0;
            this.Lbl_TitleProduto.Text = "Gerenciamento do produto";
            // 
            // Rbtn_ProdutoInativo
            // 
            this.Rbtn_ProdutoInativo.AutoSize = true;
            this.Rbtn_ProdutoInativo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ProdutoInativo.Location = new System.Drawing.Point(166, 137);
            this.Rbtn_ProdutoInativo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_ProdutoInativo.Name = "Rbtn_ProdutoInativo";
            this.Rbtn_ProdutoInativo.Size = new System.Drawing.Size(73, 24);
            this.Rbtn_ProdutoInativo.TabIndex = 31;
            this.Rbtn_ProdutoInativo.Text = "Inativo";
            this.Rbtn_ProdutoInativo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_ProdutoAtivo
            // 
            this.Rbtn_ProdutoAtivo.AutoSize = true;
            this.Rbtn_ProdutoAtivo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ProdutoAtivo.Location = new System.Drawing.Point(35, 137);
            this.Rbtn_ProdutoAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_ProdutoAtivo.Name = "Rbtn_ProdutoAtivo";
            this.Rbtn_ProdutoAtivo.Size = new System.Drawing.Size(62, 24);
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
            this.panel4.Location = new System.Drawing.Point(0, 196);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 25);
            this.panel4.TabIndex = 32;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Lbl_InfoProduto
            // 
            this.Lbl_InfoProduto.AutoSize = true;
            this.Lbl_InfoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoProduto.Location = new System.Drawing.Point(19, 0);
            this.Lbl_InfoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InfoProduto.Name = "Lbl_InfoProduto";
            this.Lbl_InfoProduto.Size = new System.Drawing.Size(194, 19);
            this.Lbl_InfoProduto.TabIndex = 21;
            this.Lbl_InfoProduto.Text = "Informações do Produto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OliveDrab;
            this.panel5.Location = new System.Drawing.Point(7, 41);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 27);
            this.panel5.TabIndex = 28;
            // 
            // Txt_NomeProduto
            // 
            this.Txt_NomeProduto.AcceptsTab = true;
            this.Txt_NomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProduto.Location = new System.Drawing.Point(35, 279);
            this.Txt_NomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NomeProduto.Name = "Txt_NomeProduto";
            this.Txt_NomeProduto.Size = new System.Drawing.Size(618, 25);
            this.Txt_NomeProduto.TabIndex = 33;
            // 
            // Lbl_NomeProduto
            // 
            this.Lbl_NomeProduto.AutoSize = true;
            this.Lbl_NomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeProduto.Location = new System.Drawing.Point(31, 251);
            this.Lbl_NomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeProduto.Name = "Lbl_NomeProduto";
            this.Lbl_NomeProduto.Size = new System.Drawing.Size(109, 20);
            this.Lbl_NomeProduto.TabIndex = 34;
            this.Lbl_NomeProduto.Text = "Nome produto";
            // 
            // Lbl_IdInsumoOrigem
            // 
            this.Lbl_IdInsumoOrigem.AutoSize = true;
            this.Lbl_IdInsumoOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdInsumoOrigem.Location = new System.Drawing.Point(32, 352);
            this.Lbl_IdInsumoOrigem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_IdInsumoOrigem.Name = "Lbl_IdInsumoOrigem";
            this.Lbl_IdInsumoOrigem.Size = new System.Drawing.Size(132, 20);
            this.Lbl_IdInsumoOrigem.TabIndex = 35;
            this.Lbl_IdInsumoOrigem.Text = "Insumo de origem";
            // 
            // comboBox_InsumoOrigem
            // 
            this.comboBox_InsumoOrigem.FormattingEnabled = true;
            this.comboBox_InsumoOrigem.Location = new System.Drawing.Point(35, 375);
            this.comboBox_InsumoOrigem.Name = "comboBox_InsumoOrigem";
            this.comboBox_InsumoOrigem.Size = new System.Drawing.Size(270, 21);
            this.comboBox_InsumoOrigem.TabIndex = 36;
            // 
            // label_PeriodoVenc
            // 
            this.label_PeriodoVenc.AutoSize = true;
            this.label_PeriodoVenc.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PeriodoVenc.ForeColor = System.Drawing.Color.Black;
            this.label_PeriodoVenc.Location = new System.Drawing.Point(25, 30);
            this.label_PeriodoVenc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PeriodoVenc.Name = "label_PeriodoVenc";
            this.label_PeriodoVenc.Size = new System.Drawing.Size(90, 20);
            this.label_PeriodoVenc.TabIndex = 37;
            this.label_PeriodoVenc.Text = "Vencimento";
            // 
            // numericUpDown_venc
            // 
            this.numericUpDown_venc.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_venc.Location = new System.Drawing.Point(29, 53);
            this.numericUpDown_venc.Name = "numericUpDown_venc";
            this.numericUpDown_venc.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown_venc.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Dia(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Dia(s)";
            // 
            // numericUpDown_Colheita
            // 
            this.numericUpDown_Colheita.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Colheita.Location = new System.Drawing.Point(178, 53);
            this.numericUpDown_Colheita.Name = "numericUpDown_Colheita";
            this.numericUpDown_Colheita.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown_Colheita.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Colheita";
            // 
            // groupBox_ConfigEstoqueColheita
            // 
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label_PeriodoVenc);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label3);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label2);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.label1);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.numericUpDown_Colheita);
            this.groupBox_ConfigEstoqueColheita.Controls.Add(this.numericUpDown_venc);
            this.groupBox_ConfigEstoqueColheita.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ConfigEstoqueColheita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.groupBox_ConfigEstoqueColheita.Location = new System.Drawing.Point(329, 322);
            this.groupBox_ConfigEstoqueColheita.Name = "groupBox_ConfigEstoqueColheita";
            this.groupBox_ConfigEstoqueColheita.Size = new System.Drawing.Size(324, 82);
            this.groupBox_ConfigEstoqueColheita.TabIndex = 43;
            this.groupBox_ConfigEstoqueColheita.TabStop = false;
            this.groupBox_ConfigEstoqueColheita.Text = "Configurações de estoque/colheita";
            // 
            // Btn_VoltarProduto
            // 
            this.Btn_VoltarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarProduto.ImageKey = "Voltar.png";
            this.Btn_VoltarProduto.Location = new System.Drawing.Point(631, 462);
            this.Btn_VoltarProduto.Name = "Btn_VoltarProduto";
            this.Btn_VoltarProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_VoltarProduto.TabIndex = 49;
            this.Btn_VoltarProduto.Text = "Voltar";
            this.Btn_VoltarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarProduto.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarProduto
            // 
            this.Btn_BuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarProduto.ImageKey = "Pesquisar.png";
            this.Btn_BuscarProduto.Location = new System.Drawing.Point(528, 462);
            this.Btn_BuscarProduto.Name = "Btn_BuscarProduto";
            this.Btn_BuscarProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_BuscarProduto.TabIndex = 48;
            this.Btn_BuscarProduto.Text = "Buscar";
            this.Btn_BuscarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarProduto.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirProduto
            // 
            this.Btn_ExcluirProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirProduto.ImageKey = "Apagar.png";
            this.Btn_ExcluirProduto.Location = new System.Drawing.Point(426, 462);
            this.Btn_ExcluirProduto.Name = "Btn_ExcluirProduto";
            this.Btn_ExcluirProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_ExcluirProduto.TabIndex = 47;
            this.Btn_ExcluirProduto.Text = "Excluir";
            this.Btn_ExcluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarProduto
            // 
            this.Btn_SalvarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarProduto.ImageKey = "Salvar.png";
            this.Btn_SalvarProduto.Location = new System.Drawing.Point(323, 462);
            this.Btn_SalvarProduto.Name = "Btn_SalvarProduto";
            this.Btn_SalvarProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_SalvarProduto.TabIndex = 46;
            this.Btn_SalvarProduto.Text = "Salvar";
            this.Btn_SalvarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarProduto.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarProduto
            // 
            this.Btn_EditarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarProduto.ImageKey = "Editar.png";
            this.Btn_EditarProduto.Location = new System.Drawing.Point(218, 462);
            this.Btn_EditarProduto.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_EditarProduto.Name = "Btn_EditarProduto";
            this.Btn_EditarProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_EditarProduto.TabIndex = 45;
            this.Btn_EditarProduto.Text = "Editar";
            this.Btn_EditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarProduto.UseVisualStyleBackColor = true;
            // 
            // Btn_NovoProduto
            // 
            this.Btn_NovoProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovoProduto.ImageKey = "Adicionar.png";
            this.Btn_NovoProduto.Location = new System.Drawing.Point(111, 462);
            this.Btn_NovoProduto.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_NovoProduto.Name = "Btn_NovoProduto";
            this.Btn_NovoProduto.Size = new System.Drawing.Size(97, 28);
            this.Btn_NovoProduto.TabIndex = 44;
            this.Btn_NovoProduto.Text = "Novo";
            this.Btn_NovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovoProduto.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroProduto_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_VoltarProduto);
            this.Controls.Add(this.Btn_BuscarProduto);
            this.Controls.Add(this.Btn_ExcluirProduto);
            this.Controls.Add(this.Btn_SalvarProduto);
            this.Controls.Add(this.Btn_EditarProduto);
            this.Controls.Add(this.Btn_NovoProduto);
            this.Controls.Add(this.comboBox_InsumoOrigem);
            this.Controls.Add(this.Lbl_IdInsumoOrigem);
            this.Controls.Add(this.Lbl_NomeProduto);
            this.Controls.Add(this.Txt_NomeProduto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Rbtn_ProdutoInativo);
            this.Controls.Add(this.Rbtn_ProdutoAtivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_ConfigEstoqueColheita);
            this.Name = "Frm_CadastroProduto_UC";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_venc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Colheita)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_InsumoOrigem;
        private System.Windows.Forms.Label label_PeriodoVenc;
        private System.Windows.Forms.NumericUpDown numericUpDown_venc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Colheita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_ConfigEstoqueColheita;
        private System.Windows.Forms.Button Btn_VoltarProduto;
        private System.Windows.Forms.Button Btn_BuscarProduto;
        private System.Windows.Forms.Button Btn_ExcluirProduto;
        private System.Windows.Forms.Button Btn_SalvarProduto;
        private System.Windows.Forms.Button Btn_EditarProduto;
        private System.Windows.Forms.Button Btn_NovoProduto;
    }
}
