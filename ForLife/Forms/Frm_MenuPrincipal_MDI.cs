using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ForLife.Forms
{
    public partial class Frm_MenuPrincipal_MDI : Form
    {
        

        public Frm_MenuPrincipal_MDI()
        {
            InitializeComponent();

            conectarToolStripMenuItem.Enabled = false;

        }


        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string UsuarioLogado = Session.Instance.UserID; 
                       

            if((MessageBox.Show("Deseja desconectar "+ UsuarioLogado +" ", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                bool statusLogin = false;

                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = statusLogin;
                usuárioToolStripMenuItem.Enabled = statusLogin;
                materialToolStripMenuItem.Enabled = statusLogin;
                fornecedorToolStripMenuItem.Enabled = statusLogin;
                clienteToolStripMenuItem.Enabled = statusLogin;
                insumosToolStripMenuItem.Enabled = statusLogin;
                produtosToolStripMenuItem.Enabled = statusLogin;
                realizarVendaToolStripMenuItem.Enabled = statusLogin;

                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 1; i += -1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                                        
                }
            }

            

        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Frm_Login login = new Frm_Login();
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
                Tbc_Aplicacoes.SelectTab(TB);
            }



        }

        private void fecharGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                if (Tbc_Aplicacoes.SelectedIndex != 0)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                }
            }
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EstoqueInsumo F = new Frm_EstoqueInsumo();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Estoque - Insumo";
            TB.Text = "Estoque - Insumo";

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
                Tbc_Aplicacoes.SelectTab(TB);

            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GerenciamentoProduto_UC F = new Frm_GerenciamentoProduto_UC();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Gerenciamento - Produto";
            TB.Text = "Gerenciamento - Produto";

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
                Tbc_Aplicacoes.SelectTab(TB);

            }

        }
    }
}
