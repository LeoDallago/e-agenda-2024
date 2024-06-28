using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        public IRepositorioDespesa repositorioDespesa;
        public IRepositorioCategoria repositorioCategoria;
        public TabelaDespesaControl tabelaDespesa;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string TipoCadastro => "Despesas";

        public override string ToolTipAdicionar => "Cadastrar uma DESPESA";

        public override string ToolTipEditar => "Editar uma DESPESA";

        public override string ToolTipExcluir => "Excluir uma DESPESA";

        public override void Adicionar()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();
            telaDespesa.CarregarCategorias(categorias);

            DialogResult resultado = telaDespesa.ShowDialog();

            // Guarda
            if (resultado != DialogResult.OK)
                return;

            Despesa novaDespesa = telaDespesa.Despesa;

            repositorioDespesa.Cadastrar(novaDespesa);

            repositorioDespesa.AdicionarCategorias(novaDespesa, telaDespesa.CategoriasSelecionadas);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cadastro ADICIONADO com sucesso!");
        }

        public override void Editar()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm();

            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();
            telaDespesa.CarregarCategorias(categorias);

            int idSelecionado = tabelaDespesa.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            telaDespesa.Despesa = repositorioDespesa.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaDespesa.ShowDialog();

            // Guarda
            if (resultado != DialogResult.OK)
                return;

            Despesa despesaEditada = telaDespesa.Despesa;

            repositorioDespesa.Editar(idSelecionado,despesaEditada);

            repositorioDespesa.AtualizarCatagorias(despesaEditada, telaDespesa.CategoriasSelecionadas, telaDespesa.CategoriasDesmarcadas);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cadastro ADICIONADO com sucesso!");
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        private void CarregarCategorias()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarCategorias();

            return tabelaDespesa;
        }
    }
}
