using eAgenda.WinApp.ModuloContato;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoSQL : IRepositorioCompromisso
    {
       public string enderecoBanco;

        public RepositorioCompromissoSQL()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=eAgendaDb;Integrated Security=True;Pooling=False";
        }

        public void Cadastrar(Compromisso novoCompromisso)
        {
            string sqlInserir =
                 @"
                    INSERT INTO [TBCompromisso] VALUES (
                        @Assunto,
                        @DataCompromisso,
                        @Inicio,
                        @Termino,
                        @Contato,
                        @Localizacao,
                        @Local
                    ); SELECT SCOPE_IDENTITY();
                ";

            SqlConnection conexaoBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoBanco);

            ConfiguarParametrosCompromisso(novoCompromisso, comandoInsercao);

            conexaoBanco.Open();

            object id = comandoInsercao.ExecuteScalar();
            novoCompromisso.Id = Convert.ToInt32(id);

            conexaoBanco.Close();

            //continuar daqui elaborar resto CRUD
        }

        public bool Editar(int idSelecionado, Compromisso compromissoEditado)
        {
            string sqlEditar =
                @"UPDATE [TBCompromisso]
                    SET
                        [Assunto] = @Assunto,
                        [DataCompromisso] = @DataCompromisso,
                        [Inicio] = @Inicio,
                        [Termino] = @Termino,
                        [Contato] = @Contato,
                        [Localizacao] = @Localizacao,
                        [Local] = @Local

                    WHERE [Id] = @Id;
                    ";

            SqlConnection conexaoBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoBanco);

            compromissoEditado.Id = idSelecionado;

            ConfiguarParametrosCompromisso(compromissoEditado, comandoEdicao);

            conexaoBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();

            conexaoBanco.Close();

            if(numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int idSelecionado)
        {
            string sqlExcluir =  @"DELETE FROM [TBCompromisso] WHERE [Id] = @Id;";

            SqlConnection conexaoBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoBanco);

            comandoExclusao.Parameters.AddWithValue("Id", idSelecionado);

            conexaoBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            conexaoBanco.Close();

            if(numeroRegistrosExcluidos < 1)
                return false;

            return true;
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            throw new NotImplementedException();
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            throw new NotImplementedException();
        }

        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            throw new NotImplementedException();
        }

        public Compromisso SelecionarPorId(int idSelecionado)
        {
            string sqlSelecionarPorId = @"SELECT*FROM [TBCompromisso] WHERE [Id] = @Id;";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("Id", idSelecionado);

            conexaoComBanco.Open();

            SqlDataReader leitor = comandoSelecao.ExecuteReader();

            Compromisso compromisso = null;

            if (leitor.Read())
            {
                compromisso = ConverterParaCompromisso(leitor);
            }

            conexaoComBanco.Close();

            return compromisso;
        }

        public List<Compromisso> SelecionarTodos()
        {
            string sqlSelecionarTodos = @"select*from [TBCompromisso];";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorCompromisso = comandoSelecao.ExecuteReader();

            List<Compromisso> compromissos = new List<Compromisso>();

            while (leitorCompromisso.Read())
            {
                Compromisso compromisso = ConverterParaCompromisso(leitorCompromisso);
                compromissos.Add(compromisso);
            }

            conexaoComBanco.Close();

            return compromissos;
        }

        private static Compromisso ConverterParaCompromisso(SqlDataReader leitorCompromisso)
        {
            return new()
            {
                Id = Convert.ToInt32(leitorCompromisso["Id"]),
                Assunto = Convert.ToString(leitorCompromisso["Assunto"]),
                DataCompromisso = Convert.ToDateTime(leitorCompromisso["DataCompromisso"]),
                Inicio = Convert.ToDateTime(leitorCompromisso["Inicio"]),
                Termino = Convert.ToDateTime(leitorCompromisso["Termino"]),
                Contato = Convert.ToString(leitorCompromisso["Contato"]),
                Localização = Convert.ToString(leitorCompromisso["Localizacao"]),
                Local = Convert.ToString(leitorCompromisso["Local"]),
            };
        }


        private static void ConfiguarParametrosCompromisso(Compromisso novoCompromisso, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("Id", novoCompromisso.Id);
            comandoInsercao.Parameters.AddWithValue("Assunto", novoCompromisso.Assunto);
            comandoInsercao.Parameters.AddWithValue("DataCompromisso", novoCompromisso.DataCompromisso.ToString());
            comandoInsercao.Parameters.AddWithValue("Inicio", novoCompromisso.Inicio.ToString());
            comandoInsercao.Parameters.AddWithValue("Termino", novoCompromisso.Termino.ToString());
            comandoInsercao.Parameters.AddWithValue("Contato", novoCompromisso.Contato);
            comandoInsercao.Parameters.AddWithValue("Localizacao", novoCompromisso.Localização);
            comandoInsercao.Parameters.AddWithValue("Local", novoCompromisso.Local);
        }
    }
}
