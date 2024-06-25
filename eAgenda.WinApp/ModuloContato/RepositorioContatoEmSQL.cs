using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmSQL : IRepositorioContato
    {
        public string enderecoBanco;

        public RepositorioContatoEmSQL()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=eAgendaDb;Integrated Security=True;Pooling=False";
        }


        public void Cadastrar(Contato novoContato)
        {
            string sqlInserir =
                @"
                INSERT INTO [TBContato] VALUES (
	                @Nome,
                    @Telefone,
                    @Email,
                    @Empresa,
                    @Cargo
                    ); SELECT SCOPE_IDENTITY();
                    ";

            
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfiguarParametrosContato(novoContato, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();
            novoContato.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }


        public bool Editar(int idSelecionado, Contato contadoEditado)
        {
            string sqlEditar =
                @"UPDATE [TBContato]	
		            SET
			            [Nome] = @Nome,
			            [Telefone] = @Telefone,
			            [Email] = @Email,
			            [Empresa] = @Empresa,
			            [Cargo] = @Cargo
		            WHERE
			            [Id] = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            contadoEditado.Id = idSelecionado;

            ConfiguarParametrosContato(contadoEditado, comandoEdicao);

            conexaoComBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();


            conexaoComBanco.Close();

            if (numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int idSelecionado)
        {
            string sqlExcluir =
              @"DELETE FROM [TBContato]
		            WHERE
			            [Id] = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", idSelecionado);

            conexaoComBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosExcluidos < 1)
                return false;

            return true;
        }

        public Contato SelecionarPorId(int idSelecionado)
        {
            string sqlSelecionarPorId = @"SELECT*FROM [TBContato] WHERE [Id] = @Id";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("Id", idSelecionado);

            conexaoComBanco.Open();

          SqlDataReader leitor =  comandoSelecao.ExecuteReader();

            Contato contato = null;

            if (leitor.Read())
            {
                contato = ConverterParaContato(leitor);
            }

            conexaoComBanco.Close();
            return contato;
        }

        public List<Contato> SelecionarTodos()
        {
            string sqlSelecionarTodos = @"select*from [TBContato];";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorContato = comandoSelecao.ExecuteReader();

            List<Contato> contatos = new List<Contato>();

            while (leitorContato.Read())
            {
                Contato contato = ConverterParaContato(leitorContato);
                contatos.Add(contato);
            }
            conexaoComBanco.Close();

            return contatos;
        }

        private static Contato ConverterParaContato(SqlDataReader leitorContato)
        {
            return new()
            {
                Id = Convert.ToInt32(leitorContato["Id"]),
                Nome = Convert.ToString(leitorContato["Nome"]),
                Telefone = Convert.ToString(leitorContato["Telefone"]),
                Email = Convert.ToString(leitorContato["Email"]),
                Empresa = Convert.ToString(leitorContato["Empresa"]),
                Cargo = Convert.ToString(leitorContato["Cargo"]),
            };
        }

        private static void ConfiguarParametrosContato(Contato novoContato, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("Id", novoContato.Id);
            comandoInsercao.Parameters.AddWithValue("Nome", novoContato.Nome);
            comandoInsercao.Parameters.AddWithValue("Telefone", novoContato.Telefone);
            comandoInsercao.Parameters.AddWithValue("Email", novoContato.Email);
            comandoInsercao.Parameters.AddWithValue("Empresa", novoContato.Empresa);
            comandoInsercao.Parameters.AddWithValue("Cargo", novoContato.Cargo);
        }
    }
}
