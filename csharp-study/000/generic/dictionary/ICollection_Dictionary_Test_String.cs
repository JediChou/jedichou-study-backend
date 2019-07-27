using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic
{
    [TestClass]
    public class GenericCollectionDictionaryTestString
    {
        [TestMethod]
        public void GenericCollection_Dicitionary_Add_Test()
        {
            var dict = new Dictionary<string, string> {{"1", "Adele"},{"2","Beyonce"}};
            Assert.AreEqual(2, dict.Count);

            // Add some record to dict
            dict.Add("3", "Jessie");
            Assert.AreEqual(3, dict.Count);
            Assert.IsTrue(dict.ContainsValue("Jessie"));
        }

        [TestMethod]
        public void GenericCollection_Dictionary_Clear_Test()
        {
            var dict = new Dictionary<string, string> {{"1","Adele"},{"2", "Beyonce" }};
            dict.Clear();
            Assert.AreEqual(0, dict.Count);
        }

        [TestMethod, Ignore]
        public void GenericCollection_Dictionary_Contains_Test()
        {
            // var firstSonger = new DictionaryEntry("1", "Adele");
            // var dict = new Dictionary<string, string> {{"1","Adele"},{"2","Beyonce"}};
            // TODO 按提示需使用Linq
        }

        [TestMethod, Ignore]
        public void GenericCollection_Dictionary_CopyTo_Test()
        {
            // var dict = new Dictionary<int, int> { { 1, 1 }, { 2, 2 } };
            // var dictArray = new DictionaryEntry[20];
            // TODO Dictionary的示例无CopyTo方法
        }

        [TestMethod]
        public void GenericCollection_Dictionary_Remove_Test()
        {
            var dict = new Dictionary<string, string> {{"1","1"},{"2","2"}};
            dict.Remove("2");
            Assert.IsTrue(dict.ContainsKey("1"));
            Assert.IsTrue(dict.ContainsValue("1"));
        }

        [TestMethod]
        public void GenericCollection_Dictionary_Count_Test()
        {
            var dict = new Dictionary<string, string> {{"1","1"},{"2","2"}};
            Assert.AreEqual(2, dict.Count);
            dict.Add("3", "3");
            Assert.AreEqual(3, dict.Count);
        }

        [TestMethod, Ignore]
        public void GenericCollection_Dictionary_IsReadOnly_Test()
        {
            // var dict = new Dictionary<int, int> { { 1, 1 }, { 2, 2 } };
            // Assert.IsFalse(dict.IsReadOnly);
            // TODO 实例没有IsReadOnly属性
        }
    }
}
