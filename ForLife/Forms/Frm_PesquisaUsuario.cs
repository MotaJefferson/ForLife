﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForLifeBiblioteca;
using ForLifeBiblioteca.Classes;
using ForLifeBiblioteca.Databases;
using ForLifeBiblioteca.ForLifeDataSetTableAdapters;

namespace ForLife.Forms

{
    public partial class Frm_PesquisaUsuario : Form
    {

        public Usuario.Unit RetornoPesquisa;

        public Frm_PesquisaUsuario()
        {
            InitializeComponent();

        }


        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario.Unit U = new Usuario.Unit();

                if (Cmb_PesqTipoUsuario.Text != "")
                {
                    int index = 0;

                    if (Cmb_PesqTipoUsuario.SelectedIndex > 0)
                    {
                        index = Cmb_PesqTipoUsuario.SelectedIndex;
                    }

                    var ListaGrid = U.BuscarVariosSQL("cargo", index.ToString());
                    Grd_ResultadosPesqUsuario.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqUsuario);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqUsuario.Rows.Add(row);
                    }
                }

                else if(Txt_PesqNomeUsuario.Text != "")
                {
                    var ListaGrid = U.BuscarVariosSQL("nome", Txt_PesqNomeUsuario.Text);
                    Grd_ResultadosPesqUsuario.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqUsuario);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqUsuario.Rows.Add(row);
                    }
                }
                                
                else if (Txt_PesqUsuario.Text != "")
                {
                    var ListaGrid = U.BuscarVariosSQL("usuario", Txt_PesqUsuario.Text);
                    Grd_ResultadosPesqUsuario.Rows.Clear();

                    for (int i = 0; i <= ListaGrid.Count - 1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Grd_ResultadosPesqUsuario);
                        row.Cells[0].Value = ListaGrid[i][0].ToString();
                        row.Cells[1].Value = ListaGrid[i][1].ToString();
                        row.Cells[2].Value = ListaGrid[i][2].ToString();
                        row.Cells[3].Value = ListaGrid[i][3].ToString();
                        Grd_ResultadosPesqUsuario.Rows.Add(row);
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
                row = Grd_ResultadosPesqUsuario.SelectedRows[0];
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
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.Unit U = new Usuario.Unit();

                var ListaGrid = U.BuscarTodosSQL();
                Grd_ResultadosPesqUsuario.Rows.Clear();

                for (int i = 0; i <= ListaGrid.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Grd_ResultadosPesqUsuario);
                    row.Cells[0].Value = ListaGrid[i][0].ToString();
                    row.Cells[1].Value = ListaGrid[i][1].ToString();
                    row.Cells[2].Value = ListaGrid[i][2].ToString();
                    row.Cells[3].Value = ListaGrid[i][3].ToString();
                    Grd_ResultadosPesqUsuario.Rows.Add(row);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
