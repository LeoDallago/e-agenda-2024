using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(GerarColunas());
            grid.ConfigurarGridZebrado();
            grid.ConfugrarGrid();
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            grid.Rows.Clear();

            foreach (Categoria categoria in categorias)
            {
                grid.Rows.Add(categoria.Id,categoria.Titulo.ToTitleCase());
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }


        private static DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo"},

            };
        }
    }
}
