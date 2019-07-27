using System;

namespace SingletonExample
{
	public class Singleton {
		// all coder will be use this instance
		private static Singleton instance;

		// keep coder can not call default constructor
		private Singleton() {}

		// use a property to get instance
		public static Singleton Instance {
			get {
				if (instance == null)
					instance = new Singleton();
				return instance;
			}
		}

	}

	public class Program {
		static void Main() {
			var ston1 = Singleton.Instance;
			var ston2 = Singleton.Instance;
			
			Console.WriteLine(ston1);
			Console.WriteLine(ston2);
		
			Console.WriteLine(
				"Object.ReferenceEquals(ston1, ston2) is : {0}", 
				Object.ReferenceEquals(ston1, ston2) == true
			);
		}
	}

}
