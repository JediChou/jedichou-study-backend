using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex01
{
	public abstract class Animal
	{
		protected string name;
		
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		
		public Animal(string newName)
		{
			name = newName;
		}
		
		public void Feed()
		{
			Console.WriteLine("{0} has been feed.", name);
		}
	}
	
	public class Cow : Animal
	{
		public void Milk()
		{
			Console.WriteLine("{0} has been milked.", name);
		}
		
		public Cow(string newName) : base(newName)
		{
		}
	}
	
	public class Chicken: Animal
	{
		public void LayEgg()
		{
			Console.WriteLine("{0} has laied an egg.", name);
		}
		
		public Chicken(string newName) : base(newName)
		{
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Create an Array type collection of Animal " + "objects and use it:");
			
			Animal[] animalArray = new Animal[2];
			Cow myCow1 = new Cow("Deirdre");
			animalArray[0] = myCow1;
			animalArray[1] = new Chicken("Ken");
			
			foreach(Animal myAnimal in animalArray)
			{
				Console.WriteLine(
					"New {0} object added to Array collection, Name = {1}",
					myAnimal.ToString(),
					myAnimal.Name
				);
			}
			
			Console.WriteLine("Array collection contains {0} objects.",	animalArray.Length);
			animalArray[0].Feed();
			((Chicken)animalArray[1]).LayEgg();
			Console.WriteLine();
			
			Console.WriteLine("Create an ArrayList type collection of Animal objects and use it:");
			ArrayList animalArrayList = new ArrayList();
			Cow myCow2 = new Cow("Hayley");
			animalArrayList.Add(myCow2);
			animalArrayList.Add(new Chicken("Roy"));
			
			// Now iterate element of array list.
			foreach (Animal myAnimal in animalArrayList)
				Console.WriteLine("New {0} object added to ArrayList collection, Name = {1}",
				myAnimal.ToString(),
				myAnimal.Name
			);
			Console.WriteLine("ArrayList collection contain {0} object.", animalArrayList.Count);
			((Animal)animalArrayList[0]).Feed();
			((Chicken)animalArrayList[1]).LayEgg();
			Console.WriteLine();
			
			Console.WriteLine("Additional manipulation of ArrayList:");
			animalArrayList.RemoveAt(0);
			((Animal)animalArrayList[0]).Feed();
			animalArrayList.AddRange(animalArray);
			((Chicken)animalArrayList[2]).LayEgg();
			Console.WriteLine("The animal called {0} is at index {1}.",
				myCow1.Name,
				animalArrayList.IndexOf(myCow1)
			);
			myCow1.Name = "Janice";
			Console.WriteLine("The animal is now called {0}.",
				((Animal)animalArrayList[1]).Name
			);
			
			Console.ReadKey();
		}
	}
}
