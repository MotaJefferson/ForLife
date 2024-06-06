using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForLifeBiblioteca.Classes;
using ForLifeBiblioteca.Databases;

namespace ForLife.Forms

{
    public partial class Frm_Pesquisa : Form
    {

        public Usuario.Unit RetornoPesquisa;

        public Frm_Pesquisa()
        {
            InitializeComponent();

        }

        private void AtualizaGrid()
        {
            try
            {
                Usuario.Unit U = new Usuario.Unit();

                var ListaGrid = U.BuscarTodosSQL();
                Grd_Resultados.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_Resultados);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    row.Cells[3].Value = ListaGrid[i][3].ToString();
                    Grd_Resultados.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void Grd_Resultados_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = Grd_Resultados.SelectedRows[0];
                string usuario = row.Cells[0].Value.ToString();

                Usuario.Unit U = new Usuario.Unit();

                U = U.BuscarSQL(usuario);

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
                MessageBox.Show("Selecione um valor", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

    }
}
