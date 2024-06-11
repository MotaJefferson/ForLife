namespace ForLife.Forms
{
    partial class Frm_PesquisarVenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Grd_ResultadosPesqVendas = new System.Windows.Forms.DataGridView();
            this.Btn_PesquisarVenda = new System.Windows.Forms.Button();
            this.Btn_PesquisarexibirTodosVenda = new System.Windows.Forms.Button();
            this.Lbl_PesquisaProdutosVendidos = new System.Windows.Forms.Label();
            this.Lbl_PesquisaNomeCliente = new System.Windows.Forms.Label();
            this.Txt_PesquisaProdutosVendidos = new System.Windows.Forms.TextBox();
            this.Txt_PesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.Coluna_PesqNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqProdutoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqQtdVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Grd_ResultadosPesqVendas
            // 
            this.Grd_ResultadosPesqVendas.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqVendas.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqVendas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_ResultadosPesqVendas.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeCliente,
            this.Coluna_PesqProdutoVendido,
            this.Coluna_PesqQtdVendido,
            this.Coluna_PesqValorTotal});
            this.Grd_ResultadosPesqVendas.Location = new System.Drawing.Point(25, 177);
            this.Grd_ResultadosPesqVendas.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqVendas.MultiSelect = false;
            this.Grd_ResultadosPesqVendas.Name = "Grd_ResultadosPesqVendas";
            this.Grd_ResultadosPesqVendas.ReadOnly = true;
            this.Grd_ResultadosPesqVendas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqVendas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_ResultadosPesqVendas.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqVendas.Size = new System.Drawing.Size(635, 228);
            this.Grd_ResultadosPesqVendas.TabIndex = 60;
            // 
            // Btn_PesquisarVenda
            // 
            this.Btn_PesquisarVenda.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarVenda.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarVenda.ImageList = this.imageIcons;
            this.Btn_PesquisarVenda.Location = new System.Drawing.Point(200, 111);
            this.Btn_PesquisarVenda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarVenda.Name = "Btn_PesquisarVenda";
            this.Btn_PesquisarVenda.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarVenda.TabIndex = 58;
            this.Btn_PesquisarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarVenda.UseVisualStyleBackColor = true;
            // 
            // Btn_PesquisarexibirTodosVenda
            // 
            this.Btn_PesquisarexibirTodosVenda.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesquisarexibirTodosVenda.Location = new System.Drawing.Point(347, 111);
            this.Btn_PesquisarexibirTodosVenda.Name = "Btn_PesquisarexibirTodosVenda";
            this.Btn_PesquisarexibirTodosVenda.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarexibirTodosVenda.TabIndex = 57;
            this.Btn_PesquisarexibirTodosVenda.Text = "Exibir todas";
            this.Btn_PesquisarexibirTodosVenda.UseVisualStyleBackColor = true;
            // 
            // Lbl_PesquisaProdutosVendidos
            // 
            this.Lbl_PesquisaProdutosVendidos.AutoSize = true;
            this.Lbl_PesquisaProdutosVendidos.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesquisaProdutosVendidos.Location = new System.Drawing.Point(138, 75);
            this.Lbl_PesquisaProdutosVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisaProdutosVendidos.Name = "Lbl_PesquisaProdutosVendidos";
            this.Lbl_PesquisaProdutosVendidos.Size = new System.Drawing.Size(58, 17);
            this.Lbl_PesquisaProdutosVendidos.TabIndex = 55;
            this.Lbl_PesquisaProdutosVendidos.Text = "Telefone";
            // 
            // Lbl_PesquisaNomeCliente
            // 
            this.Lbl_PesquisaNomeCliente.AutoSize = true;
            this.Lbl_PesquisaNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesquisaNomeCliente.Location = new System.Drawing.Point(152, 40);
            this.Lbl_PesquisaNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisaNomeCliente.Name = "Lbl_PesquisaNomeCliente";
            this.Lbl_PesquisaNomeCliente.Size = new System.Drawing.Size(47, 17);
            this.Lbl_PesquisaNomeCliente.TabIndex = 54;
            this.Lbl_PesquisaNomeCliente.Text = "Cliente";
            // 
            // Txt_PesquisaProdutosVendidos
            // 
            this.Txt_PesquisaProdutosVendidos.AcceptsTab = true;
            this.Txt_PesquisaProdutosVendidos.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesquisaProdutosVendidos.Location = new System.Drawing.Point(200, 71);
            this.Txt_PesquisaProdutosVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesquisaProdutosVendidos.Name = "Txt_PesquisaProdutosVendidos";
            this.Txt_PesquisaProdutosVendidos.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesquisaProdutosVendidos.TabIndex = 53;
            // 
            // Txt_PesquisaNomeCliente
            // 
            this.Txt_PesquisaNomeCliente.AcceptsTab = true;
            this.Txt_PesquisaNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesquisaNomeCliente.Location = new System.Drawing.Point(200, 36);
            this.Txt_PesquisaNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesquisaNomeCliente.Name = "Txt_PesquisaNomeCliente";
            this.Txt_PesquisaNomeCliente.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesquisaNomeCliente.TabIndex = 52;
            // 
            // Coluna_PesqNomeCliente
            // 
            this.Coluna_PesqNomeCliente.HeaderText = "Cliente";
            this.Coluna_PesqNomeCliente.MinimumWidth = 6;
            this.Coluna_PesqNomeCliente.Name = "Coluna_PesqNomeCliente";
            this.Coluna_PesqNomeCliente.ReadOnly = true;
            this.Coluna_PesqNomeCliente.Width = 195;
            // 
            // Coluna_PesqProdutoVendido
            // 
            this.Coluna_PesqProdutoVendido.HeaderText = "Produto";
            this.Coluna_PesqProdutoVendido.MinimumWidth = 6;
            this.Coluna_PesqProdutoVendido.Name = "Coluna_PesqProdutoVendido";
            this.Coluna_PesqProdutoVendido.ReadOnly = true;
            this.Coluna_PesqProdutoVendido.Width = 200;
            // 
            // Coluna_PesqQtdVendido
            // 
            this.Coluna_PesqQtdVendido.HeaderText = "Quantidade";
            this.Coluna_PesqQtdVendido.MinimumWidth = 6;
            this.Coluna_PesqQtdVendido.Name = "Coluna_PesqQtdVendido";
            this.Coluna_PesqQtdVendido.ReadOnly = true;
            this.Coluna_PesqQtdVendido.Width = 80;
            // 
            // Coluna_PesqValorTotal
            // 
            this.Coluna_PesqValorTotal.HeaderText = "Valor Total";
            this.Coluna_PesqValorTotal.MinimumWidth = 6;
            this.Coluna_PesqValorTotal.Name = "Coluna_PesqValorTotal";
            this.Coluna_PesqValorTotal.ReadOnly = true;
            // 
            // Frm_PesquisarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Grd_ResultadosPesqVendas);
            this.Controls.Add(this.Btn_PesquisarVenda);
            this.Controls.Add(this.Btn_PesquisarexibirTodosVenda);
            this.Controls.Add(this.Lbl_PesquisaProdutosVendidos);
            this.Controls.Add(this.Lbl_PesquisaNomeCliente);
            this.Controls.Add(this.Txt_PesquisaProdutosVendidos);
            this.Controls.Add(this.Txt_PesquisaNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisarVenda";
            this.Text = "Pesquisar Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqVendas;
        private System.Windows.Forms.Button Btn_PesquisarVenda;
        private System.Windows.Forms.Button Btn_PesquisarexibirTodosVenda;
        private System.Windows.Forms.Label Lbl_PesquisaProdutosVendidos;
        private System.Windows.Forms.Label Lbl_PesquisaNomeCliente;
        private System.Windows.Forms.TextBox Txt_PesquisaProdutosVendidos;
        private System.Windows.Forms.TextBox Txt_PesquisaNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqProdutoVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqQtdVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqValorTotal;
    }
}