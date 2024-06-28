using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class RepositorioCatagoriaEmArquivo : RepositorioBaseEmArquivo<Categoria> , IRepositorioCategoria
    {
        public RepositorioCatagoriaEmArquivo() : base("Categoria")
        {
        }
    }
}
