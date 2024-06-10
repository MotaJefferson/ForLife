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
    
    public partial class Frm_PesquisaInsumoOrigem : Form
    {
   
        public string RetornoPesquisaInsumo;

        public Frm_PesquisaInsumoOrigem()
        {
            InitializeComponent();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto.Unit P = new Produto.Unit();

                if(Txt_NomeInsumo != null)
                {
                    var ListaGrid = P.BuscarVariosInsumoSQL(Txt_NomeInsumo.Text);
                    Grd_Resultados.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_Resultados);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        Grd_Resultados.Rows.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_Resultados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_Resultados.SelectedRows[0];
                string insumo = row.Cells[0].Value.ToString();

                Produto.Unit P = new Produto.Unit();


                if (P == null)
                {
                    MessageBox.Show("Insumo não encontrado", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetornoPesquisaInsumo = P.BuscarInsumoSQL(insumo);
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
