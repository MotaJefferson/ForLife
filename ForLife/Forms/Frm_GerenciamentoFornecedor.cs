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
    public partial class Frm_GerenciamentoFornecedor : UserControl
    {

        #region Utilitarios

        string UsuarioLogado = Session.Instance.UserID;

        private void HabilitarCampos (bool habilitarDesabilitar)
        {
            if(habilitarDesabilitar == true)
            {
                Rbtn_FornecedorAtivo.Enabled = true;
                Rbtn_FornecedorInativo.Enabled = true;
                Txt_NomeFantasiaFornecedor.Enabled = true;
                Txt_RazaoSocialFornecedor.Enabled = true;
                Txt_CnpjForn.Enabled = true;
            }
            else
            {
                Rbtn_FornecedorAtivo.Enabled = false;
                Rbtn_FornecedorInativo.Enabled = false;
                Txt_NomeFantasiaFornecedor.Enabled = false;
                Txt_RazaoSocialFornecedor.Enabled = false;
                Txt_CnpjForn.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            Rbtn_FornecedorAtivo.Checked = false;
            Rbtn_FornecedorInativo.Checked = false;
            Txt_NomeFantasiaFornecedor.Clear();
            Txt_RazaoSocialFornecedor.Clear();
            Txt_CnpjForn.Clear();
        }

        Fornecedor.Unit LeituraFormulario()
        {
            Fornecedor.Unit F = new Fornecedor.Unit();

            if (Rbtn_FornecedorAtivo.Checked)
            {
                F.StatusFornecedor = 1;
            }
            if (Rbtn_FornecedorInativo.Checked)
            {
                F.StatusFornecedor = 2;
            }

            F.NomeFantasia = Txt_NomeFantasiaFornecedor.Text;
            F.RazaoSocial = Txt_RazaoSocialFornecedor.Text;

            F.CNPJ = Txt_CnpjForn.Text.Replace(".", "").Replace("/", "").Replace("-", "");

            return F;
        }

        void EscreveCampos(Fornecedor.Unit F)
        {
            if(F.StatusFornecedor == 1)
            {
                Rbtn_FornecedorAtivo.Checked = true;
            }
            if(F.StatusFornecedor == 2)
            {
                Rbtn_FornecedorInativo.Checked = true;
            }

            Txt_NomeFantasiaFornecedor.Text = F.NomeFantasia;
            Txt_RazaoSocialFornecedor.Text = F.RazaoSocial;
            Txt_CnpjForn.Text = F.CNPJ;
        }


        #endregion

        public Frm_GerenciamentoFornecedor()
        {
            InitializeComponent();
            HabilitarCampos(false);
            LimparCampos();
        }

        private void Btn_VoltarFornecedor_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
        }

        private void Btn_NovoFornecedor_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);
        }

        private void Btn_BuscarFornecedor_Click(object sender, EventArgs e)
        {
            Frm_PesquisaFornecedor F = new Frm_PesquisaFornecedor();
            F.ShowDialog();

            if (F.RetornoPesquisa != null)
            {
                EscreveCampos(F.RetornoPesquisa);
            }
        }

        private void Btn_EditarFornecedor_Click(object sender, EventArgs e)
        {
            if (Txt_NomeFantasiaFornecedor.Text == "")
            {
                MessageBox.Show("Pesquise um registro para editar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarCampos(true);
            }
        }

        private void Btn_ExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (Txt_NomeFantasiaFornecedor.Text == "")
            {
                MessageBox.Show("Pesquise um registro para excluir", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Fornecedor.Unit F = new Fornecedor.Unit();
                    F = F.BuscarSQL(Txt_NomeFantasiaFornecedor.Text);

                    if (F == null)
                    {

                    }
                    else
                    {
                        EscreveCampos(F);
                        MessageBox.Show("Deseja apagar o fornecedor " + Txt_NomeFantasiaFornecedor.Text + " ?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        F.ApagarSQL();
                        MessageBox.Show("Fornecedor apagado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        HabilitarCampos(false);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Btn_SalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (Txt_NomeFantasiaFornecedor.Enabled == false)
            {
                MessageBox.Show("Inclua ou edite um registro para salvar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    Fornecedor.Unit F = new Fornecedor.Unit();
                    F = LeituraFormulario();
                    F.ValidaClasse();

                    if (F.BuscaFornecedorExistenteSQL(Txt_NomeFantasiaFornecedor.Text) == false)
                    {
                        F.IncluirSQL(UsuarioLogado);

                        MessageBox.Show("O fornecedor " + Txt_NomeFantasiaFornecedor.Text + " incluído com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HabilitarCampos(false);
                    }
                    else
                    {
                        F.AlterarSQL(UsuarioLogado);

                        MessageBox.Show("O fornecedor " + Txt_NomeFantasiaFornecedor.Text + " alterado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarCampos(false);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
