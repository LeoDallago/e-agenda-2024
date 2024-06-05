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

    public partial class TelaCadastroItemTarefa : Form
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
                tarefa = value;
            }
        }

       public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }

        }
        public TelaCadastroItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            Tarefa = tarefaSelecionada;

            lblTituloTarefa.Text = tarefaSelecionada.Titulo;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
            {
                listItensTarefa.Items.Add(item); 
            }
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            List<string> listaTitulo = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (listaTitulo.Contains(txtTitulo.Text))
                return;

            ItemTarefa itemTarefa = new ItemTarefa(txtTitulo.Text);

            listItensTarefa.Items.Add(itemTarefa);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
