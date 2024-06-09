namespace ForLife.Forms
{
    partial class Frm_GerenciamentoFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GerenciamentoFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleFornecedor = new System.Windows.Forms.Label();
            this.Rbtn_FornecedorInativo = new System.Windows.Forms.RadioButton();
            this.Rbtn_FornecedorAtivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_statusFornecedor = new System.Windows.Forms.Label();
            this.Lbl_NomeFantasiaFornecedor = new System.Windows.Forms.Label();
            this.Txt_NomeFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_InfoFornecedor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_RazaoSocialFornecedor = new System.Windows.Forms.Label();
            this.textBox_RazaoSocialFornecedor = new System.Windows.Forms.TextBox();
            this.MaskedTextBox_CnpjForn = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CnpjFornecedor = new System.Windows.Forms.Label();
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.Btn_VoltarFornecedor = new System.Windows.Forms.Button();
            this.Btn_BuscarFornecedor = new System.Windows.Forms.Button();
            this.Btn_ExcluirFornecedor = new System.Windows.Forms.Button();
            this.Btn_SalvarFornecedor = new System.Windows.Forms.Button();
            this.Btn_EditarFornecedor = new System.Windows.Forms.Button();
            this.Btn_NovoFornecedor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleFornecedor);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 59);
            this.panel1.TabIndex = 29;
            // 
            // Lbl_TitleFornecedor
            // 
            this.Lbl_TitleFornecedor.AutoSize = true;
            this.Lbl_TitleFornecedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleFornecedor.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleFornecedor.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TitleFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleFornecedor.Name = "Lbl_TitleFornecedor";
            this.Lbl_TitleFornecedor.Size = new System.Drawing.Size(346, 30);
            this.Lbl_TitleFornecedor.TabIndex = 0;
            this.Lbl_TitleFornecedor.Text = "Gerenciamento do fornecedor";
            // 
            // Rbtn_FornecedorInativo
            // 
            this.Rbtn_FornecedorInativo.AutoSize = true;
            this.Rbtn_FornecedorInativo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_FornecedorInativo.Location = new System.Drawing.Point(141, 135);
            this.Rbtn_FornecedorInativo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_FornecedorInativo.Name = "Rbtn_FornecedorInativo";
            this.Rbtn_FornecedorInativo.Size = new System.Drawing.Size(73, 24);
            this.Rbtn_FornecedorInativo.TabIndex = 34;
            this.Rbtn_FornecedorInativo.Text = "Inativo";
            this.Rbtn_FornecedorInativo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_FornecedorAtivo
            // 
            this.Rbtn_FornecedorAtivo.AutoSize = true;
            this.Rbtn_FornecedorAtivo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_FornecedorAtivo.Location = new System.Drawing.Point(36, 135);
            this.Rbtn_FornecedorAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_FornecedorAtivo.Name = "Rbtn_FornecedorAtivo";
            this.Rbtn_FornecedorAtivo.Size = new System.Drawing.Size(62, 24);
            this.Rbtn_FornecedorAtivo.TabIndex = 33;
            this.Rbtn_FornecedorAtivo.Text = "Ativo";
            this.Rbtn_FornecedorAtivo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_statusFornecedor);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 23);
            this.panel2.TabIndex = 32;
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
            // Lbl_statusFornecedor
            // 
            this.Lbl_statusFornecedor.AutoSize = true;
            this.Lbl_statusFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_statusFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_statusFornecedor.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_statusFornecedor.Location = new System.Drawing.Point(19, 0);
            this.Lbl_statusFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_statusFornecedor.Name = "Lbl_statusFornecedor";
            this.Lbl_statusFornecedor.Size = new System.Drawing.Size(168, 19);
            this.Lbl_statusFornecedor.TabIndex = 20;
            this.Lbl_statusFornecedor.Text = "Status do fornecedor";
            // 
            // Lbl_NomeFantasiaFornecedor
            // 
            this.Lbl_NomeFantasiaFornecedor.AutoSize = true;
            this.Lbl_NomeFantasiaFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeFantasiaFornecedor.Location = new System.Drawing.Point(29, 255);
            this.Lbl_NomeFantasiaFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeFantasiaFornecedor.Name = "Lbl_NomeFantasiaFornecedor";
            this.Lbl_NomeFantasiaFornecedor.Size = new System.Drawing.Size(107, 20);
            this.Lbl_NomeFantasiaFornecedor.TabIndex = 37;
            this.Lbl_NomeFantasiaFornecedor.Text = "Nome fantasia";
            // 
            // Txt_NomeFantasiaFornecedor
            // 
            this.Txt_NomeFantasiaFornecedor.AcceptsTab = true;
            this.Txt_NomeFantasiaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeFantasiaFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeFantasiaFornecedor.Location = new System.Drawing.Point(33, 283);
            this.Txt_NomeFantasiaFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NomeFantasiaFornecedor.Name = "Txt_NomeFantasiaFornecedor";
            this.Txt_NomeFantasiaFornecedor.Size = new System.Drawing.Size(618, 25);
            this.Txt_NomeFantasiaFornecedor.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.Lbl_InfoFornecedor);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-2, 200);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 25);
            this.panel4.TabIndex = 35;
            // 
            // Lbl_InfoFornecedor
            // 
            this.Lbl_InfoFornecedor.AutoSize = true;
            this.Lbl_InfoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoFornecedor.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoFornecedor.Location = new System.Drawing.Point(19, 0);
            this.Lbl_InfoFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InfoFornecedor.Name = "Lbl_InfoFornecedor";
            this.Lbl_InfoFornecedor.Size = new System.Drawing.Size(218, 19);
            this.Lbl_InfoFornecedor.TabIndex = 21;
            this.Lbl_InfoFornecedor.Text = "Informações do Fornecedor";
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
            // Lbl_RazaoSocialFornecedor
            // 
            this.Lbl_RazaoSocialFornecedor.AutoSize = true;
            this.Lbl_RazaoSocialFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RazaoSocialFornecedor.Location = new System.Drawing.Point(32, 323);
            this.Lbl_RazaoSocialFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_RazaoSocialFornecedor.Name = "Lbl_RazaoSocialFornecedor";
            this.Lbl_RazaoSocialFornecedor.Size = new System.Drawing.Size(94, 20);
            this.Lbl_RazaoSocialFornecedor.TabIndex = 39;
            this.Lbl_RazaoSocialFornecedor.Text = "Razão Social";
            // 
            // textBox_RazaoSocialFornecedor
            // 
            this.textBox_RazaoSocialFornecedor.AcceptsTab = true;
            this.textBox_RazaoSocialFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RazaoSocialFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RazaoSocialFornecedor.Location = new System.Drawing.Point(36, 351);
            this.textBox_RazaoSocialFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_RazaoSocialFornecedor.Name = "textBox_RazaoSocialFornecedor";
            this.textBox_RazaoSocialFornecedor.Size = new System.Drawing.Size(618, 25);
            this.textBox_RazaoSocialFornecedor.TabIndex = 38;
            // 
            // MaskedTextBox_CnpjForn
            // 
            this.MaskedTextBox_CnpjForn.Location = new System.Drawing.Point(36, 421);
            this.MaskedTextBox_CnpjForn.Mask = "9999999-99. 9999. 9";
            this.MaskedTextBox_CnpjForn.Name = "MaskedTextBox_CnpjForn";
            this.MaskedTextBox_CnpjForn.Size = new System.Drawing.Size(111, 20);
            this.MaskedTextBox_CnpjForn.TabIndex = 40;
            this.MaskedTextBox_CnpjForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_CnpjFornecedor
            // 
            this.Lbl_CnpjFornecedor.AutoSize = true;
            this.Lbl_CnpjFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CnpjFornecedor.Location = new System.Drawing.Point(32, 398);
            this.Lbl_CnpjFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CnpjFornecedor.Name = "Lbl_CnpjFornecedor";
            this.Lbl_CnpjFornecedor.Size = new System.Drawing.Size(44, 20);
            this.Lbl_CnpjFornecedor.TabIndex = 41;
            this.Lbl_CnpjFornecedor.Text = "CNPJ";
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
            // Btn_VoltarFornecedor
            // 
            this.Btn_VoltarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarFornecedor.ImageKey = "Voltar.png";
            this.Btn_VoltarFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_VoltarFornecedor.Location = new System.Drawing.Point(646, 481);
            this.Btn_VoltarFornecedor.Name = "Btn_VoltarFornecedor";
            this.Btn_VoltarFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_VoltarFornecedor.TabIndex = 61;
            this.Btn_VoltarFornecedor.Text = "Voltar";
            this.Btn_VoltarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarFornecedor.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarFornecedor
            // 
            this.Btn_BuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarFornecedor.ImageKey = "Pesquisar.png";
            this.Btn_BuscarFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_BuscarFornecedor.Location = new System.Drawing.Point(543, 481);
            this.Btn_BuscarFornecedor.Name = "Btn_BuscarFornecedor";
            this.Btn_BuscarFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_BuscarFornecedor.TabIndex = 60;
            this.Btn_BuscarFornecedor.Text = "Buscar";
            this.Btn_BuscarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarFornecedor.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirFornecedor
            // 
            this.Btn_ExcluirFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirFornecedor.ImageKey = "Apagar.png";
            this.Btn_ExcluirFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_ExcluirFornecedor.Location = new System.Drawing.Point(441, 481);
            this.Btn_ExcluirFornecedor.Name = "Btn_ExcluirFornecedor";
            this.Btn_ExcluirFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_ExcluirFornecedor.TabIndex = 59;
            this.Btn_ExcluirFornecedor.Text = "Excluir";
            this.Btn_ExcluirFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirFornecedor.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarFornecedor
            // 
            this.Btn_SalvarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarFornecedor.ImageKey = "Salvar.png";
            this.Btn_SalvarFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_SalvarFornecedor.Location = new System.Drawing.Point(338, 481);
            this.Btn_SalvarFornecedor.Name = "Btn_SalvarFornecedor";
            this.Btn_SalvarFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_SalvarFornecedor.TabIndex = 58;
            this.Btn_SalvarFornecedor.Text = "Salvar";
            this.Btn_SalvarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarFornecedor.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarFornecedor
            // 
            this.Btn_EditarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarFornecedor.ImageKey = "Editar.png";
            this.Btn_EditarFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_EditarFornecedor.Location = new System.Drawing.Point(233, 481);
            this.Btn_EditarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_EditarFornecedor.Name = "Btn_EditarFornecedor";
            this.Btn_EditarFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_EditarFornecedor.TabIndex = 57;
            this.Btn_EditarFornecedor.Text = "Editar";
            this.Btn_EditarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarFornecedor.UseVisualStyleBackColor = true;
            // 
            // Btn_NovoFornecedor
            // 
            this.Btn_NovoFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovoFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovoFornecedor.FlatAppearance.BorderSize = 0;
            this.Btn_NovoFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovoFornecedor.ImageKey = "Adicionar.png";
            this.Btn_NovoFornecedor.ImageList = this.imgList_Usuario;
            this.Btn_NovoFornecedor.Location = new System.Drawing.Point(126, 481);
            this.Btn_NovoFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_NovoFornecedor.Name = "Btn_NovoFornecedor";
            this.Btn_NovoFornecedor.Size = new System.Drawing.Size(97, 28);
            this.Btn_NovoFornecedor.TabIndex = 56;
            this.Btn_NovoFornecedor.Text = "Novo";
            this.Btn_NovoFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovoFornecedor.UseVisualStyleBackColor = true;
            // 
            // Frm_GerenciamentoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_VoltarFornecedor);
            this.Controls.Add(this.Btn_BuscarFornecedor);
            this.Controls.Add(this.Btn_ExcluirFornecedor);
            this.Controls.Add(this.Btn_SalvarFornecedor);
            this.Controls.Add(this.Btn_EditarFornecedor);
            this.Controls.Add(this.Btn_NovoFornecedor);
            this.Controls.Add(this.Lbl_CnpjFornecedor);
            this.Controls.Add(this.MaskedTextBox_CnpjForn);
            this.Controls.Add(this.Lbl_RazaoSocialFornecedor);
            this.Controls.Add(this.textBox_RazaoSocialFornecedor);
            this.Controls.Add(this.Lbl_NomeFantasiaFornecedor);
            this.Controls.Add(this.Txt_NomeFantasiaFornecedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Rbtn_FornecedorInativo);
            this.Controls.Add(this.Rbtn_FornecedorAtivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_GerenciamentoFornecedor";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleFornecedor;
        private System.Windows.Forms.RadioButton Rbtn_FornecedorInativo;
        private System.Windows.Forms.RadioButton Rbtn_FornecedorAtivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_statusFornecedor;
        private System.Windows.Forms.Label Lbl_NomeFantasiaFornecedor;
        private System.Windows.Forms.TextBox Txt_NomeFantasiaFornecedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_InfoFornecedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_RazaoSocialFornecedor;
        private System.Windows.Forms.TextBox textBox_RazaoSocialFornecedor;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox_CnpjForn;
        private System.Windows.Forms.Label Lbl_CnpjFornecedor;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_VoltarFornecedor;
        private System.Windows.Forms.Button Btn_BuscarFornecedor;
        private System.Windows.Forms.Button Btn_ExcluirFornecedor;
        private System.Windows.Forms.Button Btn_SalvarFornecedor;
        private System.Windows.Forms.Button Btn_EditarFornecedor;
        private System.Windows.Forms.Button Btn_NovoFornecedor;
    }
}
