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
    public partial class Frm_EstoqueProduto : UserControl
    {
        public Frm_EstoqueProduto()
        {
            InitializeComponent();
        }

        private void Btn_PesquisarProdutoEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueProduto.Unit E = new EstoqueProduto.Unit();
                Grd_EstoqueInsumos.Rows.Clear();

                string Nome = Txt_PesqNomeProdutoEstoq.Text;
                string Data = Txt_ValProdutoEstoque.Text;


                if (Nome != "")
                {
                    var ListaGrid = E.BuscarRegistrosSQL("nome", Nome);
                    Grd_EstoqueInsumos.Rows.Clear();



                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_EstoqueInsumos);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        Grd_EstoqueInsumos.Rows.Add(row);
                    }
                }

                else if (Data != "")
                {
                    var ListaGrid = E.BuscarRegistrosSQL("data_vencimento_estimado", Nome);
                    Grd_EstoqueInsumos.Rows.Clear();



                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_EstoqueInsumos);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        Grd_EstoqueInsumos.Rows.Add(row);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_RelatorioEstoqueProduto_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueProduto.Unit E = new EstoqueProduto.Unit();
                Grd_EstoqueInsumos.Rows.Clear();

                var ListaGrid = E.BuscarTodosSQL();
                Grd_EstoqueInsumos.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_EstoqueInsumos);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    Grd_EstoqueInsumos.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
