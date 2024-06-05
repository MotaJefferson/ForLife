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
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Lnk_RecoveryPassword = new System.Windows.Forms.LinkLabel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Login
            // 
            this.Pic_Login.Location = new System.Drawing.Point(95, 12);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(100, 95);
            this.Pic_Login.TabIndex = 0;
            this.Pic_Login.TabStop = false;
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(23, 135);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "label1";
            this.Lbl_Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(23, 198);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "label2";
            this.Lbl_Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(26, 154);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(238, 22);
            this.Txt_Login.TabIndex = 3;
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(26, 221);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '●';
            this.Txt_senha.Size = new System.Drawing.Size(238, 22);
            this.Txt_senha.TabIndex = 4;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(44, 268);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(77, 27);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Acessar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Lnk_RecoveryPassword
            // 
            this.Lnk_RecoveryPassword.AutoSize = true;
            this.Lnk_RecoveryPassword.Location = new System.Drawing.Point(83, 319);
            this.Lnk_RecoveryPassword.Name = "Lnk_RecoveryPassword";
            this.Lnk_RecoveryPassword.Size = new System.Drawing.Size(113, 16);
            this.Lnk_RecoveryPassword.TabIndex = 6;
            this.Lnk_RecoveryPassword.TabStop = true;
            this.Lnk_RecoveryPassword.Text = "Recuperar Senha";
            this.Lnk_RecoveryPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lnk_RecoveryPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(-19, -19);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(160, 268);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(78, 27);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 366);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.Lnk_RecoveryPassword);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.LinkLabel Lnk_RecoveryPassword;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}