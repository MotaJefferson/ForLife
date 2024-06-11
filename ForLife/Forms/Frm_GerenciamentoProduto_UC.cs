using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForLifeBiblioteca.Classes;
using System.Data.SqlClient;
using ForLifeBiblioteca.Databases;

namespace ForLife.Forms
{
    public partial class Frm_GerenciamentoProduto_UC : UserControl
    {

        #region Utilitarios

        string UsuarioLogado = Session.Instance.UserID;

        private void HabilitarCampos (bool habilitarDesabilitar)
        {
            if(habilitarDesabilitar == true)
            {
                Rbtn_ProdutoAtivo.Enabled = true;
                Rbtn_ProdutoInativo.Enabled = true;
                Txt_NomeProduto.Enabled = true;                
                Num_Vencimento.Enabled = true;
                Num_Colheita.Enabled = true;
                Btn_PesquisaInsumo.Enabled = true;
            }
            else
            {
                Rbtn_ProdutoAtivo.Enabled = false;
                Rbtn_ProdutoInativo.Enabled = false;
                Txt_NomeProduto.Enabled = false;
                Num_Vencimento.Enabled = false;
                Num_Colheita.Enabled = false;
                Btn_PesquisaInsumo.Enabled = false;

            }
        }

        private void LimparCampos()
        {
            Rbtn_ProdutoAtivo.Checked = false;
            Rbtn_ProdutoInativo.Checked = false;
            Txt_NomeProduto.Clear();
            Txt_InsumoOrigem.Clear();
            Num_Vencimento.Value = 0;
            Num_Colheita.Value = 0;
        }

        Produto.Unit LeituraFormulario()
        {
            Produto.Unit P = new Produto.Unit();

            if (Rbtn_ProdutoAtivo.Checked)
            {
                P.StatusProduto = 1;
            }
            if (Rbtn_ProdutoInativo.Checked)
            {
                P.StatusProduto = 2;
            }

            P.NomeProduto = Txt_NomeProduto.Text;
            P.InsumoOrigem = Txt_InsumoOrigem.Text;

            P.DtVencimento = Num_Vencimento.Value;
            P.DtColheita = Num_Colheita.Value;

            return P;
        }

        void EscreveCampos(Produto.Unit P)
        {
            if(P.StatusProduto == 2)
            {
                Rbtn_ProdutoInativo.Checked = true;
            }
            if(P.StatusProduto == 1)
            {
                Rbtn_ProdutoAtivo.Checked = true;
            }

            Txt_NomeProduto.Text = P.NomeProduto;
            Txt_InsumoOrigem.Text = P.ReturnNomeInsumo(P.IdInsumoOrigem);

            Num_Vencimento.Value = P.DtVencimento;
            Num_Colheita.Value = P.DtColheita;
        }

        #endregion

        public Frm_GerenciamentoProduto_UC()
        {
            InitializeComponent();
            HabilitarCampos(false);
            LimparCampos();

            Txt_InsumoOrigem.Enabled = false;

        }
        private void Btn_VoltarProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
        }
        private void Btn_NovoProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);
        }

        private void Btn_BuscarProduto_Click(object sender, EventArgs e)
        {
            Frm_PesquisaProduto F = new Frm_PesquisaProduto();
            F.ShowDialog();

            if (F.RetornoPesquisa != null)
            {
                EscreveCampos(F.RetornoPesquisa);
            }

        }

        private void Btn_PesquisaInsumo_Click(object sender, EventArgs e)
        {
            Frm_PesquisaInsumoOrigem F = new Frm_PesquisaInsumoOrigem();
            F.ShowDialog();

            if (F.RetornoPesquisaInsumo != null)
            {
                Txt_InsumoOrigem.Text = F.RetornoPesquisaInsumo;
            }
        }

        private void Btn_SalvarProduto_Click(object sender, EventArgs e)
        {
            if (Txt_NomeProduto.Enabled == false)
            {
                MessageBox.Show("Inclua ou edite um registro para salvar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                try
                {
                    Produto.Unit P = new Produto.Unit();
                    P = LeituraFormulario();
                    P.ValidaClasse();
                    P.ValidaComplemento();

                    if (P.BuscaProdutoExistenteSQL(Txt_NomeProduto.Text) == false)
                    {
                        P.IncluirSQL(UsuarioLogado);

                        MessageBox.Show("O produto " + Txt_NomeProduto.Text + " incluído com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HabilitarCampos(false);
                    }
                    else
                    {
                        P.AlterarSQL(UsuarioLogado);

                        MessageBox.Show("O produto " + Txt_NomeProduto.Text + " alterado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarCampos(false);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_EditarProduto_Click(object sender, EventArgs e)
        {
            if (Txt_NomeProduto.Text == "")
            {
                MessageBox.Show("Pesquise um registro para editar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarCampos(true);
            }
        }

        private void Btn_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (Txt_NomeProduto.Text == "")
            {
                MessageBox.Show("Pesquise um registro para excluir", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Produto.Unit P = new Produto.Unit();
                    P = P.BuscarSQL(Txt_NomeProduto.Text);

                    if (P != null)
                    {
                        EscreveCampos(P);

                        if (MessageBox.Show("Deseja apagar o produto " + Txt_NomeProduto.Text + " ?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            P.ApagarSQL();
                            MessageBox.Show("Produto apagado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                            HabilitarCampos(false);
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
