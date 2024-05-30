using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();


            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.DataCompromisso >=  DateTime.Today)
                {
                    compromissosFuturos.Add(compromisso);
                }
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();


            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.DataCompromisso < DateTime.Now)
                {
                    compromissosFuturos.Add(compromisso);
                }
            }

            return compromissosFuturos;
        }
    }
}
