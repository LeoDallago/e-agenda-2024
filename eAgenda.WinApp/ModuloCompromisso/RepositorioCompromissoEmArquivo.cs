using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioBaseEmArquivo<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo() : base("compromissos")
        {

        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.FindAll(r => r.DataCompromisso > DateTime.Today);
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            return registros.FindAll(r => r.DataCompromisso <= DateTime.Today);
        }

        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime inicio, DateTime termino)
        {
            return registros.FindAll(r => r.DataCompromisso <= termino && r.DataCompromisso >= inicio);
        }
    }
}
