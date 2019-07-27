using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic.list
{
    [TestClass]
    public class CollectionTestObject
    {
        [TestMethod]
        public void ICollectionTest_Object_Add_Test()
        {
            var list = new List<Person> {new Person("Taylor"), new Person("Tobaco")};
            Assert.AreEqual("Taylor", list[0].Name);
            Assert.AreEqual("Tobaco", list[1].Name);
        }

        [TestMethod]
        public void ICollectionTest_Object_Clear_Test()
        {
            var list = new List<Person> {new Person("Taylor"), new Person("Tobaco")};
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ICollectionTest_Object_Contains_Test()
        {
            var list = new List<Person>();
            var taylor = new Person("Taylor");
            var taylorClone = taylor;
            list.Add(taylor);
            Assert.IsTrue(list.Contains(taylorClone));

            // After change
            taylorClone.Name = "Fuck Samsung";
            Assert.AreEqual("Fuck Samsung", list[0].Name);
        }

        [TestMethod]
        public void ICollectionTest_Object_CopyTo_Test()
        {
            var list = new List<Person> {new Person("Taylor"), new Person("Tobaco")};
            var listCopy = new Person[20];
            list.CopyTo(listCopy, 0);
            Assert.AreEqual("Taylor", listCopy[0].Name);
            Assert.AreEqual("Tobaco", listCopy[1].Name);
        }

        [TestMethod]
        public void ICollectionTest_Object_Remove_Test()
        {
            var list = new List<Person>();
            var taylor = new Person("Taylor");
            var tobaco = new Person("Tobaco");
            list.Add(taylor);
            list.Add(tobaco);
            list.Remove(taylor);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Tobaco", list[0].Name);
        }

        [TestMethod]
        public void ICollectionTest_String_Count_Test()
        {
            // Create a list instance
            var list = new List<Person>();
            Assert.AreEqual(0, list.Count);

            // After add
            list.Add(new Person("Taylor"));
            Assert.AreEqual(1, list.Count);
        }
    }
}
