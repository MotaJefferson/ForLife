namespace ForLife.Forms
{
    partial class Frm_PesquisaInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaInsumo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_PesquisarInsumo = new System.Windows.Forms.Button();
            this.Btn_PesqexibirTodosInsumo = new System.Windows.Forms.Button();
            this.Lbl_PesqTipoInsumo = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeInsumo = new System.Windows.Forms.Label();
            this.Txt_PesqTipoInsumo = new System.Windows.Forms.TextBox();
            this.Txt_PesqNomeInsumo = new System.Windows.Forms.TextBox();
            this.Grd_ResultadosPesqInsumo = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqTipoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqBloqueioInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_PesquisarInsumo
            // 
            this.Btn_PesquisarInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_PesquisarInsumo.ImageKey = "Pesquisar.png";
            this.Btn_PesquisarInsumo.ImageList = this.imageIcons;
            this.Btn_PesquisarInsumo.Location = new System.Drawing.Point(290, 133);
            this.Btn_PesquisarInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_PesquisarInsumo.Name = "Btn_PesquisarInsumo";
            this.Btn_PesquisarInsumo.Size = new System.Drawing.Size(160, 31);
            this.Btn_PesquisarInsumo.TabIndex = 75;
            this.Btn_PesquisarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarInsumo.UseVisualStyleBackColor = true;
            this.Btn_PesquisarInsumo.Click += new System.EventHandler(this.Btn_PesquisarInsumo_Click);
            // 
            // Btn_PesqexibirTodosInsumo
            // 
            this.Btn_PesqexibirTodosInsumo.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesqexibirTodosInsumo.Location = new System.Drawing.Point(486, 133);
            this.Btn_PesqexibirTodosInsumo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_PesqexibirTodosInsumo.Name = "Btn_PesqexibirTodosInsumo";
            this.Btn_PesqexibirTodosInsumo.Size = new System.Drawing.Size(160, 31);
            this.Btn_PesqexibirTodosInsumo.TabIndex = 73;
            this.Btn_PesqexibirTodosInsumo.Text = "Exibir todos";
            this.Btn_PesqexibirTodosInsumo.UseVisualStyleBackColor = true;
            this.Btn_PesqexibirTodosInsumo.Click += new System.EventHandler(this.Btn_PesqexibirTodosInsumo_Click);
            // 
            // Lbl_PesqTipoInsumo
            // 
            this.Lbl_PesqTipoInsumo.AutoSize = true;
            this.Lbl_PesqTipoInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqTipoInsumo.Location = new System.Drawing.Point(240, 86);
            this.Lbl_PesqTipoInsumo.Name = "Lbl_PesqTipoInsumo";
            this.Lbl_PesqTipoInsumo.Size = new System.Drawing.Size(42, 20);
            this.Lbl_PesqTipoInsumo.TabIndex = 71;
            this.Lbl_PesqTipoInsumo.Text = "Tipo";
            // 
            // Lbl_PesqNomeInsumo
            // 
            this.Lbl_PesqNomeInsumo.AutoSize = true;
            this.Lbl_PesqNomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeInsumo.Location = new System.Drawing.Point(227, 43);
            this.Lbl_PesqNomeInsumo.Name = "Lbl_PesqNomeInsumo";
            this.Lbl_PesqNomeInsumo.Size = new System.Drawing.Size(54, 20);
            this.Lbl_PesqNomeInsumo.TabIndex = 70;
            this.Lbl_PesqNomeInsumo.Text = "Nome";
            // 
            // Txt_PesqTipoInsumo
            // 
            this.Txt_PesqTipoInsumo.AcceptsTab = true;
            this.Txt_PesqTipoInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqTipoInsumo.Location = new System.Drawing.Point(291, 81);
            this.Txt_PesqTipoInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PesqTipoInsumo.Name = "Txt_PesqTipoInsumo";
            this.Txt_PesqTipoInsumo.Size = new System.Drawing.Size(355, 25);
            this.Txt_PesqTipoInsumo.TabIndex = 69;
            // 
            // Txt_PesqNomeInsumo
            // 
            this.Txt_PesqNomeInsumo.AcceptsTab = true;
            this.Txt_PesqNomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeInsumo.Location = new System.Drawing.Point(291, 38);
            this.Txt_PesqNomeInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PesqNomeInsumo.Name = "Txt_PesqNomeInsumo";
            this.Txt_PesqNomeInsumo.Size = new System.Drawing.Size(355, 25);
            this.Txt_PesqNomeInsumo.TabIndex = 68;
            // 
            // Grd_ResultadosPesqInsumo
            // 
            this.Grd_ResultadosPesqInsumo.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqInsumo.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqInsumo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqInsumo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grd_ResultadosPesqInsumo.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeInsumo,
            this.Coluna_PesqTipoInsumo,
            this.Coluna_PesqBloqueioInsumo});
            this.Grd_ResultadosPesqInsumo.Location = new System.Drawing.Point(35, 198);
            this.Grd_ResultadosPesqInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd_ResultadosPesqInsumo.MultiSelect = false;
            this.Grd_ResultadosPesqInsumo.Name = "Grd_ResultadosPesqInsumo";
            this.Grd_ResultadosPesqInsumo.ReadOnly = true;
            this.Grd_ResultadosPesqInsumo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqInsumo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grd_ResultadosPesqInsumo.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqInsumo.Size = new System.Drawing.Size(847, 307);
            this.Grd_ResultadosPesqInsumo.TabIndex = 76;
            this.Grd_ResultadosPesqInsumo.DoubleClick += new System.EventHandler(this.Grd_ResultadosPesqInsumo_DoubleClick);
            // 
            // Coluna_PesqNomeInsumo
            // 
            this.Coluna_PesqNomeInsumo.HeaderText = "Nome";
            this.Coluna_PesqNomeInsumo.MinimumWidth = 6;
            this.Coluna_PesqNomeInsumo.Name = "Coluna_PesqNomeInsumo";
            this.Coluna_PesqNomeInsumo.ReadOnly = true;
            this.Coluna_PesqNomeInsumo.Width = 250;
            // 
            // Coluna_PesqTipoInsumo
            // 
            this.Coluna_PesqTipoInsumo.HeaderText = "Tipo";
            this.Coluna_PesqTipoInsumo.MinimumWidth = 6;
            this.Coluna_PesqTipoInsumo.Name = "Coluna_PesqTipoInsumo";
            this.Coluna_PesqTipoInsumo.ReadOnly = true;
            this.Coluna_PesqTipoInsumo.Width = 150;
            // 
            // Coluna_PesqBloqueioInsumo
            // 
            this.Coluna_PesqBloqueioInsumo.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioInsumo.MinimumWidth = 6;
            this.Coluna_PesqBloqueioInsumo.Name = "Coluna_PesqBloqueioInsumo";
            this.Coluna_PesqBloqueioInsumo.ReadOnly = true;
            this.Coluna_PesqBloqueioInsumo.Width = 80;
            // 
            // Frm_PesquisaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(912, 530);
            this.Controls.Add(this.Grd_ResultadosPesqInsumo);
            this.Controls.Add(this.Btn_PesquisarInsumo);
            this.Controls.Add(this.Btn_PesqexibirTodosInsumo);
            this.Controls.Add(this.Lbl_PesqTipoInsumo);
            this.Controls.Add(this.Lbl_PesqNomeInsumo);
            this.Controls.Add(this.Txt_PesqTipoInsumo);
            this.Controls.Add(this.Txt_PesqNomeInsumo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_PesquisaInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Insumo";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarInsumo;
        private System.Windows.Forms.Button Btn_PesqexibirTodosInsumo;
        private System.Windows.Forms.Label Lbl_PesqTipoInsumo;
        private System.Windows.Forms.Label Lbl_PesqNomeInsumo;
        private System.Windows.Forms.TextBox Txt_PesqTipoInsumo;
        private System.Windows.Forms.TextBox Txt_PesqNomeInsumo;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqTipoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioInsumo;
    }
}