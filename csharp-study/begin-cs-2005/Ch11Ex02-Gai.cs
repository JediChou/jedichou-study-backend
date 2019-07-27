// File name: Ch11Ex02.cs
// Description: Implement Animals collection.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex02_Gai {

	public abstract class Animal {
		protected string name;
		
		public string Name {
			get { return name;}
			set { name = value;}
		}
		
		public Animal()	{
			name = "The animal with no name";
		}
		
		public Animal(string newName) {
			name = newName;
		}
		
		public void Feed() {
			Console.WriteLine("{0} has been fed.", name);
		}
	} // end Animal
	
	public class Cow : Animal {
		public void Milk() {
			Console.WriteLine("{0} has been milked.", name);
		}
		
		public Cow(string newName) : base(newName) {}
	} // end Cow
	
	public class Chicken : Animal {
		public void LayEgg() {
			Console.WriteLine("{0} has laid an egg.", name);
		}
		
		public Chicken(string newName) : base(newName) {}
	} // end chicken
	
	public class Animals : CollectionBase {
		public void Add(Animal newAnimal) {
			List.Add(newAnimal);
		}
		
		public void Remove(Animal oldAnimal) {
			List.Remove(oldAnimal);
		}
		
		public Animals() {}
		
		public Animal this[int animalIndex] {
			// This is a Index Character
			get { return (Animal)List[animalIndex]; }
			set { List[animalIndex] = value; }
		}
		
	} // end Animals
	
	public class Program {
		static void Main(string[] args) {
			List<Animal> ac = new List<Animal>();
			ac.Add(new Cow("Jack"));
			ac.Add(new Chicken("Vera"));
			
			foreach (Animal item in ac)
				item.Feed();
		}
	} // end program
	
} // end name-space
