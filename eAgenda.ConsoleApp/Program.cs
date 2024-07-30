using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eAgenda.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*eAgendaDbContext dbContext = new eAgendaDbContext();

            var tarefa = new Tarefa { Titulo = "ola mundo", Prioridade = PrioridadeTarefaEnum.Media, DataCriacao = DateTime.Now, DataConclusao = DateTime.Now };
            dbContext.Tarefas.Add(tarefa);
            dbContext.SaveChanges();

            var tarefas = dbContext.Tarefas.OrderBy(t => t.Id).ToList();
            Console.Clear();
            foreach (Tarefa item in tarefas)
            {
                Console.Write($"{item.Id} ");
                Console.Write($"{item.Titulo} ");
                Console.Write($"{item.Prioridade} ");
                Console.WriteLine();
            }*/
        }
    }



}
