using System.Data;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;

        public Despesa Despesa 
        {
            get
            {
                return despesa;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                txtValor.Text = value.Valor.ToString();
                dateTimePicker.Value = value.Data;
                cmbFormaPagamento.SelectedItem = value.FormaPagamento;

                int contadorCategoriaSelecionada = 0;

                for (int i = 0; i < listCategorias.Items.Count; i++)
                {
                    Categoria categoria = (Categoria)listCategorias.Items[i];

                    if (value.Categorias.Any(c => c.Id == categoria.Id))
                        listCategorias.SetItemChecked(contadorCategoriaSelecionada,true);

                    contadorCategoriaSelecionada++;
                }
            }
        }

        public List<Categoria> CategoriasSelecionadas
        {
            get
            {
                return listCategorias.CheckedItems
                         .Cast<Categoria>()
                         .ToList();
            }
        }

        public List<Categoria> CategoriasDesmarcadas
        {
            get
            {
                return listCategorias.CheckedItems
                         .Cast<Categoria>()
                         .Except(CategoriasSelecionadas)
                         .ToList();
            }
        }


        public TelaDespesaForm()
        {
            InitializeComponent();

            CarregarFormaDePagamento();
        }

        public void CarregarCategorias(List<Categoria> categorias)
        {
            foreach(Categoria item in categorias) 
                listCategorias.Items.Add(item);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            DateTime data = dateTimePicker.Value;
            FormaPagamentoEnum formaPagamento = (FormaPagamentoEnum)cmbFormaPagamento.SelectedItem;

            despesa = new Despesa(descricao,valor,data,formaPagamento);
            List<string> erros = despesa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }

        private void CarregarFormaDePagamento()
        {
            var formasDePagamento = Enum.GetValues(typeof(FormaPagamentoEnum));

            foreach (var item in formasDePagamento)
            {
                cmbFormaPagamento.Items.Add(item);
            }
        }
    }
}
