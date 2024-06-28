using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class ControladorCategoria : ControladorBase
    {
        public IRepositorioCategoria repositorioCategoria;
        public TabelaCategoriaControl tabelaCategoria;

        public ControladorCategoria(IRepositorioCategoria repositorio)
        {
            repositorioCategoria = repositorio;
        }

        public override string TipoCadastro => "Categoria";

        public override string ToolTipAdicionar => "Adicionar uma CATEGORIA";

        public override string ToolTipEditar => "Editar uma CATEGORIA";

        public override string ToolTipExcluir => "Excluir uma CATEGORIA";

        public override void Adicionar()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();

            // Guarda
            if (resultado != DialogResult.OK)
                return;

            Categoria novaCategoria = telaCategoria.Categoria;

            repositorioCategoria.Cadastrar(novaCategoria);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cadastro ADICIONADO com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();

            CarregarCategorias();

            return tabelaCategoria;
        }
    }
}
