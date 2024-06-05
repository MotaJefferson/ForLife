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
        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Btn_Login.Text = "Acessar";
            Btn_Cancel.Text = "Cancelar";
            Lnk_RecoveryPassword.Text = "Recuperar Senha";

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
