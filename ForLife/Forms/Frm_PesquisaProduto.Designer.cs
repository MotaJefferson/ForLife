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
            this.Btn_PesquisarExibirTodosInsumo = new System.Windows.Forms.Button();
            this.Lbl_PesqInsumoOrigemProduto = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeProduto = new System.Windows.Forms.Label();
            this.Txt_InsumoOrigem = new System.Windows.Forms.TextBox();
            this.Txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.Grd_ResultadosPesqProduto = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqInsumoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Btn_PesquisarProduto.Location = new System.Drawing.Point(284, 132);
            this.Btn_PesquisarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_PesquisarProduto.Name = "Btn_PesquisarProduto";
            this.Btn_PesquisarProduto.Size = new System.Drawing.Size(160, 31);
            this.Btn_PesquisarProduto.TabIndex = 91;
            this.Btn_PesquisarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarProduto.UseVisualStyleBackColor = true;
            this.Btn_PesquisarProduto.Click += new System.EventHandler(this.Btn_PesquisarProduto_Click);
            // 
            // Btn_PesquisarExibirTodosInsumo
            // 
            this.Btn_PesquisarExibirTodosInsumo.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesquisarExibirTodosInsumo.Location = new System.Drawing.Point(480, 132);
            this.Btn_PesquisarExibirTodosInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PesquisarExibirTodosInsumo.Name = "Btn_PesquisarExibirTodosInsumo";
            this.Btn_PesquisarExibirTodosInsumo.Size = new System.Drawing.Size(160, 31);
            this.Btn_PesquisarExibirTodosInsumo.TabIndex = 89;
            this.Btn_PesquisarExibirTodosInsumo.Text = "Exibir todos";
            this.Btn_PesquisarExibirTodosInsumo.UseVisualStyleBackColor = true;
            this.Btn_PesquisarExibirTodosInsumo.Click += new System.EventHandler(this.Btn_PesquisarExibirTodosInsumo_Click);
            // 
            // Lbl_PesqInsumoOrigemProduto
            // 
            this.Lbl_PesqInsumoOrigemProduto.AutoSize = true;
            this.Lbl_PesqInsumoOrigemProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqInsumoOrigemProduto.Location = new System.Drawing.Point(147, 82);
            this.Lbl_PesqInsumoOrigemProduto.Name = "Lbl_PesqInsumoOrigemProduto";
            this.Lbl_PesqInsumoOrigemProduto.Size = new System.Drawing.Size(121, 20);
            this.Lbl_PesqInsumoOrigemProduto.TabIndex = 87;
            this.Lbl_PesqInsumoOrigemProduto.Text = "Insumo Origem";
            // 
            // Lbl_PesqNomeProduto
            // 
            this.Lbl_PesqNomeProduto.AutoSize = true;
            this.Lbl_PesqNomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeProduto.Location = new System.Drawing.Point(220, 39);
            this.Lbl_PesqNomeProduto.Name = "Lbl_PesqNomeProduto";
            this.Lbl_PesqNomeProduto.Size = new System.Drawing.Size(54, 20);
            this.Lbl_PesqNomeProduto.TabIndex = 86;
            this.Lbl_PesqNomeProduto.Text = "Nome";
            // 
            // Txt_InsumoOrigem
            // 
            this.Txt_InsumoOrigem.AcceptsTab = true;
            this.Txt_InsumoOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_InsumoOrigem.Location = new System.Drawing.Point(284, 78);
            this.Txt_InsumoOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_InsumoOrigem.Name = "Txt_InsumoOrigem";
            this.Txt_InsumoOrigem.Size = new System.Drawing.Size(355, 25);
            this.Txt_InsumoOrigem.TabIndex = 85;
            // 
            // Txt_NomeProduto
            // 
            this.Txt_NomeProduto.AcceptsTab = true;
            this.Txt_NomeProduto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProduto.Location = new System.Drawing.Point(284, 34);
            this.Txt_NomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NomeProduto.Name = "Txt_NomeProduto";
            this.Txt_NomeProduto.Size = new System.Drawing.Size(355, 25);
            this.Txt_NomeProduto.TabIndex = 84;
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
            this.Coluna_PesqBloqueioProduto});
            this.Grd_ResultadosPesqProduto.Location = new System.Drawing.Point(32, 198);
            this.Grd_ResultadosPesqProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Grd_ResultadosPesqProduto.Size = new System.Drawing.Size(847, 305);
            this.Grd_ResultadosPesqProduto.TabIndex = 92;
            this.Grd_ResultadosPesqProduto.DoubleClick += new System.EventHandler(this.Grd_ResultadosPesqProduto_DoubleClick);
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
            // Coluna_PesqBloqueioProduto
            // 
            this.Coluna_PesqBloqueioProduto.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioProduto.MinimumWidth = 6;
            this.Coluna_PesqBloqueioProduto.Name = "Coluna_PesqBloqueioProduto";
            this.Coluna_PesqBloqueioProduto.ReadOnly = true;
            this.Coluna_PesqBloqueioProduto.Width = 80;
            // 
            // Frm_PesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(912, 530);
            this.Controls.Add(this.Grd_ResultadosPesqProduto);
            this.Controls.Add(this.Btn_PesquisarProduto);
            this.Controls.Add(this.Btn_PesquisarExibirTodosInsumo);
            this.Controls.Add(this.Lbl_PesqInsumoOrigemProduto);
            this.Controls.Add(this.Lbl_PesqNomeProduto);
            this.Controls.Add(this.Txt_InsumoOrigem);
            this.Controls.Add(this.Txt_NomeProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_PesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarProduto;
        private System.Windows.Forms.Button Btn_PesquisarExibirTodosInsumo;
        private System.Windows.Forms.Label Lbl_PesqInsumoOrigemProduto;
        private System.Windows.Forms.Label Lbl_PesqNomeProduto;
        private System.Windows.Forms.TextBox Txt_InsumoOrigem;
        private System.Windows.Forms.TextBox Txt_NomeProduto;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqInsumoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioProduto;
    }
}