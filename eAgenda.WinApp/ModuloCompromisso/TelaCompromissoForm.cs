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
            }

            get { return compromisso; }


        }

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
       private string valorRadioButton = "Nenhum valor atribuido";

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string data = dateTimeData.Text;
            string inicio = txtInicio.Text;
            string termino = txtTermino.Text;
            string contato = txtContato.Text;
            string localizacao = valorRadioButton;

            //if (rdPresencial.Checked)
            //    localizacao = rdPresencial.Text;

            //if(rdRemoto.Checked)
            //    localizacao = rdRemoto.Text;



            compromisso = new Compromisso(assunto, data, inicio, termino, contato, localizacao);
        }

        private void TelaCompromissoForm_Load(object sender, EventArgs e)
        {

        }

        private void rdPresencial_CheckedChanged(object sender, EventArgs e)
        {
            valorRadioButton = rdPresencial.Text;

        }

        private void rdRemoto_CheckedChanged(object sender, EventArgs e)
        {
            valorRadioButton = rdRemoto.Text;
        }
    }
}
