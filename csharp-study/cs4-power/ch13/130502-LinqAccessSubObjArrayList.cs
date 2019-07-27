// ref: Pro C# 2010 and the .NET 4 platform
// page 388
// author: Jedi Chou, 2016.3.25, 22:48

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class LinqAccessSubObject {

	class Car {
		public string PetName {get; set;}
		public string Color {get; set;}
		public int Speed {get; set;}
		public string Make {get; set;}
	}

	public static void Main(string[] args) {

		// notice: ArrayList do not support generic
		// so, you don't use ArrayList<Car> x = new ArrayList<Car>();
		ArrayList cars = new ArrayList() {
			new Car {PetName="Henry", Color="Silver", Speed=100, Make="BMW"},
			new Car {PetName="Daisy", Color="Tan", Speed=90, Make="BMW"},
			new Car {PetName="Mary", Color="Black", Speed=55, Make="BMW"},
			new Car {PetName="Clunker", Color="Rust", Speed=5, Make="VW"},
			new Car {PetName="Melvin", Color="White", Speed=43, Make="YuGo"}
		};

		// convert generic container by OfType<> method.
		var carsNumerable = cars.OfType<Car>();

		var fastCars = 
			from c in carsNumerable
			where c.Speed > 55
			select c;

		foreach(var car in fastCars)
			Console.WriteLine(car.PetName);
	}
}
