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

            DataGridViewColumn[] colunas = new DataGridViewColumn[]
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

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                grid.Rows.Add
                    (
                    compromisso.Id,compromisso.Assunto,compromisso.DataCompromisso,
                    compromisso.Inicio,compromisso.Termino,compromisso.Contato,
                    compromisso.Localização,compromisso.Local
                    );
            }
        }

        public Compromisso ObterRegistroSelecionado()
        {
            return null;
        }
    }
}
