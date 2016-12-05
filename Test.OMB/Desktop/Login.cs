using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMB_Desktop;
using OMB_Desktop.ViewModel;

namespace Test.OMB.Desktop
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginFallidoSinUsuario()
        {
            LoginViewModel lvm = new LoginViewModel();
            bool evento = false;
            lvm.Password = "1234";
            lvm.LoginID = null;

            lvm.FaltanDatos.Raised += (s, a) => 
            {
                evento = true;
            };
            lvm.LoginCommand.Execute(null);
            Assert.IsTrue(evento); 
        }
    }
}
