using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeriCalc.Ch1;

namespace NumeriCalcTest.Ch1Test
{
    [TestClass]
    public class Sample0102Test
    {
        [TestMethod]
        public void 测试_修正精度不足导致违反加法结合律()
        {
            var expected = Sample0102.修正精度不足导致违反加法结合律();
            Assert.IsTrue(expected);
        }
    }
}
