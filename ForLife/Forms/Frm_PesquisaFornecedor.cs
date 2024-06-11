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
        }

        private void Btn_PesquisarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor.Unit P = new Fornecedor.Unit();

                if (Txt_PesqNomeFantasiaForn != null)
                {
                    var ListaGrid = P.BuscarVariosSQL("nome", Txt_PesqNomeFantasiaForn.Text);
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

                else if (Txt_PesqRazaoSocialForn != null)
                {
                    var ListaGrid = P.BuscarVariosSQL("razao_social", Txt_PesqRazaoSocialForn.Text);
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

                else if (Txt_PesqCnpjForn != null)
                {
                    var ListaGrid = P.BuscarVariosSQL("CPF", Txt_PesqRazaoSocialForn.Text);
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
    }
}
