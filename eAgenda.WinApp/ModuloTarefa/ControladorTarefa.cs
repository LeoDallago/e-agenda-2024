﻿using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private TabelaTarefaControl listTarefas;
        private RepositorioTarefa repositorioTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string TipoCadastro { get { return "Tarefas"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma tarefa"; } }

        public override string ToolTipEditar { get { return "Editar uma tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir uma tarefa"; } }

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefas.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if (listTarefas == null)
                listTarefas = new TabelaTarefaControl();

            CarregarTarefas();

            return listTarefas;
        }
    }
}