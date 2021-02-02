using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestione;

namespace EsercitazioneTest
{
    [TestClass]
    public class Operazioni
    {

            [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 2;
            long valore_aspettato = 4;
            long resp = Calc.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato , resp);
        }

    }
}

