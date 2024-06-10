namespace ForLife.Forms
{
    partial class Frm_PesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_PesquisarProduto = new System.Windows.Forms.Button();
            this.textBox__PesqValidadeProduto = new System.Windows.Forms.TextBox();
            this.Btn_PesquisarExibirTodosInsumo = new System.Windows.Forms.Button();
            this.Lbl_PesqValidadeProduto = new System.Windows.Forms.Label();
            this.Lbl_PesqInsumoOrigemProduto = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeProduto = new System.Windows.Forms.Label();
            this.textBox__PesqInsumoOrigemProduto = new System.Windows.Forms.TextBox();
            this.textBox_PesqNomeProduto = new System.Windows.Forms.TextBox();
            this.Grd_ResultadosPesqProduto = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqInsumoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_ValidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqBloqueioProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_PesquisarProduto
            // 
            this.Btn_PesquisarProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarProduto.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarProduto.ImageList = this.imageIcons;
            this.Btn_PesquisarProduto.Location = new System.Drawing.Point(213, 132);
            this.Btn_PesquisarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarProduto.Name = "Btn_PesquisarProduto";
            this.Btn_PesquisarProduto.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarProduto.TabIndex = 91;
            this.Btn_PesquisarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // textBox__PesqValidadeProduto
            // 
            this.textBox__PesqValidadeProduto.AcceptsTab = true;
            this.textBox__PesqValidadeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__PesqValidadeProduto.Location = new System.Drawing.Point(213, 97);
            this.textBox__PesqValidadeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.textBox__PesqValidadeProduto.Name = "textBox__PesqValidadeProduto";
            this.textBox__PesqValidadeProduto.Size = new System.Drawing.Size(267, 21);
            this.textBox__PesqValidadeProduto.TabIndex = 90;
            // 
            // Btn_PesquisarExibirTodosInsumo
            // 
            this.Btn_PesquisarExibirTodosInsumo.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesquisarExibirTodosInsumo.Location = new System.Drawing.Point(360, 132);
            this.Btn_PesquisarExibirTodosInsumo.Name = "Btn_PesquisarExibirTodosInsumo";
            this.Btn_PesquisarExibirTodosInsumo.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarExibirTodosInsumo.TabIndex = 89;
            this.Btn_PesquisarExibirTodosInsumo.Text = "Exibir todos";
            this.Btn_PesquisarExibirTodosInsumo.UseVisualStyleBackColor = true;
            // 
            // Lbl_PesqValidadeProduto
            // 
            this.Lbl_PesqValidadeProduto.AutoSize = true;
            this.Lbl_PesqValidadeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqValidadeProduto.Location = new System.Drawing.Point(150, 101);
            this.Lbl_PesqValidadeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqValidadeProduto.Name = "Lbl_PesqValidadeProduto";
            this.Lbl_PesqValidadeProduto.Size = new System.Drawing.Size(59, 17);
            this.Lbl_PesqValidadeProduto.TabIndex = 88;
            this.Lbl_PesqValidadeProduto.Text = "Validade";
            // 
            // Lbl_PesqInsumoOrigemProduto
            // 
            this.Lbl_PesqInsumoOrigemProduto.AutoSize = true;
            this.Lbl_PesqInsumoOrigemProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqInsumoOrigemProduto.Location = new System.Drawing.Point(110, 67);
            this.Lbl_PesqInsumoOrigemProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqInsumoOrigemProduto.Name = "Lbl_PesqInsumoOrigemProduto";
            this.Lbl_PesqInsumoOrigemProduto.Size = new System.Drawing.Size(99, 17);
            this.Lbl_PesqInsumoOrigemProduto.TabIndex = 87;
            this.Lbl_PesqInsumoOrigemProduto.Text = "Insumo Origem";
            // 
            // Lbl_PesqNomeProduto
            // 
            this.Lbl_PesqNomeProduto.AutoSize = true;
            this.Lbl_PesqNomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeProduto.Location = new System.Drawing.Point(165, 32);
            this.Lbl_PesqNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqNomeProduto.Name = "Lbl_PesqNomeProduto";
            this.Lbl_PesqNomeProduto.Size = new System.Drawing.Size(44, 17);
            this.Lbl_PesqNomeProduto.TabIndex = 86;
            this.Lbl_PesqNomeProduto.Text = "Nome";
            // 
            // textBox__PesqInsumoOrigemProduto
            // 
            this.textBox__PesqInsumoOrigemProduto.AcceptsTab = true;
            this.textBox__PesqInsumoOrigemProduto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__PesqInsumoOrigemProduto.Location = new System.Drawing.Point(213, 63);
            this.textBox__PesqInsumoOrigemProduto.Margin = new System.Windows.Forms.Padding(2);
            this.textBox__PesqInsumoOrigemProduto.Name = "textBox__PesqInsumoOrigemProduto";
            this.textBox__PesqInsumoOrigemProduto.Size = new System.Drawing.Size(267, 21);
            this.textBox__PesqInsumoOrigemProduto.TabIndex = 85;
            // 
            // textBox_PesqNomeProduto
            // 
            this.textBox_PesqNomeProduto.AcceptsTab = true;
            this.textBox_PesqNomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesqNomeProduto.Location = new System.Drawing.Point(213, 28);
            this.textBox_PesqNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PesqNomeProduto.Name = "textBox_PesqNomeProduto";
            this.textBox_PesqNomeProduto.Size = new System.Drawing.Size(267, 21);
            this.textBox_PesqNomeProduto.TabIndex = 84;
            // 
            // Grd_ResultadosPesqProduto
            // 
            this.Grd_ResultadosPesqProduto.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqProduto.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqProduto.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_ResultadosPesqProduto.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeInsumo,
            this.Coluna_PesqInsumoOrigem,
            this.Coluna_ValidadeProduto,
            this.Coluna_PesqBloqueioProduto});
            this.Grd_ResultadosPesqProduto.Location = new System.Drawing.Point(24, 180);
            this.Grd_ResultadosPesqProduto.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqProduto.MultiSelect = false;
            this.Grd_ResultadosPesqProduto.Name = "Grd_ResultadosPesqProduto";
            this.Grd_ResultadosPesqProduto.ReadOnly = true;
            this.Grd_ResultadosPesqProduto.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqProduto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_ResultadosPesqProduto.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqProduto.Size = new System.Drawing.Size(635, 228);
            this.Grd_ResultadosPesqProduto.TabIndex = 92;
            // 
            // Coluna_PesqNomeInsumo
            // 
            this.Coluna_PesqNomeInsumo.HeaderText = "Nome";
            this.Coluna_PesqNomeInsumo.MinimumWidth = 6;
            this.Coluna_PesqNomeInsumo.Name = "Coluna_PesqNomeInsumo";
            this.Coluna_PesqNomeInsumo.ReadOnly = true;
            this.Coluna_PesqNomeInsumo.Width = 235;
            // 
            // Coluna_PesqInsumoOrigem
            // 
            this.Coluna_PesqInsumoOrigem.HeaderText = "Insumo Origem";
            this.Coluna_PesqInsumoOrigem.MinimumWidth = 6;
            this.Coluna_PesqInsumoOrigem.Name = "Coluna_PesqInsumoOrigem";
            this.Coluna_PesqInsumoOrigem.ReadOnly = true;
            this.Coluna_PesqInsumoOrigem.Width = 180;
            // 
            // Coluna_ValidadeProduto
            // 
            this.Coluna_ValidadeProduto.HeaderText = "Validade";
            this.Coluna_ValidadeProduto.Name = "Coluna_ValidadeProduto";
            this.Coluna_ValidadeProduto.ReadOnly = true;
            // 
            // Coluna_PesqBloqueioProduto
            // 
            this.Coluna_PesqBloqueioProduto.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioProduto.Name = "Coluna_PesqBloqueioProduto";
            this.Coluna_PesqBloqueioProduto.ReadOnly = true;
            this.Coluna_PesqBloqueioProduto.Width = 80;
            // 
            // Frm_PesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Grd_ResultadosPesqProduto);
            this.Controls.Add(this.Btn_PesquisarProduto);
            this.Controls.Add(this.textBox__PesqValidadeProduto);
            this.Controls.Add(this.Btn_PesquisarExibirTodosInsumo);
            this.Controls.Add(this.Lbl_PesqValidadeProduto);
            this.Controls.Add(this.Lbl_PesqInsumoOrigemProduto);
            this.Controls.Add(this.Lbl_PesqNomeProduto);
            this.Controls.Add(this.textBox__PesqInsumoOrigemProduto);
            this.Controls.Add(this.textBox_PesqNomeProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisaProduto";
            this.Text = "Pesquisar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarProduto;
        private System.Windows.Forms.TextBox textBox__PesqValidadeProduto;
        private System.Windows.Forms.Button Btn_PesquisarExibirTodosInsumo;
        private System.Windows.Forms.Label Lbl_PesqValidadeProduto;
        private System.Windows.Forms.Label Lbl_PesqInsumoOrigemProduto;
        private System.Windows.Forms.Label Lbl_PesqNomeProduto;
        private System.Windows.Forms.TextBox textBox__PesqInsumoOrigemProduto;
        private System.Windows.Forms.TextBox textBox_PesqNomeProduto;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqInsumoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ValidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioProduto;
    }
}