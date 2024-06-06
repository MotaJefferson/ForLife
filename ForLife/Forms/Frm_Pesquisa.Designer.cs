namespace ForLife.Forms
{
    partial class Frm_Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pesquisa));
            this.Grd_Resultados = new System.Windows.Forms.DataGridView();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.Cmb_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Resultados
            // 
            this.Grd_Resultados.AllowUserToAddRows = false;
            this.Grd_Resultados.AllowUserToDeleteRows = false;
            this.Grd_Resultados.AllowUserToOrderColumns = true;
            this.Grd_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuário,
            this.Nome,
            this.TipoCadastro,
            this.Bloqueado});
            this.Grd_Resultados.Location = new System.Drawing.Point(12, 205);
            this.Grd_Resultados.MultiSelect = false;
            this.Grd_Resultados.Name = "Grd_Resultados";
            this.Grd_Resultados.ReadOnly = true;
            this.Grd_Resultados.RowHeadersWidth = 51;
            this.Grd_Resultados.RowTemplate.Height = 24;
            this.Grd_Resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_Resultados.Size = new System.Drawing.Size(825, 313);
            this.Grd_Resultados.TabIndex = 1;
            this.Grd_Resultados.DoubleClick += new System.EventHandler(this.Grd_Resultados_DoubleClick);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.AcceptsTab = true;
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(82, 58);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(302, 25);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.AcceptsTab = true;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(82, 115);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(302, 25);
            this.Txt_Usuario.TabIndex = 3;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_Nome.Location = new System.Drawing.Point(22, 60);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 20);
            this.Lbl_Nome.TabIndex = 4;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_Usuario.Location = new System.Drawing.Point(12, 117);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(64, 20);
            this.Lbl_Usuario.TabIndex = 5;
            this.Lbl_Usuario.Text = "Usuário";
            // 
            // Lbl_TipoUsuario
            // 
            this.Lbl_TipoUsuario.AutoSize = true;
            this.Lbl_TipoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Lbl_TipoUsuario.Location = new System.Drawing.Point(455, 60);
            this.Lbl_TipoUsuario.Name = "Lbl_TipoUsuario";
            this.Lbl_TipoUsuario.Size = new System.Drawing.Size(101, 20);
            this.Lbl_TipoUsuario.TabIndex = 6;
            this.Lbl_TipoUsuario.Text = "Tipo Usuário";
            // 
            // Cmb_TipoUsuario
            // 
            this.Cmb_TipoUsuario.FormattingEnabled = true;
            this.Cmb_TipoUsuario.Location = new System.Drawing.Point(581, 59);
            this.Cmb_TipoUsuario.Name = "Cmb_TipoUsuario";
            this.Cmb_TipoUsuario.Size = new System.Drawing.Size(235, 24);
            this.Cmb_TipoUsuario.TabIndex = 7;
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "Pesquisar.png");
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Btn_Pesquisar.ImageKey = "Pesquisar.png";
            this.Btn_Pesquisar.ImageList = this.imageIcons;
            this.Btn_Pesquisar.Location = new System.Drawing.Point(459, 110);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(118, 34);
            this.Btn_Pesquisar.TabIndex = 39;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Usuário
            // 
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.MinimumWidth = 6;
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            this.Usuário.Width = 150;
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
            // 
            // Frm_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Cmb_TipoUsuario);
            this.Controls.Add(this.Lbl_TipoUsuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Grd_Resultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grd_Resultados;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_TipoUsuario;
        private System.Windows.Forms.ComboBox Cmb_TipoUsuario;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloqueado;
    }
}