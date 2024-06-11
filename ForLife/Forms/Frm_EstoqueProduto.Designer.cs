namespace ForLife.Forms
{
    partial class Frm_EstoqueProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EstoqueProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleEstoqueProduto = new System.Windows.Forms.Label();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Txt_ValProdutoEstoque = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_ValidadeProdutoEstoque = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeProdutoEstoq = new System.Windows.Forms.Label();
            this.Txt_PesqNomeProdutoEstoq = new System.Windows.Forms.TextBox();
            this.Btn_PesquisarProdutoEstoque = new System.Windows.Forms.Button();
            this.Btn_RelatorioEstoqueProduto = new System.Windows.Forms.Button();
            this.Grd_EstoqueInsumos = new System.Windows.Forms.DataGridView();
            this.Coluna_EstoqueProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_EstoqueProdutoQtdAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_EstoqueProdutoValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EstoqueInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleEstoqueProduto);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 73);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_TitleEstoqueProduto
            // 
            this.Lbl_TitleEstoqueProduto.AutoSize = true;
            this.Lbl_TitleEstoqueProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleEstoqueProduto.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleEstoqueProduto.Location = new System.Drawing.Point(17, 14);
            this.Lbl_TitleEstoqueProduto.Name = "Lbl_TitleEstoqueProduto";
            this.Lbl_TitleEstoqueProduto.Size = new System.Drawing.Size(310, 37);
            this.Lbl_TitleEstoqueProduto.TabIndex = 0;
            this.Lbl_TitleEstoqueProduto.Text = "Estoque de Produtos";
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Txt_ValProdutoEstoque
            // 
            this.Txt_ValProdutoEstoque.Location = new System.Drawing.Point(871, 121);
            this.Txt_ValProdutoEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ValProdutoEstoque.Mask = "00/00/0000";
            this.Txt_ValProdutoEstoque.Name = "Txt_ValProdutoEstoque";
            this.Txt_ValProdutoEstoque.Size = new System.Drawing.Size(147, 22);
            this.Txt_ValProdutoEstoque.TabIndex = 55;
            this.Txt_ValProdutoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_ValProdutoEstoque.ValidatingType = typeof(System.DateTime);
            // 
            // Lbl_ValidadeProdutoEstoque
            // 
            this.Lbl_ValidadeProdutoEstoque.AutoSize = true;
            this.Lbl_ValidadeProdutoEstoque.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValidadeProdutoEstoque.Location = new System.Drawing.Point(781, 124);
            this.Lbl_ValidadeProdutoEstoque.Name = "Lbl_ValidadeProdutoEstoque";
            this.Lbl_ValidadeProdutoEstoque.Size = new System.Drawing.Size(75, 19);
            this.Lbl_ValidadeProdutoEstoque.TabIndex = 54;
            this.Lbl_ValidadeProdutoEstoque.Text = "Validade";
            // 
            // Lbl_PesqNomeProdutoEstoq
            // 
            this.Lbl_PesqNomeProdutoEstoq.AutoSize = true;
            this.Lbl_PesqNomeProdutoEstoq.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesqNomeProdutoEstoq.Location = new System.Drawing.Point(132, 124);
            this.Lbl_PesqNomeProdutoEstoq.Name = "Lbl_PesqNomeProdutoEstoq";
            this.Lbl_PesqNomeProdutoEstoq.Size = new System.Drawing.Size(122, 19);
            this.Lbl_PesqNomeProdutoEstoq.TabIndex = 53;
            this.Lbl_PesqNomeProdutoEstoq.Text = "Nome Produto";
            // 
            // Txt_PesqNomeProdutoEstoq
            // 
            this.Txt_PesqNomeProdutoEstoq.AcceptsTab = true;
            this.Txt_PesqNomeProdutoEstoq.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeProdutoEstoq.Location = new System.Drawing.Point(268, 121);
            this.Txt_PesqNomeProdutoEstoq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PesqNomeProdutoEstoq.Name = "Txt_PesqNomeProdutoEstoq";
            this.Txt_PesqNomeProdutoEstoq.Size = new System.Drawing.Size(485, 25);
            this.Txt_PesqNomeProdutoEstoq.TabIndex = 52;
            // 
            // Btn_PesquisarProdutoEstoque
            // 
            this.Btn_PesquisarProdutoEstoque.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarProdutoEstoque.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarProdutoEstoque.ImageList = this.imageIcons;
            this.Btn_PesquisarProdutoEstoque.Location = new System.Drawing.Point(386, 175);
            this.Btn_PesquisarProdutoEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_PesquisarProdutoEstoque.Name = "Btn_PesquisarProdutoEstoque";
            this.Btn_PesquisarProdutoEstoque.Size = new System.Drawing.Size(179, 32);
            this.Btn_PesquisarProdutoEstoque.TabIndex = 57;
            this.Btn_PesquisarProdutoEstoque.Text = "Pesquisar";
            this.Btn_PesquisarProdutoEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarProdutoEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarProdutoEstoque.UseVisualStyleBackColor = true;
            this.Btn_PesquisarProdutoEstoque.Click += new System.EventHandler(this.Btn_PesquisarProdutoEstoque_Click);
            // 
            // Btn_RelatorioEstoqueProduto
            // 
            this.Btn_RelatorioEstoqueProduto.ForeColor = System.Drawing.Color.Black;
            this.Btn_RelatorioEstoqueProduto.Location = new System.Drawing.Point(601, 175);
            this.Btn_RelatorioEstoqueProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_RelatorioEstoqueProduto.Name = "Btn_RelatorioEstoqueProduto";
            this.Btn_RelatorioEstoqueProduto.Size = new System.Drawing.Size(179, 32);
            this.Btn_RelatorioEstoqueProduto.TabIndex = 56;
            this.Btn_RelatorioEstoqueProduto.Text = "Relatório Completo";
            this.Btn_RelatorioEstoqueProduto.UseVisualStyleBackColor = true;
            this.Btn_RelatorioEstoqueProduto.Click += new System.EventHandler(this.Btn_RelatorioEstoqueProduto_Click);
            // 
            // Grd_EstoqueInsumos
            // 
            this.Grd_EstoqueInsumos.AllowUserToAddRows = false;
            this.Grd_EstoqueInsumos.AllowUserToDeleteRows = false;
            this.Grd_EstoqueInsumos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_EstoqueInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_EstoqueInsumos.BackgroundColor = System.Drawing.Color.White;
            this.Grd_EstoqueInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_EstoqueInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_EstoqueProdutoNome,
            this.Coluna_EstoqueProdutoQtdAtual,
            this.Coluna_EstoqueProdutoValidade});
            this.Grd_EstoqueInsumos.Location = new System.Drawing.Point(60, 250);
            this.Grd_EstoqueInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd_EstoqueInsumos.MultiSelect = false;
            this.Grd_EstoqueInsumos.Name = "Grd_EstoqueInsumos";
            this.Grd_EstoqueInsumos.ReadOnly = true;
            this.Grd_EstoqueInsumos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_EstoqueInsumos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_EstoqueInsumos.RowTemplate.Height = 24;
            this.Grd_EstoqueInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_EstoqueInsumos.Size = new System.Drawing.Size(1079, 432);
            this.Grd_EstoqueInsumos.TabIndex = 59;
            // 
            // Coluna_EstoqueProdutoNome
            // 
            this.Coluna_EstoqueProdutoNome.DividerWidth = 1;
            this.Coluna_EstoqueProdutoNome.HeaderText = "Nome Produto";
            this.Coluna_EstoqueProdutoNome.MinimumWidth = 6;
            this.Coluna_EstoqueProdutoNome.Name = "Coluna_EstoqueProdutoNome";
            this.Coluna_EstoqueProdutoNome.ReadOnly = true;
            this.Coluna_EstoqueProdutoNome.Width = 450;
            // 
            // Coluna_EstoqueProdutoQtdAtual
            // 
            this.Coluna_EstoqueProdutoQtdAtual.HeaderText = "Quantidade atual";
            this.Coluna_EstoqueProdutoQtdAtual.MinimumWidth = 6;
            this.Coluna_EstoqueProdutoQtdAtual.Name = "Coluna_EstoqueProdutoQtdAtual";
            this.Coluna_EstoqueProdutoQtdAtual.ReadOnly = true;
            this.Coluna_EstoqueProdutoQtdAtual.Width = 150;
            // 
            // Coluna_EstoqueProdutoValidade
            // 
            this.Coluna_EstoqueProdutoValidade.HeaderText = "Validade";
            this.Coluna_EstoqueProdutoValidade.MinimumWidth = 6;
            this.Coluna_EstoqueProdutoValidade.Name = "Coluna_EstoqueProdutoValidade";
            this.Coluna_EstoqueProdutoValidade.ReadOnly = true;
            this.Coluna_EstoqueProdutoValidade.Width = 154;
            // 
            // Frm_EstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Grd_EstoqueInsumos);
            this.Controls.Add(this.Btn_PesquisarProdutoEstoque);
            this.Controls.Add(this.Btn_RelatorioEstoqueProduto);
            this.Controls.Add(this.Txt_ValProdutoEstoque);
            this.Controls.Add(this.Lbl_ValidadeProdutoEstoque);
            this.Controls.Add(this.Lbl_PesqNomeProdutoEstoq);
            this.Controls.Add(this.Txt_PesqNomeProdutoEstoq);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_EstoqueProduto";
            this.Size = new System.Drawing.Size(1200, 738);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EstoqueInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleEstoqueProduto;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.MaskedTextBox Txt_ValProdutoEstoque;
        private System.Windows.Forms.Label Lbl_ValidadeProdutoEstoque;
        private System.Windows.Forms.Label Lbl_PesqNomeProdutoEstoq;
        private System.Windows.Forms.TextBox Txt_PesqNomeProdutoEstoq;
        private System.Windows.Forms.Button Btn_PesquisarProdutoEstoque;
        private System.Windows.Forms.Button Btn_RelatorioEstoqueProduto;
        private System.Windows.Forms.DataGridView Grd_EstoqueInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueProdutoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueProdutoQtdAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueProdutoValidade;
    }
}
