﻿using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;

        public ControladorCompromisso(IRepositorioCompromisso repositorio)
        {
            repositorioCompromisso = repositorio;
        }

        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso existente"; } }

        public string ToolTipFiltrar { get { return "Filtar compromissos"; } }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            DialogResult resultado = telaCompromisso.ShowDialog();

            if(resultado != DialogResult.OK)
                return;

            Compromisso novoCompromisso = telaCompromisso.Compromisso;

            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarComprimisso();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Compromisso ADICIONADO com sucesso!");
        }

        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm ();

            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            if(idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            telaCompromisso.Compromisso = repositorioCompromisso.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso compromissoEditado = telaCompromisso.Compromisso;


            repositorioCompromisso.Editar(idSelecionado, compromissoEditado);

            CarregarComprimisso ();

            TelaPrincipalForm
              .Instancia
                .AtualizarRodape($"Cadastro \"{idSelecionado}\" editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você realmente deseja excluir \"{idSelecionado}\"?  ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if( resposta != DialogResult.Yes )
                return;


            repositorioCompromisso.Excluir(idSelecionado);

            CarregarComprimisso();

            TelaPrincipalForm
             .Instancia
             .AtualizarRodape("Cadastro EXCLUIDO com sucesso!");
        }

        public void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();

            DialogResult resultado = telaFiltro.ShowDialog();

            if( resultado != DialogResult.OK)
                return;

            TipoFiltroCompromissoEnum filtroSelecionado = telaFiltro.FiltroEscolhido;

            List<Compromisso> compromissosSelecionados;


            if (filtroSelecionado == TipoFiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPassados();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosFuturos();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Periodo)
            {
                DateTime dataInicio = telaFiltro.InicioPeriodo;
                DateTime dataTermino = telaFiltro.TerminoPeriodo;
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataInicio,dataTermino);
            }

            else compromissosSelecionados = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registros");
        }

        private void CarregarComprimisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
               tabelaCompromisso = new TabelaCompromissoControl();

            CarregarComprimisso();

            return tabelaCompromisso;
            
        }
    }
}
