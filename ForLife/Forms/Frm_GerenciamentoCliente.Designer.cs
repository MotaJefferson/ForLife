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
            this.MaskedTextBox_CpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CelularCliente = new System.Windows.Forms.Label();
            this.maskedTextBox_CelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_EndClienteRua = new System.Windows.Forms.Label();
            this.textBox_EndClienteRua = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteNumero = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteComplemento = new System.Windows.Forms.Label();
            this.textBox_EndClienteComplemento = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteBairro = new System.Windows.Forms.Label();
            this.textBox_EndClienteBairro = new System.Windows.Forms.TextBox();
            this.Lbl_EndClienteCidade = new System.Windows.Forms.Label();
            this.textBox_EndClienteCidade = new System.Windows.Forms.TextBox();
            this.Lbl__EndClienteUF = new System.Windows.Forms.Label();
            this.textBox_EndClienteUF = new System.Windows.Forms.TextBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 59);
            this.panel1.TabIndex = 30;
            // 
            // Lbl_TitleCliente
            // 
            this.Lbl_TitleCliente.AutoSize = true;
            this.Lbl_TitleCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_TitleCliente.Location = new System.Drawing.Point(13, 11);
            this.Lbl_TitleCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TitleCliente.Name = "Lbl_TitleCliente";
            this.Lbl_TitleCliente.Size = new System.Drawing.Size(303, 30);
            this.Lbl_TitleCliente.TabIndex = 0;
            this.Lbl_TitleCliente.Text = "Gerenciamento do Cliente";
            // 
            // Rbtn_ClienteInativo
            // 
            this.Rbtn_ClienteInativo.AutoSize = true;
            this.Rbtn_ClienteInativo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ClienteInativo.Location = new System.Drawing.Point(142, 146);
            this.Rbtn_ClienteInativo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_ClienteInativo.Name = "Rbtn_ClienteInativo";
            this.Rbtn_ClienteInativo.Size = new System.Drawing.Size(73, 24);
            this.Rbtn_ClienteInativo.TabIndex = 37;
            this.Rbtn_ClienteInativo.Text = "Inativo";
            this.Rbtn_ClienteInativo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_ClienteAtivo
            // 
            this.Rbtn_ClienteAtivo.AutoSize = true;
            this.Rbtn_ClienteAtivo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_ClienteAtivo.Location = new System.Drawing.Point(37, 146);
            this.Rbtn_ClienteAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.Rbtn_ClienteAtivo.Name = "Rbtn_ClienteAtivo";
            this.Rbtn_ClienteAtivo.Size = new System.Drawing.Size(62, 24);
            this.Rbtn_ClienteAtivo.TabIndex = 36;
            this.Rbtn_ClienteAtivo.Text = "Ativo";
            this.Rbtn_ClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Lbl_statusCliente);
            this.panel2.Location = new System.Drawing.Point(-1, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 23);
            this.panel2.TabIndex = 35;
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
            // Lbl_statusCliente
            // 
            this.Lbl_statusCliente.AutoSize = true;
            this.Lbl_statusCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_statusCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_statusCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_statusCliente.Location = new System.Drawing.Point(19, 0);
            this.Lbl_statusCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_statusCliente.Name = "Lbl_statusCliente";
            this.Lbl_statusCliente.Size = new System.Drawing.Size(134, 19);
            this.Lbl_statusCliente.TabIndex = 20;
            this.Lbl_statusCliente.Text = "Status do cliente";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(33, 260);
            this.Lbl_NomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(120, 20);
            this.Lbl_NomeCliente.TabIndex = 43;
            this.Lbl_NomeCliente.Text = "Nome Completo";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.AcceptsTab = true;
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(37, 288);
            this.Txt_NomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(445, 25);
            this.Txt_NomeCliente.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.Lbl_InfoCliente);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-4, 206);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 25);
            this.panel4.TabIndex = 41;
            // 
            // Lbl_InfoCliente
            // 
            this.Lbl_InfoCliente.AutoSize = true;
            this.Lbl_InfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.Lbl_InfoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoCliente.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_InfoCliente.Location = new System.Drawing.Point(19, 0);
            this.Lbl_InfoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InfoCliente.Name = "Lbl_InfoCliente";
            this.Lbl_InfoCliente.Size = new System.Drawing.Size(184, 19);
            this.Lbl_InfoCliente.TabIndex = 21;
            this.Lbl_InfoCliente.Text = "Informações do Cliente";
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
            // Lbl_CpfCliente
            // 
            this.Lbl_CpfCliente.AutoSize = true;
            this.Lbl_CpfCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CpfCliente.Location = new System.Drawing.Point(500, 266);
            this.Lbl_CpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CpfCliente.Name = "Lbl_CpfCliente";
            this.Lbl_CpfCliente.Size = new System.Drawing.Size(34, 20);
            this.Lbl_CpfCliente.TabIndex = 45;
            this.Lbl_CpfCliente.Text = "CPF";
            // 
            // MaskedTextBox_CpfCliente
            // 
            this.MaskedTextBox_CpfCliente.Location = new System.Drawing.Point(504, 289);
            this.MaskedTextBox_CpfCliente.Mask = "999.999.999-99";
            this.MaskedTextBox_CpfCliente.Name = "MaskedTextBox_CpfCliente";
            this.MaskedTextBox_CpfCliente.Size = new System.Drawing.Size(111, 20);
            this.MaskedTextBox_CpfCliente.TabIndex = 44;
            // 
            // Lbl_CelularCliente
            // 
            this.Lbl_CelularCliente.AutoSize = true;
            this.Lbl_CelularCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CelularCliente.Location = new System.Drawing.Point(633, 265);
            this.Lbl_CelularCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CelularCliente.Name = "Lbl_CelularCliente";
            this.Lbl_CelularCliente.Size = new System.Drawing.Size(56, 20);
            this.Lbl_CelularCliente.TabIndex = 47;
            this.Lbl_CelularCliente.Text = "Celular";
            // 
            // maskedTextBox_CelularCliente
            // 
            this.maskedTextBox_CelularCliente.Location = new System.Drawing.Point(637, 288);
            this.maskedTextBox_CelularCliente.Mask = "(99) 00000-0000";
            this.maskedTextBox_CelularCliente.Name = "maskedTextBox_CelularCliente";
            this.maskedTextBox_CelularCliente.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_CelularCliente.TabIndex = 46;
            // 
            // Lbl_EndClienteRua
            // 
            this.Lbl_EndClienteRua.AutoSize = true;
            this.Lbl_EndClienteRua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteRua.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteRua.Location = new System.Drawing.Point(23, 19);
            this.Lbl_EndClienteRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_EndClienteRua.Name = "Lbl_EndClienteRua";
            this.Lbl_EndClienteRua.Size = new System.Drawing.Size(104, 20);
            this.Lbl_EndClienteRua.TabIndex = 49;
            this.Lbl_EndClienteRua.Text = "Rua / Avenida";
            // 
            // textBox_EndClienteRua
            // 
            this.textBox_EndClienteRua.AcceptsTab = true;
            this.textBox_EndClienteRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EndClienteRua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndClienteRua.Location = new System.Drawing.Point(27, 47);
            this.textBox_EndClienteRua.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EndClienteRua.Name = "textBox_EndClienteRua";
            this.textBox_EndClienteRua.Size = new System.Drawing.Size(360, 25);
            this.textBox_EndClienteRua.TabIndex = 48;
            // 
            // Lbl_EndClienteNumero
            // 
            this.Lbl_EndClienteNumero.AutoSize = true;
            this.Lbl_EndClienteNumero.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteNumero.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteNumero.Location = new System.Drawing.Point(395, 19);
            this.Lbl_EndClienteNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_EndClienteNumero.Name = "Lbl_EndClienteNumero";
            this.Lbl_EndClienteNumero.Size = new System.Drawing.Size(27, 20);
            this.Lbl_EndClienteNumero.TabIndex = 51;
            this.Lbl_EndClienteNumero.Text = "Nº";
            this.Lbl_EndClienteNumero.Click += new System.EventHandler(this.Lbl_EndClienteNumero_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(399, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 25);
            this.textBox2.TabIndex = 50;
            // 
            // Lbl_EndClienteComplemento
            // 
            this.Lbl_EndClienteComplemento.AutoSize = true;
            this.Lbl_EndClienteComplemento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteComplemento.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteComplemento.Location = new System.Drawing.Point(472, 19);
            this.Lbl_EndClienteComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_EndClienteComplemento.Name = "Lbl_EndClienteComplemento";
            this.Lbl_EndClienteComplemento.Size = new System.Drawing.Size(105, 20);
            this.Lbl_EndClienteComplemento.TabIndex = 53;
            this.Lbl_EndClienteComplemento.Text = "Complemento";
            // 
            // textBox_EndClienteComplemento
            // 
            this.textBox_EndClienteComplemento.AcceptsTab = true;
            this.textBox_EndClienteComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EndClienteComplemento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndClienteComplemento.Location = new System.Drawing.Point(476, 47);
            this.textBox_EndClienteComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EndClienteComplemento.Name = "textBox_EndClienteComplemento";
            this.textBox_EndClienteComplemento.Size = new System.Drawing.Size(208, 25);
            this.textBox_EndClienteComplemento.TabIndex = 52;
            // 
            // Lbl_EndClienteBairro
            // 
            this.Lbl_EndClienteBairro.AutoSize = true;
            this.Lbl_EndClienteBairro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteBairro.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteBairro.Location = new System.Drawing.Point(23, 86);
            this.Lbl_EndClienteBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_EndClienteBairro.Name = "Lbl_EndClienteBairro";
            this.Lbl_EndClienteBairro.Size = new System.Drawing.Size(49, 20);
            this.Lbl_EndClienteBairro.TabIndex = 55;
            this.Lbl_EndClienteBairro.Text = "Bairro";
            // 
            // textBox_EndClienteBairro
            // 
            this.textBox_EndClienteBairro.AcceptsTab = true;
            this.textBox_EndClienteBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EndClienteBairro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndClienteBairro.Location = new System.Drawing.Point(27, 114);
            this.textBox_EndClienteBairro.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EndClienteBairro.Name = "textBox_EndClienteBairro";
            this.textBox_EndClienteBairro.Size = new System.Drawing.Size(283, 25);
            this.textBox_EndClienteBairro.TabIndex = 54;
            // 
            // Lbl_EndClienteCidade
            // 
            this.Lbl_EndClienteCidade.AutoSize = true;
            this.Lbl_EndClienteCidade.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EndClienteCidade.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndClienteCidade.Location = new System.Drawing.Point(322, 86);
            this.Lbl_EndClienteCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_EndClienteCidade.Name = "Lbl_EndClienteCidade";
            this.Lbl_EndClienteCidade.Size = new System.Drawing.Size(56, 20);
            this.Lbl_EndClienteCidade.TabIndex = 57;
            this.Lbl_EndClienteCidade.Text = "Cidade";
            // 
            // textBox_EndClienteCidade
            // 
            this.textBox_EndClienteCidade.AcceptsTab = true;
            this.textBox_EndClienteCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EndClienteCidade.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndClienteCidade.Location = new System.Drawing.Point(326, 114);
            this.textBox_EndClienteCidade.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EndClienteCidade.Name = "textBox_EndClienteCidade";
            this.textBox_EndClienteCidade.Size = new System.Drawing.Size(301, 25);
            this.textBox_EndClienteCidade.TabIndex = 56;
            // 
            // Lbl__EndClienteUF
            // 
            this.Lbl__EndClienteUF.AutoSize = true;
            this.Lbl__EndClienteUF.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl__EndClienteUF.ForeColor = System.Drawing.Color.Black;
            this.Lbl__EndClienteUF.Location = new System.Drawing.Point(638, 86);
            this.Lbl__EndClienteUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl__EndClienteUF.Name = "Lbl__EndClienteUF";
            this.Lbl__EndClienteUF.Size = new System.Drawing.Size(26, 20);
            this.Lbl__EndClienteUF.TabIndex = 59;
            this.Lbl__EndClienteUF.Text = "UF";
            // 
            // textBox_EndClienteUF
            // 
            this.textBox_EndClienteUF.AcceptsTab = true;
            this.textBox_EndClienteUF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EndClienteUF.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EndClienteUF.Location = new System.Drawing.Point(642, 114);
            this.textBox_EndClienteUF.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EndClienteUF.Name = "textBox_EndClienteUF";
            this.textBox_EndClienteUF.Size = new System.Drawing.Size(42, 25);
            this.textBox_EndClienteUF.TabIndex = 58;
            // 
            // groupBox_EnderecoCliente
            // 
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteBairro);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteCidade);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox_EndClienteBairro);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl__EndClienteUF);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox_EndClienteCidade);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteRua);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox_EndClienteUF);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox_EndClienteComplemento);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteComplemento);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox2);
            this.groupBox_EnderecoCliente.Controls.Add(this.Lbl_EndClienteNumero);
            this.groupBox_EnderecoCliente.Controls.Add(this.textBox_EndClienteRua);
            this.groupBox_EnderecoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_EnderecoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(45)))));
            this.groupBox_EnderecoCliente.Location = new System.Drawing.Point(38, 339);
            this.groupBox_EnderecoCliente.Name = "groupBox_EnderecoCliente";
            this.groupBox_EnderecoCliente.Size = new System.Drawing.Size(710, 157);
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
            this.Btn_VoltarCliente.Location = new System.Drawing.Point(664, 529);
            this.Btn_VoltarCliente.Name = "Btn_VoltarCliente";
            this.Btn_VoltarCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_VoltarCliente.TabIndex = 66;
            this.Btn_VoltarCliente.Text = "Voltar";
            this.Btn_VoltarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VoltarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarCliente
            // 
            this.Btn_BuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_BuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarCliente.ImageKey = "Pesquisar.png";
            this.Btn_BuscarCliente.ImageList = this.imgList_Usuario;
            this.Btn_BuscarCliente.Location = new System.Drawing.Point(561, 529);
            this.Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            this.Btn_BuscarCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_BuscarCliente.TabIndex = 65;
            this.Btn_BuscarCliente.Text = "Buscar";
            this.Btn_BuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirCliente
            // 
            this.Btn_ExcluirCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_ExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExcluirCliente.ImageKey = "Apagar.png";
            this.Btn_ExcluirCliente.ImageList = this.imgList_Usuario;
            this.Btn_ExcluirCliente.Location = new System.Drawing.Point(459, 529);
            this.Btn_ExcluirCliente.Name = "Btn_ExcluirCliente";
            this.Btn_ExcluirCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_ExcluirCliente.TabIndex = 64;
            this.Btn_ExcluirCliente.Text = "Excluir";
            this.Btn_ExcluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarCliente
            // 
            this.Btn_SalvarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_SalvarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_SalvarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SalvarCliente.ImageKey = "Salvar.png";
            this.Btn_SalvarCliente.ImageList = this.imgList_Usuario;
            this.Btn_SalvarCliente.Location = new System.Drawing.Point(356, 529);
            this.Btn_SalvarCliente.Name = "Btn_SalvarCliente";
            this.Btn_SalvarCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_SalvarCliente.TabIndex = 63;
            this.Btn_SalvarCliente.Text = "Salvar";
            this.Btn_SalvarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarCliente
            // 
            this.Btn_EditarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_EditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_EditarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarCliente.ImageKey = "Editar.png";
            this.Btn_EditarCliente.ImageList = this.imgList_Usuario;
            this.Btn_EditarCliente.Location = new System.Drawing.Point(251, 529);
            this.Btn_EditarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_EditarCliente.Name = "Btn_EditarCliente";
            this.Btn_EditarCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_EditarCliente.TabIndex = 62;
            this.Btn_EditarCliente.Text = "Editar";
            this.Btn_EditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EditarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_NovoCliente
            // 
            this.Btn_NovoCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_NovoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NovoCliente.ImageKey = "Adicionar.png";
            this.Btn_NovoCliente.ImageList = this.imgList_Usuario;
            this.Btn_NovoCliente.Location = new System.Drawing.Point(144, 529);
            this.Btn_NovoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_NovoCliente.Name = "Btn_NovoCliente";
            this.Btn_NovoCliente.Size = new System.Drawing.Size(97, 28);
            this.Btn_NovoCliente.TabIndex = 61;
            this.Btn_NovoCliente.Text = "Novo";
            this.Btn_NovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovoCliente.UseVisualStyleBackColor = true;
            // 
            // Frm_GerenciamentoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Btn_VoltarCliente);
            this.Controls.Add(this.Btn_BuscarCliente);
            this.Controls.Add(this.Btn_ExcluirCliente);
            this.Controls.Add(this.Btn_SalvarCliente);
            this.Controls.Add(this.Btn_EditarCliente);
            this.Controls.Add(this.Btn_NovoCliente);
            this.Controls.Add(this.Lbl_CelularCliente);
            this.Controls.Add(this.maskedTextBox_CelularCliente);
            this.Controls.Add(this.Lbl_CpfCliente);
            this.Controls.Add(this.MaskedTextBox_CpfCliente);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Rbtn_ClienteInativo);
            this.Controls.Add(this.Rbtn_ClienteAtivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_EnderecoCliente);
            this.Name = "Frm_GerenciamentoCliente";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.Frm_GerenciamentoCliente_Load);
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
        private System.Windows.Forms.MaskedTextBox MaskedTextBox_CpfCliente;
        private System.Windows.Forms.Label Lbl_CelularCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CelularCliente;
        private System.Windows.Forms.Label Lbl_EndClienteRua;
        private System.Windows.Forms.TextBox textBox_EndClienteRua;
        private System.Windows.Forms.Label Lbl_EndClienteNumero;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lbl_EndClienteComplemento;
        private System.Windows.Forms.TextBox textBox_EndClienteComplemento;
        private System.Windows.Forms.Label Lbl_EndClienteBairro;
        private System.Windows.Forms.TextBox textBox_EndClienteBairro;
        private System.Windows.Forms.Label Lbl_EndClienteCidade;
        private System.Windows.Forms.TextBox textBox_EndClienteCidade;
        private System.Windows.Forms.Label Lbl__EndClienteUF;
        private System.Windows.Forms.TextBox textBox_EndClienteUF;
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
