using System;

namespace CSharp.OverrideExample {
	class Person {
		public string firstname;
		public string lastname;
		
		public Person() {}
		public Person(string first, string last) {
			firstname = first;
			lastname = last;
		}
		
		public virtual string Speak() {
			return "My name is " + this.firstname + " " + this.lastname;
		}
	}

	class EnglishMan : Person {
		public override string Speak() {
			return "I'm man, but I speak english.";
		}
	}

	class Program {
		static void Main(string[] args) {
			var es = new EnglishMan();
			Console.WriteLine(es.Speak());
		}
	}
}
