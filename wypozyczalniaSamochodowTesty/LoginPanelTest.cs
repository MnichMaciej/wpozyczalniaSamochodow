using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wypozyczalniaSamochodow;
using System.Windows.Forms;

namespace wypozyczalniaSamochodowTesty
{
    [TestClass]
    public class LoginPanelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var app = new App();
            var loginpanel = new LoginPanel();
            loginpanel.setParent(app);
            Assert.AreEqual(app, loginpanel.parent);
        }
    }
}
