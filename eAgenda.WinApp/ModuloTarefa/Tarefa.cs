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

        public Tarefa(string titulo, PrioridadeTarefaEnum prioridade)
        {
            Titulo = titulo;
            Prioridade = prioridade;
            DataCriacao = DateTime.Now;
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
