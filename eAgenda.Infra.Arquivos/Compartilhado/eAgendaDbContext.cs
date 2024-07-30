using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace eAgenda.Infra.Arquivos.Compartilhado;

public class eAgendaDbContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }
    
    public DbSet<Contato> Contatos { get; set; }

    public DbSet<Compromisso> Compromissos { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        string connectionString = config.GetConnectionString("SqlServer");

        
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

        modelBuilder.Entity<Contato>(contatoBuilder =>
        {
            contatoBuilder.ToTable("TBContato");

            contatoBuilder.Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            contatoBuilder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            contatoBuilder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(100)");

            contatoBuilder.Property(c => c.Email)
                .HasColumnType("varchar(250)");

            contatoBuilder.Property(c => c.Empresa)
                .HasColumnType("varchar(250)");

            contatoBuilder.Property(c => c.Cargo)
                .HasColumnType("varchar(250)");
        });

        modelBuilder.Entity<Compromisso>(compromissoBuilder =>
        {
            compromissoBuilder.ToTable("TBCompromisso");

            compromissoBuilder.Property(cp => cp.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            compromissoBuilder.Property(cp => cp.Assunto)
                .IsRequired()
                .HasColumnType("varchar(250)");

            compromissoBuilder.Property(cp => cp.DataCompromisso)
                .IsRequired()
                .HasColumnType("DATETIME2");

            compromissoBuilder.Property(cp => cp.Inicio)
                .IsRequired()
                .HasColumnType("DATETIME2");

            compromissoBuilder.Property(cp => cp.Termino)
                .IsRequired()
                .HasColumnType("DATETIME2");

            compromissoBuilder.Property(cp => cp.Contato)
                .HasColumnType("varchar(250)");

            compromissoBuilder.Property(cp => cp.Localização)
                .IsRequired()
                .HasColumnType("varchar(250)");

            compromissoBuilder.Property(cp => cp.Local)
                .HasColumnType("varchar(250)");
        });
        
        base.OnModelCreating(modelBuilder);
    }
}