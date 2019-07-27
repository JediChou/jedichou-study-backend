using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CFA;

namespace CFA_Monitor_Lib_Test
{
    [TestClass]
    public class PortTest
    {
        [TestMethod]
        public void PortTestLocal()
        {
            var testobj = new CFA.Net();
            Assert.IsTrue(testobj.CFAPort("localhost", 80));
            //Assert.IsTrue(testobj.CFAPort("localhost", 135));
            //Assert.IsTrue(testobj.CFAPort("localhost", 443));
            //// Assert.IsTrue(testobj.CFAPort("loclahost", 445));  // TODO: avaliable
            //Assert.IsTrue(testobj.CFAPort("localhost", 1025));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1026));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1027));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1028));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1433));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1760));
            //Assert.IsTrue(testobj.CFAPort("localhost", 1765));
            //Assert.IsTrue(testobj.CFAPort("localhost", 2383));
        }


    }
}
