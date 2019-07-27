using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic.list
{
    [TestClass]
    public class CollectionTestInt
    {
        [TestMethod]
        public void ICollectionTest_List_Add_Test()
        {
            var list = new List<int> {1, 2};
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
        }

        [TestMethod]
        public void ICollectionTest_List_Clear_Test()
        {
            var list = new List<int> {1, 2};
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ICollectionTest_List_Contains_Test()
        {
            var list = new List<int> {1, 2};
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(2));
        }

        [TestMethod]
        public void ICollectionTest_List_CopyTo_Test()
        {
            var list = new List<int>();
            var listCopy = new int[20];
            list.Add(1);
            list.Add(2);
            list.CopyTo(listCopy, 0);
            Assert.AreEqual(1, listCopy[0]);
            Assert.AreEqual(2, listCopy[1]);
        }

        [TestMethod]
        public void ICollectionTest_List_Remove_Test()
        {
            var list = new List<int> {1, 2};
            list.Remove(1);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(2, list[0]);
        }

        [TestMethod]
        public void ICollectionTest_List_Count_Test()
        {
            // Create a list instance
            var list = new List<int>();
            Assert.AreEqual(0, list.Count);

            // After add
            list.Add(1);
            Assert.AreEqual(1, list.Count);
        }        
    }
}
