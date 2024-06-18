using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBaseEmMemoria<Tarefa>
    {
        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (ItemTarefa item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
        }
    }
}
