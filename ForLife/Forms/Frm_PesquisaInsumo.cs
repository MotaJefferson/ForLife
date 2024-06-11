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
    public partial class Frm_PesquisaInsumo : Form
    {
        public Insumo.Unit RetornoPesquisa;

        public Frm_PesquisaInsumo()
        {
            InitializeComponent();
        }

        

        private void Btn_PesquisarInsumo_Click(object sender, EventArgs e)
        { //Nome, Tipo, Bloqueado
            try
            {
                Insumo.Unit I = new Insumo.Unit();
               

                if (Txt_PesqTipoInsumo.Text != null)
                {
                    var ListaGrid1 = I.BuscarVariosSQL("tipo", Txt_PesqTipoInsumo.Text);
                    Grd_ResultadosPesqInsumo.Rows.Clear();

                    for (int i = 0; i <= ListaGrid1.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqInsumo);
                        row.Cells[0].Value = ListaGrid1[i][0].ToString();
                        row.Cells[1].Value = ListaGrid1[i][1].ToString();
                        row.Cells[2].Value = ListaGrid1[i][2].ToString();
                        Grd_ResultadosPesqInsumo.Rows.Add(row);
                    }
                }

                else if (Txt_PesqNomeInsumo.Text != null)
                {
                    var ListaGrid = I.BuscarVariosSQL("nome", Txt_PesqNomeInsumo.Text);
                    
                    Grd_ResultadosPesqInsumo.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqInsumo);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        Grd_ResultadosPesqInsumo.Rows.Add(row);
                    }
                }

                Txt_PesqTipoInsumo.Text = "";
                Txt_PesqNomeInsumo.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_ResultadosPesqInsumo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_ResultadosPesqInsumo.SelectedRows[0];
                string insumo = row.Cells[0].Value.ToString();

                Insumo.Unit I = new Insumo.Unit();

                I = I.BuscarSQL(insumo);

                if (I == null)
                {
                    MessageBox.Show("Usuário não encontrado", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetornoPesquisa = I;
                    this.Close();
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Btn_PesqexibirTodosInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                Insumo.Unit I = new Insumo.Unit();
                var ListaGrid = I.BuscarTodosSQL();
                Grd_ResultadosPesqInsumo.Rows.Clear();


                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_ResultadosPesqInsumo);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    Grd_ResultadosPesqInsumo.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
