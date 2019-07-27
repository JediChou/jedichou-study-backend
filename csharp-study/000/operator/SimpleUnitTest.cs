using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Operator
{
    [TestClass]
    public class SimpleUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stp = new Stopwatch();
            stp.Start();
            for(var i = 0; i < 10000; i++) {
                var temp = i;
            }
            stp.Stop();

            Assert.IsTrue(stp.Elapsed.Seconds < 1);
        }
    }
}
