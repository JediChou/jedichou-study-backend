using System;
using System.Collections.Generic;

namespace testwash
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(checkWash(6));
		}
		
		public static int checkWash(int n)
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
}