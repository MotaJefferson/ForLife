using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForLifeBiblioteca;
using ForLifeBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;


namespace ForLife.Forms
{

    public partial class Frm_GerenciarUsuario_UC : UserControl
    {
              
        private void HabilitarCampos(bool habilitarDesabilitar)
        {
            if(habilitarDesabilitar == true)
            {

                Txt_NomeCompleto.Enabled = true;
                Txt_CodAcesso.Enabled = true;
                Txt_Senha.Enabled = true;
                Txt_ConfirmarSenha.Enabled = true;
                Chk_Bloqueado.Enabled = true;
                Rbtn_Agricultor.Enabled = true;
                Rbtn_Comercial.Enabled = true;
                Rbtn_Gestor.Enabled = true;
                Btn_VerSenha.Enabled = true;

            }
            else
            {
                Txt_NomeCompleto.Enabled = false;
                Txt_CodAcesso.Enabled = false;
                Txt_Senha.Enabled = false;
                Txt_ConfirmarSenha.Enabled = false;
                Chk_Bloqueado.Enabled = false;
                Rbtn_Agricultor.Enabled = false;
                Rbtn_Comercial.Enabled = false;
                Rbtn_Gestor.Enabled = false;
                Btn_VerSenha.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            Rbtn_Agricultor.Checked = false;
            Rbtn_Comercial.Checked = false;
            Rbtn_Gestor.Checked = false;

            Chk_Bloqueado.Checked = false;
            Txt_NomeCompleto.Clear();
            Txt_CodAcesso.Clear();
            Txt_Senha.Clear();
            Txt_ConfirmarSenha.Clear();
            Lbl_ValidaSenha.Text = null;

        }

        Usuario.Unit LeituraFormulario()
        {
            Usuario.Unit U = new Usuario.Unit();

            if (Rbtn_Agricultor.Checked)
            {
                U.Cargo = 1;
            }
            if (Rbtn_Comercial.Checked)
            {
                U.Cargo = 2;
            }
            if (Rbtn_Gestor.Checked)
            {
                U.Cargo = 3;
            }

            if (Chk_Bloqueado.Checked)
            {
                U.icBloqueado = 1;
            }
            else
            {
                U.icBloqueado = 0;
            }
            
            U.Nome = Txt_NomeCompleto.Text;
            U.Usuario = Txt_CodAcesso.Text;
            U.Senha = Txt_Senha.Text;
            U.ConfirmarSenha = Txt_ConfirmarSenha.Text;

            return U;
        }

        void EscreveCampos(Usuario.Unit c)
        {
            Txt_NomeCompleto.Text = c.Nome;
            Txt_CodAcesso.Text = c.Usuario;
            Txt_Senha.Text = c.Senha;
            //Verificar
            Txt_ConfirmarSenha.Text = c.Senha;

            if(c.Cargo == 1)
            {
                Rbtn_Agricultor.Checked = true;
            }
            if(c.Cargo == 2)
            {
                Rbtn_Comercial.Checked = true;
            }
            if(c.Cargo == 3)
            {
                Rbtn_Gestor.Checked = true;
            }

            if(c.icBloqueado == 1)
            {
                Chk_Bloqueado.Checked = true;
            }

        }

        bool VerSenha = false;

        public Frm_GerenciarUsuario_UC()
        {
            InitializeComponent();

            HabilitarCampos(false);
            LimparCampos();           
        }

        private void Tbtn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if(VerSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Txt_ConfirmarSenha.PasswordChar = '\0';
                VerSenha = true;
                Btn_VerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                Btn_VerSenha.Image = global::ForLife.Properties.Resources.Invisível;
                
            }
            else
            {
                Txt_Senha.PasswordChar = '●';
                Txt_ConfirmarSenha.PasswordChar = '●';
                VerSenha = false;
                Btn_VerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                Btn_VerSenha.Image = global::ForLife.Properties.Resources.Visível;
            }
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {

            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_ValidaSenha.Text = forca.ToString();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);            
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            
            if(Txt_CodAcesso.Text == "")
            {
                MessageBox.Show("Pesquise um registro para editar", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitarCampos(true);
            }
            
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(false);
            
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.Unit U = new Usuario.Unit();
                U = LeituraFormulario();
                U.ValidaClasse();
                U.ValidaComplemento();
                U.IncluirSQL();
              

                MessageBox.Show("O usuário " + Txt_CodAcesso.Text + " cadastrado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarCampos(false);

            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if(Txt_CodAcesso.Text == "")
            {
                MessageBox.Show("Campo do usuário está vazio", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {

                try
                {
                    Usuario.Unit C = new Usuario.Unit();
                    C = C.BuscarSQL(Txt_CodAcesso.Text);

                    if(C == null)
                    {

                    }
                    else
                    {
                        EscreveCampos(C);
                        MessageBox.Show("Deseja apagar o usuário " + Txt_CodAcesso.Text + " ?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        C.ApagarSQL();
                        MessageBox.Show("Usuário apagado com sucesso", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
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
