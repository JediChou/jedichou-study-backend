using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest.collections
{
    [TestClass]
    public class HashTableTest
    {
        [TestMethod]
        public void HashTable_Add_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            Assert.AreEqual(1, hashtable.Count);

            hashtable.Add(2, "2");
            Assert.AreEqual(2, hashtable.Count);
        }

        [TestMethod]
        public void HashTable_Clear_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            hashtable.Clear();
            Assert.AreEqual(0, hashtable.Count);
        }

        [TestMethod]
        public void HashTable_Clone_Test()
        {
            var hashtable = new Hashtable();
            var hashtable_clone = hashtable.Clone();
            Assert.AreEqual("System.Collections.Hashtable", hashtable_clone.GetType().ToString());
        }

        [TestMethod]
        public void HashTable_Contains_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            Assert.IsTrue(hashtable.Contains(1));
            Assert.IsTrue(hashtable.Contains(2));
        }

        [TestMethod]
        public void HashTable_ContainsKey_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            Assert.IsTrue(hashtable.ContainsKey(1));
            Assert.IsTrue(hashtable.ContainsKey(2));
        }

        [TestMethod]
        public void HashTable_ContainsValue_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            Assert.IsTrue(hashtable.ContainsValue("1"));
            Assert.IsTrue(hashtable.ContainsValue("2"));
        }

        [TestMethod]
        public void HashTable_CopyTo_Test()
        {
            var hashtable = new Hashtable();
            var hashtable_array = new object[20];
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            hashtable.CopyTo(hashtable_array, 0);

            // Get key and value from hashtable_array
            var result1 = (DictionaryEntry)hashtable_array[0];
            var result2 = (DictionaryEntry)hashtable_array[1];

            // Notice: the id is changed.
            Assert.AreEqual(2, result1.Key);
            Assert.AreEqual("2", result1.Value);
            Assert.AreEqual(1, result2.Key);
            Assert.AreEqual("1", result2.Value);
        }

        [TestMethod]
        public void HashTable_Equals_Test()
        {
            var hashtable1 = new Hashtable();
            var hashtable2 = hashtable1; 
            Assert.AreEqual(hashtable1, hashtable2);

            // After change
            hashtable1.Add(1, "1");
            Assert.AreEqual(hashtable1, hashtable2);
        }

        [TestMethod, Ignore]
        public void HashTable_Finalize_Test()
        {
            new Hashtable();
            System.GC.Collect();
            // TODO, need a special method to test it.
        }

        [TestMethod]
        public void HashTable_GetEnumerator_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            var hashtable_enum = hashtable.GetEnumerator();

            hashtable_enum.MoveNext();
            var result1 = hashtable_enum.Current;
            var result1_temp = (DictionaryEntry)result1;
            Assert.AreEqual("System.Collections.DictionaryEntry", result1.GetType().ToString());
            Assert.AreEqual(2, result1_temp.Key);
            Assert.AreEqual("2", result1_temp.Value);

            hashtable_enum.MoveNext();
            var result2 = hashtable_enum.Current;
            var result2_temp = (DictionaryEntry)result2;
            Assert.AreEqual("System.Collections.DictionaryEntry", result2.GetType().ToString());
            Assert.AreEqual(1, result2_temp.Key);
            Assert.AreEqual("1", result2_temp.Value);
        }

        [TestMethod, Ignore]
        public void HashTable_GeHash_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            
            // There is not GetHash() code.
            // var hashtable_hash = hashtable.GetHash();
        }

        [TestMethod]
        public void HashTable_GeHashCode_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            var hashtable_hash = hashtable.GetHashCode();
            Assert.IsNotNull(hashtable_hash);
        }

        [TestMethod]
        public void HashTable_GetType_Test()
        {
            var hashtable = new Hashtable();
            Assert.AreEqual("System.Collections.Hashtable", hashtable.GetType().FullName);
        }

        [TestMethod, Ignore]
        public void HashTable_KeyEquals_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            // TODO: need to fix it.
            // There is not KeyEquals
            // Assert.IsTrue(hashtable.KeyEquals)
        }

        [TestMethod, Ignore]
        public void HashTable_MemberwiseClone_Test()
        {
            // TODO: need to fix it
            // This method is from object, need special method to test it.
        }

        [TestMethod]
        public void HashTable_Remove_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            hashtable.Remove(1);
            Assert.AreEqual(1, hashtable.Count);

            Assert.IsTrue(hashtable.ContainsKey(2));
            Assert.IsTrue(hashtable.ContainsValue("2"));
        }

        [TestMethod, Ignore]
        public void HashTable_Synchronized_Test()
        {
        }

        [TestMethod]
        public void HashTable_ToString_Test()
        {
            var hashtable = new Hashtable();
            hashtable.Add(1, "1");
            hashtable.Add(2, "2");
            Assert.AreEqual("System.Collections.Hashtable", hashtable.ToString());
        }
    }

    [TestClass]
    public class EmployeeIDAndEmployeeDataTest
    {
        [TestMethod]
        public void TestEmployees()
        {
            // Define a hashtable 
            var employees = new Hashtable(31);

            // Define two EmployeeData object
            var idMortimer = new EmployeeID("B001");
            var Mortime = new EmployeeData(idMortimer, "Mortimer", 100000.00M);
            var idArbel = new EmployeeID("W234");
            var Arbel = new EmployeeData(idArbel, "Arbel", 10000.00M);

            employees.Add(idMortimer, Mortime);
            employees.Add(idArbel, Arbel);

            Assert.AreEqual(2, employees.Count);
        }
    }

    class EmployeeID
    {
        private readonly char prefix;
        private readonly int number;

        public EmployeeID(string id)
        {
            prefix = (id.ToUpper())[0];
            number = int.Parse(id.Substring(1, 3));
        }

        public override string ToString()
        {
            return prefix.ToString() + string.Format("{0,3:000}", number);
        }

        public override bool Equals(object obj)
        {
            EmployeeID rhs = obj as EmployeeID;
            if (rhs == null)
                return false;
            if (prefix == rhs.prefix && number == rhs.number)
                return true;
            return false;
        }
    }

    class EmployeeData
    {
        private string name;
        private decimal salary;
        private EmployeeID id;

        public EmployeeData(EmployeeID id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(id.ToString(), 100);
            sb.Append(":");
            sb.Append(string.Format("{0,-20}", name));
            sb.Append(" ");
            sb.Append(string.Format("{0:C}", salary));
            return sb.ToString();
        }

    }
}
