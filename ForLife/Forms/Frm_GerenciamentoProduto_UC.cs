using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForLifeBiblioteca.Classes;

namespace ForLife.Forms
{
    public partial class Frm_GerenciamentoProduto_UC : UserControl
    {
        public Frm_GerenciamentoProduto_UC()
        {
            InitializeComponent();

            Produto.Unit P = new Produto.Unit();

                      
            comboBox_InsumoOrigem.Items.Clear();
            comboBox_InsumoOrigem.Items.Add(P.ListaInsumoSQL());
        }

    }
}
