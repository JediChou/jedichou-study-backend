// LinqQuery_UseOfTypeFilte.cs
// Ref: C#与.NET4高级程序设计-第5版
// Jedi Chou, 2016.3.19 12:48

using System;
using System.Collections;
using System.Linq;

class LinqQuery_UseOfTypeFilte
{
	class Car
    {
        public string PetName {get; set;}
        public string Color {get; set;}
        public int Speed {get; set;}
        public string Make {get; set;}
    }
	
	static void Main(string[] args)
	{
		ArrayList myStuff = new ArrayList();
		myStuff.AddRange(new object[] {
			10, 400, 8, false, new Car(), "string data"
		});
		
		// use ofType<int> to filter object
		var myInts = myStuff.OfType<int>();
		foreach(int elt in myInts)
			Console.WriteLine(elt);
	}
}