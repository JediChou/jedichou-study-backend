using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonoCSharpStudy.collections
{
	[TestClass]
	public class Mono_QueueTest
	{
		[TestMethod]
		public void Mono_Queue_CountProperty ()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');

			Assert.AreEqual (3, alpha.Count);
		}

		[TestMethod]
		public void Mono_Queue_Clear()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Clear ();

			Assert.AreEqual (0, alpha.Count);
		}

		[TestMethod]
		public void Mono_Queue_Clone()
		{
			var alpha = new Queue ();
			var alpha_clone = alpha.Clone ();
			Assert.AreEqual ("System.Collections.Queue", alpha_clone.GetType().ToString());
		}

		[TestMethod]
		public void Mono_Queue_CopyTo()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');
			var alpha_array = new char[20];
			alpha.CopyTo (alpha_array, 0);

			Assert.AreEqual ('A', alpha_array[0]);
			Assert.AreEqual ('B', alpha_array[1]);
			Assert.AreEqual ('C', alpha_array[2]);
		}

		[TestMethod]
		public void Mono_Queue_Dequeue()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');

			alpha.Dequeue ();
			Assert.AreEqual ('B', alpha.Peek ());
			Assert.AreEqual (2, alpha.Count);
		}

		[TestMethod]
		public void Mono_Queue_Enqueue()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');

			// Current
			Assert.AreEqual (3, alpha.Count);
			Assert.AreEqual ('A', alpha.Peek ());

			// After Enqueue
			alpha.Enqueue ('D');
			Assert.AreEqual (4, alpha.Count);
			Assert.AreEqual ('A', alpha.Peek ());
		}

		[TestMethod]
		public void Mono_Queue_GetEnumerator()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');

			var alpha_Enumerator = alpha.GetEnumerator ();
			alpha_Enumerator.MoveNext (); Assert.AreEqual ('A', alpha_Enumerator.Current);
			alpha_Enumerator.MoveNext (); Assert.AreEqual ('B', alpha_Enumerator.Current);
			alpha_Enumerator.MoveNext (); Assert.AreEqual ('C', alpha_Enumerator.Current);
		}

		[TestMethod]
		public void Mono_Queue_Peek()
		{
			var alpha = new Queue ();
			Assert.AreEqual (0, alpha.Count);

			alpha.Enqueue ('A');
			Assert.AreEqual (1, alpha.Count);
			Assert.AreEqual ('A', alpha.Peek ());
		}

        //[Test]
        //[ExpectedException("System.InvalidOperationException")]
        //public void Mono_Queue_Peek_QueueWithOutElements()
        //{
        //    var alpha = new Queue ();
        //    alpha.Peek ();
        //}

		[TestMethod]
		public void Mono_Queue_ToArray()
		{
			var alpha = new Queue ();
			alpha.Enqueue ('A');
			alpha.Enqueue ('B');
			alpha.Enqueue ('C');

			var alpha_array = alpha.ToArray ();
			Assert.AreEqual ('A', alpha_array [0]);
			Assert.AreEqual ('B', alpha_array [1]);
			Assert.AreEqual ('C', alpha_array [2]);
		}
	}
}

