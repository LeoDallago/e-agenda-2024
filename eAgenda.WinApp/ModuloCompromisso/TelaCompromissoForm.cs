using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {

            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                dateTimeData.Text = value.DataCompromisso;
                txtInicio.Text = value.Inicio;
                txtTermino.Text = value.Termino;
                txtContato.Text = value.Contato;
                txtLocalizacao.Text = value.Local;
            }

            get { return compromisso; }


        }

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string data = dateTimeData.Text;
            string inicio = txtInicio.Text;
            string termino = txtTermino.Text;
            string contato = txtContato.Text;
            string local = txtLocalizacao.Text;

            compromisso = new Compromisso(assunto, data, inicio, termino, contato, local);
        }

        private void TelaCompromissoForm_Load(object sender, EventArgs e)
        {

        }

        private void rdPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalizacao.Visible = true;

        }

        private void rdRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalizacao.Text = null;
            txtLocalizacao.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelContato.Visible = true;
            txtContato.Visible = true;
        }
    }
}
