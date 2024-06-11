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
            TB.Name = "Gerenciamento - Usuário";
            TB.Text = "Gerenciamento - Usuário";
            
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

        public void insumosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GerenciamentoInsumo F = new Frm_GerenciamentoInsumo();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Gerenciamento - Insumo";
            TB.Text = "Gerenciamento - Insumo";

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

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GerenciamentoFornecedor F = new Frm_GerenciamentoFornecedor();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Gerenciamento - Fornecedor";
            TB.Text = "Gerenciamento - Fornecedor";

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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GerenciamentoCliente F = new Frm_GerenciamentoCliente();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Gerenciamento - Cliente";
            TB.Text = "Gerenciamento - Cliente";

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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EstoqueProduto F = new Frm_EstoqueProduto();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Estoque - Produto";
            TB.Text = "Estoque - Produto";

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

        private void plantioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Plantio F = new Frm_Plantio();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Plantio";
            TB.Text = "Plantio";

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

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Venda F = new Frm_Venda();
            F.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Vendas";
            TB.Text = "Vendas";

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
