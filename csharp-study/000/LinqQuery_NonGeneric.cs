// LinqQuery_NonGeneric.cs
// Ref: C#与.NET4高级程序设计-第5版
// Jedi Chou, 2016.3.19 12:46

using System;
using System.Collections;
using System.Linq;

class LinqQuery_NonGeneric
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
		Console.WriteLine("***** Linq over ArrayList *****");
		
		ArrayList myCars = new ArrayList() {
			new Car {PetName="Henry", Color="Silver", Speed=100, Make="BMW"},
            new Car {PetName="Daisy", Color="Tan", Speed=90, Make="BMW"},
            new Car {PetName="Mary", Color="Black", Speed=55, Make="VW"},
            new Car {PetName="Clunker", Color="Rust", Speed=5, Make="Yugo"}
		};
		
		// get a IEnumerable<T> object
		var myCarsEnum = myCars.OfType<Car>();
		
		// create a Linq query
		var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
		
		// Output
		foreach(var car in fastCars)
			Console.WriteLine("{0} is going to fast!", car.PetName);
	}
}