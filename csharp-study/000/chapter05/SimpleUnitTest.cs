using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest
{
    [TestClass]
    public class SimpleUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stp = new Stopwatch();
            stp.Start();
            for(int i = 0; i < 10000; i++) {
                var temp = i;
            }
            stp.Stop();

            Assert.IsTrue(stp.Elapsed.Seconds < 1);
        }
    }
}
