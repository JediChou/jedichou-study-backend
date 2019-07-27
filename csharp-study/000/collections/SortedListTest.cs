using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpStudy.collections
{
	[TestClass]
	public class SortedListTest
	{
		[TestMethod]
		public void SortedList_Add ()
		{
			var alpha = new SortedList ();
			alpha.Add (1, 'A');
			Assert.AreEqual (1, alpha.Count);
		}

		[TestMethod]
		public void SortedList_Clear()
		{
			var alpha = new SortedList ();
			alpha.Add (1, 'A');
			alpha.Add (2, 'B');
			alpha.Clear ();
			Assert.AreEqual (0, alpha.Count);
		}

		[TestMethod]
		public void SortedList_Clone()
		{
			var alpha = new SortedList ();
			var alpha_clone = alpha.Clone ();
			Assert.AreEqual ("System.Collections.SortedList", alpha_clone.GetType ().ToString ());
		}

		[TestMethod]
		public void SortedList_ConstransKey()
		{
			var alpha = new SortedList ();
			alpha.Add (1, 'A');
			Assert.IsTrue(alpha.ContainsKey (1));
		}

		[TestMethod, Ignore]
		public void SortedList_CopyTo()
		{
			var alpha = new SortedList ();
			var alpha_array = new string[20];
			alpha.Add (1, 'A');
			alpha.CopyTo (alpha_array, 0);
			Assert.AreEqual ('A', alpha_array [0]);
            // TODO, must be fix
		}

        [TestMethod]
        public void SortedList_GetByIndex()
        {
            var alpha = new SortedList();
         
            alpha.Add(1, 'A');
            Assert.AreEqual('A', alpha.GetByIndex(0));

            alpha.Add(2, 'B');
            Assert.AreEqual('B', alpha.GetByIndex(1));

            Assert.AreEqual(2, alpha.Count);
        }

        [TestMethod, Ignore]
        public void SortedList_GetEnumerator()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'B');

            var alpha_enumerator = alpha.GetEnumerator(); // <- is a dictionary
            alpha_enumerator.MoveNext();
            Assert.AreEqual('A', alpha_enumerator.Current);
        }

        [TestMethod]
        public void SortedList_GetKey()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'B');

            // Use index to get key's value.
            Assert.AreEqual(1, alpha.GetKey(0));
            Assert.AreEqual(2, alpha.GetKey(1));
        }

        [TestMethod]
        public void SortedList_GetKeyList()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'A');

            var alpha_keylist = alpha.GetKeyList();
            Assert.AreEqual(2, alpha_keylist.Count);
            Assert.AreEqual(1, alpha_keylist[0]);
            Assert.AreEqual(2, alpha_keylist[1]);
        }

        [TestMethod]
        public void SortedList_GetValueList()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'A');

            var alpha_valuelist = alpha.GetValueList();
            foreach (var elt in alpha_valuelist)
                Assert.AreEqual('A', elt);
        }

        [TestMethod]
        public void SortedList_Remove()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'B');
            alpha.Remove(1);
            Assert.AreEqual(1, alpha.Count);
            Assert.AreEqual('B', alpha.GetByIndex(0));
        }

        [TestMethod]
        public void SortedList_RemoveAt()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'B');
            alpha.RemoveAt(0);
            Assert.AreEqual('B', alpha.GetByIndex(0));
        }

        [TestMethod]
        public void SortedList_SetByIndex()
        {
            var alpha = new SortedList();
            alpha.Add(1, 'A');
            alpha.Add(2, 'B');
            alpha.SetByIndex(0, 'C');
            Assert.AreEqual('C', alpha.GetByIndex(0));
        }
	}
}

