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
    public partial class Frm_GerenciamentoInsumo : UserControl
    {

        #region Utilitários

        string UsuarioLogado = Session.Instance.UserID;

        private void HabilitarCampos (bool HabilitarDesabilitar)
        {
            if (HabilitarDesabilitar == true)
            {
                Rbtn_ProdutoAtivo.Enabled = true;
                Rbtn_ProdutoInativo.Enabled = true;
                Txt_NomeInsumo.Enabled = true;
                Rdb_TipoMuda.Enabled = true;
                Rdb_TipoSemente.Enabled = true;
            }
            else
            {
                Rbtn_ProdutoAtivo.Enabled = false;
                Rbtn_ProdutoInativo.Enabled = false;
                Txt_NomeInsumo.Enabled = false;
                Rdb_TipoMuda.Enabled = false;
                Rdb_TipoSemente.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            Rbtn_ProdutoAtivo.Checked = false;
            Rbtn_ProdutoInativo.Checked = false;
            Rdb_TipoMuda.Checked = false;
            Rdb_TipoSemente.Checked = false;
            Txt_NomeInsumo.Clear();

        }

        Insumo.Unit LeituraFormulario()
        {
            Insumo.Unit I = new Insumo.Unit();

            if (Rbtn_ProdutoAtivo.Checked)
            {
                I.StatusInsumo = 1;
            }
            if (Rbtn_ProdutoInativo.Checked)
            {
                I.StatusInsumo = 2;
            }

            if (Rdb_TipoSemente.Checked)
            {
                I.TipoInsumo = 1;
            }

            if (Rdb_TipoMuda.Checked)
            {
                I.TipoInsumo = 2;
            }

            I.NomeInsumo = Txt_NomeInsumo.Text;

            return I;
        }

        void EscreveCampos(Insumo.Unit I)
        {
            if(I.StatusInsumo == 1)
            {
                Rbtn_ProdutoAtivo.Checked = true;
            }
            if (I.StatusInsumo == 2)
            {
                Rbtn_ProdutoInativo.Checked = true;
            }

            if (I.TipoInsumo == 1)
            {
                Rdb_TipoSemente.Checked = true;
            }
            if (I.TipoInsumo == 2)
            {
                Rdb_TipoMuda.Checked = true;
            }

            Txt_NomeInsumo.Text = I.NomeInsumo;
        }

        #endregion

        public Frm_GerenciamentoInsumo()
        {
            InitializeComponent();
            HabilitarCampos(false);
            LimparCampos();
        }

        private void Btn_VoltarInsumo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
        }

        private void Btn_NovoInsumo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);
        }

        private void Btn_BuscarInsumo_Click(object sender, EventArgs e)
        {
            Frm_PesquisaInsumo F = new Frm_PesquisaInsumo();
            F.ShowDialog();

            if(F.RetornoPesquisa != null)
            {
                EscreveCampos(F.RetornoPesquisa);
            }
        }

        private void Btn_EditarInsumo_Click(object sender, EventArgs e)
        {
            if (Txt_NomeInsumo.Text == "")
            {
                MessageBox.Show("Pesquise um registro para editar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarCampos(true);
            }
        }

        private void Btn_ExcluirInsumo_Click(object sender, EventArgs e)
        {
            if (Txt_NomeInsumo.Text == "")
            {
                MessageBox.Show("Pesquise um registro para excluir", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Insumo.Unit P = new Insumo.Unit();
                    P = P.BuscarSQL(Txt_NomeInsumo.Text);

                    if (P != null)
                    {
                        EscreveCampos(P);

                        if (MessageBox.Show("Deseja apagar o insumo " + Txt_NomeInsumo.Text + " ?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            P.ApagarSQL();
                            MessageBox.Show("Insumo apagado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_SalvarInsumo_Click(object sender, EventArgs e)
        {
            if (Txt_NomeInsumo.Enabled == false)
            {
                MessageBox.Show("Inclua ou edite um registro para salvar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    Insumo.Unit I = new Insumo.Unit();
                    I = LeituraFormulario();
                    I.ValidaClasse();

                    if (I.BuscaInsumoExistenteSQL(Txt_NomeInsumo.Text) == false)
                    {
                        I.IncluirSQL(UsuarioLogado);
                        MessageBox.Show("O insumo " + Txt_NomeInsumo.Text + " incluído com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarCampos(false);
                    }
                    else
                    {
                        I.AlterarSQL(UsuarioLogado);

                        MessageBox.Show("O insumo " + Txt_NomeInsumo.Text + " alterado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
