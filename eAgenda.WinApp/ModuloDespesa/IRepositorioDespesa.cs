using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public interface IRepositorioDespesa
    {
        void Cadastrar(Despesa novaDespesa);
        bool Editar(int idSelecionado, Despesa despesaEditada);
        bool Excluir(int idSelecionado);
        Despesa SelecionarPorId(int idSelecionado);
        List<Despesa> SelecionarTodos();
        void AdicionarCategorias(Despesa despesa, List<Categoria>categorias);
        void AtualizarCatagorias(Despesa despesaEditada, List<Categoria> categoriasSelecionadas, List<Categoria> categoriasDesmarcadas);
    }
}
