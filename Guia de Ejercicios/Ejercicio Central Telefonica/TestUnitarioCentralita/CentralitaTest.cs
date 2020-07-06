using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace TestUnitarioCentralita
{
    [TestClass]
    public class CentralitaTest
    {
        /// <summary>
        /// Verifica que la lista se halla instanciado y que no es nula.
        /// </summary>
        [TestMethod]
        public void VerificarListaLlamadasInstanciada_OK()
        {
            //arrange
            Centralita testCentralita = new Centralita();
            bool listaEsNula;

            //act
            listaEsNula = Object.Equals(testCentralita, null);

            //assert
            Assert.IsFalse(listaEsNula);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarLocalCentralitaException_OK()
        {
            //arrange
            Centralita centralitaTest = new Centralita();
            Local local1 = new Local("Avellaneda", 45, "Lanus", 2.65f);
            Local local2 = new Local("Avellaneda", 30, "Lanus", 2.30f);

            //act
            centralitaTest += local1;

            centralitaTest += local2;
        }
        [TestMethod]
        public void VerificarLocalCentralitaExceptionAssert_OK()
        {
            //arrange
            Centralita centralitaTest = new Centralita();
            Local local1 = new Local("Avellaneda", 45, "Lanus", 2.65f);
            Local local2 = new Local("Avellaneda", 30, "Lanus", 2.30f);

            //act
            centralitaTest += local1;

            try
            {
                centralitaTest += local2;
            }
            catch (Exception ex)
            {
                //assert
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void VerificarProvincialCentralitaException_OK()
        {
            //arrange
            Centralita centralitaTest = new Centralita();
            Provincial provincial1 = new Provincial("Avellaneda", Provincial.Franja.Franja_1, 45, "Lanus");
            Provincial provincial2 = new Provincial("Avellaneda", Provincial.Franja.Franja_3, 30, "Lanus");

            //act
            centralitaTest += provincial1;

            centralitaTest += provincial2;
        }

        [TestMethod]
        public void VerificarProvincialCentralitaExceptionAssert_OK()
        {
            //arrange
            Centralita centralitaTest = new Centralita();
            Provincial provincial1 = new Provincial("Avellaneda", Provincial.Franja.Franja_1, 45, "Lanus");
            Provincial provincial2 = new Provincial("Avellaneda", Provincial.Franja.Franja_3, 30, "Lanus");

            //act
            centralitaTest += provincial1;

            try
            {
                centralitaTest += provincial2;
            }
            catch (Exception ex)
            {
                //assert
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
        }
    }
}
