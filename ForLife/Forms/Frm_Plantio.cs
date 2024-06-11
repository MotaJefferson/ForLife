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
    public partial class Frm_Plantio : UserControl
    {
        public Frm_Plantio()
        {
            InitializeComponent();
        }

        void EscreveCampos(Produto.Unit P)
        {
            
            Txt_produtoDesejadoPlantio.Text = P.NomeProduto;
        }

        private void Btn_Pesquisa_produtoDesejadoPlantio_Click(object sender, EventArgs e)
        {
            Frm_PesquisaProduto F = new Frm_PesquisaProduto();
            F.ShowDialog();

            if (F.RetornoPesquisa != null)
            {
                EscreveCampos(F.RetornoPesquisa);
            }
        }

        private void Frm_Plantio_Load(object sender, EventArgs e)
        {

        }

        private void Btn_PlantarProdutoPlantio_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AtualizarPlantacao_Click(object sender, EventArgs e)
        {
                        
        }

        private void Btn_PesquisarNaPlantacao_Click(object sender, EventArgs e)
        {
           
        }
    }
}
