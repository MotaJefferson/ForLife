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

    public partial class Frm_PesquisaProduto : Form
    {

        public Produto.Unit RetornoPesquisa;

        public Frm_PesquisaProduto()
        {
            InitializeComponent();
        }

        private void Btn_PesquisarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produto.Unit P = new Produto.Unit();

                if (Txt_NomeProduto != null)
                {
                    var ListaGrid = P.BuscarVariosSQL("nome", Txt_NomeProduto.Text);
                    Grd_ResultadosPesqProduto.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqProduto);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        Grd_ResultadosPesqProduto.Rows.Add(row);
                    }

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_PesquisarExibirTodosInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                Produto.Unit U = new Produto.Unit();

                var ListaGrid = U.BuscarTodosSQL();
                Grd_ResultadosPesqProduto.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_ResultadosPesqProduto);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    Grd_ResultadosPesqProduto.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_ResultadosPesqProduto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_ResultadosPesqProduto.SelectedRows[0];
                string produto = row.Cells[0].Value.ToString();

                Produto.Unit U = new Produto.Unit();

                U = U.BuscarSQL(produto);

                if (U == null)
                {
                    MessageBox.Show("Usuário não encontrado", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetornoPesquisa = U;
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
