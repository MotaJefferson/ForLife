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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_PesquisarInsumo = new System.Windows.Forms.Button();
            this.textBox__PesqValidadeInsumo = new System.Windows.Forms.TextBox();
            this.Btn_PesqexibirTodosInsumo = new System.Windows.Forms.Button();
            this.Lbl_PesqValidadeInsumo = new System.Windows.Forms.Label();
            this.Lbl_PesqTipoInsumo = new System.Windows.Forms.Label();
            this.Lbl_PesqNomeInsumo = new System.Windows.Forms.Label();
            this.Txt__PesqTipoInsumo = new System.Windows.Forms.TextBox();
            this.Txt_PesqNomeInsumo = new System.Windows.Forms.TextBox();
            this.Grd_ResultadosPesqInsumo = new System.Windows.Forms.DataGridView();
            this.Coluna_PesqNomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_PesqTipoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_ValidadeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Btn_PesquisarInsumo.Location = new System.Drawing.Point(218, 135);
            this.Btn_PesquisarInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_PesquisarInsumo.Name = "Btn_PesquisarInsumo";
            this.Btn_PesquisarInsumo.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesquisarInsumo.TabIndex = 75;
            this.Btn_PesquisarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PesquisarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PesquisarInsumo.UseVisualStyleBackColor = true;
            // 
            // textBox__PesqValidadeInsumo
            // 
            this.textBox__PesqValidadeInsumo.AcceptsTab = true;
            this.textBox__PesqValidadeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox__PesqValidadeInsumo.Location = new System.Drawing.Point(218, 100);
            this.textBox__PesqValidadeInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox__PesqValidadeInsumo.Name = "textBox__PesqValidadeInsumo";
            this.textBox__PesqValidadeInsumo.Size = new System.Drawing.Size(267, 21);
            this.textBox__PesqValidadeInsumo.TabIndex = 74;
            // 
            // Btn_PesqexibirTodosInsumo
            // 
            this.Btn_PesqexibirTodosInsumo.ForeColor = System.Drawing.Color.Black;
            this.Btn_PesqexibirTodosInsumo.Location = new System.Drawing.Point(365, 135);
            this.Btn_PesqexibirTodosInsumo.Name = "Btn_PesqexibirTodosInsumo";
            this.Btn_PesqexibirTodosInsumo.Size = new System.Drawing.Size(120, 25);
            this.Btn_PesqexibirTodosInsumo.TabIndex = 73;
            this.Btn_PesqexibirTodosInsumo.Text = "Exibir todos";
            this.Btn_PesqexibirTodosInsumo.UseVisualStyleBackColor = true;
            // 
            // Lbl_PesqValidadeInsumo
            // 
            this.Lbl_PesqValidadeInsumo.AutoSize = true;
            this.Lbl_PesqValidadeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqValidadeInsumo.Location = new System.Drawing.Point(155, 104);
            this.Lbl_PesqValidadeInsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqValidadeInsumo.Name = "Lbl_PesqValidadeInsumo";
            this.Lbl_PesqValidadeInsumo.Size = new System.Drawing.Size(59, 17);
            this.Lbl_PesqValidadeInsumo.TabIndex = 72;
            this.Lbl_PesqValidadeInsumo.Text = "Validade";
            // 
            // Lbl_PesqTipoInsumo
            // 
            this.Lbl_PesqTipoInsumo.AutoSize = true;
            this.Lbl_PesqTipoInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqTipoInsumo.Location = new System.Drawing.Point(180, 70);
            this.Lbl_PesqTipoInsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqTipoInsumo.Name = "Lbl_PesqTipoInsumo";
            this.Lbl_PesqTipoInsumo.Size = new System.Drawing.Size(34, 17);
            this.Lbl_PesqTipoInsumo.TabIndex = 71;
            this.Lbl_PesqTipoInsumo.Text = "Tipo";
            // 
            // Lbl_PesqNomeInsumo
            // 
            this.Lbl_PesqNomeInsumo.AutoSize = true;
            this.Lbl_PesqNomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_PesqNomeInsumo.Location = new System.Drawing.Point(170, 35);
            this.Lbl_PesqNomeInsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PesqNomeInsumo.Name = "Lbl_PesqNomeInsumo";
            this.Lbl_PesqNomeInsumo.Size = new System.Drawing.Size(44, 17);
            this.Lbl_PesqNomeInsumo.TabIndex = 70;
            this.Lbl_PesqNomeInsumo.Text = "Nome";
            // 
            // Txt__PesqTipoInsumo
            // 
            this.Txt__PesqTipoInsumo.AcceptsTab = true;
            this.Txt__PesqTipoInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt__PesqTipoInsumo.Location = new System.Drawing.Point(218, 66);
            this.Txt__PesqTipoInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt__PesqTipoInsumo.Name = "Txt__PesqTipoInsumo";
            this.Txt__PesqTipoInsumo.Size = new System.Drawing.Size(267, 21);
            this.Txt__PesqTipoInsumo.TabIndex = 69;
            // 
            // Txt_PesqNomeInsumo
            // 
            this.Txt_PesqNomeInsumo.AcceptsTab = true;
            this.Txt_PesqNomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PesqNomeInsumo.Location = new System.Drawing.Point(218, 31);
            this.Txt_PesqNomeInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PesqNomeInsumo.Name = "Txt_PesqNomeInsumo";
            this.Txt_PesqNomeInsumo.Size = new System.Drawing.Size(267, 21);
            this.Txt_PesqNomeInsumo.TabIndex = 68;
            // 
            // Grd_ResultadosPesqInsumo
            // 
            this.Grd_ResultadosPesqInsumo.AllowUserToAddRows = false;
            this.Grd_ResultadosPesqInsumo.AllowUserToDeleteRows = false;
            this.Grd_ResultadosPesqInsumo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_ResultadosPesqInsumo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_ResultadosPesqInsumo.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ResultadosPesqInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ResultadosPesqInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_PesqNomeInsumo,
            this.Coluna_PesqTipoInsumo,
            this.Coluna_ValidadeInsumo,
            this.Coluna_PesqBloqueioInsumo});
            this.Grd_ResultadosPesqInsumo.Location = new System.Drawing.Point(26, 182);
            this.Grd_ResultadosPesqInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.Grd_ResultadosPesqInsumo.MultiSelect = false;
            this.Grd_ResultadosPesqInsumo.Name = "Grd_ResultadosPesqInsumo";
            this.Grd_ResultadosPesqInsumo.ReadOnly = true;
            this.Grd_ResultadosPesqInsumo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.Grd_ResultadosPesqInsumo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_ResultadosPesqInsumo.RowTemplate.Height = 24;
            this.Grd_ResultadosPesqInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_ResultadosPesqInsumo.Size = new System.Drawing.Size(635, 228);
            this.Grd_ResultadosPesqInsumo.TabIndex = 76;
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
            // Coluna_ValidadeInsumo
            // 
            this.Coluna_ValidadeInsumo.HeaderText = "Validade";
            this.Coluna_ValidadeInsumo.Name = "Coluna_ValidadeInsumo";
            this.Coluna_ValidadeInsumo.ReadOnly = true;
            // 
            // Coluna_PesqBloqueioInsumo
            // 
            this.Coluna_PesqBloqueioInsumo.HeaderText = "Bloqueado";
            this.Coluna_PesqBloqueioInsumo.Name = "Coluna_PesqBloqueioInsumo";
            this.Coluna_PesqBloqueioInsumo.ReadOnly = true;
            this.Coluna_PesqBloqueioInsumo.Width = 80;
            // 
            // Frm_PesquisaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.Grd_ResultadosPesqInsumo);
            this.Controls.Add(this.Btn_PesquisarInsumo);
            this.Controls.Add(this.textBox__PesqValidadeInsumo);
            this.Controls.Add(this.Btn_PesqexibirTodosInsumo);
            this.Controls.Add(this.Lbl_PesqValidadeInsumo);
            this.Controls.Add(this.Lbl_PesqTipoInsumo);
            this.Controls.Add(this.Lbl_PesqNomeInsumo);
            this.Controls.Add(this.Txt__PesqTipoInsumo);
            this.Controls.Add(this.Txt_PesqNomeInsumo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PesquisaInsumo";
            this.Text = "Pesquisar Insumo";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ResultadosPesqInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Button Btn_PesquisarInsumo;
        private System.Windows.Forms.TextBox textBox__PesqValidadeInsumo;
        private System.Windows.Forms.Button Btn_PesqexibirTodosInsumo;
        private System.Windows.Forms.Label Lbl_PesqValidadeInsumo;
        private System.Windows.Forms.Label Lbl_PesqTipoInsumo;
        private System.Windows.Forms.Label Lbl_PesqNomeInsumo;
        private System.Windows.Forms.TextBox Txt__PesqTipoInsumo;
        private System.Windows.Forms.TextBox Txt_PesqNomeInsumo;
        private System.Windows.Forms.DataGridView Grd_ResultadosPesqInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqNomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqTipoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ValidadeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_PesqBloqueioInsumo;
    }
}