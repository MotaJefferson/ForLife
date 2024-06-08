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

        public Frm_Login()
        {
            InitializeComponent();          

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Hide();
            Frm_MenuPrincipal_MDI frm = new Frm_MenuPrincipal_MDI();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
            
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

        private ToolTip tooltip;


    }
        
}
