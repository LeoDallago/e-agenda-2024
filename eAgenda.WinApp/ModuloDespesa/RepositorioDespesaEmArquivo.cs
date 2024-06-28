using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioBaseEmArquivo<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo() : base("Despesas")
        {
        }

        public void AdicionarCategorias(Despesa despesa, List<Categoria> categorias)
        {
           foreach (Categoria categoria in categorias)
            {
                despesa.AtribuirCategoria(categoria);
                categoria.RegistrarDespesa(despesa);
            }

        }

        public void AtualizarCatagorias(Despesa despesaEditada, List<Categoria> categoriasSelecionadas, List<Categoria> categoriasDesmarcadas)
        {
            foreach (Categoria categoria in categoriasSelecionadas)
            {
                despesaEditada.AtribuirCategoria(categoria);
            };

            foreach (Categoria categoria in categoriasDesmarcadas)
            {
                despesaEditada.RemoverCategoria(categoria);
            };

        }
    }
}
