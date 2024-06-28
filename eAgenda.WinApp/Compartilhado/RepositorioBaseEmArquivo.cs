using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eAgenda.WinApp.Compartilhado
{
    public class RepositorioBaseEmArquivo<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();

        protected int contadorId = 1;

        private string caminho = string.Empty;


        public RepositorioBaseEmArquivo(string nomeArquivo) 
        {
            caminho = $"C:\\temp\\eAgenda\\{nomeArquivo}.json";

            registros = DeserealizarRegistros();

            if (registros.Count > 0)
            {
                contadorId = registros.Max(r => r.Id) + 1;
            }
        }

        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);

            SerealizarRegistros();
        }

        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            SerealizarRegistros();

            return true;
        }

        public bool Excluir(int id)
        {
            bool conseguiuExcluir =  registros.Remove(SelecionarPorId(id));

            if(!conseguiuExcluir)
                return false;

            SerealizarRegistros();

            return true;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public T SelecionarPorId(int id)
        {
            return registros.Find(c => c.Id == id);
        }

        public bool Existe(int id)
        {
            return registros.Any(c => c.Id == id);
        }

        protected void SerealizarRegistros()
        {
            FileInfo arquivo = new(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve

            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros,options);

            File.WriteAllBytes(caminho , registrosEmBytes);
        }

        protected List<T> DeserealizarRegistros()
        {
            FileInfo arquivo = new(caminho);

            if(!arquivo.Exists)
                return new List<T>();

            byte[] registrosEmBytes =  File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve

            };

            List<T> registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes,options);

            return registros;
        }
    }
}
