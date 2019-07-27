using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex02
{
	public class Animal
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
	
	public class Animals : CollectionBase
	{
		public void Add(Animal newAnimal)
		{
			List.Add(newAnimal);
		}
		
		public void Remove(Animal oldAnimal)
		{
			List.Remove(oldAnimal);
		}
		
		public Animals()
		{
		}
		
		public Animal this[int animalIndex]
		{
			get
			{
				return (Animal)List[animalIndex];
			}
			set
			{
				List[animalIndex] = value;
			}
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Animals animalCollection = new Animals();
			animalCollection.Add(new Cow("Ivan"));
			animalCollection.Add(new Chicken("Ed"));
			
			foreach(Animal myAnimal in animalCollection)
				myAnimal.Feed();
			
			Console.ReadKey();
		}
	}
}
