namespace ForLife.Forms
{
    partial class Frm_Plantio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Plantio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_RelatorioPlantio = new System.Windows.Forms.Button();
            this.Lbl_produtoDesejadoPlantio = new System.Windows.Forms.Label();
            this.Txt_produtoDesejadoPlantio = new System.Windows.Forms.TextBox();
            this.Grd_Plantacao = new System.Windows.Forms.DataGridView();
            this.Btn_AtualizarPlantacao = new System.Windows.Forms.Button();
            this.textBox_PesquisarNaPlantacao = new System.Windows.Forms.TextBox();
            this.Lbl_PesquisarNaPlantacao = new System.Windows.Forms.Label();
            this.Lbl_QtdIProdutoPlantio = new System.Windows.Forms.Label();
            this.textBox_QtdProdutoPlantio = new System.Windows.Forms.TextBox();
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Pesquisa_produtoDesejadoPlantio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_plantar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_PesquisarNaPlantacao = new System.Windows.Forms.Button();
            this.Btn_ColherDescartar = new System.Windows.Forms.Button();
            this.Btn_PlantarProdutoPlantio = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_Plantacao = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitlePlantio = new System.Windows.Forms.Label();
            this.Btn_ColherArmazenar = new System.Windows.Forms.Button();
            this.Coluna_ProdutoPlantacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_QuantidadePlantada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_DataColheita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_DataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Plantacao)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_RelatorioPlantio
            // 
            this.Btn_RelatorioPlantio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RelatorioPlantio.ForeColor = System.Drawing.Color.Black;
            this.Btn_RelatorioPlantio.Location = new System.Drawing.Point(588, 343);
            this.Btn_RelatorioPlantio.Name = "Btn_RelatorioPlantio";
            this.Btn_RelatorioPlantio.Size = new System.Drawing.Size(118, 22);
            this.Btn_RelatorioPlantio.TabIndex = 85;
            this.Btn_RelatorioPlantio.Text = "Relatório Completo";
            this.Btn_RelatorioPlantio.UseVisualStyleBackColor = true;
            // 
            // Lbl_produtoDesejadoPlantio
            // 
            this.Lbl_produtoDesejadoPlantio.AutoSize = true;
            this.Lbl_produtoDesejadoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_produtoDesejadoPlantio.Location = new System.Drawing.Point(32, 120);
            this.Lbl_produtoDesejadoPlantio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_produtoDesejadoPlantio.Name = "Lbl_produtoDesejadoPlantio";
            this.Lbl_produtoDesejadoPlantio.Size = new System.Drawing.Size(113, 17);
            this.Lbl_produtoDesejadoPlantio.TabIndex = 83;
            this.Lbl_produtoDesejadoPlantio.Text = "Produto desejado";
            // 
            // Txt_produtoDesejadoPlantio
            // 
            this.Txt_produtoDesejadoPlantio.AcceptsTab = true;
            this.Txt_produtoDesejadoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_produtoDesejadoPlantio.Location = new System.Drawing.Point(35, 137);
            this.Txt_produtoDesejadoPlantio.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_produtoDesejadoPlantio.Name = "Txt_produtoDesejadoPlantio";
            this.Txt_produtoDesejadoPlantio.Size = new System.Drawing.Size(308, 21);
            this.Txt_produtoDesejadoPlantio.TabIndex = 82;
            // 
            // Grd_Plantacao
            // 
            this.Grd_Plantacao.AllowUserToAddRows = false;
            this.Grd_Plantacao.AllowUserToDeleteRows = false;
            this.Grd_Plantacao.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_Plantacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_Plantacao.BackgroundColor = System.Drawing.Color.White;
            this.Grd_Plantacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Plantacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_ProdutoPlantacao,
            this.Coluna_QuantidadePlantada,
            this.Coluna_DataColheita,
            this.Coluna_DataValidade});
            this.Grd_Plantacao.Location = new System.Drawing.Point(68, 373);
            this.Grd_Plantacao.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_Plantacao.MultiSelect = false;
            this.Grd_Plantacao.Name = "Grd_Plantacao";
            this.Grd_Plantacao.ReadOnly = true;
            this.Grd_Plantacao.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_Plantacao.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_Plantacao.RowTemplate.Height = 24;
            this.Grd_Plantacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_Plantacao.Size = new System.Drawing.Size(754, 206);
            this.Grd_Plantacao.TabIndex = 81;
            // 
            // Btn_AtualizarPlantacao
            // 
            this.Btn_AtualizarPlantacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_AtualizarPlantacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AtualizarPlantacao.ForeColor = System.Drawing.Color.Black;
            this.Btn_AtualizarPlantacao.Location = new System.Drawing.Point(447, 343);
            this.Btn_AtualizarPlantacao.Name = "Btn_AtualizarPlantacao";
            this.Btn_AtualizarPlantacao.Size = new System.Drawing.Size(135, 23);
            this.Btn_AtualizarPlantacao.TabIndex = 88;
            this.Btn_AtualizarPlantacao.Text = "Atualizar Plantação";
            this.Btn_AtualizarPlantacao.UseVisualStyleBackColor = false;
            // 
            // textBox_PesquisarNaPlantacao
            // 
            this.textBox_PesquisarNaPlantacao.AcceptsTab = true;
            this.textBox_PesquisarNaPlantacao.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesquisarNaPlantacao.Location = new System.Drawing.Point(163, 303);
            this.textBox_PesquisarNaPlantacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PesquisarNaPlantacao.Name = "textBox_PesquisarNaPlantacao";
            this.textBox_PesquisarNaPlantacao.Size = new System.Drawing.Size(359, 21);
            this.textBox_PesquisarNaPlantacao.TabIndex = 89;
            // 
            // Lbl_PesquisarNaPlantacao
            // 
            this.Lbl_PesquisarNaPlantacao.AutoSize = true;
            this.Lbl_PesquisarNaPlantacao.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesquisarNaPlantacao.Location = new System.Drawing.Point(160, 284);
            this.Lbl_PesquisarNaPlantacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisarNaPlantacao.Name = "Lbl_PesquisarNaPlantacao";
            this.Lbl_PesquisarNaPlantacao.Size = new System.Drawing.Size(143, 17);
            this.Lbl_PesquisarNaPlantacao.TabIndex = 90;
            this.Lbl_PesquisarNaPlantacao.Text = "Pesquisar na plantação";
            // 
            // Lbl_QtdIProdutoPlantio
            // 
            this.Lbl_QtdIProdutoPlantio.AutoSize = true;
            this.Lbl_QtdIProdutoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QtdIProdutoPlantio.Location = new System.Drawing.Point(401, 120);
            this.Lbl_QtdIProdutoPlantio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_QtdIProdutoPlantio.Name = "Lbl_QtdIProdutoPlantio";
            this.Lbl_QtdIProdutoPlantio.Size = new System.Drawing.Size(76, 17);
            this.Lbl_QtdIProdutoPlantio.TabIndex = 92;
            this.Lbl_QtdIProdutoPlantio.Text = "Quantidade";
            // 
            // textBox_QtdProdutoPlantio
            // 
            this.textBox_QtdProdutoPlantio.AcceptsTab = true;
            this.textBox_QtdProdutoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_QtdProdutoPlantio.Location = new System.Drawing.Point(404, 137);
            this.textBox_QtdProdutoPlantio.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_QtdProdutoPlantio.Name = "textBox_QtdProdutoPlantio";
            this.textBox_QtdProdutoPlantio.Size = new System.Drawing.Size(73, 21);
            this.textBox_QtdProdutoPlantio.TabIndex = 91;
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
            // Btn_Pesquisa_produtoDesejadoPlantio
            // 
            this.Btn_Pesquisa_produtoDesejadoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_Pesquisa_produtoDesejadoPlantio.ImageKey = "Pesquisar.png";
            this.Btn_Pesquisa_produtoDesejadoPlantio.ImageList = this.imageIcons;
            this.Btn_Pesquisa_produtoDesejadoPlantio.Location = new System.Drawing.Point(347, 137);
            this.Btn_Pesquisa_produtoDesejadoPlantio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Pesquisa_produtoDesejadoPlantio.Name = "Btn_Pesquisa_produtoDesejadoPlantio";
            this.Btn_Pesquisa_produtoDesejadoPlantio.Size = new System.Drawing.Size(35, 22);
            this.Btn_Pesquisa_produtoDesejadoPlantio.TabIndex = 94;
            this.Btn_Pesquisa_produtoDesejadoPlantio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Pesquisa_produtoDesejadoPlantio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Pesquisa_produtoDesejadoPlantio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.Lbl_plantar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-505, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 21);
            this.panel2.TabIndex = 93;
            // 
            // Lbl_plantar
            // 
            this.Lbl_plantar.AutoSize = true;
            this.Lbl_plantar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_plantar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_plantar.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_plantar.Location = new System.Drawing.Point(530, 2);
            this.Lbl_plantar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_plantar.Name = "Lbl_plantar";
            this.Lbl_plantar.Size = new System.Drawing.Size(63, 19);
            this.Lbl_plantar.TabIndex = 21;
            this.Lbl_plantar.Text = "Plantar";
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
            // Btn_PesquisarNaPlantacao
            // 
            this.Btn_PesquisarNaPlantacao.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarNaPlantacao.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarNaPlantacao.ImageList = this.imageIcons;
            this.Btn_PesquisarNaPlantacao.Location = new System.Drawing.Point(529, 302);
            this.Btn_PesquisarNaPlantacao.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarNaPlantacao.Name = "Btn_PesquisarNaPlantacao";
            this.Btn_PesquisarNaPlantacao.Size = new System.Drawing.Size(35, 22);
            this.Btn_PesquisarNaPlantacao.TabIndex = 86;
            this.Btn_PesquisarNaPlantacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarNaPlantacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarNaPlantacao.UseVisualStyleBackColor = true;
            // 
            // Btn_ColherDescartar
            // 
            this.Btn_ColherDescartar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ColherDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_ColherDescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ColherDescartar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ColherDescartar.ForeColor = System.Drawing.Color.DarkRed;
            this.Btn_ColherDescartar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ColherDescartar.ImageKey = "(nenhum/a)";
            this.Btn_ColherDescartar.Location = new System.Drawing.Point(306, 343);
            this.Btn_ColherDescartar.Name = "Btn_ColherDescartar";
            this.Btn_ColherDescartar.Size = new System.Drawing.Size(135, 23);
            this.Btn_ColherDescartar.TabIndex = 78;
            this.Btn_ColherDescartar.Text = "Colher e descartar";
            this.Btn_ColherDescartar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ColherDescartar.UseVisualStyleBackColor = false;
            // 
            // Btn_PlantarProdutoPlantio
            // 
            this.Btn_PlantarProdutoPlantio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_PlantarProdutoPlantio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_PlantarProdutoPlantio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_PlantarProdutoPlantio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlantarProdutoPlantio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PlantarProdutoPlantio.ImageKey = "(nenhum/a)";
            this.Btn_PlantarProdutoPlantio.Location = new System.Drawing.Point(35, 165);
            this.Btn_PlantarProdutoPlantio.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_PlantarProdutoPlantio.Name = "Btn_PlantarProdutoPlantio";
            this.Btn_PlantarProdutoPlantio.Size = new System.Drawing.Size(135, 23);
            this.Btn_PlantarProdutoPlantio.TabIndex = 75;
            this.Btn_PlantarProdutoPlantio.Text = "Plantar";
            this.Btn_PlantarProdutoPlantio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PlantarProdutoPlantio.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.BackgroundImage = global::ForLife.Properties.Resources.Logo_ForLife_SemFundo;
            this.panel4.Controls.Add(this.Lbl_Plantacao);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-1, 227);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 43);
            this.panel4.TabIndex = 74;
            // 
            // Lbl_Plantacao
            // 
            this.Lbl_Plantacao.AutoSize = true;
            this.Lbl_Plantacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_Plantacao.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Plantacao.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_Plantacao.Location = new System.Drawing.Point(415, 10);
            this.Lbl_Plantacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Plantacao.Name = "Lbl_Plantacao";
            this.Lbl_Plantacao.Size = new System.Drawing.Size(94, 24);
            this.Lbl_Plantacao.TabIndex = 21;
            this.Lbl_Plantacao.Text = "Plantação";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.BackgroundImage = global::ForLife.Properties.Resources.Logo_ForLife_SemFundo;
            this.panel1.Controls.Add(this.Lbl_TitlePlantio);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 59);
            this.panel1.TabIndex = 32;
            // 
            // Lbl_TitlePlantio
            // 
            this.Lbl_TitlePlantio.AutoSize = true;
            this.Lbl_TitlePlantio.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitlePlantio.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitlePlantio.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TitlePlantio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitlePlantio.Name = "Lbl_TitlePlantio";
            this.Lbl_TitlePlantio.Size = new System.Drawing.Size(91, 30);
            this.Lbl_TitlePlantio.TabIndex = 0;
            this.Lbl_TitlePlantio.Text = "Plantio";
            // 
            // Btn_ColherArmazenar
            // 
            this.Btn_ColherArmazenar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ColherArmazenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_ColherArmazenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ColherArmazenar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ColherArmazenar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Btn_ColherArmazenar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ColherArmazenar.ImageKey = "(nenhum/a)";
            this.Btn_ColherArmazenar.Location = new System.Drawing.Point(163, 343);
            this.Btn_ColherArmazenar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_ColherArmazenar.Name = "Btn_ColherArmazenar";
            this.Btn_ColherArmazenar.Size = new System.Drawing.Size(135, 23);
            this.Btn_ColherArmazenar.TabIndex = 95;
            this.Btn_ColherArmazenar.Text = "Colher e armazenar";
            this.Btn_ColherArmazenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ColherArmazenar.UseVisualStyleBackColor = false;
            // 
            // Coluna_ProdutoPlantacao
            // 
            this.Coluna_ProdutoPlantacao.DividerWidth = 1;
            this.Coluna_ProdutoPlantacao.HeaderText = "Produto";
            this.Coluna_ProdutoPlantacao.MinimumWidth = 6;
            this.Coluna_ProdutoPlantacao.Name = "Coluna_ProdutoPlantacao";
            this.Coluna_ProdutoPlantacao.ReadOnly = true;
            this.Coluna_ProdutoPlantacao.Width = 350;
            // 
            // Coluna_QuantidadePlantada
            // 
            this.Coluna_QuantidadePlantada.HeaderText = "Qtd plantada";
            this.Coluna_QuantidadePlantada.MinimumWidth = 6;
            this.Coluna_QuantidadePlantada.Name = "Coluna_QuantidadePlantada";
            this.Coluna_QuantidadePlantada.ReadOnly = true;
            this.Coluna_QuantidadePlantada.Width = 110;
            // 
            // Coluna_DataColheita
            // 
            this.Coluna_DataColheita.HeaderText = "Data Colheita";
            this.Coluna_DataColheita.MinimumWidth = 6;
            this.Coluna_DataColheita.Name = "Coluna_DataColheita";
            this.Coluna_DataColheita.ReadOnly = true;
            this.Coluna_DataColheita.Width = 140;
            // 
            // Coluna_DataValidade
            // 
            this.Coluna_DataValidade.HeaderText = "Data Validade";
            this.Coluna_DataValidade.Name = "Coluna_DataValidade";
            this.Coluna_DataValidade.ReadOnly = true;
            // 
            // Frm_Plantio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_ColherArmazenar);
            this.Controls.Add(this.Btn_Pesquisa_produtoDesejadoPlantio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_ColherDescartar);
            this.Controls.Add(this.Lbl_QtdIProdutoPlantio);
            this.Controls.Add(this.textBox_QtdProdutoPlantio);
            this.Controls.Add(this.Lbl_PesquisarNaPlantacao);
            this.Controls.Add(this.textBox_PesquisarNaPlantacao);
            this.Controls.Add(this.Btn_AtualizarPlantacao);
            this.Controls.Add(this.Btn_PesquisarNaPlantacao);
            this.Controls.Add(this.Btn_RelatorioPlantio);
            this.Controls.Add(this.Lbl_produtoDesejadoPlantio);
            this.Controls.Add(this.Txt_produtoDesejadoPlantio);
            this.Controls.Add(this.Grd_Plantacao);
            this.Controls.Add(this.Btn_PlantarProdutoPlantio);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Plantio";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Plantacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitlePlantio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Plantacao;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_ColherDescartar;
        private System.Windows.Forms.Button Btn_PlantarProdutoPlantio;
        private System.Windows.Forms.Button Btn_AtualizarPlantacao;
        private System.Windows.Forms.Button Btn_PesquisarNaPlantacao;
        private System.Windows.Forms.Button Btn_RelatorioPlantio;
        private System.Windows.Forms.Label Lbl_produtoDesejadoPlantio;
        private System.Windows.Forms.TextBox Txt_produtoDesejadoPlantio;
        private System.Windows.Forms.DataGridView Grd_Plantacao;
        private System.Windows.Forms.TextBox textBox_PesquisarNaPlantacao;
        private System.Windows.Forms.Label Lbl_PesquisarNaPlantacao;
        private System.Windows.Forms.Label Lbl_QtdIProdutoPlantio;
        private System.Windows.Forms.TextBox textBox_QtdProdutoPlantio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_plantar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_Pesquisa_produtoDesejadoPlantio;
        private System.Windows.Forms.Button Btn_ColherArmazenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ProdutoPlantacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_QuantidadePlantada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_DataColheita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_DataValidade;
    }
}
