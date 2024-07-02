using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace eAgenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {

        public string Titulo {  get; set; }
        public PrioridadeTarefaEnum Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }

      public List<ItemTarefa> Itens {  get; set; }

        public decimal PercentualConcluido
        {
            get
            {
                if (Itens.Count == 0)
                    return 0;

                int qtdConcluido = Itens.Count(i => i.Concluido);

                decimal percentual = (qtdConcluido / Itens.Count) * 100;

                return Math.Round(percentual,2);
            }
        }

        public Tarefa(string titulo, PrioridadeTarefaEnum prioridade)
        { 
            Titulo = titulo;
            Prioridade = prioridade;
            DataCriacao = DateTime.Now;
            DataConclusao = DateTime.MinValue;

            Itens = new List<ItemTarefa>();
        }

        public bool AdicionarItem(ItemTarefa item)
        {
            if(Itens.Exists(i => i.Titulo == item.Titulo))  
                return false;

            item.Tarefa = this;
            Itens.Add(item);

            DataConclusao = DateTime.MinValue;

            return true;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tarefa nova = (Tarefa)novoRegistro;

            Titulo = nova.Titulo;
            Prioridade = nova.Prioridade;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"titulo\" eh obrigatorio ");

            return erros;
        }
    }
}
