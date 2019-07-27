// LinqQuerySubclass.cs
// Ref: C#与.NET4高级程序设计-第5版
// Jedi Chou, 2016.3.13 20:31
// Update 2016.3.19, 12:37

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
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
        Console.WriteLine("LinqQuerySubclass.cs");
        var myCars = new List<Car>() {
            new Car {PetName="Henry", Color="Silver", Speed=100, Make="BMW"},
            new Car {PetName="Daisy", Color="Tan", Speed=90, Make="BMW"},
            new Car {PetName="Mary", Color="Black", Speed=55, Make="VW"},
            new Car {PetName="Clunker", Color="Rust", Speed=5, Make="Yugo"}
        };
		
		GetFastBMWs(myCars);
    }
	
	static void GetFastBMWs(List<Car> cars)
	{
		var fastCars = from c in cars where c.Speed > 90 && c.Make == "BMW" select c;
		foreach(var car in fastCars)
			Console.WriteLine("{0} is going too fast", car.PetName);
	}
}