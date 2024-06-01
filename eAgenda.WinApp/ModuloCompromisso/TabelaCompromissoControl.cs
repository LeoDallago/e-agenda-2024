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

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();
            
            grid.Columns.AddRange(GerarColunas());
            grid.ConfugrarGrid();
            grid.ConfigurarGridZebrado();
        }


        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                grid.Rows.Add
                    (
                    compromisso.Id,compromisso.Assunto,compromisso.DataCompromisso,
                    compromisso.Inicio,compromisso.Termino,compromisso.Contato.ToTitleCase(),
                    compromisso.Localização,compromisso.Local
                    );
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
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "assunto", HeaderText = "Assunto"},
                new DataGridViewTextBoxColumn { DataPropertyName = "dataCompromisso", HeaderText = "DataCompromisso"},
                new DataGridViewTextBoxColumn { DataPropertyName = "inicio", HeaderText = "Inicio"},
                new DataGridViewTextBoxColumn { DataPropertyName = "termino", HeaderText = "Termino"},
                new DataGridViewTextBoxColumn { DataPropertyName = "contato", HeaderText = "Contato"},
                new DataGridViewTextBoxColumn { DataPropertyName = "localizacao", HeaderText = "Localizacao"},
                new DataGridViewTextBoxColumn { DataPropertyName = "local", HeaderText = "Local"},
            };
        }

    }
}
