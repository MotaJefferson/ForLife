namespace ForLife.Forms
{
    partial class Frm_PesquisaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_PesquisarexibirTodosCliente = new System.Windows.Forms.Button();
            this.Lbl_PesquisaCpfCliente = new System.Windows.Forms.Label();
            this.Lbl_PesquisaTelefoneCliente = new System.Windows.Forms.Label();
            this.Lbl_PesquisaNomeCliente = new System.Windows.Forms.Label();
            this.Txt_PesquisaCidadeCliente = new System.Windows.Forms.TextBox();
            this.Txt_PesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_PesquisarCliente = new System.Windows.Forms.Button();
            this.textBox_PesquisaCpfCliente = new System.Windows.Forms.TextBox();
            this.Grd_ResultadosPesqCliente = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqTelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqEnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqCidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqBloqueioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_PesquisarexibirTodosCliente
            // 
            this.Btn_PesquisarexibirTodosCliente.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesquisarexibirTodosCliente.Location = new System.Drawing.Point(344, 132);
            this.Btn_PesquisarexibirTodosCliente.Name = "Btn_PesquisarexibirTodosCliente";
            this.Btn_PesquisarexibirTodosCliente.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarexibirTodosCliente.TabIndex = 48;
            this.Btn_PesquisarexibirTodosCliente.Text = "Exibir todos";
            this.Btn_PesquisarexibirTodosCliente.UseVisualStyleBackColor = true;
            // 
            // Lbl_PesquisaCpfCliente
            // 
            this.Lbl_PesquisaCpfCliente.AutoSize = true;
            this.Lbl_PesquisaCpfCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesquisaCpfCliente.Location = new System.Drawing.Point(164, 101);
            this.Lbl_PesquisaCpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisaCpfCliente.Name = "Lbl_PesquisaCpfCliente";
            this.Lbl_PesquisaCpfCliente.Size = new System.Drawing.Size(29, 17);
            this.Lbl_PesquisaCpfCliente.TabIndex = 45;
            this.Lbl_PesquisaCpfCliente.Text = "CPF";
            // 
            // Lbl_PesquisaTelefoneCliente
            // 
            this.Lbl_PesquisaTelefoneCliente.AutoSize = true;
            this.Lbl_PesquisaTelefoneCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesquisaTelefoneCliente.Location = new System.Drawing.Point(135, 67);
            this.Lbl_PesquisaTelefoneCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisaTelefoneCliente.Name = "Lbl_PesquisaTelefoneCliente";
            this.Lbl_PesquisaTelefoneCliente.Size = new System.Drawing.Size(58, 17);
            this.Lbl_PesquisaTelefoneCliente.TabIndex = 44;
            this.Lbl_PesquisaTelefoneCliente.Text = "Telefone";
            // 
            // Lbl_PesquisaNomeCliente
            // 
            this.Lbl_PesquisaNomeCliente.AutoSize = true;
            this.Lbl_PesquisaNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesquisaNomeCliente.Location = new System.Drawing.Point(149, 32);
            this.Lbl_PesquisaNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesquisaNomeCliente.Name = "Lbl_PesquisaNomeCliente";
            this.Lbl_PesquisaNomeCliente.Size = new System.Drawing.Size(44, 17);
            this.Lbl_PesquisaNomeCliente.TabIndex = 43;
            this.Lbl_PesquisaNomeCliente.Text = "Nome";
            // 
            // Txt_PesquisaCidadeCliente
            // 
            this.Txt_PesquisaCidadeCliente.AcceptsTab = true;
            this.Txt_PesquisaCidadeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesquisaCidadeCliente.Location = new System.Drawing.Point(197, 63);
            this.Txt_PesquisaCidadeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesquisaCidadeCliente.Name = "Txt_PesquisaCidadeCliente";
            this.Txt_PesquisaCidadeCliente.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesquisaCidadeCliente.TabIndex = 42;
            // 
            // Txt_PesquisaNomeCliente
            // 
            this.Txt_PesquisaNomeCliente.AcceptsTab = true;
            this.Txt_PesquisaNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesquisaNomeCliente.Location = new System.Drawing.Point(197, 28);
            this.Txt_PesquisaNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesquisaNomeCliente.Name = "Txt_PesquisaNomeCliente";
            this.Txt_PesquisaNomeCliente.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesquisaNomeCliente.TabIndex = 41;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_PesquisarCliente
            // 
            this.Btn_PesquisarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarCliente.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarCliente.ImageList = this.imageIcons;
            this.Btn_PesquisarCliente.Location = new System.Drawing.Point(197, 132);
            this.Btn_PesquisarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarCliente.Name = "Btn_PesquisarCliente";
            this.Btn_PesquisarCliente.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarCliente.TabIndex = 49;
            this.Btn_PesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox_PesquisaCpfCliente
            // 
            this.textBox_PesquisaCpfCliente.AcceptsTab = true;
            this.textBox_PesquisaCpfCliente.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesquisaCpfCliente.Location = new System.Drawing.Point(197, 97);
            this.textBox_PesquisaCpfCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PesquisaCpfCliente.Name = "textBox_PesquisaCpfCliente";
            this.textBox_PesquisaCpfCliente.Size = new System.Drawing.Size(267, 21);
            this.textBox_PesquisaCpfCliente.TabIndex = 50;
            // 
            // Grd_ResultadosPesqCliente
            // 
            this.Grd_ResultadosPesqCliente.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqCliente.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqCliente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Grd_ResultadosPesqCliente.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeCliente,
            this.Coluna_PesqTelefoneCliente,
            this.Coluna_PesqEnderecoCliente,
            this.Coluna_PesqCidadeCliente,
            this.Coluna_PesqBloqueioCliente});
            this.Grd_ResultadosPesqCliente.Location = new System.Drawing.Point(22, 180);
            this.Grd_ResultadosPesqCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqCliente.MultiSelect = false;
            this.Grd_ResultadosPesqCliente.Name = "Grd_ResultadosPesqCliente";
            this.Grd_ResultadosPesqCliente.ReadOnly = true;
            this.Grd_ResultadosPesqCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqCliente.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Grd_ResultadosPesqCliente.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqCliente.Size = new System.Drawing.Size(635, 228);
            this.Grd_ResultadosPesqCliente.TabIndex = 51;
            // 
            // Coluna_PesqNomeCliente
            // 
            this.Coluna_PesqNomeCliente.HeaderText = "Nome";
            this.Coluna_PesqNomeCliente.MinimumWidth = 6;
            this.Coluna_PesqNomeCliente.Name = "Coluna_PesqNomeCliente";
            this.Coluna_PesqNomeCliente.ReadOnly = true;
            this.Coluna_PesqNomeCliente.Width = 170;
            // 
            // Coluna_PesqTelefoneCliente
            // 
            this.Coluna_PesqTelefoneCliente.HeaderText = "Telefone";
            this.Coluna_PesqTelefoneCliente.MinimumWidth = 6;
            this.Coluna_PesqTelefoneCliente.Name = "Coluna_PesqTelefoneCliente";
            this.Coluna_PesqTelefoneCliente.ReadOnly = true;
            this.Coluna_PesqTelefoneCliente.Width = 110;
            // 
            // Coluna_PesqEnderecoCliente
            // 
            this.Coluna_PesqEnderecoCliente.HeaderText = "Endereço";
            this.Coluna_PesqEnderecoCliente.MinimumWidth = 6;
            this.Coluna_PesqEnderecoCliente.Name = "Coluna_PesqEnderecoCliente";
            this.Coluna_PesqEnderecoCliente.ReadOnly = true;
            this.Coluna_PesqEnderecoCliente.Width = 200;
            // 
            // Coluna_PesqCidadeCliente
            // 
            this.Coluna_PesqCidadeCliente.HeaderText = "Cidade";
            this.Coluna_PesqCidadeCliente.MinimumWidth = 6;
            this.Coluna_PesqCidadeCliente.Name = "Coluna_PesqCidadeCliente";
            this.Coluna_PesqCidadeCliente.ReadOnly = true;
            this.Coluna_PesqCidadeCliente.Width = 110;
            // 
            // Coluna_PesqBloqueioCliente
            // 
            this.Coluna_PesqBloqueioCliente.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioCliente.Name = "Coluna_PesqBloqueioCliente";
            this.Coluna_PesqBloqueioCliente.ReadOnly = true;
            this.Coluna_PesqBloqueioCliente.Width = 80;
            // 
            // Frm_PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Grd_ResultadosPesqCliente);
            this.Controls.Add(this.textBox_PesquisaCpfCliente);
            this.Controls.Add(this.Btn_PesquisarCliente);
            this.Controls.Add(this.Btn_PesquisarexibirTodosCliente);
            this.Controls.Add(this.Lbl_PesquisaCpfCliente);
            this.Controls.Add(this.Lbl_PesquisaTelefoneCliente);
            this.Controls.Add(this.Lbl_PesquisaNomeCliente);
            this.Controls.Add(this.Txt_PesquisaCidadeCliente);
            this.Controls.Add(this.Txt_PesquisaNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisaCliente";
            this.Text = "Pesquisar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_PesquisarexibirTodosCliente;
        private System.Windows.Forms.Label Lbl_PesquisaCpfCliente;
        private System.Windows.Forms.Label Lbl_PesquisaTelefoneCliente;
        private System.Windows.Forms.Label Lbl_PesquisaNomeCliente;
        private System.Windows.Forms.TextBox Txt_PesquisaCidadeCliente;
        private System.Windows.Forms.TextBox Txt_PesquisaNomeCliente;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarCliente;
        private System.Windows.Forms.TextBox textBox_PesquisaCpfCliente;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqTelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqEnderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqCidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioCliente;
    }
}