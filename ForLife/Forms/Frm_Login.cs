using ForLifeBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLife.Forms
{

    public partial class Frm_Login : Form
    {

        bool VerSenha = false;

        ValidacaoLogin LerCampos()
        {
            ValidacaoLogin V = new ValidacaoLogin();

            V.Login = Txt_Login.Text;
            V.Password = Txt_senha.Text;

            return V;
        }

        public Frm_Login()
        {
            InitializeComponent();

            Txt_Login.Clear();
            Txt_senha.Clear();
             
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                ValidacaoLogin V = new ValidacaoLogin();

                V = LerCampos();
                V.ValidaClasse();

                string usuario = V.RetornaUsuario(Txt_Login.Text);
                string senha = V.RetornaSenha(usuario);

                if (usuario != null)
                {

                    if (senha != Txt_senha.Text)
                    {
                        MessageBox.Show("Senha incorreta", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;

                        Session.Instance.UserID = Txt_Login.Text;

                        this.Hide();
                        Frm_MenuPrincipal_MDI frm = new Frm_MenuPrincipal_MDI();
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            
        }


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenha == false)
            {
                Txt_senha.PasswordChar = '\0';
                VerSenha = true;
                Btn_VerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                Btn_VerSenha.Image = global::ForLife.Properties.Resources.Invisível;

            }
            else
            {
                Txt_senha.PasswordChar = '●';
                VerSenha = false;
                Btn_VerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                Btn_VerSenha.Image = global::ForLife.Properties.Resources.Visível;
            }
        }

        private void btn_LoginDireto_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Session.Instance.UserID = Txt_Login.Text;

            this.Hide();
            Frm_MenuPrincipal_MDI frm = new Frm_MenuPrincipal_MDI();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
        
}
