using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic
{
    [TestClass]
    public class GenericCollectionDictionaryTestObject
    {
        [TestMethod]
        public void GenericCollection_Dicitionary_Add_Test()
        {
            var dict = new Dictionary<int, Person> {{1, new Person("Adele")},{2,new Person("Beyonce")}};
            Assert.AreEqual(2, dict.Count);

            // Add some record to dict
            var jessie = new Person("Jessie");
            dict.Add(3, jessie);
            Assert.AreEqual(3, dict.Count);
            Assert.IsTrue(dict.ContainsValue(jessie));
        }

        [TestMethod]
        public void GenericCollection_Dictionary_Clear_Test()
        {
            var dict = new Dictionary<int, Person> {{1, new Person("Adele")}, {2, new Person("Beyonce")}};
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
            var adele = new Person("Adele");
            var beyonce = new Person("Beyonce");
            var dict = new Dictionary<int, Person> {{ 1, adele}, {2, beyonce}};
            dict.Remove(1);
            Assert.IsTrue(dict.ContainsKey(2));
            Assert.IsTrue(dict.ContainsValue(beyonce));
        }

        [TestMethod]
        public void GenericCollection_Dictionary_Count_Test()
        {
            var adele = new Person("Adele");
            var beyonce = new Person("Beyonce");
            var jessica = new Person("Jessica");
            
            var dict = new Dictionary<int, Person> {{1, adele}, {2, beyonce}};
            Assert.AreEqual(2, dict.Count);

            dict.Add(3, jessica);
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
