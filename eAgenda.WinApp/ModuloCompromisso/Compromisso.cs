using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string DataCompromisso { get; set; }
        public string Inicio { get; set; }
        public string Termino { get; set; }
        public string Contato {  get; set; }
        public string Localização { get; set; }

        public Compromisso(string assunto, string dataCompromisso, string inicio, string termino, string contato, string localizacao)
        {
            Assunto = assunto;
            DataCompromisso = dataCompromisso;
            Inicio = inicio;
            Termino = termino;
            Contato = contato;
            Localização = localizacao;
          //  Id = id;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório");

            if (string.IsNullOrEmpty(DataCompromisso.Trim()))
                erros.Add("O campo \"Data\" é obrigatório");

            if (string.IsNullOrEmpty(Inicio.Trim()))
                erros.Add("O campo \"inicio\" é obrigatório");

            if (string.IsNullOrEmpty(Termino.Trim()))
                erros.Add("O campo \"termino\" é obrigatório");

            if (string.IsNullOrEmpty(Contato.Trim()))
                erros.Add("O campo \"contato\" é obrigatório");

            if (string.IsNullOrEmpty(Localização.Trim()))
                erros.Add("O campo \"localização\" é obrigatorio");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            DataCompromisso = atualizado.DataCompromisso;
            Inicio = atualizado.Inicio;
            Termino = atualizado.Termino;
            Contato = atualizado.Contato;
            Localização = atualizado.Localização;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Data: {DataCompromisso}," +
                $" Inicio: {Inicio} Termino: {Termino}, Contato: {Contato}, " +
                $"Localizacao: {Localização}";
        }
    }
}
