using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonoCSharpStudy.collections
{
    [TestClass]
	public class Mono_StackTest
	{
        [TestMethod]
		public void Mono_Stack_PushTest ()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			var alpha_array = alpha.ToArray ();
			Assert.AreEqual ('C', alpha_array [0]);
			Assert.AreEqual ('B', alpha_array [1]);
			Assert.AreEqual ('A', alpha_array [2]);
		}

        [TestMethod]
		public void Mono_Stack_ClearTest()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');
			alpha.Clear ();

			var alpha_array = alpha.ToArray ();
			Assert.AreEqual (0, alpha_array.Length);
		}

        [TestMethod]
		public void Mono_Stack_CloneTest()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			var alpha_clone = alpha.Clone ();
			Assert.AreEqual("System.Collections.Stack", alpha_clone.GetType ().ToString());
			// TODO, some clone feature does not test.
		}

        [TestMethod]
		public void Mono_Stack_CopyTo()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			var alpha_OneDimension = new char[30];
			alpha.CopyTo (alpha_OneDimension, 0);
			Assert.AreEqual ('C', alpha_OneDimension [0]);
			Assert.AreEqual ('B', alpha_OneDimension [1]);
			Assert.AreEqual ('A', alpha_OneDimension [2]);
		}

        [TestMethod]
		public void Mono_Stack_GetEnumerator()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			var alpha_enumerator = alpha.GetEnumerator ();
			alpha_enumerator.MoveNext(); Assert.AreEqual ('C', alpha_enumerator.Current);
			alpha_enumerator.MoveNext(); Assert.AreEqual ('B', alpha_enumerator.Current);
			alpha_enumerator.MoveNext(); Assert.AreEqual ('A', alpha_enumerator.Current);
		}

        [TestMethod]
		public void Mono_Stack_Peek()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			Assert.AreEqual ('C', alpha.Peek ());
			Assert.AreEqual (3, alpha.Count);
		}

        [TestMethod]
		public void Mono_Stack_Pop()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');

			Assert.AreEqual ('C', alpha.Pop ());
			Assert.AreEqual (2, alpha.Count);
		}

        [TestMethod]
		public void Mono_Stack_Push()
		{
			var alpha = new Stack ();
			alpha.Push ('A');
			alpha.Push ('B');
			alpha.Push ('C');
			alpha.Push ('D');

			Assert.AreEqual ('D', alpha.Peek ());
			Assert.AreEqual (4, alpha.Count);
		}

        [TestMethod, Ignore]
		public void Mono_Stack_ToArray()
		{
			// TODO, doesn't implemented.
		}
	}
}
