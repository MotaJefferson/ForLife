namespace ForLife.Forms
{
    partial class Frm_GerenciarUsuario_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GerenciarUsuario_UC));
            this.Txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Txt_CodAcesso = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.Rbtn_Agricultor = new System.Windows.Forms.RadioButton();
            this.Rbtn_Gestor = new System.Windows.Forms.RadioButton();
            this.Chk_Bloqueado = new System.Windows.Forms.CheckBox();
            this.Lbl_TipoUsuario = new System.Windows.Forms.Label();
            this.Lbl_InfoUsuarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rbtn_Comercial = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_ValidaUsuario = new System.Windows.Forms.Label();
            this.Lbl_ValidaSenha = new System.Windows.Forms.Label();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_NomeCompleto
            // 
            this.Txt_NomeCompleto.AcceptsTab = true;
            this.Txt_NomeCompleto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCompleto.Location = new System.Drawing.Point(28, 313);
            this.Txt_NomeCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NomeCompleto.Name = "Txt_NomeCompleto";
            this.Txt_NomeCompleto.Size = new System.Drawing.Size(648, 21);
            this.Txt_NomeCompleto.TabIndex = 1;
            
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(24, 285);
            this.Lbl_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(105, 17);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome Completo";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(26, 355);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(53, 17);
            this.Lbl_Usuario.TabIndex = 7;
            this.Lbl_Usuario.Text = "Usuário";

            // 
            // Txt_CodAcesso
            // 
            this.Txt_CodAcesso.AcceptsTab = true;
            this.Txt_CodAcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_CodAcesso.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodAcesso.Location = new System.Drawing.Point(28, 382);
            this.Txt_CodAcesso.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_CodAcesso.Name = "Txt_CodAcesso";
            this.Txt_CodAcesso.Size = new System.Drawing.Size(648, 21);
            this.Txt_CodAcesso.TabIndex = 4;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.AcceptsTab = true;
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Senha.Location = new System.Drawing.Point(30, 451);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '●';
            this.Txt_Senha.Size = new System.Drawing.Size(285, 21);
            this.Txt_Senha.TabIndex = 5;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Senha.Location = new System.Drawing.Point(27, 427);
            this.Lbl_Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(43, 17);
            this.Lbl_Senha.TabIndex = 10;
            this.Lbl_Senha.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirmar Senha";
            // 
            // Txt_ConfirmarSenha
            // 
            this.Txt_ConfirmarSenha.AcceptsTab = true;
            this.Txt_ConfirmarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfirmarSenha.Location = new System.Drawing.Point(350, 451);
            this.Txt_ConfirmarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha";
            this.Txt_ConfirmarSenha.PasswordChar = '●';
            this.Txt_ConfirmarSenha.Size = new System.Drawing.Size(285, 21);
            this.Txt_ConfirmarSenha.TabIndex = 6;
            // 
            // Rbtn_Agricultor
            // 
            this.Rbtn_Agricultor.AutoSize = true;
            this.Rbtn_Agricultor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Agricultor.Location = new System.Drawing.Point(23, 156);
            this.Rbtn_Agricultor.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_Agricultor.Name = "Rbtn_Agricultor";
            this.Rbtn_Agricultor.Size = new System.Drawing.Size(83, 21);
            this.Rbtn_Agricultor.TabIndex = 13;
            this.Rbtn_Agricultor.Text = "Agricultor";
            this.Rbtn_Agricultor.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Gestor
            // 
            this.Rbtn_Gestor.AutoSize = true;
            this.Rbtn_Gestor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Gestor.Location = new System.Drawing.Point(273, 156);
            this.Rbtn_Gestor.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_Gestor.Name = "Rbtn_Gestor";
            this.Rbtn_Gestor.Size = new System.Drawing.Size(65, 21);
            this.Rbtn_Gestor.TabIndex = 15;
            this.Rbtn_Gestor.Text = "Gestor";
            this.Rbtn_Gestor.UseVisualStyleBackColor = true;
            // 
            // Chk_Bloqueado
            // 
            this.Chk_Bloqueado.AutoSize = true;
            this.Chk_Bloqueado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Bloqueado.Location = new System.Drawing.Point(702, 314);
            this.Chk_Bloqueado.Margin = new System.Windows.Forms.Padding(2);
            this.Chk_Bloqueado.Name = "Chk_Bloqueado";
            this.Chk_Bloqueado.Size = new System.Drawing.Size(140, 21);
            this.Chk_Bloqueado.TabIndex = 19;
            this.Chk_Bloqueado.Text = "Usuário Bloqueado";
            this.Chk_Bloqueado.UseVisualStyleBackColor = true;
            // 
            // Lbl_TipoUsuario
            // 
            this.Lbl_TipoUsuario.AutoSize = true;
            this.Lbl_TipoUsuario.BackColor = System.Drawing.Color.OliveDrab;
            this.Lbl_TipoUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoUsuario.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TipoUsuario.Location = new System.Drawing.Point(24, 6);
            this.Lbl_TipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TipoUsuario.Name = "Lbl_TipoUsuario";
            this.Lbl_TipoUsuario.Size = new System.Drawing.Size(98, 19);
            this.Lbl_TipoUsuario.TabIndex = 20;
            this.Lbl_TipoUsuario.Text = "Tipo Usuário";
            // 
            // Lbl_InfoUsuarios
            // 
            this.Lbl_InfoUsuarios.AutoSize = true;
            this.Lbl_InfoUsuarios.BackColor = System.Drawing.Color.OliveDrab;
            this.Lbl_InfoUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoUsuarios.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoUsuarios.Location = new System.Drawing.Point(19, 6);
            this.Lbl_InfoUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InfoUsuarios.Name = "Lbl_InfoUsuarios";
            this.Lbl_InfoUsuarios.Size = new System.Drawing.Size(177, 19);
            this.Lbl_InfoUsuarios.TabIndex = 21;
            this.Lbl_InfoUsuarios.Text = "Informações do Usuário";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.Lbl_TitleUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 65);
            this.panel1.TabIndex = 25;
            // 
            // Lbl_TitleUsuario
            // 
            this.Lbl_TitleUsuario.AutoSize = true;
            this.Lbl_TitleUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleUsuario.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleUsuario.Location = new System.Drawing.Point(17, 11);
            this.Lbl_TitleUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleUsuario.Name = "Lbl_TitleUsuario";
            this.Lbl_TitleUsuario.Size = new System.Drawing.Size(310, 30);
            this.Lbl_TitleUsuario.TabIndex = 0;
            this.Lbl_TitleUsuario.Text = "Gerenciamento do Usuário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_TipoUsuario);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 34);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Location = new System.Drawing.Point(7, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 27);
            this.panel3.TabIndex = 28;
            // 
            // Rbtn_Comercial
            // 
            this.Rbtn_Comercial.AutoSize = true;
            this.Rbtn_Comercial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Comercial.Location = new System.Drawing.Point(142, 156);
            this.Rbtn_Comercial.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_Comercial.Name = "Rbtn_Comercial";
            this.Rbtn_Comercial.Size = new System.Drawing.Size(84, 21);
            this.Rbtn_Comercial.TabIndex = 14;
            this.Rbtn_Comercial.Text = "Comercial";
            this.Rbtn_Comercial.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.OliveDrab;
            this.panel4.Controls.Add(this.Lbl_InfoUsuarios);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 215);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 34);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OliveDrab;
            this.panel5.Location = new System.Drawing.Point(7, 41);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 27);
            this.panel5.TabIndex = 28;
            // 
            // Lbl_ValidaUsuario
            // 
            this.Lbl_ValidaUsuario.AutoSize = true;
            this.Lbl_ValidaUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValidaUsuario.Location = new System.Drawing.Point(698, 382);
            this.Lbl_ValidaUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ValidaUsuario.Name = "Lbl_ValidaUsuario";
            this.Lbl_ValidaUsuario.Size = new System.Drawing.Size(0, 17);
            this.Lbl_ValidaUsuario.TabIndex = 30;
            // 
            // Lbl_ValidaSenha
            // 
            this.Lbl_ValidaSenha.AutoSize = true;
            this.Lbl_ValidaSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValidaSenha.Location = new System.Drawing.Point(698, 457);
            this.Lbl_ValidaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ValidaSenha.Name = "Lbl_ValidaSenha";
            this.Lbl_ValidaSenha.Size = new System.Drawing.Size(0, 19);
            this.Lbl_ValidaSenha.TabIndex = 31;
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Image = global::ForLife.Properties.Resources.Visível;
            this.Btn_VerSenha.Location = new System.Drawing.Point(651, 450);
            this.Btn_VerSenha.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(25, 25);
            this.Btn_VerSenha.TabIndex = 32;
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Novo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Novo.ImageKey = "Adicionar.png";
            this.Btn_Novo.ImageList = this.imgList_Usuario;
            this.Btn_Novo.Location = new System.Drawing.Point(119, 527);
            this.Btn_Novo.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(104, 38);
            this.Btn_Novo.TabIndex = 33;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // imgList_Usuario
            // 
            this.imgList_Usuario.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Usuario.ImageStream")));
            this.imgList_Usuario.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Usuario.Images.SetKeyName(0, "Adicionar.png");
            this.imgList_Usuario.Images.SetKeyName(1, "Apagar.png");
            this.imgList_Usuario.Images.SetKeyName(2, "Editar.png");
            this.imgList_Usuario.Images.SetKeyName(3, "Excluir.png");
            this.imgList_Usuario.Images.SetKeyName(4, "Pesquisar.png");
            this.imgList_Usuario.Images.SetKeyName(5, "Salvar.png");
            this.imgList_Usuario.Images.SetKeyName(6, "Voltar.png");
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Editar.ImageKey = "Editar.png";
            this.Btn_Editar.ImageList = this.imgList_Usuario;
            this.Btn_Editar.Location = new System.Drawing.Point(233, 527);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Editar.TabIndex = 34;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salvar.ImageKey = "Salvar.png";
            this.Btn_Salvar.ImageList = this.imgList_Usuario;
            this.Btn_Salvar.Location = new System.Drawing.Point(345, 527);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Salvar.TabIndex = 35;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Excluir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Excluir.ImageKey = "Apagar.png";
            this.Btn_Excluir.ImageList = this.imgList_Usuario;
            this.Btn_Excluir.Location = new System.Drawing.Point(455, 527);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(104, 38);
            this.Btn_Excluir.TabIndex = 36;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.ImageKey = "Pesquisar.png";
            this.Btn_Buscar.ImageList = this.imgList_Usuario;
            this.Btn_Buscar.Location = new System.Drawing.Point(565, 527);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Buscar.TabIndex = 37;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Voltar.ImageKey = "Voltar.png";
            this.Btn_Voltar.ImageList = this.imgList_Usuario;
            this.Btn_Voltar.Location = new System.Drawing.Point(675, 527);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Voltar.TabIndex = 38;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Frm_GerenciarUsuario_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Lbl_ValidaSenha);
            this.Controls.Add(this.Lbl_ValidaUsuario);
            this.Controls.Add(this.Rbtn_Gestor);
            this.Controls.Add(this.Rbtn_Agricultor);
            this.Controls.Add(this.Rbtn_Comercial);
            this.Controls.Add(this.Chk_Bloqueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_ConfirmarSenha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_CodAcesso);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_NomeCompleto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_GerenciarUsuario_UC";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_NomeCompleto;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Txt_CodAcesso;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ConfirmarSenha;
        private System.Windows.Forms.RadioButton Rbtn_Agricultor;
        private System.Windows.Forms.RadioButton Rbtn_Gestor;
        private System.Windows.Forms.CheckBox Chk_Bloqueado;
        private System.Windows.Forms.Label Lbl_TipoUsuario;
        private System.Windows.Forms.Label Lbl_InfoUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Rbtn_Comercial;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_ValidaUsuario;
        private System.Windows.Forms.Label Lbl_ValidaSenha;
        private System.Windows.Forms.Button Btn_VerSenha;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}
