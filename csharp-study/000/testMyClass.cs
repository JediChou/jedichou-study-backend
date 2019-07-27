using System;
using NUnit.Framework;
using System.Collections.Generic;
using CoverageSample;

namespace CoverageSample
{
	[TestFixture]
	public class testMyClass
	{
		/// <summary>
	/// Description: a static library for test coverage.
	/// </summary>
	public class MyClass
	{
		/// <summary>
		/// Execute a add method sytanx
		/// </summary>
		/// <param name="num1">The first number</param>
		/// <param name="num2">The Second number</param>
		/// <returns></returns>
		public int addMethod(int num1, int num2)
		{
			return num1 + num2;
		}
		
		public int subMethod(int num1, int num2)
		{
			return num1 - num2;
		}
		
		public int findMax(List<int> lst)
		{
			int tmp = int.MinValue;
			foreach(int elt in lst)
				if (elt > tmp)
					tmp = elt;
			
			return tmp;
		}
		
		public bool checkRetange(int a, int b, int c)
		{ 
			if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a)
	            return true;				
			else 
				return false;
		}
		
		public int checkWash(int n)
		{
			List<int> lst = new List<int>();
			List<int> tmp = new List<int>();
			List<int> tmplst1 = new List<int>();
			List<int> tmplst2 = new List<int>();
			int counter = 0;
			
			if(n%2 != 0)
				return -1;
			else
				for(int i=0; i<n; i++)
				{
					lst.Add(i);
					tmp.Add(i);
				}
			
			while(true)
			{				
				// step-1: 把奇數位的元素放入tmplist1
				// step-2: 把偶數位的元素放入tmplist2
				for(int i=0; i<n; i++)
					if((i+1)%2 != 0)
						tmplst1.Add(tmp[i]);
					else
						tmplst2.Add(tmp[i]);
				
				// step-3: 由tmplist1,tmplist2生成新序列tmp
				for(int i=0; i<tmplst1.Count; i++)
				{
					tmp.Add(tmplst1[i]);
					tmp.Add(tmplst2[i]);
				}				        
				
				// step-4: counter += 1
				counter += 1;
				
				// step-4: 比較兩者是否相等
				if(lst == tmp)
					break;
				else
				{
					tmplst1.Clear();
					tmplst2.Clear();
				}
			}
			
			return counter;
		}
	}
		
		
		[Test]
		public void TestMethod()
		{
			Assert.AreEqual(2, 2);
			Assert.AreEqual(3.0, 3.0);
			Assert.AreEqual(true, true);
			Assert.AreEqual(false, false);
			Assert.AreEqual("string", "string");
		}
		
		[Test]
		public void testAddMethod()
		{
			MyClass testobj = new MyClass();
			Assert.AreEqual(2, testobj.addMethod(1,1));
		}
		
		[Test]
		public void testSubMethod()
		{
			MyClass testobj = new MyClass();
			Assert.AreEqual(1, testobj.subMethod(10,9));
		}
		
		[Test]
		public void testFindMax()
		{
			MyClass testobj = new MyClass();
			List<int> lst = new List<int>();
			lst.Add(1);
			lst.Add(2);
			lst.Add(3);
			lst.Add(4);
			
			Assert.AreEqual(4, testobj.findMax(lst));
			Assert.AreEqual(4, lst.Count);
		}
		
		[Test]
		public void testcheckRetange()
		{
			MyClass testobj = new MyClass();
			Assert.AreEqual(true, testobj.checkRetange(3,4,5));
			Assert.AreEqual(false, testobj.checkRetange(2,5,2));
		}
		
		[Test]
		public void testCheckWash()
		{
			MyClass testobj = new MyClass();
			
			List<int> lst1 = new List<int>();
			lst1.Add(1);
			lst1.Add(2);
			
			List<int> lst2 = new List<int>();
			lst2.Add(1);
			lst2.Add(2);
			
			Assert.AreEqual(-1, testobj.checkWash(3));
			Assert.AreEqual(4,  testobj.checkWash(6));
		}
	}
}
