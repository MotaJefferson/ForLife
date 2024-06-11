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
    public partial class Frm_EstoqueInsumo : UserControl
    {



        public Frm_EstoqueInsumo()
        {
            InitializeComponent();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueInsumo.Unit E = new EstoqueInsumo.Unit();
                Grd_EstoqueInsumos.Rows.Clear();

                string Nome = Txt_PesqNomeInsumoEstoq.Text;
                string Data = Txt_ValInsumoEstoque.Text;


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


        private void Btn_RelatorioEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueInsumo.Unit E = new EstoqueInsumo.Unit();
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
