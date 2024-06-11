namespace ForLife.Forms
{
    partial class Frm_PesquisaClienteVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaClienteVendas));
            this.Lbl_NomeClienteVendas = new System.Windows.Forms.Label();
            this.Txt_NomeClienteVenda = new System.Windows.Forms.TextBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Grd_ResultadosClienteVenda = new System.Windows.Forms.DataGridView();
            this.PesquisaNomeClienteVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosClienteVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_NomeClienteVendas
            // 
            this.Lbl_NomeClienteVendas.AutoSize = true;
            this.Lbl_NomeClienteVendas.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_NomeClienteVendas.Location = new System.Drawing.Point(55, 34);
            this.Lbl_NomeClienteVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeClienteVendas.Name = "Lbl_NomeClienteVendas";
            this.Lbl_NomeClienteVendas.Size = new System.Drawing.Size(105, 17);
            this.Lbl_NomeClienteVendas.TabIndex = 10;
            this.Lbl_NomeClienteVendas.Text = "Nome do cliente";
            // 
            // Txt_NomeClienteVenda
            // 
            this.Txt_NomeClienteVenda.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeClienteVenda.Location = new System.Drawing.Point(58, 54);
            this.Txt_NomeClienteVenda.Name = "Txt_NomeClienteVenda";
            this.Txt_NomeClienteVenda.Size = new System.Drawing.Size(419, 21);
            this.Txt_NomeClienteVenda.TabIndex = 9;
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
            this.Btn_Pesquisar.Location = new System.Drawing.Point(483, 50);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Pesquisar.Size = new System.Drawing.Size(80, 25);
            this.Btn_Pesquisar.TabIndex = 11;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Grd_ResultadosClienteVenda
            // 
            this.Grd_ResultadosClienteVenda.AllowUserToAddRows = false;
            this.Grd_ResultadosClienteVenda.AllowUserToDeleteRows = false;
            this.Grd_ResultadosClienteVenda.AllowUserToOrderColumns = true;
            this.Grd_ResultadosClienteVenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grd_ResultadosClienteVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosClienteVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PesquisaNomeClienteVenda});
            this.Grd_ResultadosClienteVenda.Location = new System.Drawing.Point(58, 103);
            this.Grd_ResultadosClienteVenda.Name = "Grd_ResultadosClienteVenda";
            this.Grd_ResultadosClienteVenda.ReadOnly = true;
            this.Grd_ResultadosClienteVenda.RowHeadersWidth = 51;
            this.Grd_ResultadosClienteVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosClienteVenda.Size = new System.Drawing.Size(505, 295);
            this.Grd_ResultadosClienteVenda.TabIndex = 12;
            // 
            // PesquisaNomeClienteVenda
            // 
            this.PesquisaNomeClienteVenda.HeaderText = "Nome do cliente";
            this.PesquisaNomeClienteVenda.MinimumWidth = 6;
            this.PesquisaNomeClienteVenda.Name = "PesquisaNomeClienteVenda";
            this.PesquisaNomeClienteVenda.ReadOnly = true;
            this.PesquisaNomeClienteVenda.Width = 452;
            // 
            // Frm_PesquisaClienteVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.Grd_ResultadosClienteVenda);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Lbl_NomeClienteVendas);
            this.Controls.Add(this.Txt_NomeClienteVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisaClienteVendas";
            this.Text = "Pesquisar Cliente - Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosClienteVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_NomeClienteVendas;
        private System.Windows.Forms.TextBox Txt_NomeClienteVenda;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.DataGridView Grd_ResultadosClienteVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesquisaNomeClienteVenda;
    }
}