using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                listCompromisso.Items.Add(compromisso);
            }
        }

        public Compromisso ObterRegistroSelecionado()
        {
            if (listCompromisso.SelectedItem == null)
                return null;

            return (Compromisso)listCompromisso.SelectedItem;
        }

        private void ListagemCompromissoControl_Load(object sender, EventArgs e)
        {

        }

        private void listCompromisso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
