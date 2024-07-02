using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloContato
{
    public interface IRepositorioContato
    {
        void Cadastrar(Contato novoContato);
        bool Editar(int idSelecionado, Contato contadoEditado);
        bool Excluir(int idSelecionado);
        Contato SelecionarPorId(int idSelecionado);
        List<Contato> SelecionarTodos();
    }
}
