using System;
using System.Text;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest.collections
{
    [TestClass]
    public class DictionaryEntryTest
    {
        [TestMethod]
        public void DictionaryEntry_Construct_Test()
        {
            var dict = new DictionaryEntry(1, 2);
            Assert.AreEqual(1, dict.Key);
            Assert.AreEqual(2, dict.Value);
        }

        [TestMethod]
        public void DictionaryEntry_Construct2_Test()
        {
            var dict1 = new DictionaryEntry(1, "Test");
            var dict2 = new DictionaryEntry("t", "Test");

            // Compare dict1's key and value
            Assert.AreEqual(1, dict1.Key);
            Assert.AreEqual("Test", dict1.Value);

            // Compare dict2's key and value
            Assert.AreEqual("t", dict2.Key);
            Assert.AreEqual("Test", dict2.Value);
        }

        [TestMethod]
        public void DictionaryEntry_Set_Test()
        {
            var dict = new DictionaryEntry(1, 1);
            dict.Key = 2;
            dict.Value = 2;
            Assert.AreEqual(2, dict.Key);
            Assert.AreEqual(2, dict.Value);
        }

        [TestMethod]
        public void DictionaryEntry_ToString_Test()
        {
            var dict = new DictionaryEntry(1, 1);
            Assert.AreEqual("System.Collections.DictionaryEntry", dict.ToString());
        }

        [TestMethod]
        public void DictionaryEntry_GetType_Test()
        {
            var dict = new DictionaryEntry(1, 1);
            Assert.AreEqual("System.Collections.DictionaryEntry", dict.GetType().ToString());
        }
    }
}
