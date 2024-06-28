using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(GerarColunas());

            grid.ConfugrarGrid();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            grid.Rows.Clear();

            foreach (Despesa despesa in despesas)
            {
                grid.Rows.Add(despesa.Id,despesa.Descricao,despesa.Valor,despesa.Data);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descricao"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"}
            };
        }
    }
}
