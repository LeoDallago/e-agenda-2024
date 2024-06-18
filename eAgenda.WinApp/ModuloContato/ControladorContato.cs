using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private IRepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContato;

        public ControladorContato(IRepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }

        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult resultado = telaContato.ShowDialog();

            // Guarda
            if (resultado != DialogResult.OK)
                return;
            
             Contato novoContato = telaContato.Contato;

             repositorioContato.Cadastrar(novoContato);

             CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cadastro ADICIONADO com sucesso!");
        }


        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            int idSelecionado = tabelaContato.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            telaContato.Contato = repositorioContato.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaContato.ShowDialog();

            //Guarda
            if(resultado != DialogResult.OK) 
                return;


            Contato contadoEditado = telaContato.Contato;

            repositorioContato.Editar(idSelecionado, contadoEditado);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"Cadastro \"{idSelecionado}\" , \"{contadoEditado.Nome}\" editado com sucesso!");
        }

        public override void Excluir()
        {
           int idSelecionado = tabelaContato.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta =  MessageBox.Show(
                $"Você realmente deseja excluir \"{idSelecionado}\"?  ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if( resposta != DialogResult.Yes )
                return;


            repositorioContato.Excluir(idSelecionado);

            CarregarContatos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape("Cadastro EXCLUIDO com sucesso!");
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            tabelaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaContato == null)
                tabelaContato = new TabelaContatoControl();

            CarregarContatos();

            return tabelaContato;
        }

    }
}
