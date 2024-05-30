
namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissoForm : Form
    {
       public TipoFiltroCompromissoEnum FiltroEscolhido { get; private set; }

        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Todos;

            else if (rdbFuturos.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Futuros;
            
            else if (rdbPassados.Checked) 
                FiltroEscolhido = TipoFiltroCompromissoEnum.Passados;
        }
    }
}
