using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic.list
{
    [TestClass]
    public class CollectionTestString
    {
        [TestMethod]
        public void ICollectionTest_String_Add_Test()
        {
            var list = new List<string> {"Jedi", "Chou"};
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("Jedi", list[0]);
            Assert.AreEqual("Chou", list[1]);
        }

        [TestMethod]
        public void ICollectionTest_String_Clear_Test()
        {
            var list = new List<string> {"Jedi", "Chou"};
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ICollectionTest_String_Contains_Test()
        {
            var list = new List<string> {"Jedi", "Chou"};
            Assert.IsTrue(list.Contains("Jedi"));
            Assert.IsTrue(list.Contains("Chou"));
        }

        [TestMethod]
        public void ICollectionTest_String_CopyTo_Test()
        {
            var list = new List<String>();
            var listCopy = new string[20];
            list.Add("Jedi");
            list.Add("Chou");
            list.CopyTo(listCopy, 0);
            Assert.AreEqual("Jedi", listCopy[0]);
            Assert.AreEqual("Chou", listCopy[1]);
        }

        [TestMethod]
        public void ICollectionTest_String_Remove_Test()
        {
            var list = new List<string> {"Jedi", "Chou"};
            list.Remove("Jedi");
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Chou", list[0]);
        }

        [TestMethod]
        public void ICollectionTest_String_Count_Test()
        {
            // Create a list instance
            var list = new List<string>();
            Assert.AreEqual(0, list.Count);

            // After add
            list.Add("Jedi");
            Assert.AreEqual(1, list.Count);
        }        
    }
}
