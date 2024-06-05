using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase,IControladorSubItens
    {
        private TabelaTarefaControl listTarefas;
        private RepositorioTarefa repositorioTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string TipoCadastro { get { return "Tarefas"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma tarefa"; } }

        public override string ToolTipEditar { get { return "Editar uma tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir uma tarefa"; } }

        public string ToolTipItens  { get { return "Adicionar item"; } }

        public override void Adicionar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult resultado = telaTarefa.ShowDialog();

            // Guarda
            if (resultado != DialogResult.OK)
                return;

            Tarefa novaTarefa = telaTarefa.Tarefa;

            repositorioTarefa.Cadastrar(novaTarefa);

            CarregarTarefas();
        }

        public override void Editar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            int idSelecionado = listTarefas.ObterIdSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            telaTarefa.Tarefa = repositorioTarefa.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaTarefa.ShowDialog();

            //Guarda
            if (resultado != DialogResult.OK)
                return;


            Tarefa tarefaEditda = telaTarefa.Tarefa;

            repositorioTarefa.Editar(idSelecionado, tarefaEditda);

            CarregarTarefas();
        }

        public override void Excluir()
        {
           int idSelecionado = listTarefas.ObterIdSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta =  MessageBox.Show(
                $"Você realmente deseja excluir \"{idSelecionado}\"?  ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if( resposta != DialogResult.Yes )
                return;


            repositorioTarefa.Excluir(idSelecionado);

            CarregarTarefas();
        }

        public void AdicionarItens()
        {
            int idSelecionado = listTarefas.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if(tarefaSelecionada == null)
            {
                    MessageBox.Show("Por favor, selecione uma tarefa",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    return;
            }

            TelaCadastroItemTarefa tela = new TelaCadastroItemTarefa(tarefaSelecionada);

            DialogResult resultado  = tela.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            List<ItemTarefa> itens = tela.ItensAdicionados;

            repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

            CarregarTarefas();

        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefas.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if (listTarefas == null)
                listTarefas = new TabelaTarefaControl();

            CarregarTarefas();

            return listTarefas;
        }

    }
}
