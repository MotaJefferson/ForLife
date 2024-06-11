namespace ForLife.Forms
{
    partial class Frm_PesquisarProdutoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarProdutoVenda));
            this.Grd_ResultadosProdutoVenda = new System.Windows.Forms.DataGridView();
            this.Lbl_NomeProdutoVendas = new System.Windows.Forms.Label();
            this.Txt_NomeProdutoVenda = new System.Windows.Forms.TextBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.PesquisaNomeProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_ResultadosProdutoVenda
            // 
            this.Grd_ResultadosProdutoVenda.AllowUserToAddRows = false;
            this.Grd_ResultadosProdutoVenda.AllowUserToDeleteRows = false;
            this.Grd_ResultadosProdutoVenda.AllowUserToOrderColumns = true;
            this.Grd_ResultadosProdutoVenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grd_ResultadosProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PesquisaNomeProdutoVenda});
            this.Grd_ResultadosProdutoVenda.Location = new System.Drawing.Point(67, 102);
            this.Grd_ResultadosProdutoVenda.Name = "Grd_ResultadosProdutoVenda";
            this.Grd_ResultadosProdutoVenda.ReadOnly = true;
            this.Grd_ResultadosProdutoVenda.RowHeadersWidth = 51;
            this.Grd_ResultadosProdutoVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosProdutoVenda.Size = new System.Drawing.Size(505, 295);
            this.Grd_ResultadosProdutoVenda.TabIndex = 16;
            // 
            // Lbl_NomeProdutoVendas
            // 
            this.Lbl_NomeProdutoVendas.AutoSize = true;
            this.Lbl_NomeProdutoVendas.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_NomeProdutoVendas.Location = new System.Drawing.Point(64, 33);
            this.Lbl_NomeProdutoVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeProdutoVendas.Name = "Lbl_NomeProdutoVendas";
            this.Lbl_NomeProdutoVendas.Size = new System.Drawing.Size(116, 17);
            this.Lbl_NomeProdutoVendas.TabIndex = 14;
            this.Lbl_NomeProdutoVendas.Text = "Nome do produto";
            // 
            // Txt_NomeProdutoVenda
            // 
            this.Txt_NomeProdutoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeProdutoVenda.Location = new System.Drawing.Point(67, 53);
            this.Txt_NomeProdutoVenda.Name = "Txt_NomeProdutoVenda";
            this.Txt_NomeProdutoVenda.Size = new System.Drawing.Size(419, 21);
            this.Txt_NomeProdutoVenda.TabIndex = 13;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pesquisar.ImageKey = "Pesquisar.png";
            this.Btn_Pesquisar.ImageList = this.imageIcons;
            this.Btn_Pesquisar.Location = new System.Drawing.Point(492, 49);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Pesquisar.Size = new System.Drawing.Size(80, 25);
            this.Btn_Pesquisar.TabIndex = 17;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // PesquisaNomeProdutoVenda
            // 
            this.PesquisaNomeProdutoVenda.HeaderText = "Nome do produto";
            this.PesquisaNomeProdutoVenda.MinimumWidth = 6;
            this.PesquisaNomeProdutoVenda.Name = "PesquisaNomeProdutoVenda";
            this.PesquisaNomeProdutoVenda.ReadOnly = true;
            this.PesquisaNomeProdutoVenda.Width = 452;
            // 
            // Frm_PesquisarProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Grd_ResultadosProdutoVenda);
            this.Controls.Add(this.Lbl_NomeProdutoVendas);
            this.Controls.Add(this.Txt_NomeProdutoVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisarProdutoVenda";
            this.Text = "Pesquisar Produto - Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosProdutoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_ResultadosProdutoVenda;
        private System.Windows.Forms.Label Lbl_NomeProdutoVendas;
        private System.Windows.Forms.TextBox Txt_NomeProdutoVenda;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesquisaNomeProdutoVenda;
    }
}