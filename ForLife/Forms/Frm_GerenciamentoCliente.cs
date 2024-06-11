using ForLifeBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLife.Forms
{
    public partial class Frm_GerenciamentoCliente : UserControl
    {


        #region Utilitarios

        string UsuarioLogado = Session.Instance.UserID;

        private void HabilitarCampos (bool habilitarDesabilitar)
        {
            if (habilitarDesabilitar == true)
            {
                Rbtn_ClienteAtivo.Enabled = true;
                Rbtn_ClienteInativo.Enabled = true;
                Txt_NomeCliente.Enabled = true;
                Txt_CpfCliente.Enabled = true;
                Txt_CelularCliente.Enabled = true;
                Txt_Logadouro.Enabled = true;
                Txt_NumEndereco.Enabled = true;
                Txt_Complemento.Enabled = true;
                Txt_Bairro.Enabled = true;
                Txt_Cidade.Enabled = true;
                Txt_UF.Enabled = true;
            }

            else
            {
                Rbtn_ClienteAtivo.Enabled = false;
                Rbtn_ClienteInativo.Enabled = false;
                Txt_NomeCliente.Enabled = false;
                Txt_CpfCliente.Enabled = false;
                Txt_CelularCliente.Enabled = false;
                Txt_Logadouro.Enabled = false;
                Txt_NumEndereco.Enabled = false;
                Txt_Complemento.Enabled = false;
                Txt_Bairro.Enabled = false;
                Txt_Cidade.Enabled = false;
                Txt_UF.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            Rbtn_ClienteAtivo.Checked = false;
            Rbtn_ClienteInativo.Checked = false;
            Txt_NomeCliente.Clear();
            Txt_CpfCliente.Clear();
            Txt_CelularCliente.Clear();
            Txt_Logadouro.Clear();
            Txt_NumEndereco.Clear();
            Txt_Complemento.Clear();
            Txt_Bairro.Clear();
            Txt_Cidade.Clear();
            Txt_UF.Clear();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();

            if (Rbtn_ClienteAtivo.Checked)
            {
                C.StatusCliente = 1;
            }
            if (Rbtn_ClienteInativo.Checked)
            {
                C.StatusCliente = 2;
            }

            
            C.NomeCompleto = Txt_NomeCliente.Text;
            C.CPF = Txt_CpfCliente.Text.Replace(".", "").Replace("-", "");
            C.Celular = Txt_CelularCliente.Text;
            C.Logadouro = Txt_Logadouro.Text;
            C.NumEndereco = Txt_NumEndereco.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;
            C.UF = Txt_UF.Text;

            return C;
        }

        void EscreveCampos(Cliente.Unit C)
        {
            if (C.StatusCliente == 1)
            {
                Rbtn_ClienteAtivo.Checked = true;
            }
            if (C.StatusCliente == 0)
            {
                Rbtn_ClienteInativo.Checked = true;
            }


            Txt_NomeCliente.Text = C.NomeCompleto;
            Txt_CpfCliente.Text = C.CPF;
            Txt_CelularCliente.Text = C.Celular;
            Txt_Logadouro.Text = C.Logadouro;
            Txt_NumEndereco.Text = C.NumEndereco.ToString();
            Txt_Complemento.Text = C.Complemento;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;
            Txt_UF.Text = C.UF;

        }

        #endregion

        public Frm_GerenciamentoCliente()
        {
            InitializeComponent();
            HabilitarCampos(false);
            LimparCampos();
        }
        private void Btn_VoltarCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
        }
        private void Btn_NovoCliente_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);
        }
        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            Frm_PesquisaCliente F = new Frm_PesquisaCliente();
            F.ShowDialog();

            if (F.RetornoPesquisa != null)
            {
                EscreveCampos(F.RetornoPesquisa);
            }
        }
        private void Btn_EditarCliente_Click(object sender, EventArgs e)
        {
            if (Txt_NomeCliente.Text == "")
            {
                MessageBox.Show("Pesquise um registro para editar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarCampos(true);
            }
        }

        private void Btn_SalvarCliente_Click(object sender, EventArgs e)
        {
            if (Txt_NomeCliente.Enabled == false)
            {
                MessageBox.Show("Inclua ou edite um registro para salvar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();


                    C = LeituraFormulario();
                    C.ValidaClasse();

                    if (C.BuscaClienteExistenteSQL(Txt_NomeCliente.Text) == false)
                    {
                        C.IncluirSQL(UsuarioLogado);

                        MessageBox.Show("O cliente " + Txt_NomeCliente.Text + " incluído com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HabilitarCampos(false);
                    }
                    else
                    {
                        C.AlterarSQL(UsuarioLogado);

                        MessageBox.Show("O cliente " + Txt_NomeCliente.Text + " alterado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarCampos(false);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (Txt_NomeCliente.Text == "")
            {
                MessageBox.Show("Pesquise um registro para excluir", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarSQL(Txt_NomeCliente.Text);

                    if (C != null)
                    {
                        EscreveCampos(C);

                        if (MessageBox.Show("Deseja apagar o cliente " + Txt_NomeCliente.Text + " ?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            C.ApagarSQL();
                            MessageBox.Show("Cliente apagado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
