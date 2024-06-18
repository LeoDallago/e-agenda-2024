using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioBaseEmMemoria<Compromisso>,IRepositorioCompromisso
    {

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
