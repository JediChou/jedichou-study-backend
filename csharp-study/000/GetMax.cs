using System;
using System.Collections;
using System.Collections.Generic;

namespace GetMax
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var numbers = new ArrayList();
			numbers.AddRange (new int[] { 34, 56, 77, 88, 99, -23});

			do {
				int max = GetGreater (numbers);
				Console.Write ("{0} ", max);
				numbers.Remove (max);
			} while(numbers.Count != 0);

		}

		static int GetGreater(ArrayList Numbers)
		{
			int max = (int)Numbers[0];
			foreach (int number in Numbers)
				if (number > max)
					max = number;
			return max;
		}
	}
}
