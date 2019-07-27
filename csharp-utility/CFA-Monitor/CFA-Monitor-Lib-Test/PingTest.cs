using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CFA;

namespace CFA_Monitor_Lib_Test
{
    [TestClass]
    public class PingTest
    {
        [TestMethod]
        public void PingLocalhost()
        {
            var testobj = new CFA.Net();
            Assert.IsTrue(testobj.CFAPing("localhost"));
            Assert.IsTrue(testobj.CFAPing("127.0.0.1"));
        }

        [TestMethod]
        public void PingRemotehost()
        {
            var testobj = new CFA.Net();
            Assert.IsTrue(testobj.CFAPing("10.132.162.21"));
        }

        [TestMethod]
        public void PingRemoteHostName()
        {
            var testobj = new CFA.Net();
            Assert.IsFalse(testobj.CFAPing("Jedi-Host"));
        }

        [TestMethod]
        public void PingFailRemote()
        {
            var testobj = new CFA.Net();
            Assert.IsFalse(testobj.CFAPing("10.132.162.29"));
        }
    }
}
