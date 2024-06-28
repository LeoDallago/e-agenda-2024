using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public interface IRepositorioCategoria
    { 
        void Cadastrar(Categoria novaCategoria);
        bool Editar(int idSelecionado, Categoria categoriaEditada);
        bool Excluir(int idSelecionado);
        Categoria SelecionarPorId(int idSelecionado);
        List<Categoria> SelecionarTodos();
    }
}
