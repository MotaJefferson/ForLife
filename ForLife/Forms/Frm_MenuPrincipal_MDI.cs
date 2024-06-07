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
    public partial class Frm_MenuPrincipal_MDI : Form
    {
        public Frm_MenuPrincipal_MDI()
        {
            InitializeComponent();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.MdiParent = this;
            login.ShowDialog();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GerenciarUsuario_UC F = new Frm_GerenciarUsuario_UC();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Usuário";
            TB.Text = "Usuário";
            

            int index = -1;

            for (int i = 0; i < Tbc_Aplicacoes.TabCount; i++)
            {
                if (Tbc_Aplicacoes.TabPages[i].Text.Trim() == TB.Text.Trim())
                {
                    index = i;
                    break;
                }
            }

            if(index != -1)
            {
                Tbc_Aplicacoes.SelectedIndex = index;
            }
            else
            {
                TB.Controls.Add(F);
                Tbc_Aplicacoes.TabPages.Add(TB);
                Tbc_Aplicacoes.SelectedIndex = 1;

            }



        }

        private void fecharGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Insumos_UC F = new Frm_Insumos_UC();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Gerenciar Insumos";
            TB.Text = "Gerenciar Insumos";

            int index = -1;

            for (int i = 0; i < Tbc_Aplicacoes.TabCount; i++)
            {
                if (Tbc_Aplicacoes.TabPages[i].Text.Trim() == TB.Text.Trim())
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Tbc_Aplicacoes.SelectedIndex = index;
            }
            else
            {
                TB.Controls.Add(F);
                Tbc_Aplicacoes.TabPages.Add(TB);
                Tbc_Aplicacoes.SelectedIndex = 1;
            }
        }

        private void Tbc_Aplicacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_MenuPrincipal_MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
