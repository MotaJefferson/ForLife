namespace ForLife.Forms
{
    partial class Frm_PesquisaInsumoOrigem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisaInsumoOrigem));
            this.Grd_Resultados = new System.Windows.Forms.DataGridView();
            this.NomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_NomeInsumo = new System.Windows.Forms.TextBox();
            this.Lbl_NomeInsumo = new System.Windows.Forms.Label();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Resultados
            // 
            this.Grd_Resultados.AllowUserToAddRows = false;
            this.Grd_Resultados.AllowUserToDeleteRows = false;
            this.Grd_Resultados.AllowUserToOrderColumns = true;
            this.Grd_Resultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grd_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeInsumo,
            this.tipoInsumo});
            this.Grd_Resultados.Location = new System.Drawing.Point(12, 117);
            this.Grd_Resultados.Name = "Grd_Resultados";
            this.Grd_Resultados.ReadOnly = true;
            this.Grd_Resultados.RowHeadersWidth = 51;
            this.Grd_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_Resultados.Size = new System.Drawing.Size(613, 302);
            this.Grd_Resultados.TabIndex = 0;
            this.Grd_Resultados.DoubleClick += new System.EventHandler(this.Grd_Resultados_DoubleClick);
            // 
            // NomeInsumo
            // 
            this.NomeInsumo.HeaderText = "Insumo";
            this.NomeInsumo.MinimumWidth = 6;
            this.NomeInsumo.Name = "NomeInsumo";
            this.NomeInsumo.ReadOnly = true;
            this.NomeInsumo.Width = 300;
            // 
            // tipoInsumo
            // 
            this.tipoInsumo.HeaderText = "Tipo";
            this.tipoInsumo.MinimumWidth = 6;
            this.tipoInsumo.Name = "tipoInsumo";
            this.tipoInsumo.ReadOnly = true;
            this.tipoInsumo.Width = 125;
            // 
            // Txt_NomeInsumo
            // 
            this.Txt_NomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeInsumo.Location = new System.Drawing.Point(15, 60);
            this.Txt_NomeInsumo.Name = "Txt_NomeInsumo";
            this.Txt_NomeInsumo.Size = new System.Drawing.Size(474, 21);
            this.Txt_NomeInsumo.TabIndex = 1;
            // 
            // Lbl_NomeInsumo
            // 
            this.Lbl_NomeInsumo.AutoSize = true;
            this.Lbl_NomeInsumo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_NomeInsumo.Location = new System.Drawing.Point(11, 28);
            this.Lbl_NomeInsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeInsumo.Name = "Lbl_NomeInsumo";
            this.Lbl_NomeInsumo.Size = new System.Drawing.Size(111, 17);
            this.Lbl_NomeInsumo.TabIndex = 7;
            this.Lbl_NomeInsumo.Text = "Nome do Insumo";
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
            this.Btn_Pesquisar.Location = new System.Drawing.Point(520, 55);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Pesquisar.Size = new System.Drawing.Size(104, 25);
            this.Btn_Pesquisar.TabIndex = 8;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Frm_PesquisaInsumoOrigem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Lbl_NomeInsumo);
            this.Controls.Add(this.Txt_NomeInsumo);
            this.Controls.Add(this.Grd_Resultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PesquisaInsumoOrigem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa - Insumo de Origem";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoInsumo;
        private System.Windows.Forms.TextBox Txt_NomeInsumo;
        private System.Windows.Forms.Label Lbl_NomeInsumo;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.ImageList imageIcons;
    }
}