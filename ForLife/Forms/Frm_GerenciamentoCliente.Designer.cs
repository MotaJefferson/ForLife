namespace ForLife.Forms
{
    partial class Frm_GerenciamentoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GerenciamentoCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TitleCliente = new System.Windows.Forms.Label();
            this.Rbtn_ClienteInativo = new System.Windows.Forms.RadioButton();
            this.Rbtn_ClienteAtivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_statusCliente = new System.Windows.Forms.Label();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_InfoCliente = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_CpfCliente = new System.Windows.Forms.Label();
            this.Txt_CpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CelularCliente = new System.Windows.Forms.Label();
            this.Txt_CelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_EndClienteRua = new System.Windows.Forms.Label();
            this.Txt_Logadouro = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteNumero = new System.Windows.Forms.Label();
            this.Txt_NumEndereco = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteComplemento = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteBairro = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteCidade = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl__EndClienteUF = new System.Windows.Forms.Label();
            this.Txt_UF = new System.Windows.Forms.TextBox();
            this.groupBox_EnderecoCliente = new System.Windows.Forms.GroupBox();
            this.imgList_Usuario = new System.Windows.Forms.ImageList(this.components);
            this.Btn_VoltarCliente = new System.Windows.Forms.Button();
            this.Btn_BuscarCliente = new System.Windows.Forms.Button();
            this.Btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.Btn_SalvarCliente = new System.Windows.Forms.Button();
            this.Btn_EditarCliente = new System.Windows.Forms.Button();
            this.Btn_NovoCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox_EnderecoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Lbl_TitleCliente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 73);
            this.panel1.TabIndex = 30;
            // 
            // Lbl_TitleCliente
            // 
            this.Lbl_TitleCliente.AutoSize = true;
            this.Lbl_TitleCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleCliente.Location = new System.Drawing.Point(17, 14);
            this.Lbl_TitleCliente.Name = "Lbl_TitleCliente";
            this.Lbl_TitleCliente.Size = new System.Drawing.Size(380, 37);
            this.Lbl_TitleCliente.TabIndex = 0;
            this.Lbl_TitleCliente.Text = "Gerenciamento do Cliente";
            // 
            // Rbtn_ClienteInativo
            // 
            this.Rbtn_ClienteInativo.AutoSize = true;
            this.Rbtn_ClienteInativo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ClienteInativo.Location = new System.Drawing.Point(189, 180);
            this.Rbtn_ClienteInativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_ClienteInativo.Name = "Rbtn_ClienteInativo";
            this.Rbtn_ClienteInativo.Size = new System.Drawing.Size(86, 27);
            this.Rbtn_ClienteInativo.TabIndex = 37;
            this.Rbtn_ClienteInativo.Text = "Inativo";
            this.Rbtn_ClienteInativo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_ClienteAtivo
            // 
            this.Rbtn_ClienteAtivo.AutoSize = true;
            this.Rbtn_ClienteAtivo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ClienteAtivo.Location = new System.Drawing.Point(49, 180);
            this.Rbtn_ClienteAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rbtn_ClienteAtivo.Name = "Rbtn_ClienteAtivo";
            this.Rbtn_ClienteAtivo.Size = new System.Drawing.Size(74, 27);
            this.Rbtn_ClienteAtivo.TabIndex = 36;
            this.Rbtn_ClienteAtivo.Text = "Ativo";
            this.Rbtn_ClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_statusCliente);
            this.panel2.Location = new System.Drawing.Point(-1, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 28);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Location = new System.Drawing.Point(9, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 33);
            this.panel3.TabIndex = 28;
            // 
            // Lbl_statusCliente
            // 
            this.Lbl_statusCliente.AutoSize = true;
            this.Lbl_statusCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_statusCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_statusCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_statusCliente.Location = new System.Drawing.Point(25, 0);
            this.Lbl_statusCliente.Name = "Lbl_statusCliente";
            this.Lbl_statusCliente.Size = new System.Drawing.Size(160, 25);
            this.Lbl_statusCliente.TabIndex = 20;
            this.Lbl_statusCliente.Text = "Status do cliente";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(44, 320);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(147, 23);
            this.Lbl_NomeCliente.TabIndex = 43;
            this.Lbl_NomeCliente.Text = "Nome Completo";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.AcceptsTab = true;
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(49, 354);
            this.Txt_NomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(592, 30);
            this.Txt_NomeCliente.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.Lbl_InfoCliente);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-5, 254);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1440, 31);
            this.panel4.TabIndex = 41;
            // 
            // Lbl_InfoCliente
            // 
            this.Lbl_InfoCliente.AutoSize = true;
            this.Lbl_InfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoCliente.Location = new System.Drawing.Point(25, 0);
            this.Lbl_InfoCliente.Name = "Lbl_InfoCliente";
            this.Lbl_InfoCliente.Size = new System.Drawing.Size(220, 25);
            this.Lbl_InfoCliente.TabIndex = 21;
            this.Lbl_InfoCliente.Text = "Informações do Cliente";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OliveDrab;
            this.panel5.Location = new System.Drawing.Point(9, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 33);
            this.panel5.TabIndex = 28;
            // 
            // Lbl_CpfCliente
            // 
            this.Lbl_CpfCliente.AutoSize = true;
            this.Lbl_CpfCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CpfCliente.Location = new System.Drawing.Point(667, 327);
            this.Lbl_CpfCliente.Name = "Lbl_CpfCliente";
            this.Lbl_CpfCliente.Size = new System.Drawing.Size(40, 23);
            this.Lbl_CpfCliente.TabIndex = 45;
            this.Lbl_CpfCliente.Text = "CPF";
            // 
            // Txt_CpfCliente
            // 
            this.Txt_CpfCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.Txt_CpfCliente.Location = new System.Drawing.Point(672, 356);
            this.Txt_CpfCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CpfCliente.Mask = "999,999,999-99";
            this.Txt_CpfCliente.Name = "Txt_CpfCliente";
            this.Txt_CpfCliente.Size = new System.Drawing.Size(160, 30);
            this.Txt_CpfCliente.TabIndex = 44;
            // 
            // Lbl_CelularCliente
            // 
            this.Lbl_CelularCliente.AutoSize = true;
            this.Lbl_CelularCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CelularCliente.Location = new System.Drawing.Point(844, 326);
            this.Lbl_CelularCliente.Name = "Lbl_CelularCliente";
            this.Lbl_CelularCliente.Size = new System.Drawing.Size(66, 23);
            this.Lbl_CelularCliente.TabIndex = 47;
            this.Lbl_CelularCliente.Text = "Celular";
            // 
            // Txt_CelularCliente
            // 
            this.Txt_CelularCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.Txt_CelularCliente.Location = new System.Drawing.Point(849, 354);
            this.Txt_CelularCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CelularCliente.Mask = "(99)00000-0000";
            this.Txt_CelularCliente.Name = "Txt_CelularCliente";
            this.Txt_CelularCliente.Size = new System.Drawing.Size(165, 30);
            this.Txt_CelularCliente.TabIndex = 46;
            // 
            // Lbl_EndClienteRua
            // 
            this.Lbl_EndClienteRua.AutoSize = true;
            this.Lbl_EndClienteRua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteRua.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteRua.Location = new System.Drawing.Point(31, 23);
            this.Lbl_EndClienteRua.Name = "Lbl_EndClienteRua";
            this.Lbl_EndClienteRua.Size = new System.Drawing.Size(123, 23);
            this.Lbl_EndClienteRua.TabIndex = 49;
            this.Lbl_EndClienteRua.Text = "Rua / Avenida";
            // 
            // Txt_Logadouro
            // 
            this.Txt_Logadouro.AcceptsTab = true;
            this.Txt_Logadouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logadouro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Logadouro.Location = new System.Drawing.Point(36, 58);
            this.Txt_Logadouro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Logadouro.Name = "Txt_Logadouro";
            this.Txt_Logadouro.Size = new System.Drawing.Size(479, 30);
            this.Txt_Logadouro.TabIndex = 48;
            // 
            // Lbl_EndClienteNumero
            // 
            this.Lbl_EndClienteNumero.AutoSize = true;
            this.Lbl_EndClienteNumero.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteNumero.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteNumero.Location = new System.Drawing.Point(527, 23);
            this.Lbl_EndClienteNumero.Name = "Lbl_EndClienteNumero";
            this.Lbl_EndClienteNumero.Size = new System.Drawing.Size(32, 23);
            this.Lbl_EndClienteNumero.TabIndex = 51;
            this.Lbl_EndClienteNumero.Text = "Nº";
            // 
            // Txt_NumEndereco
            // 
            this.Txt_NumEndereco.AcceptsTab = true;
            this.Txt_NumEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NumEndereco.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumEndereco.Location = new System.Drawing.Point(532, 58);
            this.Txt_NumEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NumEndereco.Name = "Txt_NumEndereco";
            this.Txt_NumEndereco.Size = new System.Drawing.Size(76, 30);
            this.Txt_NumEndereco.TabIndex = 50;
            // 
            // Lbl_EndClienteComplemento
            // 
            this.Lbl_EndClienteComplemento.AutoSize = true;
            this.Lbl_EndClienteComplemento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteComplemento.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteComplemento.Location = new System.Drawing.Point(629, 23);
            this.Lbl_EndClienteComplemento.Name = "Lbl_EndClienteComplemento";
            this.Lbl_EndClienteComplemento.Size = new System.Drawing.Size(127, 23);
            this.Lbl_EndClienteComplemento.TabIndex = 53;
            this.Lbl_EndClienteComplemento.Text = "Complemento";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.AcceptsTab = true;
            this.Txt_Complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Complemento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Complemento.Location = new System.Drawing.Point(635, 58);
            this.Txt_Complemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(276, 30);
            this.Txt_Complemento.TabIndex = 52;
            // 
            // Lbl_EndClienteBairro
            // 
            this.Lbl_EndClienteBairro.AutoSize = true;
            this.Lbl_EndClienteBairro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteBairro.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteBairro.Location = new System.Drawing.Point(31, 106);
            this.Lbl_EndClienteBairro.Name = "Lbl_EndClienteBairro";
            this.Lbl_EndClienteBairro.Size = new System.Drawing.Size(58, 23);
            this.Lbl_EndClienteBairro.TabIndex = 55;
            this.Lbl_EndClienteBairro.Text = "Bairro";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.AcceptsTab = true;
            this.Txt_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Bairro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Bairro.Location = new System.Drawing.Point(36, 140);
            this.Txt_Bairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(376, 30);
            this.Txt_Bairro.TabIndex = 54;
            // 
            // Lbl_EndClienteCidade
            // 
            this.Lbl_EndClienteCidade.AutoSize = true;
            this.Lbl_EndClienteCidade.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteCidade.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteCidade.Location = new System.Drawing.Point(429, 106);
            this.Lbl_EndClienteCidade.Name = "Lbl_EndClienteCidade";
            this.Lbl_EndClienteCidade.Size = new System.Drawing.Size(67, 23);
            this.Lbl_EndClienteCidade.TabIndex = 57;
            this.Lbl_EndClienteCidade.Text = "Cidade";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.AcceptsTab = true;
            this.Txt_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cidade.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cidade.Location = new System.Drawing.Point(435, 140);
            this.Txt_Cidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(400, 30);
            this.Txt_Cidade.TabIndex = 56;
            // 
            // Lbl__EndClienteUF
            // 
            this.Lbl__EndClienteUF.AutoSize = true;
            this.Lbl__EndClienteUF.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl__EndClienteUF.ForeColor = System.Drawing.Color.Black;
            this.Lbl__EndClienteUF.Location = new System.Drawing.Point(851, 106);
            this.Lbl__EndClienteUF.Name = "Lbl__EndClienteUF";
            this.Lbl__EndClienteUF.Size = new System.Drawing.Size(32, 23);
            this.Lbl__EndClienteUF.TabIndex = 59;
            this.Lbl__EndClienteUF.Text = "UF";
            // 
            // Txt_UF
            // 
            this.Txt_UF.AcceptsTab = true;
            this.Txt_UF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UF.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UF.Location = new System.Drawing.Point(856, 140);
            this.Txt_UF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_UF.Name = "Txt_UF";
            this.Txt_UF.Size = new System.Drawing.Size(55, 30);
            this.Txt_UF.TabIndex = 58;
            // 
            // groupBox_EnderecoCliente
            // 
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteBairro);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteCidade);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_Bairro);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl__EndClienteUF);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_Cidade);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteRua);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_UF);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_Complemento);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteComplemento);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_NumEndereco);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteNumero);
            this.groupBox_EnderecoCliente.Controls.Add(this.Txt_Logadouro);
            this.groupBox_EnderecoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_EnderecoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.groupBox_EnderecoCliente.Location = new System.Drawing.Point(51, 417);
            this.groupBox_EnderecoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_EnderecoCliente.Name = "groupBox_EnderecoCliente";
            this.groupBox_EnderecoCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_EnderecoCliente.Size = new System.Drawing.Size(947, 193);
            this.groupBox_EnderecoCliente.TabIndex = 60;
            this.groupBox_EnderecoCliente.TabStop = false;
            this.groupBox_EnderecoCliente.Text = "Endereço";
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
            // Btn_VoltarCliente
            // 
            this.Btn_VoltarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_VoltarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_VoltarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_VoltarCliente.ImageKey = "Voltar.png";
            this.Btn_VoltarCliente.ImageList = this.imgList_Usuario;
            this.Btn_VoltarCliente.Location = new System.Drawing.Point(885, 676);
            this.Btn_VoltarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_VoltarCliente.Name = "Btn_VoltarCliente";
            this.Btn_VoltarCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_VoltarCliente.TabIndex = 66;
            this.Btn_VoltarCliente.Text = "Voltar";
            this.Btn_VoltarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarCliente.UseVisualStyleBackColor = true;
            this.Btn_VoltarCliente.Click += new System.EventHandler(this.Btn_VoltarCliente_Click);
            // 
            // Btn_BuscarCliente
            // 
            this.Btn_BuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarCliente.ImageKey = "Pesquisar.png";
            this.Btn_BuscarCliente.ImageList = this.imgList_Usuario;
            this.Btn_BuscarCliente.Location = new System.Drawing.Point(748, 676);
            this.Btn_BuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            this.Btn_BuscarCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_BuscarCliente.TabIndex = 65;
            this.Btn_BuscarCliente.Text = "Buscar";
            this.Btn_BuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.Btn_BuscarCliente.Click += new System.EventHandler(this.Btn_BuscarCliente_Click);
            // 
            // Btn_ExcluirCliente
            // 
            this.Btn_ExcluirCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirCliente.ImageKey = "Apagar.png";
            this.Btn_ExcluirCliente.ImageList = this.imgList_Usuario;
            this.Btn_ExcluirCliente.Location = new System.Drawing.Point(612, 676);
            this.Btn_ExcluirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExcluirCliente.Name = "Btn_ExcluirCliente";
            this.Btn_ExcluirCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_ExcluirCliente.TabIndex = 64;
            this.Btn_ExcluirCliente.Text = "Excluir";
            this.Btn_ExcluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirCliente.UseVisualStyleBackColor = true;
            this.Btn_ExcluirCliente.Click += new System.EventHandler(this.Btn_ExcluirCliente_Click);
            // 
            // Btn_SalvarCliente
            // 
            this.Btn_SalvarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarCliente.ImageKey = "Salvar.png";
            this.Btn_SalvarCliente.ImageList = this.imgList_Usuario;
            this.Btn_SalvarCliente.Location = new System.Drawing.Point(475, 676);
            this.Btn_SalvarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SalvarCliente.Name = "Btn_SalvarCliente";
            this.Btn_SalvarCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_SalvarCliente.TabIndex = 63;
            this.Btn_SalvarCliente.Text = "Salvar";
            this.Btn_SalvarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarCliente.UseVisualStyleBackColor = true;
            this.Btn_SalvarCliente.Click += new System.EventHandler(this.Btn_SalvarCliente_Click);
            // 
            // Btn_EditarCliente
            // 
            this.Btn_EditarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarCliente.ImageKey = "Editar.png";
            this.Btn_EditarCliente.ImageList = this.imgList_Usuario;
            this.Btn_EditarCliente.Location = new System.Drawing.Point(335, 676);
            this.Btn_EditarCliente.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_EditarCliente.Name = "Btn_EditarCliente";
            this.Btn_EditarCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_EditarCliente.TabIndex = 62;
            this.Btn_EditarCliente.Text = "Editar";
            this.Btn_EditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarCliente.UseVisualStyleBackColor = true;
            this.Btn_EditarCliente.Click += new System.EventHandler(this.Btn_EditarCliente_Click);
            // 
            // Btn_NovoCliente
            // 
            this.Btn_NovoCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovoCliente.ImageKey = "Adicionar.png";
            this.Btn_NovoCliente.ImageList = this.imgList_Usuario;
            this.Btn_NovoCliente.Location = new System.Drawing.Point(192, 676);
            this.Btn_NovoCliente.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_NovoCliente.Name = "Btn_NovoCliente";
            this.Btn_NovoCliente.Size = new System.Drawing.Size(129, 34);
            this.Btn_NovoCliente.TabIndex = 61;
            this.Btn_NovoCliente.Text = "Novo";
            this.Btn_NovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovoCliente.UseVisualStyleBackColor = true;
            this.Btn_NovoCliente.Click += new System.EventHandler(this.Btn_NovoCliente_Click);
            // 
            // Frm_GerenciamentoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_VoltarCliente);
            this.Controls.Add(this.Btn_BuscarCliente);
            this.Controls.Add(this.Btn_ExcluirCliente);
            this.Controls.Add(this.Btn_SalvarCliente);
            this.Controls.Add(this.Btn_EditarCliente);
            this.Controls.Add(this.Btn_NovoCliente);
            this.Controls.Add(this.Lbl_CelularCliente);
            this.Controls.Add(this.Txt_CelularCliente);
            this.Controls.Add(this.Lbl_CpfCliente);
            this.Controls.Add(this.Txt_CpfCliente);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Rbtn_ClienteInativo);
            this.Controls.Add(this.Rbtn_ClienteAtivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_EnderecoCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GerenciamentoCliente";
            this.Size = new System.Drawing.Size(1200, 738);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox_EnderecoCliente.ResumeLayout(false);
            this.groupBox_EnderecoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TitleCliente;
        private System.Windows.Forms.RadioButton Rbtn_ClienteInativo;
        private System.Windows.Forms.RadioButton Rbtn_ClienteAtivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_statusCliente;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_InfoCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_CpfCliente;
        private System.Windows.Forms.MaskedTextBox Txt_CpfCliente;
        private System.Windows.Forms.Label Lbl_CelularCliente;
        private System.Windows.Forms.MaskedTextBox Txt_CelularCliente;
        private System.Windows.Forms.Label Lbl_EndClienteRua;
        private System.Windows.Forms.TextBox Txt_Logadouro;
        private System.Windows.Forms.Label Lbl_EndClienteNumero;
        private System.Windows.Forms.TextBox Txt_NumEndereco;
        private System.Windows.Forms.Label Lbl_EndClienteComplemento;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_EndClienteBairro;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_EndClienteCidade;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl__EndClienteUF;
        private System.Windows.Forms.TextBox Txt_UF;
        private System.Windows.Forms.GroupBox groupBox_EnderecoCliente;
        private System.Windows.Forms.ImageList imgList_Usuario;
        private System.Windows.Forms.Button Btn_VoltarCliente;
        private System.Windows.Forms.Button Btn_BuscarCliente;
        private System.Windows.Forms.Button Btn_ExcluirCliente;
        private System.Windows.Forms.Button Btn_SalvarCliente;
        private System.Windows.Forms.Button Btn_EditarCliente;
        private System.Windows.Forms.Button Btn_NovoCliente;
    }
}
