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

        [TestMethod]
        public void TestCalcoloMisterioso1()
        {
            int n = 6;
            long valore_aspettato = 1440;
            long resp = Calc.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = 3;
            long valore_aspettato = 12;
            long resp = Calc.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso3()
        {
            int n = 2;
            int valore_aspettato = -6;
            long resp = Calc.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso4()
        {
            int n = 5;
            int valore_aspettato = -360;
            long resp = Calc.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso5()
        {
            int n = 7;
            int valore_aspettato = -15120;
            long resp = Calc.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double min = Calc.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa1()
        {
            double[] valori = new double[] { 8, 10.25, -5.2, 9.6 };
            double valore_aspettato = 2;
            double min = Calc.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }


    }
}

