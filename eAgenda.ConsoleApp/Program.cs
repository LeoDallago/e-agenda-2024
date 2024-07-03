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

            eAgendaDbContext dbContext = new eAgendaDbContext();

            //var tarefa = new Tarefa { Titulo = "ola mundo", Prioridade = PrioridadeTarefaEnum.Media, DataCriacao = DateTime.Now, DataConclusao = DateTime.Now };
            //dbContext.Tarefas.Add(tarefa);
            //dbContext.SaveChanges();

            var tarefas = dbContext.Tarefas.OrderBy(t => t.Id).ToList();
            Console.Clear();
            foreach (Tarefa item in tarefas)
            {
                Console.Write($"{item.Id} ");
                Console.Write($"{item.Titulo} ");
                Console.Write($"{item.Prioridade} ");
                Console.WriteLine();
            }
        }
    }

    public class eAgendaDbContext : DbContext
    { 
        public DbSet<Tarefa> Tarefas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=eAgendaDb;Integrated Security=True;Pooling=False";

            optionsBuilder.UseSqlServer(connectionString);  

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>(tarefaBuilder => {
                tarefaBuilder.ToTable("TBTarefa");
                
               tarefaBuilder.Property(t => t.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                tarefaBuilder.Property(t => t.Titulo)
                .IsRequired()
                .HasColumnType("varchar(150)");

                tarefaBuilder.Property(t => t.Prioridade)
                .IsRequired()
                .HasColumnType("varchar(150)");

                tarefaBuilder.Property(t => t.DataCriacao)
                .HasColumnType("varchar(150)");

                tarefaBuilder.Property(t => t.DataConclusao)
                .HasColumnType("varchar(150)");
            });
        }
    }


}
