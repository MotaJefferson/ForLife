﻿namespace ForLife.Forms
{
    partial class Frm_PesquisaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_PesqCnpjForn = new System.Windows.Forms.TextBox();
            this.Btn_PesqexibirTodosForn = new System.Windows.Forms.Button();
            this.Lbl_PesqCnpjForn = new System.Windows.Forms.Label();
            this.Lbl_PesqRazaoSocialForn = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeFantasiaForn = new System.Windows.Forms.Label();
            this.Txt_PesqRazaoSocialForn = new System.Windows.Forms.TextBox();
            this.Txt_PesqNomeFantasiaForn = new System.Windows.Forms.TextBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_PesquisarFornecedor = new System.Windows.Forms.Button();
            this.Grd_ResultadosPesqFornecedor = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeFantForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqRazaoSocialForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_EnderecoForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqTelefoneForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqCidadeForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_CnpjForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqBloqueioForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PesqCnpjForn
            // 
            this.textBox_PesqCnpjForn.AcceptsTab = true;
            this.textBox_PesqCnpjForn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesqCnpjForn.Location = new System.Drawing.Point(201, 99);
            this.textBox_PesqCnpjForn.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PesqCnpjForn.Name = "textBox_PesqCnpjForn";
            this.textBox_PesqCnpjForn.Size = new System.Drawing.Size(267, 21);
            this.textBox_PesqCnpjForn.TabIndex = 58;
            // 
            // Btn_PesqexibirTodosForn
            // 
            this.Btn_PesqexibirTodosForn.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesqexibirTodosForn.Location = new System.Drawing.Point(348, 134);
            this.Btn_PesqexibirTodosForn.Name = "Btn_PesqexibirTodosForn";
            this.Btn_PesqexibirTodosForn.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesqexibirTodosForn.TabIndex = 56;
            this.Btn_PesqexibirTodosForn.Text = "Exibir todos";
            this.Btn_PesqexibirTodosForn.UseVisualStyleBackColor = true;
            // 
            // Lbl_PesqCnpjForn
            // 
            this.Lbl_PesqCnpjForn.AutoSize = true;
            this.Lbl_PesqCnpjForn.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqCnpjForn.Location = new System.Drawing.Point(159, 103);
            this.Lbl_PesqCnpjForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqCnpjForn.Name = "Lbl_PesqCnpjForn";
            this.Lbl_PesqCnpjForn.Size = new System.Drawing.Size(38, 17);
            this.Lbl_PesqCnpjForn.TabIndex = 55;
            this.Lbl_PesqCnpjForn.Text = "CNPJ";
            // 
            // Lbl_PesqRazaoSocialForn
            // 
            this.Lbl_PesqRazaoSocialForn.AutoSize = true;
            this.Lbl_PesqRazaoSocialForn.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqRazaoSocialForn.Location = new System.Drawing.Point(115, 69);
            this.Lbl_PesqRazaoSocialForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqRazaoSocialForn.Name = "Lbl_PesqRazaoSocialForn";
            this.Lbl_PesqRazaoSocialForn.Size = new System.Drawing.Size(82, 17);
            this.Lbl_PesqRazaoSocialForn.TabIndex = 54;
            this.Lbl_PesqRazaoSocialForn.Text = "Razão Social";
            // 
            // Lbl_PesqNomeFantasiaForn
            // 
            this.Lbl_PesqNomeFantasiaForn.AutoSize = true;
            this.Lbl_PesqNomeFantasiaForn.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeFantasiaForn.Location = new System.Drawing.Point(104, 34);
            this.Lbl_PesqNomeFantasiaForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqNomeFantasiaForn.Name = "Lbl_PesqNomeFantasiaForn";
            this.Lbl_PesqNomeFantasiaForn.Size = new System.Drawing.Size(93, 17);
            this.Lbl_PesqNomeFantasiaForn.TabIndex = 53;
            this.Lbl_PesqNomeFantasiaForn.Text = "Nome fantasia";
            // 
            // Txt_PesqRazaoSocialForn
            // 
            this.Txt_PesqRazaoSocialForn.AcceptsTab = true;
            this.Txt_PesqRazaoSocialForn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqRazaoSocialForn.Location = new System.Drawing.Point(201, 65);
            this.Txt_PesqRazaoSocialForn.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesqRazaoSocialForn.Name = "Txt_PesqRazaoSocialForn";
            this.Txt_PesqRazaoSocialForn.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesqRazaoSocialForn.TabIndex = 52;
            // 
            // Txt_PesqNomeFantasiaForn
            // 
            this.Txt_PesqNomeFantasiaForn.AcceptsTab = true;
            this.Txt_PesqNomeFantasiaForn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeFantasiaForn.Location = new System.Drawing.Point(201, 30);
            this.Txt_PesqNomeFantasiaForn.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesqNomeFantasiaForn.Name = "Txt_PesqNomeFantasiaForn";
            this.Txt_PesqNomeFantasiaForn.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesqNomeFantasiaForn.TabIndex = 51;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_PesquisarFornecedor
            // 
            this.Btn_PesquisarFornecedor.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarFornecedor.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarFornecedor.ImageList = this.imageIcons;
            this.Btn_PesquisarFornecedor.Location = new System.Drawing.Point(201, 134);
            this.Btn_PesquisarFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarFornecedor.Name = "Btn_PesquisarFornecedor";
            this.Btn_PesquisarFornecedor.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarFornecedor.TabIndex = 59;
            this.Btn_PesquisarFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarFornecedor.UseVisualStyleBackColor = true;
            // 
            // Grd_ResultadosPesqFornecedor
            // 
            this.Grd_ResultadosPesqFornecedor.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqFornecedor.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqFornecedor.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_ResultadosPesqFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeFantForn,
            this.Coluna_PesqRazaoSocialForn,
            this.Coluna_EnderecoForn,
            this.Coluna_PesqTelefoneForn,
            this.Coluna_PesqCidadeForn,
            this.Coluna_CnpjForn,
            this.Coluna_PesqBloqueioForn});
            this.Grd_ResultadosPesqFornecedor.Location = new System.Drawing.Point(23, 181);
            this.Grd_ResultadosPesqFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqFornecedor.MultiSelect = false;
            this.Grd_ResultadosPesqFornecedor.Name = "Grd_ResultadosPesqFornecedor";
            this.Grd_ResultadosPesqFornecedor.ReadOnly = true;
            this.Grd_ResultadosPesqFornecedor.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_ResultadosPesqFornecedor.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqFornecedor.Size = new System.Drawing.Size(635, 228);
            this.Grd_ResultadosPesqFornecedor.TabIndex = 60;
            // 
            // Coluna_PesqNomeFantForn
            // 
            this.Coluna_PesqNomeFantForn.HeaderText = "Nome Fantasia";
            this.Coluna_PesqNomeFantForn.MinimumWidth = 6;
            this.Coluna_PesqNomeFantForn.Name = "Coluna_PesqNomeFantForn";
            this.Coluna_PesqNomeFantForn.ReadOnly = true;
            this.Coluna_PesqNomeFantForn.Width = 170;
            // 
            // Coluna_PesqRazaoSocialForn
            // 
            this.Coluna_PesqRazaoSocialForn.HeaderText = "Razão Social";
            this.Coluna_PesqRazaoSocialForn.MinimumWidth = 6;
            this.Coluna_PesqRazaoSocialForn.Name = "Coluna_PesqRazaoSocialForn";
            this.Coluna_PesqRazaoSocialForn.ReadOnly = true;
            this.Coluna_PesqRazaoSocialForn.Width = 170;
            // 
            // Coluna_EnderecoForn
            // 
            this.Coluna_EnderecoForn.HeaderText = "Endereço";
            this.Coluna_EnderecoForn.Name = "Coluna_EnderecoForn";
            this.Coluna_EnderecoForn.ReadOnly = true;
            // 
            // Coluna_PesqTelefoneForn
            // 
            this.Coluna_PesqTelefoneForn.HeaderText = "Telefone";
            this.Coluna_PesqTelefoneForn.MinimumWidth = 6;
            this.Coluna_PesqTelefoneForn.Name = "Coluna_PesqTelefoneForn";
            this.Coluna_PesqTelefoneForn.ReadOnly = true;
            this.Coluna_PesqTelefoneForn.Width = 200;
            // 
            // Coluna_PesqCidadeForn
            // 
            this.Coluna_PesqCidadeForn.HeaderText = "Cidade";
            this.Coluna_PesqCidadeForn.MinimumWidth = 6;
            this.Coluna_PesqCidadeForn.Name = "Coluna_PesqCidadeForn";
            this.Coluna_PesqCidadeForn.ReadOnly = true;
            this.Coluna_PesqCidadeForn.Width = 110;
            // 
            // Coluna_CnpjForn
            // 
            this.Coluna_CnpjForn.HeaderText = "CNPJ";
            this.Coluna_CnpjForn.Name = "Coluna_CnpjForn";
            this.Coluna_CnpjForn.ReadOnly = true;
            // 
            // Coluna_PesqBloqueioForn
            // 
            this.Coluna_PesqBloqueioForn.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioForn.Name = "Coluna_PesqBloqueioForn";
            this.Coluna_PesqBloqueioForn.ReadOnly = true;
            this.Coluna_PesqBloqueioForn.Width = 80;
            // 
            // Frm_PesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Grd_ResultadosPesqFornecedor);
            this.Controls.Add(this.Btn_PesquisarFornecedor);
            this.Controls.Add(this.textBox_PesqCnpjForn);
            this.Controls.Add(this.Btn_PesqexibirTodosForn);
            this.Controls.Add(this.Lbl_PesqCnpjForn);
            this.Controls.Add(this.Lbl_PesqRazaoSocialForn);
            this.Controls.Add(this.Lbl_PesqNomeFantasiaForn);
            this.Controls.Add(this.Txt_PesqRazaoSocialForn);
            this.Controls.Add(this.Txt_PesqNomeFantasiaForn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisaFornecedor";
            this.Text = "Pesquisar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PesqCnpjForn;
        private System.Windows.Forms.Button Btn_PesqexibirTodosForn;
        private System.Windows.Forms.Label Lbl_PesqCnpjForn;
        private System.Windows.Forms.Label Lbl_PesqRazaoSocialForn;
        private System.Windows.Forms.Label Lbl_PesqNomeFantasiaForn;
        private System.Windows.Forms.TextBox Txt_PesqRazaoSocialForn;
        private System.Windows.Forms.TextBox Txt_PesqNomeFantasiaForn;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarFornecedor;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeFantForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqRazaoSocialForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_EnderecoForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqTelefoneForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqCidadeForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_CnpjForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioForn;
    }
}