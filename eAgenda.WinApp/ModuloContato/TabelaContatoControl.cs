using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (Contato contato in contatos)
            {
                grid.Rows.Add(contato.Id,contato.Nome,contato.Telefone,contato.Email,contato.Empresa,contato.Cargo);
            }
        }

        public Contato ObterRegistroSelecionado()
        {
            return null;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
