namespace LinqInAction.Chapter01.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class List0108Tests
    {
        public static List0108 listcode;
        public static List<string> result;

        [TestInitialize]
        public void Init()
        {
            listcode = new List0108();
            result = listcode.OldSchoolHello();
        }

        [TestMethod]
        public void OldSchoolHello_ContainTest()
        {
            Assert.IsTrue(result.Contains("hello"));
            Assert.IsTrue(result.Contains("linq"));
            Assert.IsTrue(result.Contains("world"));
        }

        [TestMethod]
        public void HelloLinqTest_LocationVerify()
        {
            Assert.AreEqual(0, result.IndexOf("hello"));
            Assert.AreEqual(1, result.IndexOf("linq"));
            Assert.AreEqual(2, result.IndexOf("world"));
        }
    }
}