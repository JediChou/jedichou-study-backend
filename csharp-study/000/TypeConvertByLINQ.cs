using System;
using System.Collections;
using System.Linq;
using System.Text;

public class MyClass
{
	public static void Main()
	{
		int[] arr = new int[] {1,2,3,4,5};
		float[] arr2 = arr.Select( x => (float)x).ToArray();
		float sample = 3f;
		
		Console.WriteLine(sample + " " + sample.GetType().ToString());
		foreach(float elt in arr2)
			Console.WriteLine(elt + " " + elt.GetType().ToString());
	}
}
