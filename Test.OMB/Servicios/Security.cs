using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios;

namespace Test.OMB.Servicios
{
    [TestClass]
    public class Security
    {
        [TestMethod]
        public void ProbarLoginConDatosIncorrectos()
        {
            SecurityServices serv = new SecurityServices();
            bool result;

            result = serv.Login("pirulo", "pepe");

            Assert.IsFalse(result, "Hay un Usuario pirulo????");
        }

        [TestMethod]
        public void ProbarLoginConDatosCorrectos()
        {
            SecurityServices serv = new SecurityServices();
            bool result;

            result = serv.Login("ethedy", "12345678");

            Assert.IsTrue(result, "Usuario No Existe");
        }
    }
}
