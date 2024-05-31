
namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TipoFiltroCompromissoEnum FiltroEscolhido { get; private set; }

        public DateTime InicioPeriodo 
        {
            get
            {
                return txtInicio.Value;
            }
                
        }

        public DateTime TerminoPeriodo 
        {
            get 
            { 
                return txtTermino.Value; 
            } 
        }

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

            else if (rdbPeriodo.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Periodo;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeriodo.Checked)
            {
                labelInicio.Visible = true;
                txtInicio.Visible = true;
                labelTermino.Visible = true;
                txtTermino.Visible = true;
            }
            else
            {
                labelInicio.Visible = false;
                txtInicio.Visible = false;
                labelTermino.Visible = false;
                txtTermino.Visible = false;
            }
        }
    }
}
