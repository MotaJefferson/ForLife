using System.Windows.Forms;

namespace ForLife.Forms

{


    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.btn_LoginDireto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(52, 246);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(72, 23);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Usuário";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Senha.Location = new System.Drawing.Point(52, 335);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(59, 23);
            this.Lbl_Senha.TabIndex = 2;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Login
            // 
            this.Txt_Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Login.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Login.Location = new System.Drawing.Point(55, 272);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(298, 30);
            this.Txt_Login.TabIndex = 3;
            // 
            // Txt_senha
            // 
            this.Txt_senha.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_senha.Location = new System.Drawing.Point(55, 361);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '●';
            this.Txt_senha.Size = new System.Drawing.Size(298, 30);
            this.Txt_senha.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(153, 433);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(98, 34);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Iniciar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Pic_Login
            // 
            this.Pic_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pic_Login.Image = global::ForLife.Properties.Resources.Logo_ForLife_SemFundo;
            this.Pic_Login.Location = new System.Drawing.Point(30, 30);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(349, 189);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Login.TabIndex = 0;
            this.Pic_Login.TabStop = false;
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.Btn_VerSenha.FlatAppearance.BorderSize = 0;
            this.Btn_VerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerSenha.Image = global::ForLife.Properties.Resources.Visível;
            this.Btn_VerSenha.Location = new System.Drawing.Point(359, 360);
            this.Btn_VerSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(33, 31);
            this.Btn_VerSenha.TabIndex = 33;
            this.Btn_VerSenha.TabStop = false;
            this.Btn_VerSenha.UseVisualStyleBackColor = false;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // btn_LoginDireto
            // 
            this.btn_LoginDireto.Location = new System.Drawing.Point(303, 488);
            this.btn_LoginDireto.Name = "btn_LoginDireto";
            this.btn_LoginDireto.Size = new System.Drawing.Size(101, 35);
            this.btn_LoginDireto.TabIndex = 34;
            this.btn_LoginDireto.Text = "sem login";
            this.btn_LoginDireto.UseVisualStyleBackColor = true;
            this.btn_LoginDireto.Click += new System.EventHandler(this.btn_LoginDireto_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(416, 535);
            this.Controls.Add(this.btn_LoginDireto);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_VerSenha;
        private Button btn_LoginDireto;
    }
}