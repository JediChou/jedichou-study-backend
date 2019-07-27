using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeriCalc.Ch1;

namespace NumeriCalcTest.Ch1Test
{
    [TestClass]
    public class Sample0101Test
    {
        [TestMethod]
        public void 测试_精度不足导致违反加法结合律()
        {
            var expected = Sample0101.精度不足导致违反加法结合律();
            Assert.IsFalse(expected);
        }
    }
}
