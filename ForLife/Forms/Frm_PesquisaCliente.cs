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
    public partial class Frm_PesquisaCliente : Form
    {

        public Cliente.Unit RetornoPesquisa;

        public Frm_PesquisaCliente()
        {
            InitializeComponent();

            Txt_PesquisaNomeCliente.Clear();
            Txt_Telefone.Clear();
            Txt_PesquisaCpfCliente.Clear();

        }

        private void Btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                Grd_ResultadosPesqCliente.Rows.Clear();

                string nome = Txt_PesquisaNomeCliente.Text;
                string telefone = Txt_Telefone.Text;
                string CPF = Txt_PesquisaCpfCliente.Text;

                if (nome != "")
                {
                    var ListaGrid = C.BuscarVariosSQL("CPF", CPF);
                    Grd_ResultadosPesqCliente.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqCliente);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        row.Cells[4].Value = ListaGrid[i][4].ToString();
                        Grd_ResultadosPesqCliente.Rows.Add(row);
                    }

                }
                else if (telefone != "")
                {
                    var ListaGrid = C.BuscarVariosSQL("telefone", telefone);
                    Grd_ResultadosPesqCliente.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqCliente);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        row.Cells[4].Value = ListaGrid[i][4].ToString();
                        Grd_ResultadosPesqCliente.Rows.Add(row);
                    }
                }
                else if (nome != "")
                {
                    var ListaGrid = C.BuscarVariosSQL("nome", nome);
                    Grd_ResultadosPesqCliente.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqCliente);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        row.Cells[4].Value = ListaGrid[i][4].ToString();
                        Grd_ResultadosPesqCliente.Rows.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_PesquisarexibirTodosCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();

                var ListaGrid = C.BuscarTodosSQL();
                Grd_ResultadosPesqCliente.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_ResultadosPesqCliente);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    row.Cells[3].Value = ListaGrid[i][3].ToString();
                    Grd_ResultadosPesqCliente.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grd_ResultadosPesqCliente_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_ResultadosPesqCliente.SelectedRows[0];
                string usuario = row.Cells[0].Value.ToString();

                Cliente.Unit C = new Cliente.Unit();

                C = C.BuscarSQL(usuario);

                if (C == null)
                {
                    MessageBox.Show("Cliente não encontrado", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RetornoPesquisa = C;
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
