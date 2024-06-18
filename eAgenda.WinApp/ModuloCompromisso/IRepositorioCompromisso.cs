using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Cadastrar(Compromisso novoCompromisso);
        bool Editar(int idSelecionado, Compromisso compromissoEditado);
        bool Excluir(int idSelecionado);
        List<Compromisso> SelecionarCompromissosFuturos();
        List<Compromisso> SelecionarCompromissosPassados();
        List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino);
        Compromisso SelecionarPorId(int idSelecionado);
        List<Compromisso> SelecionarTodos();
    }
}
