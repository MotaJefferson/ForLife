namespace ForLife.Forms
{
    partial class Frm_EstoqueInsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EstoqueInsumo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleEstoqueInsumo = new System.Windows.Forms.Label();
            this.Btn_RelatorioEstoque = new System.Windows.Forms.Button();
            this.Lbl_PesqNomeInsumoEstoq = new System.Windows.Forms.Label();
            this.Grd_EstoqueInsumos = new System.Windows.Forms.DataGridView();
            this.Coluna_EstoqueInsumoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_EstoqueInsumoQtdAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_EstoqueInsumoValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Txt_PesqNomeInsumoEstoq = new System.Windows.Forms.TextBox();
            this.Lbl_ValidadeInsumoEstoque = new System.Windows.Forms.Label();
            this.Txt_ValInsumoEstoque = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EstoqueInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleEstoqueInsumo);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 73);
            this.panel1.TabIndex = 30;
            // 
            // Lbl_TitleEstoqueInsumo
            // 
            this.Lbl_TitleEstoqueInsumo.AutoSize = true;
            this.Lbl_TitleEstoqueInsumo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleEstoqueInsumo.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleEstoqueInsumo.Location = new System.Drawing.Point(17, 14);
            this.Lbl_TitleEstoqueInsumo.Name = "Lbl_TitleEstoqueInsumo";
            this.Lbl_TitleEstoqueInsumo.Size = new System.Drawing.Size(300, 37);
            this.Lbl_TitleEstoqueInsumo.TabIndex = 0;
            this.Lbl_TitleEstoqueInsumo.Text = "Estoque de Insumos";
            // 
            // Btn_RelatorioEstoque
            // 
            this.Btn_RelatorioEstoque.ForeColor = System.Drawing.Color.Black;
            this.Btn_RelatorioEstoque.Location = new System.Drawing.Point(607, 176);
            this.Btn_RelatorioEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_RelatorioEstoque.Name = "Btn_RelatorioEstoque";
            this.Btn_RelatorioEstoque.Size = new System.Drawing.Size(177, 32);
            this.Btn_RelatorioEstoque.TabIndex = 49;
            this.Btn_RelatorioEstoque.Text = "Relatório Completo";
            this.Btn_RelatorioEstoque.UseVisualStyleBackColor = true;
            this.Btn_RelatorioEstoque.Click += new System.EventHandler(this.Btn_RelatorioEstoque_Click);
            // 
            // Lbl_PesqNomeInsumoEstoq
            // 
            this.Lbl_PesqNomeInsumoEstoq.AutoSize = true;
            this.Lbl_PesqNomeInsumoEstoq.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PesqNomeInsumoEstoq.Location = new System.Drawing.Point(143, 126);
            this.Lbl_PesqNomeInsumoEstoq.Name = "Lbl_PesqNomeInsumoEstoq";
            this.Lbl_PesqNomeInsumoEstoq.Size = new System.Drawing.Size(117, 19);
            this.Lbl_PesqNomeInsumoEstoq.TabIndex = 44;
            this.Lbl_PesqNomeInsumoEstoq.Text = "Nome Insumo";
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
            this.Grd_EstoqueInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd_EstoqueInsumos.BackgroundColor = System.Drawing.Color.White;
            this.Grd_EstoqueInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_EstoqueInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_EstoqueInsumoNome,
            this.Coluna_EstoqueInsumoQtdAtual,
            this.Coluna_EstoqueInsumoValidade});
            this.Grd_EstoqueInsumos.Location = new System.Drawing.Point(61, 242);
            this.Grd_EstoqueInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd_EstoqueInsumos.MultiSelect = false;
            this.Grd_EstoqueInsumos.Name = "Grd_EstoqueInsumos";
            this.Grd_EstoqueInsumos.ReadOnly = true;
            this.Grd_EstoqueInsumos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_EstoqueInsumos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grd_EstoqueInsumos.RowTemplate.Height = 24;
            this.Grd_EstoqueInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_EstoqueInsumos.Size = new System.Drawing.Size(1079, 441);
            this.Grd_EstoqueInsumos.TabIndex = 41;
            // 
            // Coluna_EstoqueInsumoNome
            // 
            this.Coluna_EstoqueInsumoNome.DividerWidth = 1;
            this.Coluna_EstoqueInsumoNome.HeaderText = "Nome Insumo";
            this.Coluna_EstoqueInsumoNome.MinimumWidth = 6;
            this.Coluna_EstoqueInsumoNome.Name = "Coluna_EstoqueInsumoNome";
            this.Coluna_EstoqueInsumoNome.ReadOnly = true;
            this.Coluna_EstoqueInsumoNome.Width = 450;
            // 
            // Coluna_EstoqueInsumoQtdAtual
            // 
            this.Coluna_EstoqueInsumoQtdAtual.HeaderText = "Quantidade atual";
            this.Coluna_EstoqueInsumoQtdAtual.MinimumWidth = 6;
            this.Coluna_EstoqueInsumoQtdAtual.Name = "Coluna_EstoqueInsumoQtdAtual";
            this.Coluna_EstoqueInsumoQtdAtual.ReadOnly = true;
            this.Coluna_EstoqueInsumoQtdAtual.Width = 150;
            // 
            // Coluna_EstoqueInsumoValidade
            // 
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.Coluna_EstoqueInsumoValidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Coluna_EstoqueInsumoValidade.HeaderText = "Validade";
            this.Coluna_EstoqueInsumoValidade.MinimumWidth = 6;
            this.Coluna_EstoqueInsumoValidade.Name = "Coluna_EstoqueInsumoValidade";
            this.Coluna_EstoqueInsumoValidade.ReadOnly = true;
            this.Coluna_EstoqueInsumoValidade.Width = 154;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Txt_PesqNomeInsumoEstoq
            // 
            this.Txt_PesqNomeInsumoEstoq.AcceptsTab = true;
            this.Txt_PesqNomeInsumoEstoq.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeInsumoEstoq.Location = new System.Drawing.Point(269, 122);
            this.Txt_PesqNomeInsumoEstoq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PesqNomeInsumoEstoq.Name = "Txt_PesqNomeInsumoEstoq";
            this.Txt_PesqNomeInsumoEstoq.Size = new System.Drawing.Size(485, 25);
            this.Txt_PesqNomeInsumoEstoq.TabIndex = 42;
            // 
            // Lbl_ValidadeInsumoEstoque
            // 
            this.Lbl_ValidadeInsumoEstoque.AutoSize = true;
            this.Lbl_ValidadeInsumoEstoque.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValidadeInsumoEstoque.Location = new System.Drawing.Point(783, 126);
            this.Lbl_ValidadeInsumoEstoque.Name = "Lbl_ValidadeInsumoEstoque";
            this.Lbl_ValidadeInsumoEstoque.Size = new System.Drawing.Size(75, 19);
            this.Lbl_ValidadeInsumoEstoque.TabIndex = 45;
            this.Lbl_ValidadeInsumoEstoque.Text = "Validade";
            // 
            // Txt_ValInsumoEstoque
            // 
            this.Txt_ValInsumoEstoque.Location = new System.Drawing.Point(872, 122);
            this.Txt_ValInsumoEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ValInsumoEstoque.Mask = "00/00/0000";
            this.Txt_ValInsumoEstoque.Name = "Txt_ValInsumoEstoque";
            this.Txt_ValInsumoEstoque.Size = new System.Drawing.Size(147, 22);
            this.Txt_ValInsumoEstoque.TabIndex = 51;
            this.Txt_ValInsumoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_ValInsumoEstoque.ValidatingType = typeof(System.DateTime);
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_Pesquisar.ImageKey = "Pesquisar.png";
            this.Btn_Pesquisar.ImageList = this.imageIcons;
            this.Btn_Pesquisar.Location = new System.Drawing.Point(393, 176);
            this.Btn_Pesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(177, 32);
            this.Btn_Pesquisar.TabIndex = 50;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Frm_EstoqueInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Txt_ValInsumoEstoque);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_RelatorioEstoque);
            this.Controls.Add(this.Lbl_ValidadeInsumoEstoque);
            this.Controls.Add(this.Lbl_PesqNomeInsumoEstoq);
            this.Controls.Add(this.Txt_PesqNomeInsumoEstoq);
            this.Controls.Add(this.Grd_EstoqueInsumos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_EstoqueInsumo";
            this.Size = new System.Drawing.Size(1200, 738);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EstoqueInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleEstoqueInsumo;
        private System.Windows.Forms.Button Btn_RelatorioEstoque;
        private System.Windows.Forms.Label Lbl_PesqNomeInsumoEstoq;
        private System.Windows.Forms.DataGridView Grd_EstoqueInsumos;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.TextBox Txt_PesqNomeInsumoEstoq;
        private System.Windows.Forms.Label Lbl_ValidadeInsumoEstoque;
        private System.Windows.Forms.MaskedTextBox Txt_ValInsumoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueInsumoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueInsumoQtdAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EstoqueInsumoValidade;
    }
}
