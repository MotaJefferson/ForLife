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
    public partial class Frm_PesquisaFornecedor : Form
    {
        public Fornecedor.Unit RetornoPesquisa;

        public Frm_PesquisaFornecedor()
        {
            InitializeComponent();

            Txt_PesqCnpjForn.Clear();
            Txt_PesqNomeFantasiaForn.Clear();
            Txt_PesqRazaoSocialForn.Clear();
        }

        private void Btn_PesquisarFornecedor_Click(object sender, EventArgs e)
        {
            
            try
            {
                Fornecedor.Unit P = new Fornecedor.Unit();
                Grd_ResultadosPesqFornecedor.Rows.Clear();

                string nomeFantasia = Txt_PesqNomeFantasiaForn.Text;
                string CNPJ = Txt_PesqCnpjForn.Text;
                string razaoSocial = Txt_PesqRazaoSocialForn.Text;

                if (CNPJ != "")
                {
                    var ListaGrid = P.BuscarVariosSQL("CNPJ", CNPJ);
                    Grd_ResultadosPesqFornecedor.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqFornecedor);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqFornecedor.Rows.Add(row);
                    }

                }

                else if (razaoSocial != "")
                {
                    var ListaGrid = P.BuscarVariosSQL("razao_social", razaoSocial);
                    Grd_ResultadosPesqFornecedor.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqFornecedor);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqFornecedor.Rows.Add(row);
                    }

                }

                else if (nomeFantasia != "")
                {
                    var ListaGrid = P.BuscarVariosSQL("nome", nomeFantasia);
                    Grd_ResultadosPesqFornecedor.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqFornecedor);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqFornecedor.Rows.Add(row);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_PesqexibirTodosForn_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor.Unit F = new Fornecedor.Unit();

                var ListaGrid = F.BuscarTodosSQL();
                Grd_ResultadosPesqFornecedor.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_ResultadosPesqFornecedor);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    row.Cells[3].Value = ListaGrid[i][3].ToString();
                    Grd_ResultadosPesqFornecedor.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_ResultadosPesqFornecedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_ResultadosPesqFornecedor.SelectedRows[0];
                string usuario = row.Cells[0].Value.ToString();

                Fornecedor.Unit F = new Fornecedor.Unit();

                F = F.BuscarSQL(usuario);

                if (F == null)
                {
                    MessageBox.Show("Fornecedor não encontrado", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetornoPesquisa = F;
                    this.Close();
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
