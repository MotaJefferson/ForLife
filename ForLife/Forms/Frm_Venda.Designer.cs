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
            this.Txt_NomeProdutoVenda = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_InfoVenda = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_NomeProdutoVenda = new System.Windows.Forms.Label();
            this.groupBox_ValoresVenda = new System.Windows.Forms.GroupBox();
            this.label_ValorVenda = new System.Windows.Forms.Label();
            this.Lbl_ValorTotalVenda = new System.Windows.Forms.Label();
            this.Lbl_qtdProdutoVenda = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox_ValorTotalVenda = new System.Windows.Forms.TextBox();
            this.textBox_ValorUnitario = new System.Windows.Forms.TextBox();
            this.label_Cifrao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_NomeClienteVenda = new System.Windows.Forms.Label();
            this.textBox__NomeClienteVenda = new System.Windows.Forms.TextBox();
            this.Btn__PesqNomeClienteVenda = new System.Windows.Forms.Button();
            this.Btn_PesquisaProdutoVenda = new System.Windows.Forms.Button();
            this.Btn_VoltarCliente = new System.Windows.Forms.Button();
            this.Btn_BuscarVenda = new System.Windows.Forms.Button();
            this.Btn_ExcluirVenda = new System.Windows.Forms.Button();
            this.Btn_SalvarVenda = new System.Windows.Forms.Button();
            this.Btn_EditarVenda = new System.Windows.Forms.Button();
            this.Btn_NovaVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox_ValoresVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.BackgroundImage = global::ForLife.Properties.Resources.Logo_ForLife_SemFundo;
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
            this.Rbtn_dinheiro.Location = new System.Drawing.Point(145, 378);
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
            this.Rbtn_cartao.Location = new System.Drawing.Point(40, 378);
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
            this.panel2.Location = new System.Drawing.Point(-1, 337);
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
            this.Rdb_Pix.Location = new System.Drawing.Point(268, 378);
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
            // Txt_NomeProdutoVenda
            // 
            this.Txt_NomeProdutoVenda.AcceptsTab = true;
            this.Txt_NomeProdutoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeProdutoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProdutoVenda.Location = new System.Drawing.Point(39, 255);
            this.Txt_NomeProdutoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NomeProdutoVenda.Name = "Txt_NomeProdutoVenda";
            this.Txt_NomeProdutoVenda.Size = new System.Drawing.Size(345, 25);
            this.Txt_NomeProdutoVenda.TabIndex = 74;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.Lbl_InfoVenda);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-3, 99);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 25);
            this.panel4.TabIndex = 73;
            // 
            // Lbl_InfoVenda
            // 
            this.Lbl_InfoVenda.AutoSize = true;
            this.Lbl_InfoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoVenda.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoVenda.Location = new System.Drawing.Point(19, 0);
            this.Lbl_InfoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InfoVenda.Name = "Lbl_InfoVenda";
            this.Lbl_InfoVenda.Size = new System.Drawing.Size(180, 19);
            this.Lbl_InfoVenda.TabIndex = 21;
            this.Lbl_InfoVenda.Text = "Informações da Venda";
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
            // Lbl_NomeProdutoVenda
            // 
            this.Lbl_NomeProdutoVenda.AutoSize = true;
            this.Lbl_NomeProdutoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeProdutoVenda.Location = new System.Drawing.Point(35, 233);
            this.Lbl_NomeProdutoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeProdutoVenda.Name = "Lbl_NomeProdutoVenda";
            this.Lbl_NomeProdutoVenda.Size = new System.Drawing.Size(131, 20);
            this.Lbl_NomeProdutoVenda.TabIndex = 75;
            this.Lbl_NomeProdutoVenda.Text = "Nome do Produto";
            // 
            // groupBox_ValoresVenda
            // 
            this.groupBox_ValoresVenda.Controls.Add(this.label1);
            this.groupBox_ValoresVenda.Controls.Add(this.label_Cifrao);
            this.groupBox_ValoresVenda.Controls.Add(this.textBox_ValorTotalVenda);
            this.groupBox_ValoresVenda.Controls.Add(this.textBox_ValorUnitario);
            this.groupBox_ValoresVenda.Controls.Add(this.label_ValorVenda);
            this.groupBox_ValoresVenda.Controls.Add(this.Lbl_ValorTotalVenda);
            this.groupBox_ValoresVenda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ValoresVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.groupBox_ValoresVenda.Location = new System.Drawing.Point(541, 209);
            this.groupBox_ValoresVenda.Name = "groupBox_ValoresVenda";
            this.groupBox_ValoresVenda.Size = new System.Drawing.Size(285, 95);
            this.groupBox_ValoresVenda.TabIndex = 77;
            this.groupBox_ValoresVenda.TabStop = false;
            this.groupBox_ValoresVenda.Text = "Valores da venda";
            // 
            // label_ValorVenda
            // 
            this.label_ValorVenda.AutoSize = true;
            this.label_ValorVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorVenda.ForeColor = System.Drawing.Color.Black;
            this.label_ValorVenda.Location = new System.Drawing.Point(44, 28);
            this.label_ValorVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ValorVenda.Name = "label_ValorVenda";
            this.label_ValorVenda.Size = new System.Drawing.Size(78, 20);
            this.label_ValorVenda.TabIndex = 37;
            this.label_ValorVenda.Text = "Valor unit.";
            // 
            // Lbl_ValorTotalVenda
            // 
            this.Lbl_ValorTotalVenda.AutoSize = true;
            this.Lbl_ValorTotalVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValorTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ValorTotalVenda.Location = new System.Drawing.Point(176, 27);
            this.Lbl_ValorTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ValorTotalVenda.Name = "Lbl_ValorTotalVenda";
            this.Lbl_ValorTotalVenda.Size = new System.Drawing.Size(79, 20);
            this.Lbl_ValorTotalVenda.TabIndex = 40;
            this.Lbl_ValorTotalVenda.Text = "Valor total";
            // 
            // Lbl_qtdProdutoVenda
            // 
            this.Lbl_qtdProdutoVenda.AutoSize = true;
            this.Lbl_qtdProdutoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_qtdProdutoVenda.ForeColor = System.Drawing.Color.Black;
            this.Lbl_qtdProdutoVenda.Location = new System.Drawing.Point(431, 234);
            this.Lbl_qtdProdutoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_qtdProdutoVenda.Name = "Lbl_qtdProdutoVenda";
            this.Lbl_qtdProdutoVenda.Size = new System.Drawing.Size(89, 20);
            this.Lbl_qtdProdutoVenda.TabIndex = 78;
            this.Lbl_qtdProdutoVenda.Text = "Quantidade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(435, 256);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 22);
            this.numericUpDown1.TabIndex = 79;
            // 
            // textBox_ValorTotalVenda
            // 
            this.textBox_ValorTotalVenda.Location = new System.Drawing.Point(179, 46);
            this.textBox_ValorTotalVenda.Name = "textBox_ValorTotalVenda";
            this.textBox_ValorTotalVenda.Size = new System.Drawing.Size(78, 22);
            this.textBox_ValorTotalVenda.TabIndex = 44;
            // 
            // textBox_ValorUnitario
            // 
            this.textBox_ValorUnitario.Location = new System.Drawing.Point(47, 47);
            this.textBox_ValorUnitario.Name = "textBox_ValorUnitario";
            this.textBox_ValorUnitario.Size = new System.Drawing.Size(78, 22);
            this.textBox_ValorUnitario.TabIndex = 43;
            // 
            // label_Cifrao
            // 
            this.label_Cifrao.AutoSize = true;
            this.label_Cifrao.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cifrao.ForeColor = System.Drawing.Color.Black;
            this.label_Cifrao.Location = new System.Drawing.Point(18, 49);
            this.label_Cifrao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Cifrao.Name = "label_Cifrao";
            this.label_Cifrao.Size = new System.Drawing.Size(26, 20);
            this.label_Cifrao.TabIndex = 45;
            this.label_Cifrao.Text = "R$";
            this.label_Cifrao.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "R$";
            // 
            // Lbl_NomeClienteVenda
            // 
            this.Lbl_NomeClienteVenda.AutoSize = true;
            this.Lbl_NomeClienteVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeClienteVenda.Location = new System.Drawing.Point(36, 153);
            this.Lbl_NomeClienteVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeClienteVenda.Name = "Lbl_NomeClienteVenda";
            this.Lbl_NomeClienteVenda.Size = new System.Drawing.Size(123, 20);
            this.Lbl_NomeClienteVenda.TabIndex = 81;
            this.Lbl_NomeClienteVenda.Text = "Nome do Cliente";
            // 
            // textBox__NomeClienteVenda
            // 
            this.textBox__NomeClienteVenda.AcceptsTab = true;
            this.textBox__NomeClienteVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox__NomeClienteVenda.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__NomeClienteVenda.Location = new System.Drawing.Point(40, 175);
            this.textBox__NomeClienteVenda.Margin = new System.Windows.Forms.Padding(2);
            this.textBox__NomeClienteVenda.Name = "textBox__NomeClienteVenda";
            this.textBox__NomeClienteVenda.Size = new System.Drawing.Size(345, 25);
            this.textBox__NomeClienteVenda.TabIndex = 80;
            // 
            // Btn__PesqNomeClienteVenda
            // 
            this.Btn__PesqNomeClienteVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn__PesqNomeClienteVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn__PesqNomeClienteVenda.ImageKey = "Pesquisar.png";
            this.Btn__PesqNomeClienteVenda.ImageList = this.imgList_Usuario;
            this.Btn__PesqNomeClienteVenda.Location = new System.Drawing.Point(390, 173);
            this.Btn__PesqNomeClienteVenda.Name = "Btn__PesqNomeClienteVenda";
            this.Btn__PesqNomeClienteVenda.Size = new System.Drawing.Size(26, 27);
            this.Btn__PesqNomeClienteVenda.TabIndex = 82;
            this.Btn__PesqNomeClienteVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn__PesqNomeClienteVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_PesquisaProdutoVenda
            // 
            this.Btn_PesquisaProdutoVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PesquisaProdutoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PesquisaProdutoVenda.ImageKey = "Pesquisar.png";
            this.Btn_PesquisaProdutoVenda.ImageList = this.imgList_Usuario;
            this.Btn_PesquisaProdutoVenda.Location = new System.Drawing.Point(389, 253);
            this.Btn_PesquisaProdutoVenda.Name = "Btn_PesquisaProdutoVenda";
            this.Btn_PesquisaProdutoVenda.Size = new System.Drawing.Size(26, 27);
            this.Btn_PesquisaProdutoVenda.TabIndex = 76;
            this.Btn_PesquisaProdutoVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisaProdutoVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_VoltarCliente
            // 
            this.Btn_VoltarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarCliente.ImageKey = "Voltar.png";
            this.Btn_VoltarCliente.ImageList = this.imgList_Usuario;
            this.Btn_VoltarCliente.Location = new System.Drawing.Point(655, 464);
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
            this.Btn_BuscarVenda.Location = new System.Drawing.Point(552, 464);
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
            this.Btn_ExcluirVenda.Location = new System.Drawing.Point(450, 464);
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
            this.Btn_SalvarVenda.Location = new System.Drawing.Point(347, 464);
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
            this.Btn_EditarVenda.Location = new System.Drawing.Point(242, 464);
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
            this.Btn_NovaVenda.Location = new System.Drawing.Point(135, 464);
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
            this.Controls.Add(this.Btn__PesqNomeClienteVenda);
            this.Controls.Add(this.Lbl_NomeClienteVenda);
            this.Controls.Add(this.textBox__NomeClienteVenda);
            this.Controls.Add(this.Lbl_qtdProdutoVenda);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox_ValoresVenda);
            this.Controls.Add(this.Btn_PesquisaProdutoVenda);
            this.Controls.Add(this.Lbl_NomeProdutoVenda);
            this.Controls.Add(this.Txt_NomeProdutoVenda);
            this.Controls.Add(this.panel4);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox_ValoresVenda.ResumeLayout(false);
            this.groupBox_ValoresVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_NomeProdutoVenda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_InfoVenda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_NomeProdutoVenda;
        private System.Windows.Forms.Button Btn_PesquisaProdutoVenda;
        private System.Windows.Forms.GroupBox groupBox_ValoresVenda;
        private System.Windows.Forms.Label label_ValorVenda;
        private System.Windows.Forms.Label Lbl_ValorTotalVenda;
        private System.Windows.Forms.Label Lbl_qtdProdutoVenda;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_ValorTotalVenda;
        private System.Windows.Forms.Label label_Cifrao;
        private System.Windows.Forms.TextBox textBox_ValorUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn__PesqNomeClienteVenda;
        private System.Windows.Forms.Label Lbl_NomeClienteVenda;
        private System.Windows.Forms.TextBox textBox__NomeClienteVenda;
    }
}
