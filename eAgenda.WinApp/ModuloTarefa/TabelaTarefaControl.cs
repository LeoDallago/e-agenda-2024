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
            listTarefas.Groups.Clear();

          var tarefasAgrupadas = tarefas.GroupBy(t => t.Prioridade);

            foreach (var item in tarefasAgrupadas)
            {
                ListViewGroup listViewGroup = new ListViewGroup($"Prioridade {item.Key}", HorizontalAlignment.Left);

                listTarefas.Groups.Add(listViewGroup);

                foreach (Tarefa tarefa in item)
                {
                    ListViewItem subItem = new ListViewItem(tarefa.Id.ToString())
                    {
                        Tag = tarefa,                    
                    };

                    subItem.SubItems.Add(tarefa.Titulo);
                    subItem.SubItems.Add(tarefa.DataCriacao.ToShortDateString());

                    subItem.Group = listViewGroup;

                     listTarefas.Items.Add(subItem);
                }

            }

        }

        public int ObterIdSelecionado()
        {
            if(listTarefas.SelectedItems.Count == 0)
                return -1;

            var tarefaSelecionada =  (Tarefa)listTarefas.SelectedItems[0].Tag;

            return tarefaSelecionada.Id;
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
