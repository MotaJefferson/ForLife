namespace ForLife.Forms
{
    partial class Frm_PesquisaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaUsuario));
            this.Grd_ResultadosPesqUsuario = new System.Windows.Forms.DataGridView();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_PesqNomeUsuario = new System.Windows.Forms.TextBox();
            this.Txt_PesqUsuario = new System.Windows.Forms.TextBox();
            this.Lbl_PesqNomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_PesqUsuario = new System.Windows.Forms.Label();
            this.Lbl_PesqTipoUsuario = new System.Windows.Forms.Label();
            this.Cmb_PesqTipoUsuario = new System.Windows.Forms.ComboBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_exibirTodosUsuario = new System.Windows.Forms.Button();
            this.Btn_PesquisarUsuario = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_ResultadosPesqUsuario
            // 
            this.Grd_ResultadosPesqUsuario.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqUsuario.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqUsuario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grd_ResultadosPesqUsuario.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuário,
            this.Nome,
            this.TipoCadastro,
            this.Bloqueado});
            this.Grd_ResultadosPesqUsuario.Location = new System.Drawing.Point(23, 179);
            this.Grd_ResultadosPesqUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqUsuario.MultiSelect = false;
            this.Grd_ResultadosPesqUsuario.Name = "Grd_ResultadosPesqUsuario";
            this.Grd_ResultadosPesqUsuario.ReadOnly = true;
            this.Grd_ResultadosPesqUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grd_ResultadosPesqUsuario.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqUsuario.Size = new System.Drawing.Size(635, 230);
            this.Grd_ResultadosPesqUsuario.TabIndex = 1;
            this.Grd_ResultadosPesqUsuario.DoubleClick += new System.EventHandler(this.Grd_Resultados_DoubleClick);
            // 
            // Usuário
            // 
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.MinimumWidth = 6;
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            this.Usuário.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Completo";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // TipoCadastro
            // 
            this.TipoCadastro.HeaderText = "Tipo do Cadastro";
            this.TipoCadastro.MinimumWidth = 6;
            this.TipoCadastro.Name = "TipoCadastro";
            this.TipoCadastro.ReadOnly = true;
            this.TipoCadastro.Width = 140;
            // 
            // Bloqueado
            // 
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.MinimumWidth = 6;
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Width = 125;
            // 
            // Txt_PesqNomeUsuario
            // 
            this.Txt_PesqNomeUsuario.AcceptsTab = true;
            this.Txt_PesqNomeUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeUsuario.Location = new System.Drawing.Point(188, 26);
            this.Txt_PesqNomeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesqNomeUsuario.Name = "Txt_PesqNomeUsuario";
            this.Txt_PesqNomeUsuario.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesqNomeUsuario.TabIndex = 2;
            // 
            // Txt_PesqUsuario
            // 
            this.Txt_PesqUsuario.AcceptsTab = true;
            this.Txt_PesqUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqUsuario.Location = new System.Drawing.Point(188, 60);
            this.Txt_PesqUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesqUsuario.Name = "Txt_PesqUsuario";
            this.Txt_PesqUsuario.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesqUsuario.TabIndex = 3;
            // 
            // Lbl_PesqNomeUsuario
            // 
            this.Lbl_PesqNomeUsuario.AutoSize = true;
            this.Lbl_PesqNomeUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeUsuario.Location = new System.Drawing.Point(140, 30);
            this.Lbl_PesqNomeUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqNomeUsuario.Name = "Lbl_PesqNomeUsuario";
            this.Lbl_PesqNomeUsuario.Size = new System.Drawing.Size(44, 17);
            this.Lbl_PesqNomeUsuario.TabIndex = 4;
            this.Lbl_PesqNomeUsuario.Text = "Nome";
            // 
            // Lbl_PesqUsuario
            // 
            this.Lbl_PesqUsuario.AutoSize = true;
            this.Lbl_PesqUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqUsuario.Location = new System.Drawing.Point(131, 64);
            this.Lbl_PesqUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqUsuario.Name = "Lbl_PesqUsuario";
            this.Lbl_PesqUsuario.Size = new System.Drawing.Size(53, 17);
            this.Lbl_PesqUsuario.TabIndex = 5;
            this.Lbl_PesqUsuario.Text = "Usuário";
            // 
            // Lbl_PesqTipoUsuario
            // 
            this.Lbl_PesqTipoUsuario.AutoSize = true;
            this.Lbl_PesqTipoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqTipoUsuario.Location = new System.Drawing.Point(101, 99);
            this.Lbl_PesqTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqTipoUsuario.Name = "Lbl_PesqTipoUsuario";
            this.Lbl_PesqTipoUsuario.Size = new System.Drawing.Size(83, 17);
            this.Lbl_PesqTipoUsuario.TabIndex = 6;
            this.Lbl_PesqTipoUsuario.Text = "Tipo Usuário";
            // 
            // Cmb_PesqTipoUsuario
            // 
            this.Cmb_PesqTipoUsuario.FormattingEnabled = true;
            this.Cmb_PesqTipoUsuario.Items.AddRange(new object[] {
            "",
            "Agricultor",
            "Comercial",
            "Gestor"});
            this.Cmb_PesqTipoUsuario.Location = new System.Drawing.Point(188, 95);
            this.Cmb_PesqTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_PesqTipoUsuario.Name = "Cmb_PesqTipoUsuario";
            this.Cmb_PesqTipoUsuario.Size = new System.Drawing.Size(267, 21);
            this.Cmb_PesqTipoUsuario.TabIndex = 7;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_exibirTodosUsuario
            // 
            this.Btn_exibirTodosUsuario.ForeColor = System.Drawing.Color.Black;
            this.Btn_exibirTodosUsuario.Location = new System.Drawing.Point(335, 130);
            this.Btn_exibirTodosUsuario.Name = "Btn_exibirTodosUsuario";
            this.Btn_exibirTodosUsuario.Size = new System.Drawing.Size(120, 25);
            this.Btn_exibirTodosUsuario.TabIndex = 40;
            this.Btn_exibirTodosUsuario.Text = "Exibir todos";
            this.Btn_exibirTodosUsuario.UseVisualStyleBackColor = true;
            this.Btn_exibirTodosUsuario.Click += new System.EventHandler(this.btn_listarTodos_Click);
            // 
            // Btn_PesquisarUsuario
            // 
            this.Btn_PesquisarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarUsuario.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarUsuario.ImageList = this.imageIcons;
            this.Btn_PesquisarUsuario.Location = new System.Drawing.Point(188, 130);
            this.Btn_PesquisarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarUsuario.Name = "Btn_PesquisarUsuario";
            this.Btn_PesquisarUsuario.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarUsuario.TabIndex = 39;
            this.Btn_PesquisarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarUsuario.UseVisualStyleBackColor = true;
            this.Btn_PesquisarUsuario.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Frm_PesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Btn_exibirTodosUsuario);
            this.Controls.Add(this.Btn_PesquisarUsuario);
            this.Controls.Add(this.Cmb_PesqTipoUsuario);
            this.Controls.Add(this.Lbl_PesqTipoUsuario);
            this.Controls.Add(this.Lbl_PesqUsuario);
            this.Controls.Add(this.Lbl_PesqNomeUsuario);
            this.Controls.Add(this.Txt_PesqUsuario);
            this.Controls.Add(this.Txt_PesqNomeUsuario);
            this.Controls.Add(this.Grd_ResultadosPesqUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PesquisaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqUsuario;
        private System.Windows.Forms.TextBox Txt_PesqNomeUsuario;
        private System.Windows.Forms.TextBox Txt_PesqUsuario;
        private System.Windows.Forms.Label Lbl_PesqNomeUsuario;
        private System.Windows.Forms.Label Lbl_PesqUsuario;
        private System.Windows.Forms.Label Lbl_PesqTipoUsuario;
        private System.Windows.Forms.ComboBox Cmb_PesqTipoUsuario;
        private System.Windows.Forms.Button Btn_PesquisarUsuario;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Btn_exibirTodosUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloqueado;
    }
}