using System.Linq;
using cscorner_libs.Feature;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cscorner_test
{
    [TestClass]
    public class MethodParameterTest
    {
        [TestMethod]
        public void AddTest_TC1()
        {
            var actual = MethodParameter.Add(0, 0, null);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void AddTest_TC2()
        {
            var actual = MethodParameter.Add(1, 0, null);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddTest_TC3()
        {
            var actual = MethodParameter.Add(1, 0);
            Assert.AreEqual(1, actual);

            actual = MethodParameter.Add(0, 1);
            Assert.AreEqual(1, actual);

            actual = MethodParameter.Add(3, 4);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void AddTest_TC4()
        {
            var intList = new int[] { };
            var actual = MethodParameter.Add(1, 0, intList);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddTest_TC5()
        {
            var intList = new int[] { };
            var actual = MethodParameter.Add(0, 1, intList);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void AddTest_TC6()
        {
            var intList = new[] { 1 };
            var actual = MethodParameter.Add(0, 1, intList);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Simple()
        {
            var intList = new[] { 1, 2, 3 };
            var actual = MethodParameter.Add(0, 1, intList.ToArray());
            Assert.AreEqual(7, actual);
        }
    }
}
