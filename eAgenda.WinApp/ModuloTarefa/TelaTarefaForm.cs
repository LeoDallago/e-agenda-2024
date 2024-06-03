using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa 
        {
            get 
            {
                return tarefa; 
            }
            set 
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                comboBoxPrioridades.SelectedItem = value.Prioridade;
            }
        }

        public TelaTarefaForm()
        {
            InitializeComponent();

            CarregarEnumPrioridades();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)Enum.Parse(typeof(PrioridadeTarefaEnum),comboBoxPrioridades.Text);

            tarefa = new Tarefa(titulo,prioridade);

            
        }

        private void CarregarEnumPrioridades()
        {
            Array valoresEnum = Enum.GetNames(typeof(PrioridadeTarefaEnum));

            foreach (var valor in valoresEnum)
                comboBoxPrioridades.Items.Add(valor);

            comboBoxPrioridades.SelectedItem = PrioridadeTarefaEnum.Baixa;
        }

    }
}
