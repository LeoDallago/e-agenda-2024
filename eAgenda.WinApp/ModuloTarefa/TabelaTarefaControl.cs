namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();
            GerarColunas();

            ConfigurarListView();
        }

        public void AtualizarRegistros (List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                ListViewItem item = new ListViewItem(tarefa.Id.ToString());

                item.SubItems.Add(tarefa.Titulo);
                item.SubItems.Add(tarefa.DataCriacao.ToShortDateString());

                listTarefas.Items.Add(item);
            }
        }

        private void GerarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
            {
                new ColumnHeader() { Text = "id", Width = 80 },
                new ColumnHeader() {Text = "Titulo", Width = 150},
                new ColumnHeader() { Text = "Data de criacao", Width = 100},
            };

            listTarefas.Columns.AddRange(colunas);
        }

        private void ConfigurarListView()
        {
            listTarefas.MultiSelect = false;
            listTarefas.FullRowSelect = true;
            listTarefas.GridLines = true;

            listTarefas.View = View.Details;
        }
    }
}
