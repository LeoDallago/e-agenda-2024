using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda_Teste_Unitario
{
    [TestClass]
    [TestCategory("eAgenda Unitario")]
    public class UnitTest1
    {
        [TestMethod]
        public void Faz_Contato_Corretamente()
        {
            //Arrange
            string nome = "fulano";
            string telefone = "12344321";
            string email = "leo@leo.com";
            string empresa = "test";
            string cargo = "test";
            
            //Act
            Contato contato = new Contato(nome,telefone, email, empresa,cargo);

            //Assert
            Assert.IsNotNull(nome,telefone,email);
        }


        [TestMethod]
        public void Faz_Compromisso_Corretamente()
        {
            //Arrange
            string assunto = "Fazer teste";
            DateTime dataCompromisso = DateTime.Today;
            DateTime dataInicio = DateTime.Now;
            DateTime dataTermino = DateTime.Now;
            string contato = "fulano";
            string local = "visual studio";

            //Act
            Compromisso compromisso = new Compromisso(assunto,dataCompromisso,dataInicio,dataTermino,contato,local);

            //Assert
            Assert.AreEqual(dataCompromisso,DateTime.Today);
            Assert.IsNotNull(assunto);
        }
    }
}