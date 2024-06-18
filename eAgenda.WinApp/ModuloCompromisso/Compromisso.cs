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
        public DateTime DataCompromisso { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Contato {  get; set; }
        public string Localização { get; set; }
        public string Local { get; set; }

        public TipoCompromissoEnum TipoCompromisso
        {
            get
            {
                TipoCompromissoEnum tipoSelcionado;
                
                if(Local.Length > 0)
                 tipoSelcionado = TipoCompromissoEnum.Presencial;
                else
                 tipoSelcionado = TipoCompromissoEnum.Remoto;

                return tipoSelcionado;
            }
        }

        public Compromisso(string assunto, DateTime dataCompromisso, DateTime inicio, DateTime termino, string contato, string local)
        {
            Assunto = assunto;
            DataCompromisso = dataCompromisso;
            Inicio = inicio;
            Termino = termino;
            Contato = contato;
            Local = local;
            Localização = TipoCompromisso.ToString();
        }

        public Compromisso()
        {
            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório");

            if (DataCompromisso == null)
                erros.Add("O campo \"Data\" é obrigatório");

            if (DataCompromisso == null)
                erros.Add("O campo \"inicio\" é obrigatório");

            if (DataCompromisso == null)
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
            Local = atualizado.Local;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Data: {DataCompromisso}," +
                $" Inicio: {Inicio} Termino: {Termino}, Contato: {Contato}, " +
                $"Local: {Local}, Localização: {TipoCompromisso}";
        }
    }
}
