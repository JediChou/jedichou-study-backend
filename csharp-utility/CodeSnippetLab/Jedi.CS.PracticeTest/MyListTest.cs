using CodeSnippetLab.Practice032;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jedi.CS.PracticeTest
{
    /// <summary>
    /// MyListTest的測試類
    /// </summary>
    [TestClass]
    public class MyListTest
    {
        /// <summary>
        /// MyList构造函数的測試1
        /// </summary>
        [TestMethod]
        public void MyListConstructorTest1()
        {
            MyList target = new MyList(0);
            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        /// MyList构造函数的測試2
        /// </summary>
        [TestMethod]
        public void MyListConstructorTest2()
        {
            MyList target = new MyList(1);
            Assert.AreEqual(1, target.Count);
        }

        /// <summary>
        ///Item的測試
        ///</summary>
        [TestMethod]
        public void ItemTest()
        {
            MyList target = new MyList(1);
            target[0] = 123;
            Assert.AreEqual(123, target[0]);
        }
    }
}
