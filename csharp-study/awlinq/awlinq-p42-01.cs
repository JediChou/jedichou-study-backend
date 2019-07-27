using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program 
{
	public static void Main()
	{
		int[] nums = new int[] {0,4,2,6,3,8,3,1};
		
		// Extension method format
		var result1 = nums.Where(n=>n<5).OrderBy(n=>n);
		var output = result1.ToList();
		foreach(var elt in output)
			Console.WriteLine("result1 elt: {0}", elt);

		// Query Expresion format
		var result2 = from n in nums
				      where n < 5
					  orderby n
					  select n;
		var output2 = result2.ToList();
		foreach(var elt in output2)
			Console.WriteLine("result2 elt: {0}", elt);

		// Query Dot syntax
		var result3 = (from n in nums
						where n < 5
						orderby n
						select n).Distinct();
		var output3 = result3.ToList();
		foreach(var elt in output3)
			Console.WriteLine("result3 elt: {0}", elt);
	}
}
