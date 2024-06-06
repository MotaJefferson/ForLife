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
    public partial class Frm_Pesquisa : Form
    {
        public List<DadosUsuario> Usuarios { get; set; }        
        public Frm_Pesquisa()
        {
            Usuarios = GetUsuarios();
            InitializeComponent();
        }

        private List<DadosUsuario> GetUsuarios()
        {
            var lista = new List<DadosUsuario>();

            return lista;
        }
    }
}
