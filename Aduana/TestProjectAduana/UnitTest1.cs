using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aduana;

namespace TestProjectAduana
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TienePrioridadDeberiaRetornarTrue()
        {
            //arrange
            PaqueteFragil pf = new PaqueteFragil("11",100,"Mar del Plata", "Buenos Aires", 10);
            //act
            bool respuesta = pf.TienePrioridad;
            //assert
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void TienePrioridadDeberiaRetornarFalse()
        {
            //arrange
            PaquetePesado pp = new PaquetePesado("11", 100, "Mar del Plata", "Buenos Aires", 100);
            //act
            bool respuesta = pp.TienePrioridad;
            //assert
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //arrange
            PaquetePesado pp = new PaquetePesado("11", 100, "Mar del Plata", "Buenos Aires", 100);
            //act
            decimal respuesta = pp.Impuestos;
            //assert
            Assert.AreEqual(35, respuesta);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //arrange
            PaquetePesado pp = new PaquetePesado("11", 100, "Mar del Plata", "Buenos Aires", 100);
            //act
            decimal respuesta = pp.AplicarImpuestos();
            //
            Assert.AreEqual(135, respuesta);
        }
    }
}
